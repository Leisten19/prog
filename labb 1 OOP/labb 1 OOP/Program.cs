using System;
using System.Runtime.CompilerServices;

namespace labb_1_OOP
{
     class Program
    {
        static void Main(string[] args)
        {
            Produkt gucciskor = new Produkt("Gucci", "Skor", 5500);
            Produkt mayajacka = new Produkt("Moncler", "Jacka", 10500);

            Console.WriteLine("Produkt gucciskor är: " + gucciskor.Märke + gucciskor.Plagg + gucciskor.Pris);

            Console.WriteLine("Produkt mayajacka är: " + mayajacka.Märke + mayajacka.Plagg + mayajacka.Pris);

            Console.WriteLine("De här produkterna har butiken, vad vill du köpa? ");

            Butik b = new Butik();
            b.klädesplagg.Add(gucciskor);
            b.klädesplagg.Add(mayajacka);

            
            Console.ReadLine();

        }
    }
}
