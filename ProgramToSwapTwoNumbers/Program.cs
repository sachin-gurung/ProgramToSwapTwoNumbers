using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToSwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            C# Program to Swap two Numbers
            */
            {
                int num1, num2, temp;
                //Input first number
                Console.Write("\nEnter the First Number : ");
                num1 = int.Parse(Console.ReadLine());
                //Input second number
                Console.Write("\nEnter the Second Number : ");
                num2 = int.Parse(Console.ReadLine());
                temp = num1;
                num1 = num2;
                num2 = temp;
                Console.Write("\nAfter Swapping : ");
                Console.Write("\nFirst Number : " + num1);
                Console.Write("\nSecond Number : " + num2);
                Console.Read();
            }
        }
    }
}
 /*
 Result:
 Enter the First Number : 23
Enter the Second Number : 25
After Swapping :
First Number : 25
Second Number : 23
 */

