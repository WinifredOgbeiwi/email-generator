using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace email_generator
{
    internal class Generator
    {
      public string name;
      public string surname;
      public string position;
        public int randomNo;
        public string Generate()
        {
          string  email = "";
            email += name + "." + surname + randomNo + "@" + position + "." + "vistula.edu.pl";
            return email;
        }
    }
}
