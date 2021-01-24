using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class MyDict<T1,T2,T3>
    {
        T1[] idArray;
        T2[] nameArray;
        T3[] surnameArray;
        T1[] idTemp;
        T2[] nameTemp;
        T3[] surnameTemp;

        public MyDict()
        {
            idArray = new T1[0];
            nameArray = new T2[0];
            surnameArray = new T3[0];

        }

        public void Add(T1 id, T2 name, T3 surname)
        {
            idTemp = idArray;
            nameTemp = nameArray;
            surnameTemp = surnameArray;

            idArray = new T1[idArray.Length + 1];
            nameArray = new T2[nameArray.Length + 1];
            surnameArray = new T3[surnameArray.Length + 1];
            for (int i = 0; i < idTemp.Length; i++)
            {
                idArray[i] = idTemp[i];
                nameArray[i] = nameTemp[i];
                surnameArray[i] = surnameTemp[i];

            }

            idArray[idArray.Length - 1] = id;
            nameArray[nameArray.Length - 1] = name;
            surnameArray[surnameArray.Length - 1] = surname;

        }

        public int Length
        {
            get { return idArray.Length; }
        }

        public T1[] Ids
        {
            get { return idArray; }
        }
        public T2[] Names
        {
            get { return nameArray; }
        }

        public T3[] SurNames
        {
            get { return surnameArray; }
        }

        
    }
}
