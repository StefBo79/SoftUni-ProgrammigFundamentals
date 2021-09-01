using System;


namespace pinCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string n1 = input[2].ToString() + input[1] + input[0];
            string n2 = input[input.Length - 1].ToString() + input[5] + input[4];
            int pin = 0;

            if (int.Parse(n1) >= int.Parse(n2))
            {
                pin = int.Parse(n1);
            }
            else
            {
                pin = int.Parse(n2);
            }

            pin = int.Parse(pin.ToString().TrimStart('0'));
            Console.WriteLine(pin);
        }
    }
}
