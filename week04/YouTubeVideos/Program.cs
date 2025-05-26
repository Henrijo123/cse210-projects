using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("My first video", "Me", 600);
        Video video1 = new Video("My second video", "also Me", 60);
        Video video2 = new Video("My third video", "maybe Me", 900);
        Comment comment1v1 = new Comment("Random User11", "Best video ever1");
        Comment comment2v1 = new Comment("Random User21", "Probably it is1");
        Comment comment3v1 = new Comment("Random User31", "I think that too!1");
        Comment comment1v2 = new Comment("Random User12", "Best video ever2");
        Comment comment2v2 = new Comment("Random User22", "Probably it is2");
        Comment comment3v2 = new Comment("Random User32", "I think that too!2");
        Comment comment1v3 = new Comment("Random User13", "Best video ever3");
        Comment comment2v3 = new Comment("Random User23", "Probably it is3");
        Comment comment3v3 = new Comment("Random User33", "I think that too!3");

        video.StoreComments(comment1v1);
        video.StoreComments(comment2v1);
        video.StoreComments(comment3v1);
        video1.StoreComments(comment1v2);
        video1.StoreComments(comment2v2);
        video1.StoreComments(comment3v2);
        video2.StoreComments(comment1v3);
        video2.StoreComments(comment2v3);
        video2.StoreComments(comment3v3);
        List<Video> listOfVideos = [video, video1, video2];
        foreach (Video i in listOfVideos)
        {
            Console.WriteLine(i._title);
            Console.WriteLine(i._author);
            Console.WriteLine(i._length);
            Console.WriteLine(i.NumberOfComments());
            foreach (Comment j in i._comments)
            {
                Console.WriteLine($"{j.GetName()}: {j.GetText()}");
            }
        }
    }
}