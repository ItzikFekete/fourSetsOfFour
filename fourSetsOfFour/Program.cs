using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourSetsOfFour
{
    class Program
    {
        private static int sum;

        static void Main(string[] args)
        {
            // These string variables are for user input to avoid runtime errors.
            string firstInput, secondInput, thirdInput, fourthInput, 
                fifthInput, sixthInput, seventhInput, eightInput;
            // theese boolean variables are for the do while loops.
            bool testNum1, testNum2, testNum3, testNum4, testNum5, testNum6, testNum7, testNum8;

            int firstNum, secondNum, thirdNum, fourthNum, fifthNum, sisthNum, seventhNum, eightNum;
            

            do
            {
                
                Console.WriteLine("All numbers are 0 to 9, excpet the first and last digit, which must be odd");
                Console.WriteLine("Please enter your first number");
                firstInput = Console.ReadLine();
                // firstNum = int.Parse(Console.ReadKey(true).KeyChar); didn't work

                if ((firstInput.All(char.IsDigit) && (firstInput == "1" || firstInput == "3" || firstInput == "5" || 
                    firstInput == "7" || firstInput == "9")))
                {
                    firstNum = Convert.ToInt16(firstInput);
                    Console.WriteLine("You choose " +  firstNum);
                    testNum1 = true;
                }

                else
                {
                    Console.WriteLine("Please choose again");
                    testNum1 = false;
                }
            } while (testNum1 == false);

            Console.WriteLine("Please chose your second number");
            do
            {
                secondInput = Console.ReadLine();
                if ((secondInput.All(char.IsDigit) && (secondInput == "1" || secondInput == "2" || secondInput == "3" || 
                    secondInput == "4" || secondInput == "5" || secondInput == "6" || secondInput == "7" || secondInput == "8" ||
                    secondInput == "9" || secondInput == "0")))
                {
                    secondNum = Convert.ToInt16(secondInput);
                    Console.WriteLine("You choose " +  secondNum);
                    testNum2 = true;
                }

                else
                {
                    Console.WriteLine("Please choose again");
                    testNum2 = false;
                }
            } while (testNum2 == false);
            Console.WriteLine("Please enter your next SINGULAR number");
            do
            {
                thirdInput = Console.ReadLine();
                if ((thirdInput.All(char.IsDigit) && (thirdInput == "1" || thirdInput == "2" || thirdInput == "3" || 
                    thirdInput == "4" || thirdInput == "5" || thirdInput == "6" || thirdInput == "7" || thirdInput == "8" || 
                    thirdInput == "9" || thirdInput == "0")))
                {
                    thirdNum = Convert.ToInt16(thirdInput);
                    Console.WriteLine("You choose " +  thirdNum);
                    testNum3 = true;
                }

                else
                {
                    Console.WriteLine("Please choose again");
                    testNum3 = false;
                }
            } while (testNum3 == false);
            Console.WriteLine("Please enter your next SINGULAR number");
            do
            {
                fourthInput = Console.ReadLine();
                if ((fourthInput.All(char.IsDigit) && (fourthInput == "1" || fourthInput == "2" || fourthInput == "3" || 
                    fourthInput == "4" || fourthInput == "5" || fourthInput == "6" || fourthInput == "7" || fourthInput == "8" || 
                    fourthInput == "9" || fourthInput == "0")))
                {
                    fourthNum = Convert.ToInt16(fourthInput);
                    Console.WriteLine("You choose " + fourthNum);
                    testNum4 = true;
                }

                else
                {
                    Console.WriteLine("Please choose again");
                    testNum4 = false;
                }
            }


            while (testNum4 == false);
            string set1 = firstInput + secondInput + thirdInput + fourthInput;
             
            
            int set1N;
            do
            {
                Console.WriteLine("You have chosen" + set1);
                set1N = Convert.ToInt16(set1);
                Console.WriteLine("The sum of all your digits is {set1N}", sum);
                fifthInput = Console.ReadLine();
                if ((fifthInput.All(char.IsDigit) && (fifthInput == "1" || fifthInput == "2" || fifthInput == "3" || fifthInput == "4" || fifthInput == "5" || fifthInput == "6" || fifthInput == "7" || fifthInput == "8" || fifthInput == "9" || fifthInput == "0")))
                {
                    fifthNum = Convert.ToInt16(fifthInput);
                    Console.WriteLine("You choose " + fifthNum);
                    testNum5 = true;
                }

                else
                {
                    Console.WriteLine("Please choose again");
                    testNum5 = false;
                }


                while (testNum5 == false) ;
                Console.WriteLine("I don't have more time now");



            }
            






        }
    }
}
