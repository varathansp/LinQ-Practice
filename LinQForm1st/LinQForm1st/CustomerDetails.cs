using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinQForm1st
{
    class CustomerDetails
    {
        ProductDBDataContext contexObj = new ProductDBDataContext();
        customer obj = new customer();
        List<customer> list = new List<customer>();
       
        public void AddCustomer(int id, string name, string mail, string loc, string dob)
        {
            try
            {
                obj.CustomerID = id;
                obj.CustomerName = name;
                obj.CustomerMail = mail;
                obj.Location = loc;
                obj.DOB = Convert.ToDateTime(dob);
                contexObj.customers.InsertOnSubmit(obj);
                contexObj.SubmitChanges();
            }
            catch
            { }
        }
        public void DeleteCustomer(int id)
        {
            try
            {
                obj.CustomerID = id;
                //obj.CustomerName = name;
                //obj.CustomerMail = mail;
                //obj.Location = loc;
                //obj.DOB = Convert.ToDateTime(dob);
                var DeleteStatement = contexObj.customers.Where(data => data.CustomerID == id).FirstOrDefault();
                contexObj.customers.DeleteOnSubmit(DeleteStatement);
                contexObj.SubmitChanges();
            }
            catch
            { }
        }
        public void UpdateCustomer(int id, string name, string mail, string loc, string dob)
        {
           
        var query = from data in contexObj.customers where data.CustomerID == id select data;
            List<customer> list = query.ToList();
            
                foreach(customer data in list)
                {
                    data.CustomerID = id;
                    data.CustomerName = name;
                    data.CustomerMail = mail;
                    data.Location = loc;
                    data.DOB = Convert.ToDateTime(dob);
                    
                }
    //insertonsubmit
    //contextobj.Customers.Single(data => data.CustomerID == ID);      ///insert into table
                 contexObj.SubmitChanges();              
           
        }
       
    }
}
