using System;
using System.Data.Common;

namespace section5_exercise1
{
    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Open connection");
        }

        public override void Close()
        {
            Console.WriteLine("Close connection");
        }

        public SqlConnection(string connectionString) : base(connectionString)
        {
        }
    }
}