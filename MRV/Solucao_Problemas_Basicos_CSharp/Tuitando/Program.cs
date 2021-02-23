using System;

namespace Tuitando
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = Console.ReadLine();
            char[] arr = v.ToCharArray();
            if (arr.Length <= 140) //complete a condicional
                Console.WriteLine("TWEET");
            else
                Console.WriteLine("MUTE");
        }
    }
}
