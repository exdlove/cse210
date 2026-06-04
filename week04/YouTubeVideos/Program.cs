using System;
using System.Collections.Generic;

// Create a list of videos
List<Video> videos = new List<Video>();

// Create Video 1
Video video1 = new Video("Learn C# in 10 Minutes", "CodeMaster", 600);

video1.Comments.Add(new Comment("John", "Very helpful!"));
video1.Comments.Add(new Comment("Mary", "Great tutorial!"));
video1.Comments.Add(new Comment("Peter", "Thanks!"));

// Add video to list
videos.Add(video1);

// Create Video 2
Video video2 = new Video("OOP Explained", "Tech Guru", 900);

video2.Comments.Add(new Comment("Sarah", "Excellent explanation!"));
video2.Comments.Add(new Comment("Mike", "I understand OOP now."));
video2.Comments.Add(new Comment("Jane", "Very clear video."));

videos.Add(video2);

// STEP 5 CODE GOES HERE
foreach (Video video in videos)
{
    Console.WriteLine($"Title: {video.Title}");
    Console.WriteLine($"Author: {video.Author}");
    Console.WriteLine($"Length: {video.Length}");
    Console.WriteLine($"Comments: {video.GetCommentCount()}");

    foreach (Comment comment in video.Comments)
    {
        Console.WriteLine($"{comment.Name}: {comment.Text}");
    }

    Console.WriteLine();
}