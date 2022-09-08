using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11
{

    public class StackCalc
    {
        private Stack<int> _stack = new Stack<int>();

        public Action<int> OnPopItems;
        public Action<int> OnPushItem;
        public Action<string> OnProblem;

        public void Push(int n)
        {
            _stack.Push(n);
            OnPushItem(n);
        }
        
        private void executeBinary(Func<int, int, int> op)
        {
            if (dontHave(2))
            {
                return;
            }
            var a = _stack.Pop();
            var b = _stack.Pop();
            OnPopItems(2);

            var r = op(a, b);
            Push(r);            
            OnProblem("OK");
        }

        private void executeUniary(Func<int, int> op)
        {
            if (dontHave(1))
            {
                return;
            }
            var a = _stack.Pop();            
            OnPopItems(1);

            var r = op(a);
            Push(r);
            OnProblem("OK");
        }

        
        public void Add() => executeBinary((a, b) => a + b);
        public void Mul() => executeBinary((a, b) => a * b);

        internal void Sub() => executeBinary((a, b) => b - a);
        internal void Div() => executeBinary((a, b) => b / a);

        internal void DivRem()
        {
            if (dontHave(2))
            {
                return;
            }
            var a = _stack.Pop();
            var b = _stack.Pop();
            OnPopItems(2);

            var r = b / a;
            var m = b % a;
            Push(r);
            Push(m);
            OnProblem("OK");
        }

        internal void Power() => executeBinary((a, b) => (int)Math.Pow(a, b));

        internal void Abs() => executeUniary(x => Math.Abs(x));

        internal void Sqrt() => executeUniary(x => (int)Math.Sqrt(x));

        internal void Swap()
        {
            
            var a = _stack.Pop();
            var b = _stack.Pop();
            OnPopItems(2);

            Push(a);
            Push(b);
            OnProblem("OK");
        }

        internal void Mod() => executeBinary((a, b) => b % a);

        internal void Rotate(int v)
        {
            if (dontHave(3))
            {
                return;
            }
            var a = _stack.Pop();
            var b = _stack.Pop();
            var c = _stack.Pop();
            OnPopItems(3);

            Push(a);
            Push(c);
            Push(b);
            OnProblem("OK");
        }

        private bool dontHave(int needed)
        {
            if (_stack.Count < needed)
            {
                OnProblem($"{needed} needed");
                return true;
            }
            return false;
        }

        internal void Reset()
        {
            OnPopItems(_stack.Count);
            _stack.Clear();
        }
    }
}
