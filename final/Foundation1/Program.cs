using System;

class Program
{
    static void Main(string[] args)
    {  
       Videos video1 = new Videos();
        video1._author = "jawed";
        video1._title  = "Me at the zoo";
        video1._lenght = 19;
        Comments comment1 = new Comments();
        comment1._user1 = "Jeff";
        comment1.commentsList1.Add("This guy is the only person who has the rights to say first on youtube.");
    

        Videos video2 = new Videos();
        video2._author = "YouTube";
        video2._title  = "Youtube Rewind 2018";
        video2._lenght = 493;
        Comments comment2 = new Comments();
        comment2._user2 = "Brandon Butch";
        comment1.commentsList2.Add("Let's all take a moment of silence for the 19m dislikes before they got removed");



        Videos video3 = new Videos();
        video3._author = "officialpsy";
        video3._title  = "Gangnam Style";
        video3._lenght = 208;
        Comments comment3 = new Comments();
        comment3._user3 = "Sporty kid 101";
        comment1.commentsList3.Add("The person that first commented on this video must feel like the king of the world.");


        
        List<Videos> videoList = new List<Videos> ();
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        int counter = 0;
        foreach(Videos video in videoList)
        {
            video.Display(counter);
            counter ++;
        }

        Console.WriteLine("");
        Console.WriteLine("choose a video # to see the comments");
        string videoNumber = Console.ReadLine();

        if (videoNumber == "0" )
        {
            comment1.Display1();
        }
        else if (videoNumber == "1" )
        {
            comment1.Display2();
        }
        else if (videoNumber == "2" )
        {
          comment1.Display3();   
        }


        Console.ReadLine();


    }
}
