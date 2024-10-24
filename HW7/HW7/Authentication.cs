using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Authentication : IAuthentication
    {
        public bool Login(string ModelUsername, string ModelPassword)
        {
            foreach (var user in Storage.Users)
            {
                if (user is not null)
                {
                    if (user.Username==ModelUsername && user.Password==ModelPassword)
                    {
                        //Console.WriteLine($"***** Wellcome {user.Name} *****");
                        Storage.CurrentUser = user;
                        return true;
                    }
                }
            }
            Console.WriteLine("There is no person With this information in database!");
            return false;
        }
        public bool Register(string ModelEmail, string ModelPassword, string ModelUsername)
        {
            foreach (var item in Storage.Users)
            {
                if (item is not null)
                {
                    if (item.Email == ModelEmail)
                    {
                        Console.WriteLine("This Email is already used!");
                        return false;
                    }
                    else
                        if (item.Username == ModelUsername)
                    {
                        Console.WriteLine("This Username is already taken!");
                        return false;
                    }
                }
                else
                    if (item is null)
                {
                    User person = new User();
                    person.Email = ModelEmail;
                    person.Password = ModelPassword;
                    person.Username = ModelUsername;
                    person.Role = RoleEnum.NormalUser;
                    int counter = 1;
                    foreach (var user in Storage.Users)
                    {
                        if (user is not null)
                        {
                            counter++;
                        }
                        else
                            if (user is null)
                        {
                            break;
                        }
                    }
                    person.Id = counter;
                    return true;
                }
            }
            return false;
        }
    }


}