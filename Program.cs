using System;

namespace JustMessingAroundCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Whats your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, How old are you?");
            var userAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sooo {userName} you are {userAge} years old?");

            if (userAge < 21)
            {
                Console.WriteLine("You are to young to ride this ride");
            }
            else
            {
                Console.WriteLine("You are welcome to come in");
            }
        }
    }
}
