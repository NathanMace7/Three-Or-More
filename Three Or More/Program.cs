using System;

namespace Three_Or_More
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Three Or More\n"); //Title
            Console.WriteLine("Rules of Three Or More: \n" + //Rules
                "\nPlayers take turns rolling five dice and score for three-of-a-kind or better. " +
                "\nIf a player only has two-of-a-kind, they may re-throw the remaining dice\nin an attempt to improve the remaining dice values." +
                "\nIf no matching numbers are rolled after two rolls, the player scores 0.");
        }
        //public static void Dice()  { } <- NEEDED
        public static void Player()
        {
            Console.WriteLine("Player 1, please make your turn. Type 'Roll' or '1' to roll."); //Program promts user to roll

            //Bool used for continuing the program after a choice is made.
            bool continuepar = false;

            do
            {
                string chooseRoll = Console.ReadLine();

                switch (chooseRoll)
                {
                    case "1": break;
                    case "Roll": break;
                    case "roll": break;

                    default:
                        Console.WriteLine("Invalid answer. Please enter '1' or 'Roll'"); //If the input is invalid, print this line
                        break; //Stops when the program is finished
                }
            }
            while (continuepar == false); //Tells the program to repeat the question
        }
        public static void Game()
        {
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 7);
                Console.WriteLine(rnd);
            }
        }

    }
}
