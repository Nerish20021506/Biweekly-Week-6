using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double gradecount = 3;
            for (int gradecounter = 1; gradecounter <= 5; gradecounter++) 
            {
                Console.Write("Enter the grade: ");
                double grade = Convert.ToDouble(Console.ReadLine());
                total = total + grade;
                gradecounter = gradecounter + 1;
            }
            Console.WriteLine("The average of the class is: " + total/gradecount);
        }
    }
}
