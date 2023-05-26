using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            Phone = phoneNumber;
        }

        public override string ToString()
        {
            return $"{Name}; {Phone}";
        }
    }
}
