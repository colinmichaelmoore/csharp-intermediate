using System;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace section5_exercise2
{
    public class DbCommand
    {
        public DbCommand(string DbConnection)
        {
            if (DbConnection == null)
            {
                throw new Exception("DbConnection is null");
            }
        }

        public void Execute()
        {
            DbConnection.
        }
    }
}