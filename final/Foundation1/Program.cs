using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create Video objects
        Console.WriteLine();
        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        Video video2 = new Video("Funny Cat Compilation", "PetLovers", 300);
        Video video3 = new Video("Top 10 Movie Scenes", "Cinephile", 1200);

        // Step 2: Add comments to videos
        video1.AddComment(new Comment("Alice", "This is so helpful!"));
        video1.AddComment(new Comment("Bob", "Great explanation."));
        video1.AddComment(new Comment("Carol", "Can you make a tutorial on advanced topics?"));

        video2.AddComment(new Comment("Dave", "Haha, I love this!"));
        video2.AddComment(new Comment("Eve", "So cute, can't stop watching."));
        video2.AddComment(new Comment("Frank", "My day just got better."));

        video3.AddComment(new Comment("Grace", "Amazing scenes!"));
        video3.AddComment(new Comment("Hank", "I can't believe these moments."));
        video3.AddComment(new Comment("Ivy", "Where's the full movie?"));

        // Step 3: Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Step 4: Display video details and comments
        foreach (Video video in videos)
        {
            
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine();
        }
    }
}