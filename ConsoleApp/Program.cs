using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruitList = new List<string>();
            //B/c it's new I'm calling the list classes constructor method with () at the end
            fruitList.Add("Orange");
            fruitList.Add("Strawberry");
            fruitList.Add("Banana");
            fruitList.Add("Fig");
            fruitList.Add("Apple");
            //New comment

            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            fruitList.Sort();                   //Sorts by asc, alphabetical when used on strings
            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            ReportOnApples(fruitList);

            Console.ReadLine();
        }

        static void ReportOnApples(List<string> items)
        {
            string AppleReport = items.Contains("Apple", StringComparer.OrdinalIgnoreCase) ?
                "Yes there are apples." :
                "No there are no apples.";

            Console.WriteLine(AppleReport);
        }

    }
}
