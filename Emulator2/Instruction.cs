using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class Instruction
    {        
        public OpCodeEnum _opCode;
        public int _operand; //  because what to do if not operand???
        public int _argc;

        private Func<DataStack, Controller, int,DataStack, Memory, bool> _execute;
        public Instruction(OpCodeEnum opCode, int operand, int argc, Func<DataStack, Controller, int,DataStack, Memory,  bool> execute)
        {
            _opCode = opCode;
            _operand = operand;
            _argc = argc;
            _execute = execute;            
        }

        public override string ToString()
        {
            var operand = _operand == 0 ? string.Empty : $" {_operand}";
            return $"{_opCode}{operand}";
        }

        public bool Execute(DataStack stack, Controller controller,DataStack stackIP, Memory mem)
        {
            return _execute(stack, controller, _operand, stackIP, mem);
        }

         
    }
}
