using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12
{
    internal class Logistics
    {
        private Stack<int> _logistics = new Stack<int>();

        public Action<int> OnPopItems;
        public Action<int> OnPushItems;
        public Action<string> OnAlert;

        public void Push(int n)
        {
            _logistics.Push(n);
            OnPushItems(n);
        }

        private bool requirement(int n)
        {
            if (_logistics.Count > n)
            {
                return true;
            }
            OnAlert($"{n} numbers needed");
            return false;      
        }

        private void ExecuteBinary(Func<int, int, int> op)
        {
            if (requirement(2))
            {
                return;
            }
            var a = _logistics.Pop();
            var b = _logistics.Pop();
            OnPopItems(2);

            var r = op(a, b);
            Push(r);
        }

        private void ExecuteUniary(Func<int, int> op)
        {
            if (requirement(1))
            {
                return;
            }
            var a = _logistics.Pop();
            OnPopItems(1);

            var r = op(a);
            Push(r);
        }

        public void Add() => ExecuteBinary((a, b) => a + b);
        public void Mul() => ExecuteBinary((a, b) => a * b);
        public void Sub() => ExecuteBinary((a, b) => b - a);
        public void Div() => ExecuteBinary((a, b) => b / a);
        public void Power() => ExecuteBinary((a, b) => (int)Math.Pow(a, b));
        public void Mod() => ExecuteBinary((a, b) => b % a);

        public void Abs() => ExecuteUniary((a) => Math.Abs(a));
        public void Sqrt() => ExecuteUniary((a) => (int)Math.Sqrt(a));

        public void Divrem()
        {
            if (requirement(2))
            {
                return;
            }
            var a = _logistics.Pop();
            var b = _logistics.Pop();
            OnPopItems(2);

            var r = b / a;
            var m = b % a;
            Push(r);
            Push(m);
        }

        internal void Swap()
        {

            var a = _logistics.Pop();
            var b = _logistics.Pop();
            OnPopItems(2);

            Push(a);
            Push(b);
        }

        internal void Rotate(int v)
        {
            if (requirement(3))
            {
                return;
            }
            var a = _logistics.Pop();
            var b = _logistics.Pop();
            var c = _logistics.Pop();
            OnPopItems(3);

            Push(a);
            Push(c);
            Push(b);
        }

        internal void Reset()
        {
            _logistics.Clear();
        }
    }
}
