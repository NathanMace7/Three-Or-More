using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Three_Or_More.BotsPlay;

namespace Three_Or_More
{
    class PlayersPlay
    {
        public static void Player()
        {
            Console.WriteLine("\nPlayer 1, please make your turn. Type 'Roll' or '1' to roll.");  //Program promts user to roll
            bool continuepar = false;   //Bool used for continuing the program after a choice is made.
            do
            {
                string chooseRoll = Console.ReadLine();
                switch (chooseRoll)
                {
                    case "1": Dice(); break;    //User can input '1' for 'Yes'
                    case "roll": Dice(); break; //User can input 'roll'...
                    case "Roll": Dice(); break; //...or 'Roll' to choose to roll
                    default:
                        Console.WriteLine("Invalid answer. Please enter '1' or 'Roll'"); //If the input is invalid, print this line
                        break;  //Stops when the program is finished
                }
            }
            while (continuepar == false);   //Tells the program to repeat the question
        }

        public static void Dice()
        {
            Console.WriteLine("\nDice rolls: \n");  //Tells user they rolled the dice
            Random rnd = new Random();  //Creates new random
            int dice1 = rnd.Next(1, 7); //Chooses dice 1's value
            int dice2 = rnd.Next(1, 7); //Chooses dice 2's value
            int dice3 = rnd.Next(1, 7); //Chooses dice 3's value
            int dice4 = rnd.Next(1, 7); //Chooses dice 4's value
            int dice5 = rnd.Next(1, 7); //Chooses dice 5's value
            //int score = 0;  //Sets score
            //Displays dice rolls ↓
            Console.WriteLine("You rolled a " + dice1 + ".\nYou rolled a " + dice2 + ".\nYou rolled a " + dice3 + ".\nYou rolled a " + dice4 + ".\nYou rolled a " + dice5 + ".\n");
            Game(dice1, dice2, dice3, dice4, dice5, 0); //Goes to Game() method
        }
        public static void Game(int dice1, int dice2, int dice3, int dice4, int dice5, int score)
        {
            //If all 5 dice are the same
            if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4 && dice4 == dice5)
            { Console.WriteLine("All dice are the same."); score = score + 12; Console.WriteLine("Your score is: " + score); BotPlay(); }

            //If 4 dice are the same
            else if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)    //If dice 1, 2, 3 and 4 are the same
            { Console.WriteLine("4 dice are the same."); score = score + 6; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice1 == dice2 && dice2 == dice3 && dice3 == dice5)    //If dice 1, 2, 3 and 5 are the same
            { Console.WriteLine("4 dice are the same."); score = score + 6; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice1 == dice2 && dice2 == dice4 && dice4 == dice5)    //If dice 1, 2, 4 and 5 are the same
            { Console.WriteLine("4 dice are the same."); score = score + 6; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice1 == dice3 && dice3 == dice4 && dice4 == dice5)    //If dice 1, 3, 4 and 5 are the same
            { Console.WriteLine("4 dice are the same."); score = score + 6; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice2 == dice3 && dice3 == dice4 && dice4 == dice5)    //If dice 2, 3, 4 and 5 are the same
            { Console.WriteLine("4 dice are the same."); score = score + 6; Console.WriteLine("Your score is: " + score); BotPlay(); }

