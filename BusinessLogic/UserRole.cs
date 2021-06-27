
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UserRole
    {
        public string Employee_name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Department { get; set; }

        public class User
        {
            public User()
            {

            }
            public User(string emailaddress, string userid, string traineeNumber)
            {
                
                this.traineeNumber = traineeNumber;
            }
            public string traineeNumber { get; set; }
           
            public UserRole UserRole { get; set; }
            public object SqlData { get; private set; }
            
            
            }
        }

        

    }
}