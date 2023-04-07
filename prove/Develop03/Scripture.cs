using System;

public class Scripture
{
    private string _textScripture;

    public List<Reference> _newList = new List<Reference>();

    public void Display()
    {
        foreach (Reference reference in _newList)
        {
            reference.Display();
        }
        Console.WriteLine(_textScripture);
    }
    public Scriptures (string _textScripture)
    {
        _textScripture = _textScriptures;
    }
}