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
        public Form1()
        {
            InitializeComponent();
        }

        private void excuteoperation(Func<int,int,int> op)
        {
            if (listBox1.Items.Count > 1)
            {
                var index = listBox1.Items.Count - 1;
                var lastnum = listBox1.Items[index];
                var beforelast = listBox1.Items[index - 1];

                var a = Convert.ToInt32(lastnum);
                var b = Convert.ToInt32(beforelast);
                var result = op(a, b);

                listBox1.Items.RemoveAt(index);
                listBox1.Items.RemoveAt(index - 1);

                listBox1.Items.Add(result);
            }
            else
            {
                label1.Text = "need 2 numbers";
            }
        }

        private void Pushbtn(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            int number;
            if (int.TryParse(text, out number))
            {
                listBox1.Items.Add(number);
                textBox1.Text = "";
                label1.Text = "";
            }
            else
            {
                label1.Text = "not a number";
            }
        }

        private void Addbtn(object sender, EventArgs e)
        {
            excuteoperation((a,b) => a + b);
        }
        private void Subtractbtn(object sender, EventArgs e)
        {
            excuteoperation((a,b) => b - a);
        }

        private void Multibtn(object sender, EventArgs e)
        {
            excuteoperation((a, b) => a * b);
        }

        private void Divbtn(object sender, EventArgs e)
        {
            excuteoperation((a, b) => b / a);
        }

        private void Modulebtn(object sender, EventArgs e)
        {
            excuteoperation((a, b) => a % b);
            excuteoperation((a, b) => b / a);

        }

        private void Powerbtn(object sender, EventArgs e)
        {
            excuteoperation((a, b) => (int)Math.Pow(a, b));
        }

        private void Sqrtbtn(object sender, EventArgs e)
        {
            var index = listBox1.Items.Count - 1;
            var lastnum = listBox1.Items[index];
            var a = Convert.ToInt32(lastnum);

            if (a > 0)
            {
                var b = Math.Sqrt(a);
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Add(b);
            }
            else
            {
                label1.Text = "number has to be positive";
            }
        }

        private void Absolute(object sender, EventArgs e)
        {
            var index = listBox1.Items.Count - 1;
            var lastnum = listBox1.Items[index];
            var a = Convert.ToInt32(lastnum);
            if (a < 0)
            {
                listBox1.Items[index] = -a;
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Swap(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 3)
            {
                var index = listBox1.Items.Count - 1;
                var lastnum = listBox1.Items[index];
                var beforelast = listBox1.Items[index - 1];
                var thirdtolast = listBox1.Items[index - 2];

                var a = Convert.ToInt32(thirdtolast);
                var b = Convert.ToInt32(beforelast);
                var c = Convert.ToInt32(lastnum);
                
                listBox1.Items[index - 2] = c;
                listBox1.Items[index - 1] = a;
                listBox1.Items[index] = b;

            }
            else
            {
                label1.Text = "3 numbers needed";
            }
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                var text = textBox1.Text;
                int number;
                if (int.TryParse(text, out number))
                {
                    listBox1.Items.Add(number);
                    textBox1.Text = "";
                    label1.Text = "";
                }
                else
                {
                    label1.Text = "not a number";
                }
            }
        }
    }
}
