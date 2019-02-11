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
    public class President
    {
        public string firstName;
        public string lastName;
        public int order;
        public int yearBirth;
        public int yearStart;
        public int yearEnd;
        public string party;
        public bool alive;

        public void About()
        {
            Console.WriteLine("NAME:         {0} {1}", firstName, lastName);
            toOrder();
            Console.WriteLine("BORN:         {0}", yearBirth);
            Console.WriteLine("TERM SERVED:  {0} - {1}", yearStart, yearEnd);
            Console.WriteLine("PARTY:        {0}", party);
            ifAlive();
        }

        private void ifAlive()
        {
            if (!alive)
                Console.WriteLine("OCCUPATION:   Former president, Deceased");
            else
                Console.WriteLine("OCCUPATION:   Former president, Retired");
        }

        private void toOrder()
        {
            if (order % 10 == 1)
                Console.WriteLine("TIMELINE:     {0}st President of the USA", order);
            else if (order % 10 == 2)
                Console.WriteLine("TIMELINE:     {0}nd President of the USA", order);
            else
                Console.WriteLine("TIMELINE:     {0}th President of the USA", order);
        }

        public President(string toFirst, string toLast, int toNum, int toBirth, int toStart, int toEnd, string toPolitic, bool toAlive)
        {
            firstName = toFirst;
            lastName = toLast;
            order = toNum;
            yearBirth = toBirth;
            yearStart = toStart;
            yearEnd = toEnd;
            party = toPolitic;
            alive = toAlive;
        }
    }
}
