using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_12
{
    public partial class Form1 : Form
    {
        private Translator translator = new Translator();

        private Logistics Logistics = new Logistics();
        
        public Form1()
        {
            InitializeComponent();
            Logistics.OnPopItems = PopList;
            Logistics.OnPushItems = PushList;
            Logistics.OnAlert = Alert;

            translator.TranslatedItems = TranslatedList;
            translator.OnAlert = Alert;

        }

        private void TranslatedList(int n)
        {
            NumbInput.Items.Add(n.ToString());
        }

        private void PushList(int n)
        {
            Output.Items.Add(n.ToString());
        }

        private void PopList(int n)
        {
            var items = Output.Items;
            for (int i = 0; i < n; i++)
            {
                items.RemoveAt(items.Count - 1);
            }
        }

        private void Alert(string msg)
        {
            Msg.Text = msg;
        }

        private void Textinput(object sender, EventArgs e)
        {

        }

        private void Numbinput(object sender, EventArgs e)
        {

        }


        private void Step(object sender, EventArgs e)
        {

        }

        private void FullOP(object sender, EventArgs e)
        {
            string Items = NumbInput.Text;
            translator.translate(Items);
        }
    }
}
