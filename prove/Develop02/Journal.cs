class journal
{
        List<string> entries;

        public PromptGenerator()
        {

        }
    
       public void DisplayJournalEntries() 
       {
        Console.Write(journalPrompt[mIndex]);
        string journal = Console.ReadLine();

        Console.WriteLine($"{Journal}");
        labelName.Text = DateTime.Now.ToString("MMM dd yyyy");
       }

       public void CreateJournalEntry()
       {

       }

       public void SaveToCSV()
       {
        Console.Write("What is the file name? ");
        File.WriteAllText(File.text);
        
       }

       public void LoadFromCSV()
       {
        Console.WriteLine (File.ReadAllText (file));
        Console.WriteLine():
       }
}