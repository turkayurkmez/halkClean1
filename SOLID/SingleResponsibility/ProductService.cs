namespace SingleResponsibility
{
    public class ProductService
    {
        public int AddProduct(string name, double price)
        {
            var connectionString = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=halkbankeshopdb;Integrated Security=True";
            var commandText = "INSERT into Products (Name, Price) values (@name, @price)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);


            var dataAccesss = new DataAccess(connectionString);
            int affectedRows = dataAccesss.Execute(commandText, parameters);

            //SqlCommand sqlCommand = new SqlCommand(, sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@name", name);
            //sqlCommand.Parameters.AddWithValue("@price", price);

            //sqlConnection.Open();
            //var affectedRows = sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();

            return affectedRows;
        }

        public void SendNotificationToOwner(string ownerEmailAddress)
        {
            Console.WriteLine($"{ownerEmailAddress} adresine bilgi gönderildi!");
        }
    }
}
