using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace visma_test.Models
{
    public class UserDetailsModel
    {
        public string phoneNumber { get; set; }
        public string login { get; set; }
        public DateTime timestamp { get; set; }
        
        public UserDetailsModel(string phoneNumber, string login, DateTime timestamp)
        {
            this.phoneNumber = phoneNumber;
            this.login = login;
            this.timestamp = timestamp;
        }
    }
}