            //If 3 dice are the same
            else if (dice1 == dice2 && dice2 == dice3)  //If dice 1, 2 and 3 are the same
            { Console.WriteLine("3 dice are the same."); score = score + 3; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice1 == dice2 && dice2 == dice4)  //If dice 1, 2 and 4 are the same
            { Console.WriteLine("3 dice are the same."); score = score + 3; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice1 == dice2 && dice2 == dice5)  //If dice 1, 2 and 5 are the same
            { Console.WriteLine("3 dice are the same."); score = score + 3; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice1 == dice3 && dice3 == dice4)  //If dice 1, 3 and 4 are the same
            { Console.WriteLine("3 dice are the same."); score = score + 3; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice1 == dice3 && dice3 == dice5)  //If dice 1, 3 and 5 are the same
            { Console.WriteLine("3 dice are the same."); score = score + 3; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice1 == dice4 && dice4 == dice5)  //If dice 1, 4 and 5 are the same
            { Console.WriteLine("3 dice are the same."); score = score + 3; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice2 == dice3 && dice3 == dice4)  //If dice 2, 3 and 4 are the same
            { Console.WriteLine("3 dice are the same."); score = score + 3; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice2 == dice3 && dice3 == dice5)  //If dice 2, 3 and 5 are the same
            { Console.WriteLine("3 dice are the same."); score = score + 3; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice2 == dice4 && dice4 == dice5)  //If dice 2, 4 and 5 are the same
            { Console.WriteLine("3 dice are the same."); score = score + 3; Console.WriteLine("Your score is: " + score); BotPlay(); }
            else if (dice3 == dice4 && dice4 == dice5)  //If dice 3, 4 and 5 are the same
            { Console.WriteLine("3 dice are the same."); score = score + 3; Console.WriteLine("Your score is: " + score); BotPlay(); }

            //If two dice are the same
            else if (dice1 == dice2) { Console.WriteLine("Dice 1 and 2 are the same. Reroll!"); Reroll(); }
            else if (dice1 == dice3) { Console.WriteLine("Dice 1 and 3 are the same. Reroll!"); Reroll(); }
            else if (dice1 == dice4) { Console.WriteLine("Dice 1 and 4 are the same. Reroll!"); Reroll(); }
            else if (dice1 == dice5) { Console.WriteLine("Dice 1 and 5 are the same. Reroll!"); Reroll(); }
            else if (dice2 == dice3) { Console.WriteLine("Dice 2 and 3 are the same. Reroll!"); Reroll(); }
            else if (dice2 == dice4) { Console.WriteLine("Dice 2 and 4 are the same. Reroll!"); Reroll(); }
            else if (dice2 == dice5) { Console.WriteLine("Dice 2 and 5 are the same. Reroll!"); Reroll(); }
            else if (dice3 == dice4) { Console.WriteLine("Dice 3 and 4 are the same. Reroll!"); Reroll(); }
            else if (dice3 == dice5) { Console.WriteLine("Dice 3 and 5 are the same. Reroll!"); Reroll(); }
            else if (dice4 == dice5) { Console.WriteLine("Dice 4 and 5 are the same. Reroll!"); Reroll(); }

            //Else, if no dice are the same
            else { Console.WriteLine("No two die are the same. What a shame! Next, the bot's turn!"); BotPlay(); }
        }

        public static void Reroll()
        {
            //This method is for when the User gets to re-roll because two of the previous dice were the same value
            Console.WriteLine("\nDice rolls: \n");  //Tells user they rolled the dice
            Random rnd = new Random();  //Creates new random
            int dice1 = rnd.Next(1, 7); //Chooses dice 1's value
            int dice2 = rnd.Next(1, 7); //Chooses dice 2's value
            int dice3 = rnd.Next(1, 7); //Chooses dice 3's value
            int score = 0;  //Sets score
            //Displays dice rolls ↓
            Console.WriteLine("You rolled a " + dice1 + ".\nYou rolled a " + dice2 + ".\nYou rolled a " + dice3 + ".\n");

            //If all other 3 dice are the same
            if (dice1 == dice2 && dice2 == dice3)
            { Console.WriteLine("All 3 other dice are the same."); score = score + 12; Console.WriteLine("Your score is: " + score); }

            //If 2 other dice are the same
            else if (dice1 == dice2)    //If dice 1 and 2 are the same
            { Console.WriteLine("2 other dice are the same."); score = score + 6; Console.WriteLine("Your score is: " + score); }
            else if (dice1 == dice3)    //If dice 1 and 3 are the same
            { Console.WriteLine("2 other dice are the same."); score = score + 6; Console.WriteLine("Your score is: " + score); }
            else if (dice2 == dice3)    //If dice 2 and 3 are the same
            { Console.WriteLine("2 other dice are the same."); score = score + 6; Console.WriteLine("Your score is: " + score); }

            //Else, if no other dice are the same
            else { Console.WriteLine("Unfortunatly no other dice are the same. What a shame! Next, the bot's turn!"); }
            BotPlay(); //Goes to the bot
        }
    }
}
