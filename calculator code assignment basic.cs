using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_PJ
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculator assignment by PJ
            //oct 10th


            /*
             * old code
            string X1 = Console.ReadLine();

            int x = Convert.ToInt32(X1);

            Console.WriteLine(x);

            Console.ReadKey();
            */

            string equationChoice = "x"; //might be used for future improvement of this calculator, but atm pretty pointless.

            Console.WriteLine("Enter a number");

            int num1 = Convert.ToInt32( Console.ReadLine() );



            Console.WriteLine("Enter another number");

            int num2 = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Choose what kind of equation you wanna do:");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");

            equationChoice = Console.ReadLine();

            switch (equationChoice)
            {
                case "+":

                    int result = num1 + num2; 

                    Console.WriteLine(num1 + num2); old simple code

                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    break;

                case "*":
                    Console.WriteLine(num1 * num2);
                    break;

                case "/":
                    Console.WriteLine(num1 / num2);
                    break;

                case "x":
                    Console.WriteLine("Only enter + , - , / or * please.");
                    break;
            }


            Console.ReadKey();

        }//static void Main
    }//class program
}//namespace
