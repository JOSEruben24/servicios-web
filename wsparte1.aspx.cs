using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsparte1
{
    public partial class wspart1 : System.Web.UI.Page
    {
        wsparte1.CalculatorSoapClient ws = new wsparte1.CalculatorSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {    
           Label1.Text = ws.Add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = ws.Subtract(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = ws.Multiply(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = ws.Divide(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }
    }
}