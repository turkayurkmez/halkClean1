namespace GoodCode.Library
{
    public class TimeSheetBillCalculator
    {
        public double calculateBillForCompany(Company company, List<TimeSheetEntry> timeSheetEntries)
        {
            double totalWorkedHours = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.ToLower().Contains(company.Name))
                {
                    totalWorkedHours += timeSheetEntries[i].HoursWorked;
                }
            }
            return totalWorkedHours * company.HourlyPayment;
        }


        public double calculateBillForExtraTime(List<TimeSheetEntry> timeSheetEntries, int maxHourForWeek)
        {
            int extraTimePayment = 15;
            int normalTimePayment = 10;

            double totalWorkedHours = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                totalWorkedHours += timeSheetEntries[i].HoursWorked;
            }
            if (totalWorkedHours > maxHourForWeek)
            {
                var paymentForMoreThanHourOfWeek = (totalWorkedHours - maxHourForWeek) * extraTimePayment;
                var paymentIcludeNormalTime = maxHourForWeek * normalTimePayment;

                return paymentForMoreThanHourOfWeek + paymentIcludeNormalTime;
            }
            else
            {
                return totalWorkedHours * normalTimePayment;
            }
        }
    }
}
