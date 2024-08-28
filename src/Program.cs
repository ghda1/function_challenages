using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

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

        public static void ProfileUpdater (ref string? name, ref int? age, ref string? email){
            System.Console.Write("Enter your new name: ");
            name = Console.ReadLine();
            System.Console.WriteLine($"Name updated to: {name}");
            System.Console.Write("Enter your new age: ");
            age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine($"Age updated to: {age}");
            System.Console.Write("Enter your new email: ");
            email = Console.ReadLine();
            System.Console.WriteLine($"Email updated to: {email}");
            System.Console.WriteLine();
            System.Console.WriteLine(); 
            System.Console.WriteLine("Updated profile:");
            Console.WriteLine($"Name: { name} ");
            Console.WriteLine($"Age: { age} ");
            Console.WriteLine($"Email: { email} ");
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
         } // handling double\float\string inputs
         catch (FormatException e){
            System.Console.WriteLine($" {e.Message}: please make sur you have enret an integer value!");

         }
  
    }
                
            // Challenge 3
            
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
             // Challenge 4

              System.Console.WriteLine("Enter Your Name, Age, and Email. (note: you can update later)");  
              System.Console.Write("Name: ");
              string? name = Console.ReadLine();
              // handling null or empty input
              if (name is null || name == ""){
                System.Console.WriteLine("Please make sure that you enter your name: ");
                name = Console.ReadLine();
              }

              System.Console.Write("Age: ");
              int? age = Convert.ToInt32(Console.ReadLine());
              // handling null or empty input
              if (age is null || age.ToString() == ""){
                System.Console.WriteLine("Please make sure that you enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
              } // handling negative input
              else if(age < 0){
                System.Console.WriteLine("your age shouldn't be negative. Please enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
              }

              System.Console.Write("Email: ");
              string? email = Console.ReadLine();
              // handling null or empty input
              if (email is null || email == ""){
                System.Console.WriteLine("Please make sure that you enter your email: ");
                email = Console.ReadLine();
              }
              // handling unvalid email
              bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
               RegexOptions.IgnoreCase);
              if (!isEmail){
                System.Console.WriteLine("Please enter a valid email: ");
                email = Console.ReadLine();
              }
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Initial profile:");
            Console.WriteLine($"Name: { name} ");
            Console.WriteLine($"Age: { age} ");
            Console.WriteLine($"Email: { email} ");
            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("Do you want to update your profile? (type: y/n)");
            string? updateSighn = Console.ReadLine();
            // handling null or empty input
            if (updateSighn is null || updateSighn == ""){
                System.Console.WriteLine("Please enter y/n!");
                updateSighn = Console.ReadLine();
              }else if(updateSighn.Trim().ToLower() == "n"){
                System.Console.WriteLine("Thanks!");

              }else if (updateSighn.Trim().ToLower() == "y"){
                ProfileUpdater(ref name, ref age, ref email);
              }
        }
    }
}