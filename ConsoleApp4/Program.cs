using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anil", "Sharma", "Abdullah",
                       "Imran", "Siva", "Naresh",
                       "Suresh", "Suman" };

            //Using LINQFunctions Queries
            UsingLINQFunctions(names);
        }

        private static void UsingLINQFunctions(string[] names)
        {

            Func<string, bool> filter = s => s.Length == 5;
            Func<string, string> extract = s => s;
            Func<string, string> project = s => s.ToUpper();

            IEnumerable<string> query = names.Where(filter)
                                            .OrderBy(extract)
                                            .Select(project);

            //select * from
            foreach (string item in query)
                Console.WriteLine(item);

            Console.Read();
        }
    }
}
