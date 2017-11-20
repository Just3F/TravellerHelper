using TravellerHelper.Models.Common;

namespace TravellerHelper.Models
{
    public class tblUser : DatabaseObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public long? RoleId { get; set; }
        public tblRole Role { get; set; }
    }
}
