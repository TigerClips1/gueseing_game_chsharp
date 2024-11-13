/*This program is a basic guesing game*/

// Make namespace just in case i want to use it later,
namespace Gueseing_Game
{
    // Make a class name game,
    public class Game
    {
        // The main function aka the old version of making a C# project,
        public static void Main(string[] args)
        {
            // Make a number the user have to guest in the game,
            char favnum = '9';
            // Loop it until the number is true,
            while (true)
            {
                // Handle the input,
                Console.WriteLine("Please Enter a number 1-10: ");
                //FIXME.
                #pragma warning disable 8604 // disable warning CS8604.
                char num = Convert.ToChar(Console.ReadLine());
                // If the favnum is right then it will say it's correct else if you don't guest the right number it will keep on looping until you get it right  then when you get it right then it will break outta the while loop.
                if (favnum == num)
                {
                    Console.WriteLine("You guest the right number");
                    break;
                   
                } 
                else 
                {
                    Console.WriteLine("Please Try and guest again");
                }
            }
        }
    }
}
