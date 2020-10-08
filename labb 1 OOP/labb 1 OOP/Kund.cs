using System;
using System.Collections.Generic;
using System.Text;

namespace labb_1_OOP
{
    class Kund
    {
        public string name;
        public string storlek;
        public string epost;



        public Kund(string customerName, string customerStorlek, string Epost)
        {
            name = customerName;
            storlek = customerStorlek;
            epost = Epost;
        }
    }
}
