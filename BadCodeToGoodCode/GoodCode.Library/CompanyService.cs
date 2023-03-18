namespace GoodCode.Library
{
    public class CompanyService
    {
        TimeSheetBillCalculator billCalculator = new TimeSheetBillCalculator();
        public void SendMailToCompanies(List<TimeSheetEntry> timeSheetEntries)
        {
            var companies = new FakeCompanyRepository().GetCompanies();
            MailSenderComponent senderComponent = new MailSenderComponent();
            senderComponent.sendMailToCompanies(companies, timeSheetEntries, billCalculator);
        }

        public double CalculateBillForExtraTime(List<TimeSheetEntry> timeSheetEntries, int maxHour)
        {
            return billCalculator.calculateBillForExtraTime(timeSheetEntries, maxHour);
        }
    }
}
