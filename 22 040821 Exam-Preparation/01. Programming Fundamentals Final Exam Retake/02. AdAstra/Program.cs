using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#|])(?<name>[A-Za-z\s]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]{1,})\1";

            string foodInfo = Console.ReadLine();
            MatchCollection foodMaches = Regex.Matches(foodInfo, pattern);
            List<Food> food = new List<Food>();

            foreach (Match match in foodMaches)
            {
                string name = match.Groups["name"].Value;
                string date = match.Groups["date"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);

                Food currentFood = new Food(name, date, calories);
                food.Add(currentFood);
            }

            double days = Math.Floor((double)food.Select(f => f.Calories).Sum() / 2000);
            Console.WriteLine($"You have food to last you for: {days} days!");
            Console.WriteLine(string.Join(Environment.NewLine, food));
        }
    }
}
class Food
{
    public Food(string name, string date, int calories) 
    {
        Name = name;
        Date = date;
        Calories = calories;    
    }
    public string Name { get; set; }
    public string Date { get; set; }
    public int Calories { get; set; }

    public override string ToString()
    
        => $"Item: {Name}, Best before: {Date}, Nutrition: {Calories}";

 }

