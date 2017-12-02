using System;
using System.Security.Cryptography.X509Certificates;

namespace section5_exercise1
{
    public class DbCommand
    {
        public DbCommand(string DbConnection, string Instruction)
        {
            if (DbConnection == null || Instruction == null)
            {
                throw new Exception("DbConnection is null");
            }

            
        }

        public void Execute(string Instruction)
        {

            Console.WriteLine(Instruction);

        }



    }
}