using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = "SDNsSA2KgDNJ5ShAJN3DNA6SJ";
            string newcontent = "";

            foreach(char c in content)
            {
                newcontent += c;
            }

            Console.WriteLine(String.Join("\n", newcontent));
            Console.ReadKey();
        }
            
    }
}
