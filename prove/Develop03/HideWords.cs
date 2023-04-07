using System;
using System.Linq;
using System.Collections.Generic;

public class hidewords
{
    private string _text;

    public hidewords (string ScriptureText)
    {
        _text = scriptureText;
    }
    public void ClearLine(int counter)
    {
        List<string> toListText = !string.IsNullOrEmpty(_text) ? _text.Split(" ").ToList() : new List<string>();

        for(int i = counter; i < toListText.Count ; i ++)
        {
            toListText[i] = "__";
        }
        string toTextList = string.Join(" ", toListText);
        Console.Clear();
        Console.WriteLine(toTextList);
    }
}