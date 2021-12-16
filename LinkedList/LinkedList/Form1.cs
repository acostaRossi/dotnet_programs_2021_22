using System;
using System.Collections;
using System.Windows.Forms;

namespace LinkedList
{
    class LinkedList<T> : IEnumerable
    {
        public LinkedListNode<T> First { get; set; }
        public LinkedListNode<T> Last { get; set; }
        public int Count { get; set; } = 0;
        public void AddFirst(T value)
        {
            LinkedListNode<T> node = NewNode(value);

            if (First == null)
            {
                First = node;
                Last = node;
                Count++;
                return;
            }

            node.Next = First;
            First = node;
            Count++;
        }
        public void RemoveFirst()
        {
            if (Count == 1)
            {
                First = null;
                Last = null;
                Count--;
                return;
            }

            LinkedListNode<T> node = First.Next;

            First.Next = null;
            First = node;
            Count--;
        }
        public void AddLast(T value)
        {
            LinkedListNode<T> node = NewNode(value);

            if (First == null)
            {
                First = node;
                Last = node;
                Count++;
                return;
            }

            Last.Next = node;
            Last = node;
            Count++;
        }
        public void RemoveLast()
        {
            if (Count == 1)
            {
                First = null;
                Last = null;
                Count--;
                return;
            }

            LinkedListNode<T> node = First;

            int i = 1;

            while (i < Count - 1)
            {
                node = node.Next;
                i++;
            }

            node.Next = null;
            Last = node;
            Count--;
        }
        private LinkedListNode<T> NewNode(T value)
        {
            return new LinkedListNode<T>()
            {
                Value = value,
                Prev = null,
                Next = null
            };
        }
        public IEnumerator GetEnumerator()
        {
            return new LinkedListEnum<T>(this);
        }
    }
    class LinkedListEnum<T> : IEnumerator
    {
        private LinkedList<T> linkedList;        
        private LinkedListNode<T> position;
        public LinkedListEnum(LinkedList<T> list)
        {
            linkedList = list;
        }
        public object Current { get => position; }
        public bool MoveNext()
        {
            if (position == null)
                position = linkedList.First;
            else
                position = position.Next;

            return position != null;
        }
        public void Reset()
        {
            position = linkedList.Last;
        }
    }
    class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Prev { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LinkedList<int> lnkList = new LinkedList<int>();

            lnkList.AddLast(2);

            lnkList.AddLast(3);

            lnkList.AddLast(4);
            
            lnkList.AddFirst(1);

            lnkList.AddFirst(0);

            lnkList.AddLast(5);

            lnkList.RemoveLast();

            lnkList.RemoveFirst();

            foreach (LinkedListNode<int> item in lnkList)
            {   
                Console.WriteLine(item.Value);
            }
        }
    }
}
