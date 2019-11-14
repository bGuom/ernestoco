using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Core_2_1.Models
{
    public class AppSettings
    {
        public string GoogleClientId { get; set; }
        public string TokenValidationAPI { get; set; }
        public string LoginPath { get; set; }
        public string AccessDeniedPath { get; set; }
        public string LogoutPath { get; set; }
        public string APIURL { get; set; }
        public string AUTH_SERVICE_API { get; set; }
        public string Version { get; set; }
        public string LogOutInterval { get; set; }
        public string AlertTimer { get; set; }
        public string FunctionRefreshTimer { get; set; }
    }
}
