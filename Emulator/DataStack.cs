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

        public Action<int> stackViewPush;
        public Action stackViewPop;

        public DataStack(Action<int> stackViewerPush, Action stackViewerPop)
        {
            stackViewPush = stackViewerPush;
            stackViewPop = stackViewerPop;
        }
        public void PUSH(int data)
        {
            dataStack.Push(data);
            stackViewPush(data);
        }
        public int POP()
        {
            stackViewPop();
            return dataStack.Pop();
        }

        public int TOP()
        {
            return dataStack.Peek();
        }       

        public int Count => dataStack.Count;
    }
}
