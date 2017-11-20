using System.Collections.Generic;
using TravellerHelper.Models.Common;

namespace TravellerHelper.Models
{
    public class tblRole : DatabaseObject
    {
        public string Name { get; set; }
        public List<tblUser> Users { get; set; }
        public tblRole()
        {
            Users = new List<tblUser>();
        }
    }
}
