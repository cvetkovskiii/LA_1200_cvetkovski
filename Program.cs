using System;

namespace Random_number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(Figgle.FiggleFonts.Slant.Render("RandomNumberAC"));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to RandomNumberAC! DO WHAT THE GAME SAYS!!!!");
            Console.WriteLine("PRESS THE KEY *Enter* TO START THE GAME!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            
            Random random = new Random();

            int rn = random.Next(1, 101);                     // This is the random number
            int attempts = 1;
            bool rnum = false;                  // the variable rnum is false (we use bool for right and false)

            while (rnum == false)                    // This is how you do the "while" loop
            {
                try         // when you write a char or a symbol it doesn't close the program
                {
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("Guess a number between 1 and 100:");
                    string s = Console.ReadLine();

                    int i = int.Parse(s);                   // This is how you convert the variable string



                    if (i > rn)
                    {
                        int triestook = attempts++;   // how many times you tried to guess (Rateversuche)
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Your number is too high! Guess a lower one...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i < rn)
                    {
                        int triestook = attempts++;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Your number is too low! Guess a higher one...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if (i == rn)
                    {
                        int triestook = attempts++;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("YOU GUESSED THE NUMBER" + " " + i + " " + "BOSS, BRAVO!!!!!");
                        Console.WriteLine("You only needed" + " " + triestook + " " + "guesses");
                        
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Press *Enter* to end the game");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        rnum = true;                    // The number is guessed, so the program will close when you click Enter
                    }
                    if (i > 100 || i < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Guess a number between 1 and 100, not lower or higher!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    } 
                    //if you write a higher than 100 or lower than 1, you will get this message ^


                    Console.WriteLine();

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    { Console.WriteLine("Invalid input! Write a NUMBER"); }
                    Console.ForegroundColor = ConsoleColor.White;

                }
























            }
        }
    }      
 
}
