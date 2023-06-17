using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class Bank with acc no, name, account type, balance .
//assign the value using non parametric & parametric constructor & display the details

namespace DemoFirst
{
    public class bank
    {
        private string name, account_type;
        private int account_number, balance;

        public bank()
        {
            name = "BOI";
            account_type = "saving";
            account_number = 123456789;
            balance = 20000;
        }
        public bank(string na,string at,int no,int bal)
        {
            name=na;
            account_type=at;
            account_number=no;
            balance = bal;
        }

        public string PrintBank()
        {
            return $"the name ={name}\nacc type ={account_type}\nacc no ={account_number}\n balance={balance}";
        }
    }
}
