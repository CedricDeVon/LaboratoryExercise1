using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryExercise1
{
    public class User
    {
        public string Name { get; private set; }

        public string Email { get; private set; }

        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
