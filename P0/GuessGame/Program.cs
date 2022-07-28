using System;

namespace GuessGame
{
    class Program 
    {
        static void Main (string [] args)
        {
            bool endConsole = true;

            while (endConsole)
            {
                Console.WriteLine("Hello! Please enter a number to choose a game from the following:");
                Console.WriteLine("1: Random number guessing game");
                Console.WriteLine("2: Rock, Paper, Scissors game");
                Console.WriteLine("0: Exit");
                string initial = Console.ReadLine();
                int initialGame = int.Parse(initial);
                Console.WriteLine("new line");
                Console.WriteLine("new");

                switch (initialGame)
                {
                    case 1: //Random Number Game
                        Random r = new Random();

                    int random = r.Next(1,100); //Generates a random number between 1 and 100
                    int random2 = r.Next(1,40); //Generates second random number

                    bool end = false; //ends the game

                    int Streak = 0;
                    int count = 0;
                    
                    Console.WriteLine();
                    Console.WriteLine("Please choose a number between 1 and 100.");
                    Console.WriteLine("If you guess the number within 5 trials, you get a point.");
                    Console.WriteLine("If you do not enter a numeric value, the game will exit.");

                    try{ //Catch block to catch exceptions for non-numeric values 
                        do{ //double do-while loops to allow the game to have turns and allows the user to play again.
                            do 
                            {
                                string a = Console.ReadLine();
                                int b = int.Parse(a);
                                
                                if (b > random)
                                {
                                    count += 1;                                               
                                    Console.WriteLine("Guess too high! Guess lower.");
                                    Console.WriteLine("Count: " + count);
                                    Console.WriteLine();
                                }
                                else if(b < random)
                                {
                                    count += 1;                                   
                                    Console.WriteLine("Guess too low! Guess higher.");
                                    Console.WriteLine("Count: " + count);
                                    Console.WriteLine();
                                }
                                else if (b == random)
                                {
                                    count += 1;
                                    Console.WriteLine("Correct Answer!");
                                    Console.WriteLine();
                                    count = 6;
                                    random += random2;
                                    if (random >=99) {random -=50;}
                                    else if (random <30) {random += 40;}
                                    Streak += 1;
                                }
                            } while (count < 5);
                            Console.WriteLine();
                            Console.WriteLine("Game Over!   " + "Streak: " + Streak);
                            Console.WriteLine("Please Select one of the options: ");
                            Console.WriteLine("Press 1 play again");
                            Console.WriteLine("Press 0 to exit the game");

                            string c = Console.ReadLine();
                            int d = int.Parse(c);

                            switch (d)
                            {
                                case 1:
                                    end = false;
                                    count = 0;
                                    Console.WriteLine("Please choose a number between 1 and 100.");
                                    Console.WriteLine("If you guess the number within 5 trials, you get a point.");
                                    break;
                                case 0:
                                    end = true; 
                                    break; 
                            }
                        } while (end != true);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Please enter a number!!");
                    }

                    Console.WriteLine("Thank You for playing the guessing game!");
                    Console.WriteLine();

                    
                    break;

                    case 2: //Rock Paper Scissors
                        bool gameLoop = true;

                Console.WriteLine("Welcome to Rock, Paper, Scisors!");
                Console.WriteLine("Press 1 to begin game");
                Console.WriteLine("Press 0 to exit");
                string input = Console.ReadLine();
                int userInput = int.Parse(input);
                int userPoints = 0;
                int computerPoints = 0;
                try{
                    while (gameLoop)
                    {
                        Random g = new Random();
                        int systemChoice = g.Next(1,4);

                        switch (userInput)
                        {
                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("Press 1 for Rock, 2 for Paper, 3 for Scisors");  
                                Console.WriteLine("Press 0 to exit the game.");    
                                Console.WriteLine();       
                                break;
                            case 0:
                                gameLoop = false; 
                                break;
                            default :
                                Console.WriteLine("Press choose one of the options");
                                break;
                        }

                        string Choice = Console.ReadLine();
                        int userChoice = int.Parse(Choice);

                        switch (userChoice)
                        {
                            case 1:
                            if(systemChoice == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Computer Choice: Rock");
                                Console.WriteLine("User Choice: Rock");
                                Console.WriteLine("It's a tie");
                            }
                            else if(systemChoice == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Computer Choice: Paper");
                                Console.WriteLine("User Choice: Rock");
                                Console.WriteLine("Computer wins!");
                                computerPoints++;
                                Console.WriteLine("User Points: " + userPoints + " Computer Points: " + computerPoints); 
                            }
                            else if (systemChoice == 3)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Computer Choice: Scissors");
                                Console.WriteLine("User Choice: Rock");
                                Console.WriteLine("User Wins");
                                userPoints++;
                                Console.WriteLine("User Points: " + userPoints + " Computer Points: " + computerPoints); 
                            }
                            break;
                            case 2:
                            if (systemChoice == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Computer Choice: Rock");
                                Console.WriteLine("User Choice: Paper");
                                Console.WriteLine("User Wins!");
                                userPoints++;
                                Console.WriteLine("User Points: " + userPoints + " Computer Points: " + computerPoints); 
                            }
                            else if (systemChoice == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Computer Choice: Paper");
                                Console.WriteLine("User Choice: Paper");
                                Console.WriteLine("It's a tie!");
                            }
                            else if (systemChoice == 3)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Computer Choice: Scissors");
                                Console.WriteLine("User Choice: Paper");
                                Console.WriteLine("Computer Wins!");
                                computerPoints++;
                                Console.WriteLine("User Points: " + userPoints + " Computer Points: " + computerPoints); 
                            }
                            break;
                            case 3:
                            if (systemChoice == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Computer Choice: Rock");
                                Console.WriteLine("User Choice: Scissors");
                                Console.WriteLine("Computer Wins!");
                                computerPoints++;
                                Console.WriteLine("User Points: " + userPoints + " Computer Points: " + computerPoints); 
                            }
                            else if (systemChoice ==2)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Computer Choice: Paper");
                                Console.WriteLine("User Choice: Scissors");
                                Console.WriteLine("User Wins!");
                                userPoints++;
                                Console.WriteLine("User Points: " + userPoints + " Computer Points: " + computerPoints); 
                            }
                            else if (systemChoice == 3)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Computer Choice: Scissors");
                                Console.WriteLine("User Choice: Scissors");
                                Console.WriteLine("It's a tie!");
                            }
                            break;
                            case 0:
                            gameLoop = false;
                            break;
                        }
                    }
                        Console.WriteLine();
                        Console.WriteLine("Do you wish to play again?");
                        Console.WriteLine("Enter Y or N");
                        string playAgain = Console.ReadLine();
                        if (playAgain == "N" || playAgain == "n")
                        {
                            gameLoop = false; 
                            Console.WriteLine("Thank You for playing!"); 
                            Console.WriteLine("User Points: " + userPoints + " Computer Points: " + computerPoints); 
                        }
                     
                }
                catch (Exception m)
                {
                    Console.WriteLine("Pleae enter a value between 1 and 3");
                }

                    break;

                    case 0:
                        endConsole = false;
                        Console.WriteLine("Goodbye!");
                    break;

                }   
            }
        }
    }
}
