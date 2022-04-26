using System;

//Names space
namespace NumberGuesser
{
    //Main class
    class Program
    {
        //Entry Point Method
        static void Main(String[] args)
        {
            getAppInfo();//Run GetAppInfo function

            GreetUser();

            PrintColorMessage(ConsoleColor.Yellow, "What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            PrintColorMessage(ConsoleColor.Yellow, String.Format("Hello {0} let's play a game..", inputName));

            //Init set correct number
            //int correctNumber = 7;

            //Create a new Random object
            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            //Init guess var
            int guess = 0;

            do
            {
                //Ask user for number
                PrintColorMessage(ConsoleColor.Yellow, "Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure its a numer
                    if (!int.TryParse(input, out guess))
                    {
                            
                        //Prit error message
                        PrintColorMessage(ConsoleColor.Red,"Please enter an actual number");
                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    //guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Tell user its the wrong number
                        PrintColorMessage(ConsoleColor.Red, String.Format("Wrong number, {0} please try again", inputName));
                    }
                }
                //Output succes message
                //Tell user its the right number
                PrintColorMessage(ConsoleColor.Green, String.Format("Congratulations {0} , You are correct!!!", inputName));

                //Ask to play again
                PrintColorMessage(ConsoleColor.Yellow, "Play Againg? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    guess = 0;
                    correctNumber = random.Next(1, 10);
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            } while (true);

        }

        //Get and display app info
        static void getAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Daniel Parrillas";
            string message = String.Format("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Write app out info
            PrintColorMessage(ConsoleColor.DarkGray, message);
        }

        //Ask users name and greet
        static void GreetUser()
        {

        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;
            //Write
            Console.WriteLine(message);
            //Reset text color
            Console.ResetColor();
        }
    }
}