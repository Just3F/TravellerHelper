using System.Collections.Generic;

namespace TravellerHelper.ViewModels.Constants
{
    public class DefaultValues
    {
        public const string DateFormat = "dd/MM/yyyy H:mm";

    }

    public class UserRolesConstants
    {
        public const string Administrator = "Administrator";
        public const string User = "User";

        public static List<string> AllRoles => new List<string>
        {
            Administrator,
            User
        };
    }
}
