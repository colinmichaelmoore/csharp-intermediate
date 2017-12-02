using System;

namespace section5_exercise1
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (connectionString == null || connectionString == "") 
            {
                throw new Exception("Connection string not valid");
            }
            
        }

        public abstract void Open();



        public abstract void Close();

    }

}