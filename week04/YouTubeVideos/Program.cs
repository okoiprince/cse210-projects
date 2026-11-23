using System;

class Program
{
    static void Main(string[] args)
    {
        // Main Program
        // Video Details 1
        Video video1 = new Video(
            "Introduction to C# Programming",
            "Prince Okoi",
            700
        );

        video1.AddComment(new Comment("Peter", "I love the video!"));
        video1.AddComment(new Comment("Mary", "Very true and correct."));
        video1.AddComment(new Comment("David", "Please drop more videos."));
        video1.AddComment(new Comment("Sarah", "How can I download"));

        // Video Details 2
        Video video2 = new Video(
            "Learning Python for Beginners",
            "Jane Williams",
            900
        );

        video2.AddComment(new Comment("James", "Python is interesting."));
        video2.AddComment(new Comment("Grace", "Thanks for this lesson."));
        video2.AddComment(new Comment("Paul", "Very easy to understand."));

        // Video details 3
        Video video3 = new Video(
            "Introduction to Web Development",
            "Michael Brown",
            1200
        );

        video3.AddComment(new Comment("Paul", "Excellent content!"));
        video3.AddComment(new Comment("Faith", "I love web development."));
        video3.AddComment(new Comment("Daniel", "Please make more videos."));
        video3.AddComment(new Comment("Esther", "This was very informative."));

        // Video Details 4
        Video video4 = new Video(
            "Understanding Object-Oriented Programming",
            "David Wilson",
            750
        );

        video4.AddComment(new Comment("James", "Composition is now clear for me."));
        video4.AddComment(new Comment("Jane", "Thank you for explaining OOP."));
        video4.AddComment(new Comment("Samuel", "Great teacher, you did well."));

        // List of videos 
        List<Video> myVideos = new List<Video>();

        myVideos.Add(video1);
        myVideos.Add(video2);
        myVideos.Add(video3);
        myVideos.Add(video4);

        // Display video information and comments
        foreach (Video video in myVideos)
        {
            Console.WriteLine("VIDEO: ");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine($"\nComments:");

            video.DisplayComments();

            Console.WriteLine();
        }
    }
}
