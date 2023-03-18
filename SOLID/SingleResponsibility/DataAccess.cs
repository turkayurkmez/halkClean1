namespace SingleResponsibility
{
    internal class DataAccess
    {
        private string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal int Execute(string commandText, Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }
    }
}