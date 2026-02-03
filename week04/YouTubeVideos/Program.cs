using System;
using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> _videoList = new List<Video>();

        Video video1 = new Video("How to code!", "Coder Guy", 400);
        _videoList.Add(video1);
        video1.AddComment(new Comment("Cassie", "Wow! Great explanation"));
        video1.AddComment(new Comment("Alice", "This was so helpful! I finally understand loops"));
        video1.AddComment(new Comment("Bob", "Could you do a follow-up video on Classes and Objects?"));
        video1.AddComment(new Comment("Charlie", "I got an error on line 12, but I figured it out. Great Content!"));

        // Video 2
        Video video2 = new Video("Best Chocolate Cake", "Chef Maria", 600);
        _videoList.Add(video2);
        video2.AddComment(new Comment("John", "Followed the recipe and it was delicious!"));
        video2.AddComment(new Comment("Sarah", "Can I use gluten-free flour instead?"));
        video2.AddComment(new Comment("Dave", "Instructions were very clear, thanks."));
        video2.AddComment(new Comment("Baker101", "Does the oven need to be preheated?"));

        // Video 3
        Video video3 = new Video("Level 1 Speedrun", "ProGamer99", 120);
        _videoList.Add(video3);
        video3.AddComment(new Comment("GamerGirl", "That jump at 0:45 was insane!"));
        video3.AddComment(new Comment("NoobMaster", "I've been trying that for weeks."));
        video3.AddComment(new Comment("Rex", "World record pace right there."));
        video3.AddComment(new Comment("Speedy", "Incredible movement, great job."));
        

        foreach(Video video in _videoList)
        {
            video.GetWholeText();
        }



        // Video video2 = new Video("dfds", "yourmom", 12);
        // Comment comment2 = new Comment("Cassie", "she is big brain");
        // Video video3 = new Video("dfds", "yourmom", 12);
        // Comment comment3 = new Comment("Cassie", "she is big brain");
        // Video video4 = new Video("dfds", "yourmom", 12);
        // Comment comment4 = new Comment("Cassie", "she is big brain");
    }
}