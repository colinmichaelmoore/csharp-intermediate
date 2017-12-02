using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section5_exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand dbCommand = new DbCommand("connection", "Delete entry");

            SqlConnection sql = new SqlConnection("SQLconnection");



        }
    }
}
