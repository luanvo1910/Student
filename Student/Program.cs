using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.Name = Console.ReadLine();
            student1.Age = int.Parse(Console.ReadLine());
            student1.GPA = float.Parse(Console.ReadLine());

            Console.WriteLine($"{student1.Name} {student1.Age} Years old, {student1.GPA} points");
            Console.ReadLine();
        }
    }
}
