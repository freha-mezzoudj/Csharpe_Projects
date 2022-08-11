// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
using System;
//using System.Collections.Generic;
//using.System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//Namespace
namespace NumberGuesser
{ //Main class 
    class Program
    {   //Entry point Method

        static void Main(string[] args)
        {
            //start here

            Console.WriteLine("//***************** Game 1: Guess Number ********************//");
            //set app vars:
            GetAppInfo();
            //Ask users name and great!
            GreetUser();

            //inorder to play many time the game...

            while(true){

                    
            
                // Set correct number
                // int correctNumber = 7; we try with a random number!

                //int correct radom number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                    // init guess var 
                    int guess = 0;

                    Console.WriteLine("Guess a number between 1 and 10!");
        
                    //we need to give to the player many possibilities until he finds the correct Number 7
                    //so we need to use a loop: while guess is not correct yet..do
                
                    while(guess != correctNumber){
                        //Get users input
                        string inputNum = Console.ReadLine();
                        
                        if(!int.TryParse(inputNum, out guess)){
                            //tell the user that that he must input a number ..red!
                            printColorMsg(ConsoleColor.Red,"Enter a number, please try again!");
                            
                            /* //tell the user that that he must input a number ..red!
                            Inseade all this code, only use "printColoerMsg()"!
                            
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Enter a number, please try again!");
                                
                            //Reset text color default
                            Console.ResetColor();
                            */

                            //Keep going
                            continue;
                        }

                        //cast to int and put in guess (which is an int);
                        guess = Int32.Parse(inputNum); //it work but only when the input is a number!
                        
                        //Match guess to correct number
                        if(guess != correctNumber){

                            printColorMsg(ConsoleColor.Red, "Wrong Number:(, please try again!");
                        }    

                    }
                    //Output success 
                    //tell the user that the number is right ..green!

                            printColorMsg(ConsoleColor.Yellow, "You are CORRECT :)");
    
                            //ask to play againe 
                            Console.WriteLine("Play Again? [Y or N]");

                            //get answer
                            string answer = Console.ReadLine().ToUpper();

                            if (answer == "Y"){
                                continue;
                            }
                                else if (answer == "N"){
                                    return;
                                }
                                else
                                {
                                    return;
                                } 
                            }//end while --play game many times
        Console.ReadKey();   
            }
        //Functions: for a clean code :)     
        static void GetAppInfo(){
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mouad Bmz";

            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion,appAuthor);

            //to change text color in the console:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion,appAuthor);
            
            //Reset text color default
            Console.ResetColor();

        } 
        static void GreetUser(){
            //Ask user for his name?
             Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game ...", inputName);
        }
        static void printColorMsg(ConsoleColor color, string message){
            //tell the user that the number is wrong ..red!
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = color;
            //Console.WriteLine("Wrong Number:(, please try again!");
            Console.WriteLine(message);                    
            //Reset text color default
            Console.ResetColor();      
        }

        }

    } 
//}
