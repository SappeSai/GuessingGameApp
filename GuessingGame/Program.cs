using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System;

namespace GuessingGame
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generate a random number within a specified range(e.g. 1 to 100) and store it as the "answer".

            //Prompt the user to enter their guess.

            //Compare the user's guess to the answer. If the guess is correct, output a message indicating that they have won the game. If the guess is incorrect, output a message indicating whether the answer is higher or lower than the guess.

            //Allow the user to continue guessing until they correctly guess the answer.

            //Keep track of the number of guesses the user has made and output this information when the game is over.

            //Allow the user to play the game again by prompting them if they want to play again. If they say yes, start a new game, otherwise exit the program.

            //Validate the user's input to ensure that it is a valid number within the specified range.

            //Use a while loop to keep the game running until the user correctly guesses the number or decides to quit.

            //Use appropriate variables, control flow statement, and functions

            //Be mindful of edge cases and add proper error handling

            //Test your code and debug it if necessary.



            // Generating random number between 1 and 20

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 21);
            

            // Checking answer
            bool isFinished = false;

            while (!isFinished)
            {
                Console.Write("Enter guess between 1 and 20, and then press Enter: ");
                string userGuessString = Console.ReadLine();
                int userGuessInt = 0;

                while(!int.TryParse(userGuessString, out userGuessInt))
                {
                    Console.Write("This is not a valid input. Please enter an integer value: ");
                    userGuessString = Console.ReadLine();
                };

                if (userGuessInt == randomNumber)
                {
                    Console.WriteLine("Congratulations. You won!");
                    break;
                }
                else if (userGuessInt > randomNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                    
                }
                else
                {
                   Console.WriteLine("Your guess is too low.");
                }
            }
        }
        }
    }