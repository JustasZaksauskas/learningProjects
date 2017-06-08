using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties2
{
    public enum Role { admin, user, editor };
    public class User
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string FullName
        {
            get
            {
                return (Name + " " + Surname).ToUpper();
            }
        }

        public int Age { get; set; }

        public bool IsAdult
        {
            get
            {
                return Age>17;
            }

        }






    }
}
