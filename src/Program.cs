using System;
using System.Runtime.CompilerServices;

namespace FunctionChallenges
{
    class Program
    {

        public static void StringNumberProcessor(string[] userInput){
            int isNumber = 0;
            int sum = 0;
            string conString = "";
            
            for (int i = 0 ; i < userInput.Length; i++){
                if(Int32.TryParse(userInput[i], out isNumber)){
                    sum += isNumber;
            }else{
                conString += " ";
                conString += userInput[i];
            }
           
            }
             Console.WriteLine($"{conString}: {sum}");
        }
        static void Main(string[] args)
        {

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

        }
    }
}