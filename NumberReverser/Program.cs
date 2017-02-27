using System;

namespace NumberReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user to input number and assign to string "userInput".
            Console.WriteLine("Please input a number to reverse: ");
            string userInput = Console.ReadLine();

            //Assign userInput to int inputNum, converting string to integer. Declare other needed variables.
            int inputNum = Convert.ToInt32(userInput);
            int remain, reverseNum = 0;

            //Calculate reverse of inputNum
            while (inputNum > 0)
            {
                //Find remainder from dividing inputNum by 10
                remain = inputNum % 10;
                //Add remainder from above to the current value of reverseNum multiplied by 10. Assign result as new value of reverseNum.
                reverseNum = reverseNum * 10 + remain;
                //Divide current value of inputNum by 10.  If it's above zero, the loop continues.
                inputNum /= 10;
            }

            //Display results
            Console.WriteLine("The reverse of " + userInput + " is " + reverseNum + ".");
            Console.ReadLine();
        }
    }
}
