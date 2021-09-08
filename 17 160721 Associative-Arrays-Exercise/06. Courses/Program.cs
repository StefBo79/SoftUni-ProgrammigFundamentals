using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> programOfCourses = new Dictionary<string, List<string>>();
            List<string> studentData = Console.ReadLine().Split(" : ").ToList();


            while (studentData[0] != "end")
            {
                
                string course = studentData[0];
                string student = studentData[1];                

                if (!programOfCourses.ContainsKey(course))
                {
                    programOfCourses.Add(course, new List<string>());
                    programOfCourses[course].Add(student);
                    studentData = Console.ReadLine().Split(" : ").ToList();
                    continue;
                }
                programOfCourses[course].Add(student);
                studentData = Console.ReadLine().Split(" : ").ToList();
            }

            foreach (var course in programOfCourses.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                course.Value.Sort();
                Console.Write("-- ");
                Console.WriteLine(string.Join($"\n-- ", course.Value));
            }
        }
    }
}
