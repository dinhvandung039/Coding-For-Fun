namespace Observer;

public class YoutubeNotify : Observer
{
    public YoutubeNotify(Subject subject)
    {
        Subject = subject;
        Subject.AttachObserver(this);
    }

    public override void Notify(object arg)
    {
        if (Subject is VideoData videoData)
        {
            Console.WriteLine($"Name: {videoData.GetTitle()} - Description: {videoData.GetDescription()}- FileName: {videoData.GetFileName()}");
        }
    }
}
