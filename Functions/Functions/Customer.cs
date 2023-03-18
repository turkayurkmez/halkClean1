namespace Functions
{
    public class Customer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public double Rating { get; set; }

    }

    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
    }
}
