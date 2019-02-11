using System;
using Microsoft;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace CSharpFinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            dataList allPresidents = new dataList();
            allPresidents.ImportExcel();
            Console.WriteLine("Here is a list of the 15 last presidents of the USA:");
            allPresidents.OutputAll();
            Console.ReadLine();
        }
    }
}
