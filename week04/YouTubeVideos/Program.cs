using System;
using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video = new Video("dfds", "yourmom", 12);
        video.GetWholeText();
        Comment comment = new Comment("Cassie", "she is big brain");

        // Video video2 = new Video("dfds", "yourmom", 12);
        // Comment comment2 = new Comment("Cassie", "she is big brain");
        // Video video3 = new Video("dfds", "yourmom", 12);
        // Comment comment3 = new Comment("Cassie", "she is big brain");
        // Video video4 = new Video("dfds", "yourmom", 12);
        // Comment comment4 = new Comment("Cassie", "she is big brain");
    }
}