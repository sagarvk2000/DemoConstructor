using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class EMployee with empid, name, salary , accept the data & print it

namespace DemoFirst
{
    public class empdet
    {
        private int empid;
        private string name;
        private int salary;


        //public void AcceptData(int id, string na, int sal) // using method with parameters only
        //{
        //    empid = id;
        //    name = na;
        //    salary = sal;

        //}
        public empdet()  //using constructor without parameter
        {
            empid = 256;
            name = "sagar";
            salary = 50000;           
        }
        public empdet(int id, string na, int sal)  //  using constructor with parameter
        {
            empid = id;
            name = na; 
            salary = sal;
        }
        public string PrintEmpD()
        {
            return $"the emp details is \n The emp is = {empid}\n The name is ={name}\n " +
                $"The salary is ={salary}";
        }
    }
}
