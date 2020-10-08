using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace labb_1_OOP
{
    class Butik
    {
        public List <Produkt> klädesplagg { get; set; }
        public List <Kund> kunder { get; set; }

        public Butik()
        {
            klädesplagg = new List<Produkt>();
            kunder = new List<Kund>();

            
        }
        
    }
}
