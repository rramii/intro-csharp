using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12
{
    internal class Translator
    {
        private Stack<string> _translator = new Stack<string>();

        public Action<int> TranslatedItems;
        public Action<string> OnAlert;

        public void translate(string n)
        {
            switch (n)
            {
                case "Push":
                    TranslatedItems(0);
                    break;
                case "push":
                    TranslatedItems(0);
                    break;
                case "add":
                    TranslatedItems(1);
                    break;
                case "Add":
                    TranslatedItems(1);
                    break;
                case "Sub":
                    TranslatedItems(2);
                    break;
                case "sub":
                    TranslatedItems(2);
                    break;
                case "mul":
                    TranslatedItems(3);
                    break;
                case "Mul":
                    TranslatedItems(3);
                    break;
                case "div":
                    TranslatedItems(4);
                    break;
                case "Div":
                    TranslatedItems(4);
                    break;
                case "mod":
                    TranslatedItems(5);
                    break;
                case "Mod":
                    TranslatedItems(5);
                    break;
                case "power":
                    TranslatedItems(6);
                    break;
                case "Power":
                    TranslatedItems(6);
                    break;
                case "abs":
                    TranslatedItems(7);
                    break;
                case "Abs":
                    TranslatedItems(7);
                    break;
                case "Sqrt":
                    TranslatedItems(8);
                    break;
                case "sqrt":
                    TranslatedItems(8);
                    break;
                case "divrem":
                    TranslatedItems(9);
                    break;
                case "Divrem":
                    TranslatedItems(9);
                    break;
                case "swap":
                    TranslatedItems(10);
                    break;
                case "Swap":
                    TranslatedItems(10);
                    break;
                case "Rotate":
                    TranslatedItems(11);
                    break;
                case "rotate":
                    TranslatedItems(11);
                    break;
            }
        }
    }
}
