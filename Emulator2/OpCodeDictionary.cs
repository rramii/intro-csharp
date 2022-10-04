using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public enum OpCodeEnum
    {
        NOP , 
        PUSH,
        PUSHIP,
        POPIP,
        DROPIP,
        DROP,
        ADD ,
        SUB ,
        MUL ,
        DIV ,
        MOD ,
        INC ,
        DEC ,
        NEG ,
        DUP ,
        CMP ,
        SWAP,
        ROL3,
        HLT ,
        JZ  ,
        JNZ ,
        JMP ,

        STORE,
    }

    
    public static class OpCodeDictionary
    {
        private static Dictionary<string, (OpCodeEnum, int, Func<DataStack, Controller, int,DataStack, Memory, bool>)> OpCodeMap = new Dictionary<string, (OpCodeEnum, int, Func<DataStack, Controller, int,DataStack, Memory, bool>)>()
        {
            //Name       OpCode        stack args            
            { "NOP",  (OpCodeEnum.NOP,  0, (s,c,arg,s2 , m) => { ++c.PC;  return true; } ) },
            { "PUSH", (OpCodeEnum.PUSH, 0, (s,c,arg,s2 , m) => { ++c.PC; s.PUSH(arg); return true; } ) },
            { "PUSHIP", (OpCodeEnum.PUSHIP, 0, (s,c,arg,s2 , m) => { ++c.PC; s2.PUSH(arg); return true; } ) },//ok
            { "POPIP", (OpCodeEnum.POPIP, 0, (s,c,arg,s2 , m) => { ++c.PC; c.PC=s2.POP(); return true; } ) },//CHANGE

            { "DROPIP", (OpCodeEnum.DROPIP, 0, (s,c,arg,s2 , m) => { ++c.PC; s2.POP(); return true; } ) },//OK
            { "DROP", (OpCodeEnum.DROP, 0, (s,c,arg,s2 , m) => { ++c.PC; s.POP(); return true; } ) },
            { "ADD",  (OpCodeEnum.ADD , 2, (s,c,arg,s2 , m) => { ++c.PC; s.PUSH(s.POP()+s.POP()); return true; } ) },
            { "SUB",  (OpCodeEnum.SUB , 2, (s,c,arg,s2 , m) => { ++c.PC; s.PUSH(-s.POP()+s.POP()); return true; } ) },
            { "MUL",  (OpCodeEnum.MUL , 2, (s,c,arg,s2 , m) => { ++c.PC; s.PUSH(s.POP()*s.POP()); return true; } ) },
            { "DIV",  (OpCodeEnum.DIV , 2, (s,c,arg,s2 , m) => { ++c.PC; s.PUSH(s.POP()-s.POP()); return true; } ) },
            { "MOD",  (OpCodeEnum.MOD , 2, (s,c,arg,s2 , m) => { ++c.PC; s.PUSH(s.POP()-s.POP()); return true; } ) },
            { "INC",  (OpCodeEnum.INC , 1, (s,c,arg,s2 , m) => { ++c.PC; s.PUSH(s.POP()+1); return true; } ) },
            { "DEC",  (OpCodeEnum.DEC , 1, (s,c,arg,s2 , m) => { ++c.PC; s.PUSH(s.POP()-1); return true; } ) },
            { "NEG",  (OpCodeEnum.NEG , 1, (s,c,arg,s2 , m) => { ++c.PC; s.PUSH(-s.POP()); return true; } ) },
            { "DUP",  (OpCodeEnum.DUP , 1, (s,c,arg,s2 , m) => { ++c.PC; s.PUSH(s.TOP()); return true; } ) },
            { "CMP",  (OpCodeEnum.CMP , 2, (s,c,arg,s2 , m) => { ++c.PC; return true; } ) },
            { "SWAP", (OpCodeEnum.SWAP, 2, (s,c,arg,s2 , m) => { ++c.PC; var (a, b) = (s.POP(), s.POP()); s.PUSH(a); s.PUSH(b); return true; } ) },
            { "ROL3", (OpCodeEnum.ROL3, 3, (s,c,arg,s2 , m) => { ++c.PC; return true; } ) },
            { "HLT",  (OpCodeEnum.HLT , 0, (s,c,arg,s2 , m) => { return false; } ) },
            { "JMP",  (OpCodeEnum.JMP , 0, (s,c,arg,s2 , m) => { c.PC =  arg;  return true; }) },
            { "JZ",   (OpCodeEnum.JZ  , 1, (s,c,arg,s2 , m) => {
                                                        if( s.POP() == 0)
                                                        {
                                                            c.PC =  arg;
                                                        }
                                                        else
                                                        {
                                                            ++c.PC;
                                                        }
                                                        return true;
                                                    })},
            { "JNZ",  (OpCodeEnum.JNZ , 1, (s,c,arg,s2 , m) => {
                                                        if( s.POP() != 0)
                                                        {
                                                            c.PC =  arg;
                                                        }
                                                        else
                                                        {
                                                            ++c.PC;
                                                        }
                                                        return true;
                                                    })},
            { "STORE", (OpCodeEnum.STORE, 1, (s,c,arg,ips, m) => { 
                                                        ++c.PC;
                                                        m.Write(s.POP(), arg);
                                                        return true; 
                                                    })},

        };

        public static (OpCodeEnum, int, Func<DataStack, Controller, int,DataStack, Memory, bool>) Get(string name)
        {
            if(OpCodeMap.TryGetValue(name, out var result))
            {
                return result;
            }
            else
            {
                //TODO: report an error
                return OpCodeMap["NOP"];
            }
        }

    }
}
