using lesson_14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Calculator c = new Calculator();
        var t = TextBox1.Text;
        var r = c.Square(t);
        TextBox2.Text = r;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Calculator c = new Calculator();
        var t = TextBox1.Text;
        var r = c.Sqrt(t);
        TextBox2.Text = r;
    }
}