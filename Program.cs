using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileWriter fileWriter = new XmlFileWriter();

            Console.WriteLine(fileWriter.WriteToFile("MinFil"));

            Console.ReadLine();
        }
    }
}
