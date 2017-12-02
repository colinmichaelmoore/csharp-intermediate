using System;

namespace section5_exercise1
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Open connection");
        }

        public override void Close()
        {
            Console.WriteLine("Close connection");
        }
    }
}