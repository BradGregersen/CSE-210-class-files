using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video { Title = "Video 1", Author = "Author 1", Length = 10 };
        Video video2 = new Video { Title = "Video 2", Author = "Author 2", Length = 20 };
        Video video3 = new Video { Title = "Video 3", Author = "Author 3", Length = 30 };

    
        Comment comment1 = new Comment { Name = "Respondent 1", Text = "Comment 1 in Video 1" };
        Comment comment2 = new Comment { Name = "Respondent 2", Text = "Comment 2 in Video 1" };
        Comment comment3 = new Comment { Name = "Respondent 3", Text = "Comment 3 in Video 1" };

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Comment comment4 = new Comment { Name = "Respondent 1", Text = "Comment 1 in Video 2" };
        Comment comment5 = new Comment { Name = "Respondent 2", Text = "Comment 2 in Video 2" };
        Comment comment6 = new Comment { Name = "Respondent 3", Text = "Comment 3 in Video 2" };

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Comment comment7 = new Comment { Name = "Respondent 1", Text = "Comment 1 in Video 3" };
        Comment comment8 = new Comment { Name = "Respondent 2", Text = "Comment 2 in Video 3" };
        Comment comment9 = new Comment { Name = "Respondent 3", Text = "Comment 3 in Video 3" };

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        List<Video> videos = new List<Video> { video1, video2, video3 };


        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length} minutes");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
