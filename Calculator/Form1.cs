namespace Calculator
{
    public partial class CounterForm : Form
    {
        public int Value { get; set; }

        public CounterForm()
        {            
            Value = 0;            
            InitializeComponent();
            lblError.BorderStyle = BorderStyle.None;
            lblCounter.Text = Value.ToString();
        }

        private void UpdateDisplay()
        {
            lblCounter.Text = Value.ToString();
        }

        private void OnButtonnUp(object sender, EventArgs e)
        {
            lblError.Text = "";
            Value += 1;
            UpdateDisplay();

            if(listBox1.Items.Count > 0)
            {
                lblError.Text = listBox1.Items[0].ToString();
            }
        }

        private void OnButtonDown(object sender, EventArgs e)
        {
            lblError.Text = "";
            Value -= 1;
            UpdateDisplay();
            listBox1.Items.Add(13);
            listBox1.Items.Add(27);
        }

        private void OnButtonReset(object sender, EventArgs e)
        {
            var t = txtInput.Text;

            int n;
            if( int.TryParse(t, out n))
            {
                Value = n;
                UpdateDisplay();
                lblError.Text = "";
            }
            else
            {
                lblError.Text = $"Not a Number: {t}";
            }

            txtInput.Text = "";
        }
        
    }
}