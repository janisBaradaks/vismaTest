using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace visma_test.Models
{
    public class UserModel
    {
        public string userId { get; set; }

        [Display(Name = "Name")]
        public string userName { get; set; }

        [Display(Name = "Surname")]
        public string userSurname { get; set; }

        public virtual ICollection<visma_test.Models.UserDetailsModel> UserDetailsModel { get; set; }

        public UserModel(string userId, string userName, string userSurname)
        {
            this.userId = userId;
            this.userName = userName;
            this.userSurname = userSurname;
            UserDetailsModel = new List<UserDetailsModel>();
        }
    }
}
