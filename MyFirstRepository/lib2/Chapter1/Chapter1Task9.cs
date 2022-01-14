﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1
{
    namespace Task9
    {
        public abstract class Base
        {
            protected char[] symbols;
            public Base(string text)
            {
                this.symbols = text.ToCharArray();
            }
            public char getSymbol(int index)
            {
                return symbols[index];
            }
            public abstract void Method(int num, char symbol);
        }
        public interface IFirst
        {
            void Method(string text);
            char this[int index]
            {
                get;
                set;
            }
        }
        public class MyClass : Base, IFirst
        {
            public MyClass(string text) : base(text) { }
            public override void Method(int num, char symbol)
            {
                symbols[num] = symbol;
            }

            public void Method(string text)
            {
                throw new NotImplementedException();
            }

            public char this[int index]
            {
                get
                {
                    return base.getSymbol(index);
                }
                set
                {
                    symbols[index] = value;
                }
            }
        }
        public class ProgramClass
        {
            public static int run()
            {
                return 0;
            }
        }
    }
}
