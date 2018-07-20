using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQForm1st
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CustomerDetails obj = new CustomerDetails();
            int ID = Convert.ToInt32(textBox1.Text);
            string Name = textBox2.Text;
            string mail = textBox3.Text;
            string loc = textBox4.Text;
            string dob = textBox5.Text;
            obj.AddCustomer(ID, Name, mail, loc, dob);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustomerDetails obj = new CustomerDetails();
            int ID = Convert.ToInt32(textBox1.Text);
            //string Name = textBox2.Text;
            //string mail = textBox3.Text;
            //string loc = textBox4.Text;
            //string dob = textBox5.Text;
            obj.DeleteCustomer(ID);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CustomerDetails obj = new CustomerDetails();
            int ID = Convert.ToInt32(textBox1.Text);
            string Name = textBox2.Text;
            string mail = textBox3.Text;
            string loc = textBox4.Text;
            string dob = textBox5.Text;
            obj.UpdateCustomer(ID,Name,mail,loc,dob);
        }
    }
}
