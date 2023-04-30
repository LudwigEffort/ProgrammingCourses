using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;

using static System.Environment;

namespace csharp_biblioteca
{
    public class User
    {
        string lastname;
        string name;
        string email;
        string password;
        string phone;

        public User(string lastname, string name, string email, string password, string phone){
            this.lastname = lastname;
            this.name = name;
            this.email = email;
            this.password = password;
            this.phone = phone;
        }

        public override string ToString()
        {
            return $"lastname: {lastname}" + NewLine
                + $"name: {name}" + NewLine
                + $"email: {email}" + NewLine
                + $"password: {password}" + NewLine
                + $"phone: {phone}";
        }
    }
}