namespace Functions
{
    public class ReportGenerator
    {
        public ReportGenerator(string excelFilePath)
        {
            //1. Validasyon:
            //1.A: Dosya var mı?
            try
            {
                validateFile(excelFilePath);
            }
            catch (Exception exception)
            {

                throw exception;
            }


        }

        public Report CreateReport()
        {

            var report = new Report();
            return report;


            //Raporu oluştur:

        }

        private void validateFile(string excelFilePath)
        {
            if (!isValidated(excelFilePath))
            {

                throw new FileNotFoundException();
            }
        }

        private bool excelFileIsExists(string excelFilePath)
        {
            return File.Exists(excelFilePath);
        }

        private bool isFormatIsExpected(string path)
        {
            return false;
        }
        private bool isValidated(string excelFilePath)
        {
            return !excelFileIsExists(excelFilePath) &&
                   !isFormatIsExpected(excelFilePath);
        }


        bool isEven(int number) => number % 2 == 0;




    }

    public class Report
    {
        public string Title { get; set; }
    }
}
