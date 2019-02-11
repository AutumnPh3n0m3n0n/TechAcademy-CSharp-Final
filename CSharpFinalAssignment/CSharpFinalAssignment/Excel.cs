using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace CSharpFinalAssignment
{
    class Excel
    {
        string link;
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string toLink, int getSheet)
        {
            link = toLink;
            wb = excel.Workbooks.Open(toLink);
            ws = wb.Worksheets[getSheet];
        }

        public void Close()
        {
            if (wb != null)
                wb.Close();
        }

        public string getCellData(int x, int y)
        {
            if (ws.Cells[x, y].Value2 != null)
                return ws.Cells[x, y].Value2;
            else
                return null;
        }

        public int getCellNum(int x, int y)
        {
            if (ws.Cells[x, y].Value2 != null)
                return (int)ws.Cells[x, y].Value2;
            else
                return 0;
        }

    }
}
