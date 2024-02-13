using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checker c=new checker();
            Console.WriteLine("Enter the Percentage: ");
           var percent=Convert.ToInt32(Console.ReadLine());
            var grade = c.gradechecker(percent);
            Console.WriteLine($"Student Grade: {grade}");


           
        }
    }
}
