using System;
using System.Collections.Generic;
using System.Text;

namespace labb_1_OOP
{
     class Produkt
    {
        private string v1;
        private string v2;
        private string v3;
        private int v;

        public string Märke { get; set; }
        public string Plagg { get; set; }
        

        public double Pris { get; set; }

        Produkt(string märke, string plagg, double pris)
        {
            Märke = märke;
            Plagg = plagg;
            
            Pris = pris;
        }

        public Produkt(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public Produkt(string v1, string v2, int v)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v = v;
        }
    }
}
