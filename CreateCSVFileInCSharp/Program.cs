using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateCSVFileInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder csvcontent = new StringBuilder();
            csvcontent.AppendLine("Name,Age");
            csvcontent.AppendLine("Mahesh,31");
            string csvpath = "D:\\xyz.csv";
            File.AppendAllText(csvpath, csvcontent.ToString());
        }
    }
}
