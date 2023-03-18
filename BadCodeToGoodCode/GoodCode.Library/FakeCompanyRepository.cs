namespace GoodCode.Library
{
    public class FakeCompanyRepository
    {
        public List<Company> GetCompanies()
        {
            Company acme = new Company { Name = "acme", HourlyPayment = 150 };
            Company abc = new Company { Name = "abc", HourlyPayment = 125 };

            List<Company> companies = new List<Company>() { acme, abc };
            return companies;
        }
    }
}
