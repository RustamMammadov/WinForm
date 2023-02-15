using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2.Conrtol
{

    internal class User
    {
        public User(string surname, string name, string father_name, string country, string city, string phone, DateTime dt, string gender)
        {
            Surname = surname;
            Name = name;
            Father_name = father_name;
            Country = country;
            City = city;
            Phone = phone;
            Dt = dt;
            Gender = gender;
        }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Father_name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime Dt { get; set; }
        public string Gender { get; set; }
    }
}
