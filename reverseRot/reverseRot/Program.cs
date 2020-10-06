using System;

namespace reverseRot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a system to encrypt messages, enter a number to move the letter one step forward. The message will then be reversed");

            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_.";
            var input = Console.ReadLine();

            var words = input.Split(' ');
            var rotation = Convert.ToInt32(words[0]);
            var message = words[1];
            var result = "";

            for (int i = 0; i < message.Length; i++)
            {
                var letter = message.ToCharArray()[i];
                var indexOfLetter = alphabet.IndexOf(letter);
                var newIndex = indexOfLetter + rotation;
                var newLetter = alphabet.ToCharArray()[newIndex];
                result += newLetter;

                if (newIndex > 27)
                {
                    newIndex = newIndex - 28;
                }

            }
            var reverseWord = ReverseString(result);
            Console.WriteLine(reverseWord);
          
            
            //Lägg in en rad från användaren
            //Läs av bokstäverna
            //kolla av teckerna i alfabetet
            //när hittad bostav är hittad, stega fram i alfabetet
            //spara i ett resultat, för varje bokstav
            //vänd på bokstäverna

        }
        private static string ReverseString(string result)
        {
            var restulArr = result.ToCharArray();
            Array.Reverse(restulArr);
            return new string(restulArr);
        }

    }
}
