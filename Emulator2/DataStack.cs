using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    
    public class DataStack
    {
        private Stack<int> dataStack = new Stack<int>();
        

        public event Action<int> OnPush;
        public event Action OnPop;

        public DataStack()
        {

        }

        public DataStack(Action<int> stackViewerPush, Action stackViewerPop)
        {
            OnPush = stackViewerPush;
            OnPop = stackViewerPop;
        }
        public void PUSH(int data)
        {
            dataStack.Push(data);
            OnPush(data);

        }
        public int POP()
        {
            OnPop();
            return dataStack.Pop();
        }

        public int TOP()
        {
            return dataStack.Peek();
        }       

        public int Count => dataStack.Count;

        internal void Clear()
        {
            int count = dataStack.Count;            
            for (int i = 0; i < count; i++)
            {
                POP();
            }
        }
    }
}
