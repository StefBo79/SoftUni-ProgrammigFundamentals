using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = "AlaBalaNica Turska Panica";
            string power = card.Substring(5);
            Console.WriteLine(power);
        }
    }
}
