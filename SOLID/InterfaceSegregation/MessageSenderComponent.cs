namespace InterfaceSegregation
{
    public class MessageSenderComponent
    {
        public void SendMessage(IMessage message)
        {
            Console.WriteLine($"{message.To} adresine, {message.Subject} konulu mesaj gönderildi}");

        }

        public void LogStreaming(IVideoMessage message)
        {
            Console.WriteLine($"{message.VideoDuration} saniye uzunluğundaki video içeriği loglandı");
        }
    }
}
