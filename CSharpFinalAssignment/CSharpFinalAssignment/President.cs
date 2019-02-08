using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalAssignment
{
    public class President
    {
        public string firstName;
        public string lastName;
        public int yearBirth;
        public int yearStart;
        public int yearEnd;
        public string party;
        public bool alive;

        public void About()
        {
            Console.WriteLine("NAME:         {0} {1}", firstName, lastName);
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
    }
}
