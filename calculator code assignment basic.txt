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
            //updated Oct 11th

            /*atm it can't handel a unicode being entered instead of a number
             * fixed for the exitchoice loop
             * 
             * 
             * 
             * /

            /*
             * old code
            string X1 = Console.ReadLine();

            int x = Convert.ToInt32(X1);

            Console.WriteLine(x);

            Console.ReadKey();
            */

            string equationChoice = "x"; //might be used for future improvement of this calculator, but atm pretty pointless.

            //int exitChoice;


            bool keepalive = true;
            while (keepalive)
            {

                Console.WriteLine("Enter a number and press Enter");

                int num1 = Convert.ToInt32(Console.ReadLine());



                //Console.WriteLine("Enter another number");

                //int num2 = Convert.ToInt32(Console.ReadLine());

                bool equationcheck = true;
                while(equationcheck)
                {
                    Console.WriteLine("Choose what kind of equation you wanna do [Only use symbols]:");
                    //Console.WriteLine("+  -  *  /");
                    Console.WriteLine("+ addition");
                    Console.WriteLine("- subtraction");
                    Console.WriteLine("* multiplication");
                    Console.WriteLine("/ division");

                    equationChoice = Console.ReadLine();

                    switch (equationChoice)
                    {
                        case "+":

                            equationcheck = false;

                            break;

                        case "-":

                            equationcheck = false;

                            break;

                        case "*":

                            equationcheck = false;

                            break;

                        case "/":

                            equationcheck = false;

                            break;

                        default:
                            Console.WriteLine("Only enter + , - , / or * please.");

                            break;
                    }
                }




                Console.WriteLine("Enter another number and press Enter");

                int num2 = Convert.ToInt32(Console.ReadLine());


                switch (equationChoice)
                {
                    case "+":

                        int result = num1 + num2;

                        Console.WriteLine("Result: " + num1.ToString() + "+" + num2.ToString() + " = " + result);
                        //^ improvement over the code below
                        //Console.WriteLine(num1 + num2);

                        //keepalive = false; old code when the final choice was outside of the keepalive loop
                        break;

                    case "-":
                        int resultM = num1 - num2;
                        Console.WriteLine("Result: " + num1.ToString() + "-" + num2.ToString() + " = " + resultM);
                        //^ improvement over the code below
                        //Console.WriteLine(num1 - num2);

                        //keepalive = false; old code when the final choice was outside of the keepalive loop
                        break;

                    case "*":
                        int resultT = num1 * num2;
                        Console.WriteLine("Result: " + num1.ToString() + "*" + num2.ToString() + " = " + resultT);
                        //^ improvement over the code below
                        //Console.WriteLine(num1 * num2);

                        //keepalive = false; old code when the final choice was outside of the keepalive loop
                        break;

                    case "/":
                        int resultD = num1 / num2;
                        Console.WriteLine("Result: " + num1.ToString() + "/" + num2.ToString() + " = " + resultD);
                        //^ improvement over the code below
                        //Console.WriteLine(num1 / num2);

                        //keepalive = false; old code when the final choice was outside of the keepalive loop
                        break;

                    case "x":
                        Console.WriteLine("Only enter + , - , / or * please.");
                        break;


                }



                bool finalchoice = true;
                while (finalchoice)
                {

                    Console.WriteLine("1. Another calculation");
                    Console.WriteLine("2. Exit");

                    char exitChoicestr = Console.ReadKey(true).KeyChar; //putting true inside of () of readkey or readline will hide the input
                    //.keychar makes it so it reads a specific character

                    //int.TryParse(exitChoicestr, out exitChoice); //old code

                    switch (exitChoicestr)
                    {
                        case '1':
                            finalchoice = false;

                            break;

                        case '2':


                            keepalive = false;
                            finalchoice = false;

                            break;

                        //case '0':
                        //    Console.WriteLine("use only 1 or 2 please.");
                        //    //Console.ReadKey();
                        //    break;
                        //this case is not needed, replaced by default

                        default:

                            Console.WriteLine("use only 1 or 2 please.");
                            //Console.ReadKey();

                            break;
                    }

                }//whilefinalchoice


                //Console.ReadKey();

            }//while keepalive

        }//static void Main
    }//class program
}//namespace
