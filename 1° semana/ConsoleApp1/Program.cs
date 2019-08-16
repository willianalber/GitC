using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] nameList = new string[2] { "valor 1", "valor 2" };

            foreach (var item in nameList)
                Console.WriteLine(item);

            string[] dateList = new string[10000];
            DateTime firstTime = DateTime.Now;

            for(int i = 0; i < dateList.Length; i++)
            {
                dateList[i] = DateTime.Now.ToString("yyyyMMddhhmmssfff");
                Console.WriteLine(dateList[i]);
                //Thread.Sleep(10);
            }

            Console.WriteLine((DateTime.Now - firstTime));

           /* foreach (var item in dateList)
                Console.WriteLine(item);*/

            Console.ReadKey();
        }
    }
}
