using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFirst
{
    public class Date
    {
        private int day,year;
        private string month;

        public void AcceptData(int dd, string mm , int yr)
        {
            day = dd;
            month = mm;
            year= yr;
        }

        public string PrintDate()
        {
            return $"Date is {day}-{month}-{year}";
        }


        public int PrintYear()
        {
            return year;
        }

    }
}
