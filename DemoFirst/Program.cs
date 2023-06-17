using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Date date1=new Date();
            //date1.AcceptData(16, "june",2023);     1st method -- to print the o/p.
            ////Console.WriteLine(date1.PrintDate());
            //string data = date1.PrintDate();     2nd method--.these two methods to print  the o/p.in this method 
                                                              //we have to take the object data into an another variable
            //Console.WriteLine(data);             
            //int year = date1.PrintYear();        
            //Console.WriteLine(year);


            //using method for Student details with parameter
            //studentdetails studentdetails1 = new studentdetails();
            //studentdetails1.AcceptData("sagar", 22, 77.63);
            //Console.WriteLine(studentdetails1.PrintStudentD());

            // using method for employee details with parameter
            //empdet empdet1 = new empdet();
            //empdet1.AcceptData(345, "sagar", 400000);
            //Console.WriteLine(empdet1.PrintEmpD());

            //using method for product details with parameter
            //proddet proddet1 = new proddet();
            //proddet1.AcceptData("laptop", 234, 20000);
            //Console.WriteLine(proddet1.PrintProduct());

            //using constructor for employee details without parameter
            //empdet empdet1 = new empdet();
            //Console.WriteLine(empdet1.PrintEmpD() );

            //using constructor for employee details with parameter
            //empdet empdet2 = new empdet(365,"sagar",56000);  
            //Console.WriteLine(empdet1.PrintEmpD());

            //using constructor for product details without parameter

            //proddet proddet1 = new proddet();
            //Console.WriteLine(proddet1.PrintProduct());

            //proddet proddet2 = new proddet("sagar",555,65444); //with parameter
            //Console.WriteLine(proddet2.PrintProduct());

            //using constructor for student details without parameter
            //studentdetails studentdetails1 = new studentdetails();
            //Console.WriteLine(studentdetails1.PrintStudentD());

            //studentdetails studentdetails2 = new studentdetails("\n\n\nsagar",26,55.66); //with parameter
            //Console.WriteLine(studentdetails2.PrintStudentD());

            //book book1 = new book();
            //Console.WriteLine(book1.PrintBook());
            //book book2 = new book("\n\n\nDR.APJ ABDUL KALAM","WINGS OF FIRE",454,300);
            //Console.WriteLine(book2.PrintBook());

            //bank bank1 = new bank();
            //Console.WriteLine(bank1.PrintBank());
            //bank bank2 = new bank("\n\n\nboi","salary",987654321,100);
            //Console.WriteLine(bank2.PrintBank());

            user user1 = new user();
            Console.WriteLine(user1.PrintUser());
            user user2 = new user("\n \n\nsagar","sagar22@gmail.com",54,56546);
            Console.WriteLine(user2.PrintUser());
        }
    }

}
