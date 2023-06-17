using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create class User with user id, user name, email & password.
//Assign value using parametric constructor & display the details
namespace DemoFirst
{
    public class user
    {
        private string username,email;
        private int userid, password;

        public user()
        {
            username = "sagar2222";
            email = "sagar@gmail.com";
            userid = 55;
            password = 222;
        }
        public user(string un,string em,int uid,int pass)
        {
            username = un;
            email = em;
            userid = uid;
            password = pass;
        }

        public string PrintUser()
        {
            return $"the username is ={username}\nemail ={email}\nuserid is ={userid}\n password ={password}";
        }
    }
}
