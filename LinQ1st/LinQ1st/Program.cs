using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ1st
{
    class Program
    {
        static void Main(string[] args)
        {
            Users obj = new Users();
            List<Users> userDetails = obj.getUserDetails();
            foreach (var data in userDetails)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t", data.userID, data.userName, data.userPayment);
            }

        }
    }
}
