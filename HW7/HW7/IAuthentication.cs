using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public interface IAuthentication
    {
        public bool Login(string ModelUsername, string ModelPassword);
        public bool Register(string ModelEmail, string ModelPassword, string ModelUsername);
    }
}
