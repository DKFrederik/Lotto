using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.ModelLayer
{
    public  class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public Users(int id, string firstname, string lastname, string username)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.UserName = username;
        }

        public Users(string firstname, string lastname, string username)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.UserName = username;
        }

        public Users()
        {

        }
    }
}
