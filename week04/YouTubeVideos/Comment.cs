using System;

public class Comments
{

    
    private static List<string[]> comments_video1 = new List<string[]>()
    {
        new string[] {"_Stacy_Da_Bomb_", "That was a very inciteful and interesting video!"},
        new string[] {"WaffleFlop", "That explained so much thank!!!"},
        new string[] {"JoeMama34", "Coding is hard ;-;"},
        new string[] {"Stacy's Mother", "This helped me so much in my classes!"}
    }; 

    
    private static List<string[]> comments_video2 = new List<string[]>()
    {
        new string[] {"Fun-guy45", "I can feel myself getting faster already."},
        new string[] {"Gamer524", "Go man GO!"},
        new string[] {"Guest32", "That Explains so much! Thanks!"}
    };

    
    private static List<string[]> comments_video3 = new List<string[]>()
    {
        new string[] {"HypeMan4Life", "I've never been so motivated before in my whole life!"},
        new string[] {"MotivationFan", "This is my new favorite video!"},
        new string[] {"McFan", "I can't wait to get started!"}
    };


    public static List<string[]> Get_Comments(int video_num)
    {
        List<string[]> comments = new List<string[]>();

        if (video_num == 1)
        {
            comments = comments_video1;
        }
        else if (video_num == 2)
        {
            comments = comments_video2;
        }
        else if (video_num == 3)
        {
            comments = comments_video3;
        }


        return comments;
    }


}