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
          char firstLetter = name[0];
            string shortenSurname;
            if (surname.Length > 5) shortenSurname = surname.Substring(0, 5);
            else shortenSurname = surname;
         
          string  email = "";

          email += firstLetter + "." + shortenSurname + randomNo + "@" + position + "." + "vistula.edu.pl";
            return email;
        }
    }
}
