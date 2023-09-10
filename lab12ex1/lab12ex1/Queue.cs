using System;
using System.Collections.Generic;


namespace lab12ex1
{
    class Queue<T>
    {
        private T[] elements;

        public int Count { get; private set; } = 0;

        public Queue()
        {
            elements = new T[4];
        }


        public Queue(int maxCapacity)
        {

            elements = new T[maxCapacity];
        }

        public void Enqueue(T elementToEnqueue)
        {
            if (Count == elements.Length)
            {
                /*Console.WriteLine("Nu se mai pot adauga elemente");
                return;*/

                var newVec = new T[2 * elements.Length];
                for (int i = 0; i < elements.Length; i++)
                {
                    newVec[i] = elements[i];
                }

                elements = newVec;

            }

            elements[Count] = elementToEnqueue;
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                return default;
            }
            T result = elements[0];

            for (int i = 0; i < Count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
            Count--;

            return result;
        }


        public void Afisare()
        {
            for (var i = 0; i < Count; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
