using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtApp.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "jipheensAdmin", EmailAddress = "jipheens.admin@email.com", Password = "Pass1234", GivenName = "wahome", Surname = "Wahome", Role = "Administrator" },
            new UserModel() { Username = "wanjiruSeller", EmailAddress = "wanjiru.seller@email.com", Password = "Pass1234", GivenName = "wanjiru", Surname = "kamau", Role = "Seller" },
        };
    }
}
