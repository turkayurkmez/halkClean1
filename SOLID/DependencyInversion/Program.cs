// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ProductService productService = new ProductService(new MailSender());




public class ProductService
{

    private ISender _sender;
    public ProductService(ISender mailSender)
    {
        _sender = mailSender;
    }
    public void UpdateStock(int productId)
    {
        // MailSender mailSender  = new MailSender();
        _sender.Send();
    }
}

public interface ISender
{
    void Send();
}
public class MailSender : ISender
{
    public void Send() => Console.WriteLine("Mail gönderildi");
}

public class WPSender : ISender
{
    public void Send() => Console.WriteLine("Whatsapp ile gönderildi");
}

public class TelegramSender : ISender
{
    public void Send()
    {
        Console.WriteLine("Telegram ile gönderildi");
    }
}