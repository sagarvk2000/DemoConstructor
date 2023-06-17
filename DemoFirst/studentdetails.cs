using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create class Student with rollno, name & percentage . Accept the data & print it

namespace DemoFirst
{
    public class studentdetails
    {
        private int  rollno;
        private string name;
        double percentage;

        //public void AcceptData(string na,int rn, double per)
        //{
        //    name = na;
        //    rollno = rn;
        //    percentage = per;
        //}

        public studentdetails()
        {
            name = "Sagar";
            rollno = 23;
            percentage = 78.66;

        }

        public studentdetails(string na, int rn, double per)
        {
            name = na;
            rollno = rn;
            percentage = per;
        }

        public string PrintStudentD()
        {
            return $"the student details is \n The name is = {name}\n The roll no is ={rollno}\n The percentage is ={percentage}";
        }

    }
}
