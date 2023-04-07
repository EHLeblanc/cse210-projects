using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is t he book?: ");
        string nameOfBook = Console.ReadLine();
        Console.WriteLine("What is the chapter?: ");
        string nameOfChapter = Console.ReadLine();
        Console.WriteLine("Is there one verse? ");
        string answerQuestion = Console.ReadLine();
        Reference reference1 = null;
        if(answerQuestion.ToLower() =="no")
        {
            Console.WriteLine("What is the start of the verse? ");
            string verseStart = Console.ReadLine();
            Console.WriteLine("And what is the end of the verse? ");
            string verseEnd = Console.ReadLine();

            reference1 = new Reference(nameOfBook, nameOfChapter, verseStart, verseEnd);
        }
        else
        {
            Console.WriteLine("What is the verse?");
            string verseText = Console.ReadLine();

            reference1 = new Reference(nameOfBook, nameOfChapter, verseText);
        }

        Console.WriteLine("Add the scripture: ");
        string _textScripture = Console.ReadLine();

        Scripture scriptureText = new Scripture(textScripture);
        scriptureText._newList.Add(reference1);
        scriptureText.Display();
        Console.WriteLine("Time to memorize.")
        int counter = 0;
        string enterLoop = "";
        while (enterLoop.ToLower() != "quit")
        {
            Console.WriteLine("Press 'enter' to continue, 'quit' to finsh");
            enterLoop = Console.ReadLine();
            Hide hidewords = new Hide(_textScripture);
            hidewords.clearLine(counter);
            counter ++;
        }
        Console.WriteLine("Bye");
    }
}