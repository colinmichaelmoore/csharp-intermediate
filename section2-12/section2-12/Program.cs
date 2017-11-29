using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1987, 3, 17));
            
            Console.WriteLine(person.Age);
        }
    }
}
