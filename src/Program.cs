using System;
using System.Runtime.CompilerServices;

namespace FunctionChallenges
{
    class Program
    {

        public static void StringNumberProcessor(string[] userInput){
            int sum = 0;
            string conString = "";
            
            for (int i = 0 ; i < userInput.Length; i++){
                int isNumber;
                if (Int32.TryParse(userInput[i], out isNumber))
                {
                    sum += isNumber;
                }
                else
                {
                    conString += " ";
                    conString += userInput[i];
                }

            }
             Console.WriteLine($"{conString}: {sum}");
        }

        public static void GuessingGame(int? userInput){
            Random random = new Random();
            int number = random.Next(1, 101);
            if (number == userInput){
                System.Console.WriteLine("you guess it right!");

            }else{
                System.Console.WriteLine("Try again.");
            }
        }
        public static void ReverseWords(string userInput){
            string[] splitInput = userInput.Split(" ");
            string[] revInput = new string[splitInput.Length];
        
            for(int i = 0; i < splitInput.Length; i++){
                char[] word = splitInput[i].ToCharArray();
                Array.Reverse(word);
                revInput[i] = new string(word); 
             }
            System.Console.WriteLine(string.Join(" ", revInput));


        }

        static void Main(string[] args)
        {
            // Challenge 1
            /*
            while (true){

            Console.WriteLine("Enter your inputs or type (Quit) to exit: ");
            string? userInput = Console.ReadLine();

            // handling null or empty input
            if (userInput is null || userInput.ToString() == ""){

                Console.WriteLine("Please make sure you have enter some text!");

            }else if (userInput.Trim().ToLower() == "quit"){
                Console.WriteLine("program terminate.");
                break;

            }else{
                string[] splittingText = userInput.Split(" ");
                StringNumberProcessor(splittingText);
            } 

            }
            
            // Challenge 2
            
            while(true){
            Console.WriteLine("Enter your guess from 1 to 100 or type 404 to quit:");
             try{
                int? userInput = Convert.ToInt32(Console.ReadLine());
                    
                // handling null or empty input
            if (userInput is null || userInput.ToString() == ""){

                Console.WriteLine("Please make sure you have enter some text!");
                
            } else if (Convert.ToInt32(userInput) == 404){

                System.Console.WriteLine("program terminate.");
                break;

            }
            else{
                GuessingGame(userInput);
            }
         }
         catch (FormatException e){
            System.Console.WriteLine($" {e.Message}: please make sur you have enret an integer value!");

         }
  
    }*/
                
            // Challenge 3
            /*
            while(true){
            Console.WriteLine("Enter your inputs to reverse it, or type (Quit) to exit: ");
            string? userInput = Console.ReadLine();

            // handling null or empty input
            if (userInput is null || userInput.ToString() == ""){

                Console.WriteLine("Please make sure you have enter some text!");

            }else if (userInput.Trim().ToLower() == "quit"){
                Console.WriteLine("program terminate.");
                break;

            }else{
                ReverseWords(userInput);
            }

            }
            */
        }
    }
}