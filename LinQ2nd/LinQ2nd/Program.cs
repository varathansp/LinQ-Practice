using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            List<Employee> emplist = obj.getemployeedetails();


            //query expression syntax

            //var empdetails0 = from data in emplist where data.salary > 70000 select data;
            //var empdetails = from data in emplist where data.salary > 70000 orderby data.deptname select data;

            //foreach (Employee data in empdetails)
            //{
            //    Console.WriteLine(data.empid + data.empname + data.salary + data.deptname);
            //}
            //// method invocation syntax

            //var empdetails1 = emplist.Where((data) => data.salary > 70000).OrderByDescending(data => data.deptname).Select(data => data);

            //foreach (Employee data in empdetails1)
            //{
            //    Console.WriteLine(data.empid + data.empname + data.salary + data.deptname);
            //}
            //var empdetails2 = from data in emplist where data.empname.StartsWith("v") select new { data.empname, data.deptname, data.salary };
            //foreach (var data in empdetails2)
            //{
            //    Console.WriteLine(data.empname + data.salary + data.deptname);
            //}
            //var empdetails3 = from data in emplist group data by data.deptname into departmentGroup select new { departmentGroup.Key,DeptCount=departmentGroup.Count(),departmentSalary=departmentGroup.Sum(data=>data.salary),maximumSalary=departmentGroup.Max(data=>data.salary) };
            //foreach (var data in empdetails3)
            //{
            //    Console.WriteLine("{0}{1}{2}{3}",data.Key , data.DeptCount, data.departmentSalary,data.maximumSalary);
            //}
            CustomerDetails obj1 = new CustomerDetails();
            //List<customer> li = obj1.showCustomerDetails();
            //foreach (var data in li)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", data.CustomerID, data.CustomerName, data.CustomerMail, data.Location, data.DOB);
            //}
            List<CustomerData> li = obj1.showCustomerDetails();
            foreach (var data in li)
            {
                Console.WriteLine("{0}\t{1}", data.CustomerID, data.CustomerName);
            }

        }
    }
}
