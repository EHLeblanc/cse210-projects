using System;

public class Simple
{
    public Simple(string title,string description, int points)
    {
        
    

        public Simple(string title, string description, int points)
        {
            _title = title;
            _description = description;
            _points = points;
        }

        public override void Display()
        {
            Console.WriteLine($" [{_checked}] {_title} ({_description})");
        }
    }
}