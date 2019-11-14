using ASPNET_Core_2_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;


namespace LIMS.Web.Filters
{
    public class ConfigHelperFilter : ActionFilterAttribute
    {
        private readonly AppSettings _settings;

        public ConfigHelperFilter(IOptions<AppSettings> options)
        {
            _settings = options.Value;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = (context.Controller as Controller);
            controller.ViewBag.SITE_NAME = "Ernestoco";
            controller.ViewBag.APIURL = _settings.APIURL;
            controller.ViewBag.AUTH_SERVICE_API = _settings.AUTH_SERVICE_API;
            controller.ViewBag.Version = _settings.Version;
            controller.ViewBag.LogOutInterval = _settings.LogOutInterval;
            controller.ViewBag.AlertTimer = _settings.AlertTimer;
            controller.ViewBag.FunctionRefreshTimer = _settings.FunctionRefreshTimer;
            base.OnActionExecuting(context);
        }
    }
}
