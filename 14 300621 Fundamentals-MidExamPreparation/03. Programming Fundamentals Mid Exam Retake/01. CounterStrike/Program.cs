using System;

namespace _01._CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialEnergy = double.Parse(Console.ReadLine());
            string distandce = Console.ReadLine();
            int count = 0;
            bool dead = false;
            
            while (distandce != "End of battle")
            {
                if (initialEnergy < double.Parse(distandce))
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {initialEnergy} energy");
                    dead = true;
                    break;                    
                }                
                    initialEnergy -= double.Parse(distandce);
                    count++;

                if (count % 3 == 0)
                {
                    initialEnergy += count;
                }
                distandce = Console.ReadLine();
            }
            if (!dead)
            {
                Console.WriteLine($"Won battles: {count}. Energy left: {initialEnergy}");
            }
            
        }
    }
}
