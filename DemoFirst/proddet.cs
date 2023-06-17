using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create class Product with code,name & price , accept the data & print it

namespace DemoFirst
{
    public class proddet
    {
        private string name;
        private int code;
        private int price;

        //public void AcceptData(string na,int co,int pri)
        //{
        //    name = na;
        //    code = co;
        //    price = pri;
        //}

        public proddet()  //using constructor without parameter
        {
            name = "sagar";
            code = 444;
            price = 65000;
        }

        public proddet(string na, int co, int pri) //using constructor with parameter
        {
            name =na;
            code = co;  
            price = pri;
        }

        public string PrintProduct()
        {
            return $"the product name is \n{name}\n the code is={code}\nthe price is {price}";
        }
    }
}
