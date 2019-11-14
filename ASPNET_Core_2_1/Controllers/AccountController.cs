using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ASPNET_Core_2_1.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Core_2_1.Controllers
{
    public class AccountController : Controller
    {
        public async Task<IActionResult> Login(string ReturnUrl)
        {
            var aut = User.Identity.IsAuthenticated;
            if (aut)
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.Response.Cookies.Delete("token");
            }
            ViewBag.ReturnUrl = ReturnUrl;
            ViewBag.GoogleClientId = "911261399754-oa1nom5ffpq0b47nblh6g3rncln5ovv5.apps.googleusercontent.com";
            ViewBag.GOOGLE_AUTH_URL = "http://localhost:13218/api/auth/";
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> LoginConfirmed([FromBody]LoginResponse login)
        {
            
            if (login == null)
                return BadRequest();

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,  login.ThisUser.DisplayName!=null ? login.ThisUser.DisplayName : ""),
                new Claim(ClaimTypes.Role, login.ThisUser.Role),
                new Claim(ClaimTypes.Sid, login.Token)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return Ok(new { success = true });
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> Logout(string ReturnUrl)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Response.Cookies.Delete("token");
            return RedirectToAction("Login", new { ReturnUrl = ReturnUrl });
        }

        public IActionResult Login0()
        {
            var aut = User.Identity.IsAuthenticated;
            if (aut)
                return RedirectToAction("Index", "Dashboard");
            return RedirectToAction("Login");
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult GuestLogin()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

    }
}