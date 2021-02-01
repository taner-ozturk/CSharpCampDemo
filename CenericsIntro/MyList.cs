﻿namespace CenericsIntro
{
    public class MyList<T>
    {

        T[] items;
        //constructor
        
        public MyList()
        {
            items = new T[0];
        }

        

        public void Add(T item)
        {

            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                
            }

            items[items.Length - 1] = item;

        }

        public int Length => items.Length;
        public T[] Items
        {
            get
            {
                return items;
            }
        }
    }
}
