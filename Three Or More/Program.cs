using System;
using static Three_Or_More.PlayersPlay;
using static Three_Or_More.BotsPlay;

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
        
        
    }
}
