using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    internal class DemoPrograms
    {        
        public static readonly string SimpleWithJumps 
= @"PUSH 5
PUSH 2
DUP
INC
NOP
MUL
ADD
DUP
SUB
JZ 1
NOP
HLT";

    }
}
