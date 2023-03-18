namespace Functions
{
    public class CustomerService
    {
        public void AddCustomer(string name, string lastName, string streetAddress, string city, string country, double rating)
        {

        }

        public void AddCustomer(Customer customer)
        {

        }

        public void ChangeCustomerAddress(int customerId, Address address)
        {
            Customer customer = getCustomer(customerId);
            customer.Address = address;
        }

        private Customer getCustomer(int customerId)
        {
            return new Customer();
        }
    }
}
