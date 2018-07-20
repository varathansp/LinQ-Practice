using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ1st
{
    class Users
    {
        //Auto implemented property
        public int userID { get; set; }
        public string userName { get; set; }
        public double userPayment { get; set; }
        //show user --->payment >50000
        //public bool searchUsers(Users userObj)
        //{
        //    return userObj.userPayment > 50000;
        //}
        public List<Users> getUserDetails()
        {
            //collection and object initializer
            List<Users> userList = new List<Users>()
            {
                new Users() {userID=101,userName="Navin",userPayment=70000},
                 new Users() { userID = 102, userName = "Sathish", userPayment = 20000 },
                  new Users() { userID = 103, userName = "Jai", userPayment = 80000 },
                   new Users() { userID = 104, userName = "Prabha", userPayment = 60000 },
                    new Users() { userID = 105, userName = "Rogue", userPayment = 40000 }
            };
            //where() Extension method--return result--condition
            //return userList.Where(searchUsers).ToList(); 
            //delegate
            // return userList.Where(delegate (Users userObj) { return userObj.userPayment > 50000; }).ToList();
          //  return userList.Where((data)=>data.userPayment>50000).ToList();
          double result=userList.Average((data)=>data.userPayment);
            return userList.Where((data) => data.userPayment > result).ToList();


        }

    }
}
