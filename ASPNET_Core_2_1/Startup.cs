using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using ASPNET_Core_2_1.Models;
using LIMS.Web.Filters;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ASPNET_Core_2_1
{

    public class CustomCookieAuthenticationEvents : CookieAuthenticationEvents
    {
        AppSettings appSettings;
        public CustomCookieAuthenticationEvents(IOptions<AppSettings> options)
        {
            appSettings = options.Value;
        }

        public override async Task ValidatePrincipal(CookieValidatePrincipalContext context)
        {
            var userPrincipal = context.Principal;

            // Look for the LastChanged claim.
            var token = userPrincipal.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid);
            var _token = context.HttpContext.Request.Cookies["token"];

            if (string.IsNullOrWhiteSpace(token?.Value) || string.IsNullOrWhiteSpace(_token) || (token?.Value != _token && context.Request.Path != "/Account/LoginConfirmed") || !await DoValidate(context.HttpContext, appSettings, token?.Value))
            {
                context.RejectPrincipal();
                context.HttpContext.Response.Cookies.Delete("token");

                await context.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
        }

        private async Task<bool> DoValidate(HttpContext context, AppSettings settings, string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                return false;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(settings.APIURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            HttpResponseMessage response = client.PutAsJsonAsync(settings.TokenValidationAPI, new { }).Result;

            LoginResponse resp = null;
            if (response.StatusCode != System.Net.HttpStatusCode.OK ||
                (resp = await response.Content.ReadAsAsync<LoginResponse>()) == null)
            {
                return false;
            }

            context.Items["user"] = resp.ThisUser;

            if (token != resp.Token)
            {
                await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                context.Response.Cookies.Append("token", resp.Token);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, resp.ThisUser.DisplayName),
                    new Claim(ClaimTypes.Role, resp.ThisUser.Role),
                    new Claim(ClaimTypes.Sid, resp.Token)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            }
            return true;
        }
    }


    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private AppSettings settings { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            settings = new AppSettings();
            Configuration.GetSection("Settings").Bind(settings);

            services.Configure<AppSettings>(options => Configuration.GetSection("Settings").Bind(options));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddMvcOptions(o => { o.Filters.Add<ConfigHelperFilter>(); o.Filters.Add(new GlobalExceptionFilter()); }); 
            services.AddScoped<CustomCookieAuthenticationEvents>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options => {
                options.LoginPath = new PathString(settings.LoginPath);
                options.AccessDeniedPath = new PathString(settings.LogoutPath);
                options.LogoutPath = new PathString(settings.LogoutPath);
                options.EventsType = typeof(CustomCookieAuthenticationEvents);
                options.ReturnUrlParameter = "ReturnUrl";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Dashboards/Dashboard_1");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=index}");
            });
        }
    }
}
