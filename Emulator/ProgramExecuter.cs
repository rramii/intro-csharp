using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class Controller
    {
        public int PC { get; set; } = 0;
    }

    public class ProgramExecuter
    {
        public Controller _controller = new Controller();
              
        
        private List<Instruction> _instructions;
        private DataStack _stack;
        public ProgramExecuter(List<Instruction> instructions, DataStack stack)
        {
            _instructions = instructions;
            _stack = stack;
        }

        public bool IsHalted =>    _controller.PC >= _instructions.Count 
                                || CurrentInstruction()._opCode == OpCodeEnum.HLT;

        private Instruction CurrentInstruction() => _instructions[_controller.PC];
        
        private bool NotEnoughParameters(int n) => n > _stack.Count;
            
        public bool ExecuteStep()
        {
            if (IsHalted)
            {
                return false;
            }

            var instruction = CurrentInstruction();
            if (NotEnoughParameters(instruction._argc))
            {
                _controller.PC = _instructions.Count;
                return false;
            }

            return instruction.Execute(_stack, _controller);                                    
        }
    }
}
