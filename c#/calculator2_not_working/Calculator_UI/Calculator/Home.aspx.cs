using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calculator.ServiceReference2;

namespace Calculator
{
    public partial class Home : System.Web.UI.Page
    {
        private float num, ans;
        private int count;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient s= new ServiceReference2.WebService1SoapClient();

            double answer = 0.0;
            string select = DropDownList1.SelectedValue;

            //if (select.Equals("Add"))
            //{

            //   answer= s.Add(double.Parse(TextBox1.Text),double.Parse(TextBox2.Text));


            //}else if (select.Equals("Sub"))
            //{
            //    answer = s.Sub(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            //}
            //else if (select.Equals("Mul"))
            //{
            //    answer = s.Mul(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            //}
            //else if (select.Equals("Dev"))
            //{
            //    answer = s.Dev(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            //}



            Label1.Text = "Total is: " + answer.ToString();


        }

       
        

        //protected void Button19_Click(object sender, EventArgs e)
        //{
        //    TextBox3.Text = TextBox3.Text + ".";
        //    TextBox3.ForeColor = Color.FromArgb(237, 6, 6);
        //}

        //protected void Button18_Click(object sender, EventArgs e)
        //{
        //    TextBox3.Text = TextBox3.Text + 0;
        //    TextBox3.ForeColor = Color.FromArgb(237, 6, 6);
        //}

        //protected void Button14_Click(object sender, EventArgs e)
        //{
        //    TextBox3.Text = TextBox3.Text + 1;
        //    TextBox3.ForeColor = Color.FromArgb(237, 6, 6);
        //}

        //protected void Button15_Click(object sender, EventArgs e)
        //{
        //    TextBox3.Text = TextBox3.Text + 2;
        //    TextBox3.ForeColor = Color.FromArgb(237, 6, 6);
        //}

        //protected void Button16_Click(object sender, EventArgs e)
        //{
        //    TextBox3.Text = TextBox3.Text + 3;
        //    TextBox3.ForeColor = Color.FromArgb(237, 6, 6);
        //}

        //protected void Button10_Click(object sender, EventArgs e)
        //{
        //    TextBox3.Text = TextBox3.Text + 4;
        //    TextBox3.ForeColor = Color.FromArgb(237, 6, 6);
        //}

        //protected void Button11_Click(object sender, EventArgs e)
        //{
        //    Label2.Text = Label2.Text + 5;
        //    Label2.ForeColor = Color.FromArgb(237, 6, 6);
        //}

        protected void Button12_Click(object sender, EventArgs e)
        {
            Label2.Text = Label2.Text + 6;
            Label2.ForeColor = Color.FromArgb(237, 6, 6);
        }

        //protected void Button6_Click(object sender, EventArgs e)
        //{
        //    TextBox3.Text = TextBox3.Text + 7;
        //    TextBox3.ForeColor = Color.FromArgb(237, 6, 6);
        //}

        //protected void Button7_Click(object sender, EventArgs e)
        //{
        //    TextBox3.Text = TextBox3.Text + 8;
        //    TextBox3.ForeColor = Color.FromArgb(237, 6, 6);
        //}

        //protected void Button8_Click(object sender, EventArgs e)
        //{
        //    TextBox3.Text = TextBox3.Text + 9;
        //    TextBox3.ForeColor = Color.FromArgb(237, 6, 6);
        //}

        protected void Button21_Click(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient s = new ServiceReference2.WebService1SoapClient();
            Label2.Text = "";
             //TextBox3.Focus();
             count = 1;

            var answer = s.Add(Label2.Text.ToString());
            Label2.Text = answer.ToString();
        }

        //protected void Button17_Click(object sender, EventArgs e)
        //{
        //    ServiceReference2.WebService1SoapClient s = new ServiceReference2.WebService1SoapClient();
            
        //    //TextBox3.Focus();
        //    count = 2;
        //    var answer = s.Sub(double.Parse(TextBox3.Text));
        //    Label2.Text = "";
        //    TextBox3.Text = "";
        //    TextBox3.Text = answer.ToString();
        //    Label2.Text = answer.ToString();
        //}

        //protected void Button13_Click(object sender, EventArgs e)
        //{
        //    ServiceReference2.WebService1SoapClient s = new ServiceReference2.WebService1SoapClient();
        //    Label2.Text = "";
        //    TextBox3.Text = "";
        //    //TextBox3.Focus();
        //    count = 3;
        //    var answer = s.Mul(double.Parse(TextBox3.Text));
        //    TextBox3.Text = answer.ToString();
        //    Label2.Text = answer.ToString();
        //}

        //protected void Button9_Click(object sender, EventArgs e)
        //{
        //    ServiceReference2.WebService1SoapClient s = new ServiceReference2.WebService1SoapClient();
        //    Label2.Text = "";
        //    TextBox3.Text = "";
        //    //TextBox3.Focus();
        //    count = 4;
        //    var answer = s.Dev(double.Parse(TextBox3.Text));
        //    TextBox3.Text = answer.ToString();
        //    Label2.Text = answer.ToString();
        //}
        protected void Button20_Click(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient s = new ServiceReference2.WebService1SoapClient();

            //var gotAns = s.Compute(count, num);

            //TextBox3.Text = gotAns.ToString();
        }

       
    }
}