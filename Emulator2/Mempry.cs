using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class Memory
    {
        private int[] _memory;

        public event Action<int, int> OnWrite;
        public Memory(int size)
        {
            _memory = new int[size];
        }

        public void Write(int address, int data)
        {
            _memory[address] = data;
            if(OnWrite != null)
                OnWrite(address, data);
        }
        public int Read(int address) => _memory[address];
    }
}
