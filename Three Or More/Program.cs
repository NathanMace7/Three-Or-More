using System;
using static Three_Or_More.PlayersPlay;
using static Three_Or_More.BotsPlay;

namespace Three_Or_More
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Three Or More\n");    //Title
            Console.WriteLine("Rules of Three Or More: \n" +    //Rules
                "\nPlayers take turns rolling five dice and score for three-of-a-kind or better. " +
                "\nIf a player only has two-of-a-kind, they may re-throw the remaining dice\nin an attempt to improve the remaining dice values." +
                "\nIf no matching numbers are rolled after two rolls, the player scores 0." +
                "\n\nIn this game, you will be up against a bot.\nThe bot does not tell you its rolls (mainly for simplicity on the console), but will give you its scoring and tell you if it needs a re-roll.");
            ScoreSet();
        }

        public static void ScoreSet() 
        { 
            int playerscore = 0; 
            int botscore = 0;
            Score(playerscore, botscore);
        }
        public static void Score(int playerscore, int botscore)
        {
            if (playerscore >= 50) 
            { 
                Console.WriteLine("\nAnd the Player wins!\nPlayer's score: " + playerscore + "\nThe bot's score: " + botscore);
                Console.WriteLine("\nWould you like to play again?");  //Program promts user to play again
                bool continuepar = false;   //Bool used for continuing the program after a choice is made.
                do
                {
                    string chooseToContinue = Console.ReadLine();
                    switch (chooseToContinue)
                    {
                        case "1": Main(); break;    //User can input '1' for 'Yes'
                        case "roll": Main(); break; //User can input 'roll'...
                        case "Roll": Main(); break; //...or 'Roll' to choose to continue
                        case "yes": Main(); break;  //User can input 'yes'... 
                        case "Yes": Main(); break;  //...or 'Yes' to choose to continue
                        case "y": Main(); break;    //User can input 'y'... 
                        case "Y": Main(); break;    //...or 'Y' to choose to continue
                        case "0": Console.WriteLine("Thanks for playing! Please press any putton to quit"); Console.ReadKey(); Environment.Exit(0); break;  //User can input '0' for 'No'
                        case "no": Console.WriteLine("Thanks for playing! Please press any putton to quit"); Console.ReadKey(); Environment.Exit(0); break; //User can input 'no'... 
                        case "No": Console.WriteLine("Thanks for playing! Please press any putton to quit"); Console.ReadKey(); Environment.Exit(0); break; //...or 'No' to choose to quit
                        case "n": Console.WriteLine("Thanks for playing! Please press any putton to quit"); Console.ReadKey(); Environment.Exit(0); break;  //User can input 'n'... 
                        case "N": Console.WriteLine("Thanks for playing! Please press any putton to quit"); Console.ReadKey(); Environment.Exit(0); break;  //...or 'N' to choose to quit
                        default:
                            Console.WriteLine("Valid responses for yes: '1', 'Roll', 'Yes' or 'Y'\nValid responses for no: '0', 'No', or 'N'"); //If the input is invalid, print this line
                            break;  //Stops when the program is finished
                    }
                }
                while (continuepar == false);   //Tells the program to repeat the question
            }
            else if (botscore >= 50) 
            { 
                Console.WriteLine("\nAnd the Bot wins! \nThe bot's score: " + botscore + "\nPlayer's score: " + playerscore);
                Console.WriteLine("\nWould you like to play again?");  //Program promts user to play again
                bool continuepar = false;   //Bool used for continuing the program after a choice is made.
                do
                {
                    string chooseToContinue = Console.ReadLine();
                    switch (chooseToContinue)
                    {
                        case "1": Main(); break;    //User can input '1' for 'Yes'
                        case "roll": Main(); break; //User can input 'roll'...
                        case "Roll": Main(); break; //...or 'Roll' to choose to continue
                        case "yes": Main(); break;  //User can input 'yes'... 
                        case "Yes": Main(); break;  //...or 'Yes' to choose to continue
                        case "y": Main(); break;    //User can input 'y'... 
                        case "Y": Main(); break;    //...or 'Y' to choose to continue
                        case "0": Main(); break;    //User can input '0' for 'No'
                        case "no": Main(); break;   //User can input 'no'... 
                        case "No": Main(); break;   //...or 'No' to choose to continue
                        case "n": Main(); break;    //User can input 'n'... 
                        case "N": Main(); break;    //...or 'N' to choose to continue
                        default:
                            Console.WriteLine("Valid responses for yes: '1', 'Roll', 'Yes' or 'Y'\nValid responses for no: '0', 'No', or 'N'"); //If the input is invalid, print this line
                            break;  //Stops when the program is finished
                    }
                }
                while (continuepar == false);   //Tells the program to repeat the question
            }
            else { Player(playerscore, botscore); }
        }
    }
}
