using System;

namespace First_Project
{
    class Mathsquiz
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Welcome, please enter your name.");

           string userName = Console.ReadLine();

           Console.WriteLine("Welcome to the game " + userName);
           Console.WriteLine("I have three questions for you, if you answer them correctly you will be rich beyond imagination. \nLet us begin");

           Console.WriteLine("For your first question, what is 10 + 2?");

           int answer01 = Convert.ToInt32(Console.ReadLine());

           if (answer01 == 12)
           {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
           }
           else
           {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect");
           }
           Console.ForegroundColor = ConsoleColor.Black;

           Console.WriteLine("When you are ready for your next question press any key.");

           Console.ReadKey();

           Console.WriteLine("Now for your second question \nWhat is 5*5?");

           int answer02 = Convert.ToInt32(Console.ReadLine());

           if (answer02 == 25)
           {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
           }
           else
           {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect!");
           }

           Console.ForegroundColor = ConsoleColor.Black;
           Console.WriteLine("When you are ready for your next question press any key.");

           Console.ReadKey();

           Console.WriteLine("Now for your third question. What is 52 + 5?");

           int answer03 = Convert.ToInt32(Console.ReadLine());

           if (answer03 == 57)
           {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");            
           }
            else
           {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect!");
           }
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("When you are ready for your next question press any key.");

            Console.ReadKey();

            Console.WriteLine("Now for your fourth question. What is 10*10?");

            int answer04 = Convert.ToInt32(Console.ReadLine());

            if (answer04 == 100)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");            
           }
            else
           {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect!");
           }
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("When you are ready for your next question press any key.");

            Console.ReadKey();

            Console.WriteLine("Now for your fifth and final question. What is 10-10?");

            int answer05 = (Convert.ToInt32(Console.ReadLine()));

            if (answer05 == 0)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");            
           }
            else
           {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect!");
           }
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Thank you for answering my questions! Now I can pass my test and you get nothing thanks sucker!");


            //Waits for input before closing
            Console.ReadKey();
        }
    }
}
