using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ2nd
{
    class Employee
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public string deptname { get; set; }
        public double salary { get; set; }
        public List<Employee> getemployeedetails()
        {

            List<Employee> emplist = new List<Employee>()
            {
                new Employee() { empid = 101,empname = "vijay",deptname="d1",salary= 50000},
                        new Employee() { empid = 102, empname = "Ajith",deptname = "d1", salary = 60000},
                        new Employee() { empid = 103, empname = "Kamal",deptname = "d1", salary = 70000},
                        new Employee() { empid = 104, empname = "Rajini",deptname = "d2", salary = 80000},
                        new Employee() { empid = 105, empname = "vikram",deptname = "d3", salary = 90000}

            };
            return emplist;
        }
    }
}
