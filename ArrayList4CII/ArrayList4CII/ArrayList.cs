using System;

namespace ArrayList4CII
{
    class ArrayList
    {
        private int[] arr;
        private int index = 0;

        public ArrayList()
        {
            arr = new int[10];
        }

        public ArrayList(int size)
        {
            arr = new int[size];
        }

        public ArrayList(int[] vector)
        {
            arr = new int[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                arr[i] = vector[i]; 
            }

            index = vector.Length - 1;
        }

        public void Add(int val)
        {
            if(index >= arr.Length)
            {
                // resize
                Array.Resize(ref arr, arr.Length*2);
            }
            arr[index++] = val;
        }

        public void Add(int val, int position)
        {
            if (position >= arr.Length)
            {
                // resize
                Array.Resize(ref arr, position*2);
            }
            arr[position] = val;
        }

        public int Get(int pos)
        {
            if(pos >= 0 && pos < arr.Length)
            {
                return arr[pos];
            }

            return -1;
            //throw()
        }

        public void Remove(int pos)
        {
            if (pos >= 0 && pos < arr.Length)
            {
                arr[pos] = null;
            }
        }
    }
}
