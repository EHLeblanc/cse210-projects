using System.IO;

public class File
{
    private List<Goal> _entries; = new List<Goal>();

    public void SaveToFile()
    {
        string GoalSaved = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(GoalSaved))
        {
            outputFile.WriteLine(_entries);
        }
    }

    public void LoadFromFile()
    {
        string GoalLoad = "myfile.txt";
        string[] lines = System.IO.File.ReadAllLines(GoalLoad);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string firstLine = parts[0];
            
        }
    }
}