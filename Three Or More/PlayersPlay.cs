using System;
using static Three_Or_More.BotsPlay;
using static Three_Or_More.Three_Or_More.Program;

namespace Three_Or_More
{
    class PlayersPlay
    {
        public static void Player(int playerscore, int botscore)
        {
            Console.WriteLine("\nPlayer 1, please make your turn. Type 'Roll' or '1' to roll.");  //Program promts user to roll
            bool continuepar = false;   //Bool used for continuing the program after a choice is made.
            do
            {
                string chooseRoll = Console.ReadLine();
                switch (chooseRoll)
                {
                    case "1": case "roll": case "Roll": case "yes": case "Yes": case "y": case "Y": Main(); break;
                    case "0": case "no": case "No": case "n": case "N": Console.WriteLine("Thanks for playing! Please press any putton to quit"); Console.ReadKey(); Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Valid responses for yes: '1', 'Roll', 'Yes' or 'Y'\nValid responses for no: '0', 'No', or 'N'"); //If the input is invalid, print this line
                        break;  //Stops when the program is finished
                }
            }
            while (continuepar == false);   //Tells the program to repeat the question
        }

        public static void Dice(int playerscore, int botscore)
        {
            Console.WriteLine("\nDice rolls: \n");  //Tells user they rolled the dice
            Random rnd = new Random();  //Creates new random
            int dice1 = rnd.Next(1, 7); //Chooses dice 1's value
            int dice2 = rnd.Next(1, 7); //Chooses dice 2's value
            int dice3 = rnd.Next(1, 7); //Chooses dice 3's value
            int dice4 = rnd.Next(1, 7); //Chooses dice 4's value
            int dice5 = rnd.Next(1, 7); //Chooses dice 5's value

            //Displays dice rolls ↓
            Console.WriteLine("You rolled a " + dice1 + ".\nYou rolled a " + dice2 + ".\nYou rolled a " + dice3 + ".\nYou rolled a " + dice4 + ".\nYou rolled a " + dice5 + ".\n");
            Game(dice1, dice2, dice3, dice4, dice5, playerscore, botscore); //Goes to Game() method
        }
        public static void Game(int dice1, int dice2, int dice3, int dice4, int dice5, int playerscore, int botscore)
        {
            //If all 5 dice are the same
            if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4 && dice4 == dice5)
            { Console.WriteLine("All dice are the same."); playerscore = playerscore + 12; Console.WriteLine("Your score is: " + playerscore); BotPlay(playerscore, botscore); }

            //If 4 dice are the same
            else if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4 || dice1 == dice2 && dice2 == dice3 && dice3 == dice5 || dice1 == dice2 && dice2 == dice4 && dice4 == dice5 || dice1 == dice3 && dice3 == dice4 && dice4 == dice5 || dice2 == dice3 && dice3 == dice4 && dice4 == dice5)    //If dice 1, 2, 3 and 4 are the same
            { Console.WriteLine("4 dice are the same."); playerscore = playerscore + 6; Console.WriteLine("Your score is: " + playerscore); BotPlay(playerscore, botscore); }

            //If 3 dice are the same
            else if (dice1 == dice2 && dice2 == dice3 || dice1 == dice2 && dice2 == dice4 || dice1 == dice2 && dice2 == dice5 || dice1 == dice3 && dice3 == dice4 || dice1 == dice3 && dice3 == dice5 || dice1 == dice4 && dice4 == dice5 || dice2 == dice3 && dice3 == dice4 || dice2 == dice3 && dice3 == dice5 || dice2 == dice4 && dice4 == dice5 || dice3 == dice4 && dice4 == dice5)  //If dice 1, 2 and 3 are the same
            { Console.WriteLine("3 dice are the same."); playerscore = playerscore + 3; Console.WriteLine("Your score is: " + playerscore); BotPlay(playerscore, botscore); }

            //If two dice are the same
            else if (dice1 == dice2 || dice1 == dice3 || dice1 == dice4 || dice1 == dice5 || dice2 == dice3 || dice2 == dice4 || dice2 == dice5 || dice3 == dice4 || dice3 == dice5 || dice4 == dice5) { Console.WriteLine("Dice 1 and 2 are the same. Reroll!"); Reroll(playerscore, botscore); }

            //Else, if no dice are the same
            else { Console.WriteLine("No two die are the same. What a shame! Next, the bot's turn!"); BotPlay(playerscore, botscore); }
        }

        public static void Reroll(int playerscore, int botscore)
        {
            //This method is for when the User gets to re-roll because two of the previous dice were the same value
            Console.WriteLine("\nDice rolls: \n");  //Tells user they rolled the dice
            Random rnd = new Random();  //Creates new random
            int dice1 = rnd.Next(1, 7); //Chooses dice 1's value
            int dice2 = rnd.Next(1, 7); //Chooses dice 2's value
            int dice3 = rnd.Next(1, 7); //Chooses dice 3's value

            //Displays dice rolls ↓
            Console.WriteLine("You rolled a " + dice1 + ".\nYou rolled a " + dice2 + ".\nYou rolled a " + dice3 + ".\n");

            //If all other 3 dice are the same
            if (dice1 == dice2 && dice2 == dice3)
            { Console.WriteLine("All 3 other dice are the same."); playerscore = playerscore + 12; Console.WriteLine("Your score is: " + playerscore); }

            //If 2 other dice are the same
            else if (dice1 == dice2 || dice1 == dice3 || dice2 == dice3)    //If dice 1 and 2 are the same
            { Console.WriteLine("2 other dice are the same."); playerscore = playerscore + 6; Console.WriteLine("Your score is: " + playerscore); }

            //Else, if no other dice are the same
            else { Console.WriteLine("Unfortunatly no other dice are the same. What a shame! Next, the bot's turn!"); }
            BotPlay(playerscore, botscore); //Goes to the bot
        }
    }
}
