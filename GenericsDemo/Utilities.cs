using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{

    //where T : IComparable
    //where T : Product
    //where T : struct
    //where T : class
    //where T : new()
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            //return a > b ? a : b;
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}
