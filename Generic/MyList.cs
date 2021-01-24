using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class MyList<T> // Generic Class 
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T sehir)
        {
            
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length-1] = sehir;

        }

        public int Length
        {
            get { return _array.Length; }
        }
     
        public T[] Items
        {
            get { return _array; }
        }

    }
}
