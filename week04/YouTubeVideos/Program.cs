using System;

class Program
{
    static void Main(string[] args)
    {
        // Main Program
        // Video Details 1
        Video video1 = new Video(
            "Introduction to C# Programming",
            "John Smith",
            600
        );

        video1.AddComment(new Comment("Peter", "Great tutorial!"));
        video1.AddComment(new Comment("Mary", "Very helpful explanation."));
        video1.AddComment(new Comment("David", "I learned something new."));
        video1.AddComment(new Comment("Sarah", "Keep up the good work!"));

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

        video3.AddComment(new Comment("John", "Excellent content!"));
        video3.AddComment(new Comment("Faith", "I love web development."));
        video3.AddComment(new Comment("Daniel", "Please make more videos."));
        video3.AddComment(new Comment("Esther", "This was very informative."));

        // Video Details 4
        Video video4 = new Video(
            "Understanding Object-Oriented Programming",
            "David Wilson",
            750
        );

        video4.AddComment(new Comment("Peter", "Composition is now clear."));
        video4.AddComment(new Comment("Mary", "Thank you for explaining OOP."));
        video4.AddComment(new Comment("Samuel", "Great teaching method."));

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
