using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Emulator
{
    public partial class Form_MachineEmulator : Form
    {        
        private ProgramExecuter _executor;        
        
        public Form_MachineEmulator()
        {
            InitializeComponent();
            var memory = new Bitmap(300, 300);
            pictureBox1.Image = memory;

            _executor = new ProgramExecuter();
            _executor.AttachDataStack(
                        (data) => listBox_StackViewer.Items.Add(data),
                        () => listBox_StackViewer.Items.RemoveAt(listBox_StackViewer.Items.Count - 1)
                    );


            _executor.AttachIpStack(
                        (data) => listBox_IpStack.Items.Add(data),
                        () => listBox_IpStack.Items.RemoveAt(listBox_IpStack.Items.Count - 1)
                    );
            
            _executor.OnPcChange = (pc) => label_PC.Text = $"PC: {pc}";

            _executor.OnMemoryWritten = (address, data) =>
            {
                var y = address / 20 * 5;
                var x = address % 20 * 5;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        memory.SetPixel(x + i, y + j, Color.FromKnownColor((KnownColor) data));
                    }
                }
                pictureBox1.Refresh();
            };

            textBox_ProgramCode.Text = DemoPrograms.SimpleWithJumpsIP;
        }

        private void BuildCode_Click(object sender, EventArgs e)
        {           
            var compiler = new Compiler();
            string sourceCode = textBox_ProgramCode.Text.Trim();
            var opcodes = compiler.BuildCode(sourceCode);

            listBox_ExeCode.Items.Clear();
            int label = 0;
            foreach (var opcode in opcodes)
            {
                listBox_ExeCode.Items.Add($"{label++}: {opcode.ToString()}");
            }

            _executor.Load(opcodes);
        }

        
        private void ExecuteStep_Click(object sender, EventArgs e)
        {
            if (_executor.IsHalted)
            {
                textBox_ExecutingMessage.Text = "STOPED";                
            }
            else
            {
                
                if (_executor.ExecuteStep())
                {
                    textBox_ExecutingMessage.Text = "Executing";
                }
                else
                {
                    textBox_ExecutingMessage.Text = "Halting on Error";
                }                                
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_ProgramCode.Clear();
            _executor.Reset();            
        }

        private void Run_Click(object sender, EventArgs e)
        {
            while(!_executor.IsHalted)
            {
                btn_ExecuteStep.PerformClick();
            }
            textBox_ExecutingMessage.Text = "STOPED";
        }

        private void listBox_StackViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_IpStack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ProgramCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Load programs";
            openFileDialog1.InitialDirectory = "m:/train";
            openFileDialog1.ShowDialog(this);
            
            var f = openFileDialog1.OpenFile();
            var sr = new StreamReader(f);
            var l = sr.ReadLine();
            textBox_ProgramCode.Text += l;
            textBox_ProgramCode.Text += '\n';
            textBox_ProgramCode.Text += sr.ReadLine();
                

        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            
        }
    }
}
