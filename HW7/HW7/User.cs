using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class User
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public RoleEnum Role { get; set; }
        public ShoppingCart? ShoppingCart { get; set; }
        public List<Items>? BughtList { get; set; }
    }
}
