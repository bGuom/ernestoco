using System;

namespace ASPNET_Core_2_1.Models
{




        public class LoginResponse
        {

            public string Token { get; set; }
            public DateTime Expiration { get; set; }
            public UserResourceModel ThisUser { get; set; }

        }

        public class UserResourceModel
        {
            public Guid UserId { get; set; }

            public string UserName { get; set; }
            public string DisplayName { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }
        }
    

}
