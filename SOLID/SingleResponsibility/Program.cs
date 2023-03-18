namespace SingleResponsibility
{

    // See https://aka.ms/new-console-template for more information

    /*
     * Her nesne; sadece bir sorumluluğa sahip olmalıdır.
     * 
     * Eğer bir nesnede değişiklik yapmak için birden fazla sebebiniz varsa; prensibe uymuyorsunuz demektir!
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Eklenecek ürünün adını giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Ürünün fiyatını giriniz");
            double price = 0.0;
            if (double.TryParse(Console.ReadLine(), out price))
            {
                var affectedRows = new ProductService().AddProduct(name, price);
                string message = affectedRows > 0 ? "Başarılı" : "Başarısz";
                Console.WriteLine(message);
            }

        }
    }




}