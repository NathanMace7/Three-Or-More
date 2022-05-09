using System;

namespace Three_Or_More
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Three Or More\n");    //Title
            Console.WriteLine("Rules of Three Or More: \n" +    //Rules
                "\nPlayers take turns rolling five dice and score for three-of-a-kind or better. " +
                "\nIf a player only has two-of-a-kind, they may re-throw the remaining dice\nin an attempt to improve the remaining dice values." +
                "\nIf no matching numbers are rolled after two rolls, the player scores 0." +
                "\n\nIn this game, you will be up against a bot.\nThe bot does not tell you its rolls (mainly for simplicity on the console), but will give you its scoring and tell you if it needs a re-roll.");
            Player();
        }
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
        public static void BotPlay()
        {
            Console.WriteLine("\nThe bot is now playing their turn.");
            Random rnd = new Random();  //Creates new random
            int bpdice1 = rnd.Next(1, 7);  //Chooses the bot's dice 1 value
            int bpdice2 = rnd.Next(1, 7);  //Chooses the bot's dice 1 value
            int bpdice3 = rnd.Next(1, 7);  //Chooses the bot's dice 1 value
            int bpdice4 = rnd.Next(1, 7);  //Chooses the bot's dice 1 value
            int bpdice5 = rnd.Next(1, 7);  //Chooses the bot's dice 1 value
            int score = 0;

            //If all 5 dice are the same
            if (bpdice1 == bpdice2 && bpdice2 == bpdice3 && bpdice3 == bpdice4 && bpdice4 == bpdice5)
            { Console.WriteLine("The bot's dice all dice are the same."); score = score + 12; Console.WriteLine("Bot's score is: " + score); }

            //If The bot rolled the same 4 dice
            else if (bpdice1 == bpdice2 && bpdice2 == bpdice3 && bpdice3 == bpdice4)    //If dice 1, 2, 3 and 4 are the same
            { Console.WriteLine("The bot rolled the same 4 dice."); score = score + 6; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice1 == bpdice2 && bpdice2 == bpdice3 && bpdice3 == bpdice5)    //If dice 1, 2, 3 and 5 are the same
            { Console.WriteLine("The bot rolled the same 4 dice."); score = score + 6; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice1 == bpdice2 && bpdice2 == bpdice4 && bpdice4 == bpdice5)    //If dice 1, 2, 4 and 5 are the same
            { Console.WriteLine("The bot rolled the same 4 dice."); score = score + 6; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice1 == bpdice3 && bpdice3 == bpdice4 && bpdice4 == bpdice5)    //If dice 1, 3, 4 and 5 are the same
            { Console.WriteLine("The bot rolled the same 4 dice."); score = score + 6; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice2 == bpdice3 && bpdice3 == bpdice4 && bpdice4 == bpdice5)    //If dice 2, 3, 4 and 5 are the same
            { Console.WriteLine("The bot rolled the same 4 dice."); score = score + 6; Console.WriteLine("Bot's score is: " + score); }

            //If the bot rolled the same 3 dice
            else if (bpdice1 == bpdice2 && bpdice2 == bpdice3)  //If dice 1, 2 and 3 are the same
            { Console.WriteLine("The bot rolled the same 3 dice."); score = score + 3; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice1 == bpdice2 && bpdice2 == bpdice4)  //If dice 1, 2 and 4 are the same
            { Console.WriteLine("The bot rolled the same 3 dice."); score = score + 3; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice1 == bpdice2 && bpdice2 == bpdice5)  //If dice 1, 2 and 5 are the same
            { Console.WriteLine("The bot rolled the same 3 dice."); score = score + 3; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice1 == bpdice3 && bpdice3 == bpdice4)  //If dice 1, 3 and 4 are the same
            { Console.WriteLine("The bot rolled the same 3 dice."); score = score + 3; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice1 == bpdice3 && bpdice3 == bpdice5)  //If dice 1, 3 and 5 are the same
            { Console.WriteLine("The bot rolled the same 3 dice."); score = score + 3; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice1 == bpdice4 && bpdice4 == bpdice5)  //If dice 1, 4 and 5 are the same
            { Console.WriteLine("The bot rolled the same 3 dice."); score = score + 3; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice2 == bpdice3 && bpdice3 == bpdice4)  //If dice 2, 3 and 4 are the same
            { Console.WriteLine("The bot rolled the same 3 dice."); score = score + 3; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice2 == bpdice3 && bpdice3 == bpdice5)  //If dice 2, 3 and 5 are the same
            { Console.WriteLine("The bot rolled the same 3 dice."); score = score + 3; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice2 == bpdice4 && bpdice4 == bpdice5)  //If dice 2, 4 and 5 are the same
            { Console.WriteLine("The bot rolled the same 3 dice."); score = score + 3; Console.WriteLine("Bot's score is: " + score); }
            else if (bpdice3 == bpdice4 && bpdice4 == bpdice5)  //If dice 3, 4 and 5 are the same
            { Console.WriteLine("The bot rolled the same 3 dice."); score = score + 3; Console.WriteLine("Bot's score is: " + score); }

            //If the bot rolled the same 2 dice
            else if (bpdice1 == bpdice2) { Console.WriteLine("Dice 1 and 2 are the same. The bot gets to re-roll!"); BotReroll(); }
            else if (bpdice1 == bpdice3) { Console.WriteLine("Dice 1 and 3 are the same. The bot gets to re-roll!"); BotReroll(); }
            else if (bpdice1 == bpdice4) { Console.WriteLine("Dice 1 and 4 are the same. The bot gets to re-roll!"); BotReroll(); }
            else if (bpdice1 == bpdice5) { Console.WriteLine("Dice 1 and 5 are the same. The bot gets to re-roll!"); BotReroll(); }
            else if (bpdice2 == bpdice3) { Console.WriteLine("Dice 2 and 3 are the same. The bot gets to re-roll!"); BotReroll(); }
            else if (bpdice2 == bpdice4) { Console.WriteLine("Dice 2 and 4 are the same. The bot gets to re-roll!"); BotReroll(); }
            else if (bpdice2 == bpdice5) { Console.WriteLine("Dice 2 and 5 are the same. The bot gets to re-roll!"); BotReroll(); }
            else if (bpdice3 == bpdice4) { Console.WriteLine("Dice 3 and 4 are the same. The bot gets to re-roll!"); BotReroll(); }
            else if (bpdice3 == bpdice5) { Console.WriteLine("Dice 3 and 5 are the same. The bot gets to re-roll!"); BotReroll(); }
            else if (bpdice4 == bpdice5) { Console.WriteLine("Dice 4 and 5 are the same. The bot gets to re-roll!"); BotReroll(); }

            //Else, if no dice are the same
            else { Console.WriteLine("No two die are the same. What a shame! Next, the player's turn!"); }
            Player();
        }

        public static void BotReroll()
        {
            //This method is for when the User gets to re-roll because two of the previous dice were the same value
            //Console.WriteLine("\nDice rolls: \n");  //Tells user the rolled the dice
            Random rnd = new Random();  //Creates new random
            int bpdice1 = rnd.Next(1, 7); //Chooses dice 1's value
            int bpdice2 = rnd.Next(1, 7); //Chooses dice 2's value
            int bpdice3 = rnd.Next(1, 7); //Chooses dice 3's value
            int score = 0;  //Sets score
            //Displays dice rolls ↓
            //Console.WriteLine("You rolled a " + bpdice1 + ".\nYou rolled a " + bpdice2 + ".\nYou rolled a " + bpdice3 + ".\n");

            //If all other 3 dice are the same
            if (bpdice1 == bpdice2 && bpdice2 == bpdice3)
            { Console.WriteLine("All 3 other dice are the same."); score = score + 12; Console.WriteLine("The bot's score is: " + score); }

            //If 2 other dice are the same
            else if (bpdice1 == bpdice2)    //If dice 1 and 2 are the same
            { Console.WriteLine("2 other dice are the same."); score = score + 6; Console.WriteLine("The bot's score is: " + score); }
            else if (bpdice1 == bpdice3)    //If dice 1 and 3 are the same
            { Console.WriteLine("2 other dice are the same."); score = score + 6; Console.WriteLine("The bot's score is: " + score); }
            else if (bpdice2 == bpdice3)    //If dice 2 and 3 are the same
            { Console.WriteLine("2 other dice are the same."); score = score + 6; Console.WriteLine("The bot's score is: " + score); }

            //Else, if no other dice are the same
            else { Console.WriteLine("Unfortunatly no other dice are the same. What a shame! Next, the player's turn!"); }
            Player(); //Goes to the player
        }
    }
}
