using System;
using System.Text;

namespace _07._StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder explosion = new StringBuilder();
            explosion.Append(Console.ReadLine());

            int bomb = 0;

            for (int i = 0; i < explosion.Length; i++)
            {
                if (bomb > 0 && explosion[i] != '>')
                {
                    explosion.Remove(i, 1);
                    i--;
                    bomb--;
                }
                else if (explosion[i] == '>')
                {
                    bomb += int.Parse(explosion[i + 1].ToString());
                }
            }

            Console.WriteLine(explosion);
        }
    }
}
