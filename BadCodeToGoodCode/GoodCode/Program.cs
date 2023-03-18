using GoodCode.Library;

namespace GoodCode
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TimeSheetEntry> timeSheetEntries = loadEntries();
            CompanyService companyService = new CompanyService();
            companyService.SendMailToCompanies(timeSheetEntries);
            var extraBill = companyService.CalculateBillForExtraTime(timeSheetEntries, 40);

            Console.WriteLine($"You will get paid ${extraBill} for your work.");
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }

        static List<TimeSheetEntry> loadEntries()
        {
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            string answer = string.Empty;
            do
            {
                double timeForJob = 0;
                Console.Write("Enter what you did: ");
                string workDoneWithCompanyName = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                string rawTimeWorked = Console.ReadLine();

                while (double.TryParse(rawTimeWorked, out timeForJob) == false)
                {
                    rawTimeWorked = getRawTimeFromUser();
                }

                TimeSheetEntry ent = new TimeSheetEntry
                {
                    HoursWorked = timeForJob,
                    WorkDone = workDoneWithCompanyName
                };
                timeSheetEntries.Add(ent);

                Console.Write("Do you want to enter more time (yes/no): ");
                answer = Console.ReadLine();



            } while (answer.ToLower() == "yes");

            return timeSheetEntries;


        }

        private static string getRawTimeFromUser()
        {
            string rawTimeWorked;
            Console.WriteLine();
            Console.WriteLine("Invalid number given");
            Console.Write("How long did you do it for: ");
            rawTimeWorked = Console.ReadLine();
            return rawTimeWorked;
        }

    }


}

