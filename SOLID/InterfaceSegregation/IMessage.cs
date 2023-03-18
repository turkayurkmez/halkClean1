namespace InterfaceSegregation
{
    public interface IMessage
    {
        string From { get; set; }
        string To { get; set; }
        string Body { get; set; }
        string Message { get; set; }
        string Subject { get; set; }





    }

    public interface IVideoMessage : IMessage
    {
        public int VideoDuration { get; set; }
        public string VideoFormat { get; set; }
    }

    public interface IAudioMessage : IMessage
    {
        public int AudioDuration { get; set; }
        public string AudioFormat { get; set; }
    }

    public class VideoMessage : IMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }

    }
}


