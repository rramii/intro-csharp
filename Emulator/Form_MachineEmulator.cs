using System;
using System.Windows.Forms;

namespace Emulator
{
    public partial class Form_MachineEmulator : Form
    {        
        private ProgramExecuter _executor;        

        private readonly DataStack _stack; 

        public Form_MachineEmulator()
        {
            InitializeComponent();
            _stack = new DataStack(stackViewerPush, stackViewerPop);

            textBox_ProgramCode.Text = DemoPrograms.SimpleWithJumps;
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

            _executor = new ProgramExecuter(opcodes, _stack);

            label_PC.Text = "PC: 0";
            listBox_StackViewer.Items.Clear();
        }

        private  void stackViewerPush(int data)
        {
            listBox_StackViewer.Items.Add(data);
        }
        private  void stackViewerPop()
        {
            listBox_StackViewer.Items.RemoveAt(listBox_StackViewer.Items.Count - 1);
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
                

                label_PC.Text = $"PC: {_executor._controller.PC}";
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_ProgramCode.Clear();
            listBox_StackViewer.Items.Clear();
            listBox_ExeCode.Items.Clear();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            while(!_executor.IsHalted)
            {
                btn_ExecuteStep.PerformClick();
            }
            textBox_ExecutingMessage.Text = "STOPED";
        }
    }
}
