
using System.Globalization;

public class Video
{
    private static string video1 = "Learn to code in 20 minuts";
    private static string video2 = "An intro to Speed running";
    private static string video3 = "How to stay motivated";


    public static int num_Of_Comments(int video_num)
    {
        string video_title = Get_Video_Title(video_num);
        List<string[]> comment_video = new List<string[]>();
        int count = 0;

        if (video_num == 1)
        {
            comment_video = Comments.Get_Comments(1);
        }
        else if (video_num == 2)
        {
            comment_video = Comments.Get_Comments(2);
        }
        else if (video_num == 3)
        {
            comment_video = Comments.Get_Comments(3);
        }

        foreach (string[] line in comment_video)
        {
            count++;
        }

        return count;
    }

    public static string Get_Video_Title(int select)
    {
        string video_title = "";

        if (select == 1)
        {
            video_title = video1;
        }
        else if (select == 2)
        {
            video_title = video2;
        }
        else if (select == 3)
        {
            video_title = video3;
        }

        return video_title;
    }
}