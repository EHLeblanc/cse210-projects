using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;
    private string _verseText;

    public Reference(string book, string chapter, string verseText)
    {
       _book = book;
       _chapter = chapter;
       _verseText = verseText;
       _verseEnd ="a";
    }
    public Reference(string book, string chapter, string verseStart, string verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;

    }

    public void Display()
    {
        if (_verseEnd == "a")
        {
            Console.WriteLine($"{_book} {_chapter}: {_verseText}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_verseStart}-{_verseEnd}");
        }
    }
}

