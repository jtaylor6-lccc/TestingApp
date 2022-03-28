using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp
{
    class LinqTesting
    {
        public static void simpleQuery()
        {
            //three parts to a linq query
            // 1. Data Source
            // 2. Query Creation
            // 3. Query Execution

            int[] scores = { 97, 92, 81, 60, 40, 95, 20};      //1 - data source


            //scores larger than 80
            IEnumerable<int> scoreQuery =           //2 - query creation
                from score in scores
                where score > 80
                orderby score descending
                select score;

            //scores larger than 80 - method syntax
            IEnumerable<int> scoreQuery2 = scores.Where(score => score > 80).OrderByDescending(s => s);

            //execute the query
            Console.WriteLine("Query syntax results");
            foreach (int i in scoreQuery)           //3 - query execution
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Method syntax results");
            foreach (int i in scoreQuery2)           //3 - query execution
            {
                Console.Write(i + " ");
            }


        }




    }
}
