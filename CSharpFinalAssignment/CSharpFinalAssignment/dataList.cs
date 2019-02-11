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
    class dataList
    {
        List<President> Leaders = new List<President>();

        public void ImportExcel()
        {
            string toFirst;
            string toLast;
            string toData;
            int toNum;
            int toBirth;
            int toStart;
            int toEnd;
            string toPolitic;
            string toBool;
            bool toAlive;
            int row;
            President toImport;

            Excel toGet = new Excel(@"C:\Users\Sharath\Documents\GitHub\TechAcademy-CSharp-Final\CSharpFinalAssignment\ExcelReference.xlsx", 1);
            for (row = 1; row < 16; row++)
            {
                toFirst = toGet.getCellData(row, 1);
                toLast = toGet.getCellData(row, 2);
                toNum = toGet.getCellNum(row, 3);
                toBirth = toGet.getCellNum(row, 4);
                toStart = toGet.getCellNum(row, 5);
                toEnd = toGet.getCellNum(row, 6);
                toPolitic = toGet.getCellData(row, 7);
                toBool = toGet.getCellData(row, 8);
                if (toBool == "Yes")
                    toAlive = true;
                else
                    toAlive = false;

                toImport = new President(toFirst, toLast, toNum, toBirth, toStart, toEnd, toPolitic, toAlive);

                addLeader(toImport);
            }

            toGet.Close();

        }
        public void addLeader(President toAdd)
        {
            Leaders.Add(toAdd);
        }

        public void OutputAll()
        {
            Console.WriteLine();
            for (int i = 0; i < Leaders.Count; i++)
            {
                Console.WriteLine();
                Leaders[i].About();
            }
        }


    }
}
