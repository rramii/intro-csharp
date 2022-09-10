using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_11
{
    public partial class Form1 : Form
    {
        private StackCalc calc = new StackCalc();
        

        public Form1()
        {
            InitializeComponent();
            calc.OnPopItems = popList;
            calc.OnPushItem = pushList;
            calc.OnProblem = displayError;
        }

        private void displayError(string msg)
        {
            label1.Text = msg;
        }
        private void pushList(int n)
        {
            listBox1.Items.Add(n.ToString());
        }

        private void popList(int n)
        {
            var items = listBox1.Items;
            for (int i = 0; i < n; i++)
            {
                items.RemoveAt(items.Count - 1);
            }            
        }

        
        private void Pushbtn(object sender, EventArgs e)
        {
            ActualPush();
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ActualPush();
            }
        }

        private void ActualPush()
        {
            var text = textBox1.Text;
            int number;
            if (int.TryParse(text, out number))
            {
                calc.Push(number);
                textBox1.Text = "";
            }
            else
            {
                label1.Text = "not a number";
            }
        }

        private void Addbtn(object sender, EventArgs e) => calc.Add();
        
        private void Subtractbtn(object sender, EventArgs e) => calc.Sub();

        private void Multibtn(object sender, EventArgs e) => calc.Mul();

        private void Divbtn(object sender, EventArgs e) => calc.Div();

        private void Modulebtn(object sender, EventArgs e) => calc.Mod();
        

        private void Powerbtn(object sender, EventArgs e) => calc.Power();


        private void Sqrtbtn(object sender, EventArgs e) => calc.Sqrt();
        

        private void Absolute(object sender, EventArgs e) => calc.Abs();

        private void Clear(object sender, EventArgs e) => calc.Reset();
        

        private void Swap(object sender, EventArgs e) => calc.Swap();

        private void button12_Click(object sender, EventArgs e) => calc.Rotate(3);

        private void CheckEnter(object sender, KeyPressEventHandler e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1.PerformClick();
            }
        }

        private void button13_Click(object sender, EventArgs e) => calc.DivRem();
    }
}
