using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ2nd
{
    class CustomerDetails
    {
        ProjectDBDataContext contexObj = new ProjectDBDataContext();
        public List<CustomerData> showCustomerDetails()
        {
            List<CustomerData> list = new List<CustomerData>();
            //  list = (from data in contexObj.customers select data).ToList();
            //list = (from data in contexObj.customers where data.Location=="france" orderby data.CustomerName select data ).ToList();
            list = (from data in contexObj.customers where data.Location == "france" orderby data.CustomerName select new
                    CustomerData()
            { CustomerID=data.CustomerID,CustomerName=data.CustomerName}).ToList();
            return list;
            //List<CustomerData> list = new List<CustomerData>();
            //list = (from data in contextObj.Customers
            //        where data.Location == "Hyderabad"
            //        orderby data.CustomerName
            //        select new CustomerData()
            //        { CustomerID1 = data.CustomerID, CustomerName1 = data.CustomerName }).ToList();
        }
    }
}
