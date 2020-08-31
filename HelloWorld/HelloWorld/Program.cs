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


        }
    }
}

