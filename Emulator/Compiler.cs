using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class Compiler
    {                       
        private Instruction decodeLine(string line)
        {
            string[] parts = line.Split(' ');
            if( parts.Length > 0)
            {               
                var opCodeText = parts[0].Trim().ToUpper();

                var (opCode, argc, lambda) = OpCodeDictionary.Get(opCodeText);
                if( opCode == OpCodeEnum.PUSH || opCode == OpCodeEnum.JNZ || opCode == OpCodeEnum.JZ)
                {
                    if(parts.Length > 1 && int.TryParse(parts[1].Trim(), out var operand))
                    {
                        return new Instruction(opCode, operand, argc, lambda);
                    }
                    else
                    {
                        //TODO: report an error
                        return new Instruction(opCode, 9999, argc, lambda);
                    }
                }
                else
                {
                    return new Instruction(opCode, 0, argc, lambda);
                }
            }
            else
            {
                return null;
            }                      
        }

        public List<Instruction> BuildCode(string source)
        {
            var instructions = new List<Instruction>();

            source = source.Trim();
            string[] sourceLines = source.Split('\n');
            if(sourceLines.Length == 0)
            {
                instructions.Add(decodeLine("HLT"));
                return instructions;
            }

            
            foreach (var line in sourceLines)
            {
                var instruction = decodeLine(line);
                instructions.Add(instruction);
            }

            return instructions;
            
            //ProgStack = new DataStack(stackViewerPush, stackViewerPop);
            //progExec = new ProgramExecuter(compilation.programList, ProgStack);
        }        
    }
}
