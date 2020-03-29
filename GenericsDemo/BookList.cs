using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    class BookList
    {
        public void Add(BookList book)
        {
            throw new NotImplementedException();
        }

        public BookList this[int Index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    public class GenericDictionary<TKey,Tvalue>
    {
        public void Add(TKey key,Tvalue value)
        {

        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
