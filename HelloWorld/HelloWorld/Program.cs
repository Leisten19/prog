using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello skriv in ditt namn");
            var username = Console.ReadLine();
            Console.WriteLine("Ditt namn är: " + username);
            Console.WriteLine("skriv in din ålder");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Din ålder är: " + age);

            Console.WriteLine("Är du vid liv?");
            var alive = Console.ReadLine();
            var ja = true;
            var nej = false;
            Console.WriteLine(ja);
            Console.WriteLine(nej);

            if (age >= 18)
            {
                Console.WriteLine("Grattis, du kan ta körkort!");
            }
            else
            {
                Console.WriteLine("Bara ett år till lagligt snusköp!");
            }

            
            var bil = 5;
            switch (bil)
            {
                case 1:
                    Console.WriteLine("Mercedes");
                    break;
                case 2:
                    Console.WriteLine("BMW");
                    break;
                case 3:
                    Console.WriteLine("Volvo");
                    break;
                case 4:
                    Console.WriteLine("Mclaren");
                    break;
                case 5:
                    Console.WriteLine("Polestar");
                    break;
            }

            bool kör = Convert.ToBoolean(Console.ReadLine());

            while (kör)
            {
                Console.WriteLine("koenigsegg jesko ser så fkn sexig ut!");
            }


        }
    }
    }


