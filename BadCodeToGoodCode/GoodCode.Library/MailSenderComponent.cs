namespace GoodCode.Library
{
    public class MailSenderComponent
    {
        public void sendMailToCompanies(List<Company> companies, List<TimeSheetEntry> timeSheetEntries, TimeSheetBillCalculator billCalculator)
        {
            foreach (var company in companies)
            {
                var billForAcme = billCalculator.calculateBillForCompany(company, timeSheetEntries);
                sendMail(company.Name, billForAcme);
            }
        }

        private void sendMail(string companyName, double billForAcme)
        {
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine($"Your bill is $ {billForAcme} for the hours worked.");
        }
    }
}
