using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListIterator<T>
    {
        private LinkedListNode<T> currentNode;

        // default constructor for the iterator
        public LinkedListIterator()
        {
            this.currentNode = null;
        }


        // constructor for the iterator with a starting node
        public LinkedListIterator(LinkedListNode<T> node)
        {
            this.currentNode = node;
        }

        public T? Data()
        {
            return currentNode.data;
        }

        // advance to the next node and return the iterator
        public LinkedListIterator<T> Next() 
        {
            this.currentNode = currentNode.next;
            return this;
        }
        // return the current node
        public LinkedListNode<T> Current()
        {
            return this.currentNode;
        }
    }
}
