using System;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Collections.Generic;

namespace _01._EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                string names = Console.ReadLine();
                sum[i] = sumVowelsConsonants(names);
            }
            Array.Sort(sum);

            foreach (var item in sum)
            {
                Console.WriteLine(item);
            }
        }

        private static int sumVowelsConsonants(string text)
        {
                  int sum = 0;
                  foreach (char element in text)
                  {
                      if (element == 'a' || element == 'A' || element == 'e' || element == 'E' || element == 'i' || element == 'I' || element == 'u' || element == 'U' || element == 'o' || element == 'O')
                      {
                          sum += (int)element * text.Length;
                      }
                      else
                      {
                          sum += (int)element / text.Length;
                      }
                  }
              
                  return sum;
              }
        }
    }
