using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string num = Console.ReadLine();



            int intNum = Convert.ToInt32(num);

            if (intNum == 10)
            {
                Console.WriteLine("The number entered is equal to 10");
            }
            else if (intNum < 10)
            {
                Console.WriteLine("The number entered is less than 10");
            }
            else 
            {
                Console.WriteLine("The number entered is greater than 10.");
            
            }
        }
    }
}
