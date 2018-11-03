using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniDeckOfCards
{
    class Stack<T>
    {
        T[] theStack;
        int Capacity => theStack.Length;
        int ItemCount = 0;
        public Stack()
        {
            theStack = new T[5];
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = ItemCount - 1; i >= 0; i--)
            {
                yield return theStack[i];
            }
        }
        public bool IsEmpty()
        {
            return theStack.Length == 0;

        }
        public void Push(T itemToPush)
        {
            if (ItemCount >= Capacity)
            {
                T[] temp = new T[theStack.Length * 2];

                for (int i = 0; i < ItemCount; i++)
                {
                    temp[i] = theStack[i];
                }
                theStack = temp;
            }

            theStack[ItemCount] = itemToPush;


            ItemCount++;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("The Stack Is Empty");
            }


            //test this for more understanding
            return theStack[ItemCount -= 1];
        }

        public T Peek()
        {
            T itemToPeek = theStack[ItemCount];
            return itemToPeek;
        }

    }
}
