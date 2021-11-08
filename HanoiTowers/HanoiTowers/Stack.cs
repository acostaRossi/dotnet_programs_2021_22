namespace HanoiTowers
{
    public class Stack {

        private int[] arr;

        private int _size; // field

        private int _counter = 0; // field

        // ritorna la capaciá' massima dello stack
        public int Size { get => _size; } // readonly

        // ritorna in numero di elementi presenti nello stack
        public int Counter
        {
            get
            {
                return _counter;
            }
        }

        //public Stack()
        //{
        //    _size = 20;

        //    arr = new int[_size];
        //}

        public Stack(int n = 20)
        {
            _size = n;

            arr = new int[_size];
        }
        public void Push(int n)
        {
            if (!IsFull())
            {
                arr[_counter] = n;

                _counter++;
            }
            else
            {
                // lancio un eccezione
            }
        }
        public int Pop()
        {
            if (!IsEmpty())
            {
                _counter--;

                //arr[_counter] = 0;

                return arr[_counter];
            }
            else
            {
                return -1;
            }
        }
        public int Peek()
        {
            if (!IsEmpty())
            {
                return arr[_counter - 1];
            }
            else
            {
                return -1;
            }
        }
        public bool IsEmpty()
        {

            return _counter == 0;
        }
        public bool IsFull()
        {

            return _counter == _size;

        }
        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < _counter; i++)
            {
                s += arr[i];

                if (i != _counter - 1) s += "->";
            }

            return s;
        }
    }
}
