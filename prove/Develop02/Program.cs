using System;

class Program
{
    static void Main(string[] args)
    {
        journal         journal = new journal();
        int             menuUserinput = 0;

        List<string>    menu = new List<string>
            {
                "Select one of the following:",
                "1. Write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "What you doin? "
            };
        
        while (menuUserinput != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());
        }
    }
}