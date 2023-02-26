using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int secret = randomGenerator.Next(1, 101);

        int number = -1;
       
        while (secret != number)
        {   
            Console.Write("What is the guess number? ");
            number = int.Parse(Console.ReadLine());
             
            if (secret > number)
            {
                Console.WriteLine("The secret number is in the higher digits.");
            }
            else if (secret < number)
            {
                Console.WriteLine("The secret number is in the lower digits.");
            }
            else
            {
                Console.WriteLine("You guessed the secret number!!");
            }
        }
        
    }
}