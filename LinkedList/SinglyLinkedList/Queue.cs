using System;

namespace LinkedList
{
    /// <summary>
    /// A generic queue implementation using a singly linked list.
    /// </summary>
    /// <typeparam name="T">The type of elements in the queue.</typeparam>
    public class Queue<T>
    {
        private LinkedList<T> list;

        /// <summary>
        /// Initializes a new instance of the Queue class.
        /// </summary>
        public Queue()
        {
            list = new LinkedList<T>();
        }

        /// <summary>
        /// Adds an item to the end of the queue.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Enqueue(T item)
        {
            list.InsertLast(item);
        }

        /// <summary>
        /// Removes and returns the item at the front of the queue.
        /// Throws InvalidOperationException if the queue is empty.
        /// </summary>
        /// <returns>The item at the front of the queue.</returns>
        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");
            T value = list.head.data;
            list.DeleteFirst();
            return value;
        }

        /// <summary>
        /// Returns the item at the front of the queue without removing it.
        /// Throws InvalidOperationException if the queue is empty.
        /// </summary>
        /// <returns>The item at the front of the queue.</returns>
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");
            return list.head.data;
        }

        /// <summary>
        /// Returns true if the queue is empty.
        /// </summary>
        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        /// <summary>
        /// Returns the number of items in the queue.
        /// </summary>
        public int Size()
        {
            return list.count;
        }

        /// <summary>
        /// Prints the contents of the queue for debugging purposes.
        /// </summary>
        public void Print()
        {
            list.PrintList();
        }
    }
} 