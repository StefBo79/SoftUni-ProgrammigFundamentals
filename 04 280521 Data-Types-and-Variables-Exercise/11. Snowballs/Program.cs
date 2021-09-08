using System;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            System.Numerics.BigInteger biggestValue = 0;
            int biggestSnow = 0;
            int biggestTime = 0;
            int biggestQuality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                System.Numerics.BigInteger currentValue = System.Numerics.BigInteger.Pow(snow / time, quality);

                if (currentValue > biggestValue)
                {
                    biggestValue = currentValue;
                    biggestSnow = snow;
                    biggestTime = time;
                    biggestQuality = quality;
                }
            }
            Console.WriteLine($"{biggestSnow} : {biggestTime} = {biggestValue} ({biggestQuality})");
        }
    }
}
