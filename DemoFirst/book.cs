using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class Book with book id , name, price & author name.
//Assign value using non parametric & parametric constructor & display the details

namespace DemoFirst
{
    public class book
    {
        private int bookid,price;
        private string name,author_name;

        public book()
        {
            author_name = "DR.APJ ABDUL KALAM";
            name = "Wings Of Fire";
            bookid = 444;
            price = 300;
        }

        public book(string an, string na,int id, int pri)
        {
            author_name=an;
            name=na;
            bookid=id;
            price=pri;
        }

        public string PrintBook()
        {
            return $"The author name is ={author_name}\n the book name is ={name}\n the book id is ={bookid}\n the is price ={price}";
        }
    }
}
