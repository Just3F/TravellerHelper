using System;
using System.Security.Claims;

namespace TravellerHelper.Services.Utils
{
    public class AppUser
    {
        public static long GetId()
        {
            var id = Convert.ToInt64(RequestContextManager.Instance.CurrentContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            return id;
        }

        public static string GetUserName()
        {
            var userName = RequestContextManager.Instance.CurrentContext.User.FindFirst("FirstName")?.Value;
            return userName;
        }

        public static string GetUserEmail()
        {
            var userEmail = RequestContextManager.Instance.CurrentContext.User
                .FindFirst(x => x.Type == ClaimsIdentity.DefaultNameClaimType).Value;
            return userEmail;
        }

        public static string GetFullUserName()
        {
            var userName = RequestContextManager.Instance.CurrentContext.User.FindFirst("FirstName")?.Value + " " +
                           RequestContextManager.Instance.CurrentContext.User.FindFirst("LastName")?.Value;
            return userName;
        }

        public static string GetRole()
        {
            var role = RequestContextManager.Instance.CurrentContext.User
                .FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
            return role;
        }
    }
}
