using System;
using System.Linq;
using System.Collections.Generic;

public class Hide
{
    private string _text;

    public Hide (string scriptureText)
    {
        _text = scriptureText;
    }
    public void ClearLine(int counter)
    {
        List<string> toListText = !string.IsNullOrEmpty(_text) ? _text.Split(" ").ToList () : new List<string>();

        for(int i = counter; i < toListText.Count ; i ++)
        {
            toListText[i] ="_";
        }
        string toTextList = string.Join("", toListText);
        Console.Clear();
        Console.WriteLine(toTextList);
    }
}