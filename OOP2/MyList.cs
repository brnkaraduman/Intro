using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class MyList <T>
    {


        T[] items;
        T[] myTempArray;
        public MyList() { items = new T[0]; }

        public void Add(T item)
        {
            myTempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < myTempArray.Length; i++)
            {
                items[i] = myTempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Length {

            get { return items.Length; }

        }


    }
}
