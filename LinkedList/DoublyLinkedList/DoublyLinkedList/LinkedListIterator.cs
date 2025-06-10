using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DoublyLinkedList
{
    public class LinkedListIterator<T>
    {
        private LinkedListNode<T> currentNode;

        public LinkedListIterator()
        {
            this.currentNode = null;
        }
        public LinkedListIterator(LinkedListNode<T> node)
        {
            this.currentNode = node;
        }
        public T Data()
        {
            return this.currentNode.data;
        }
        public LinkedListIterator<T> Next()
        {
            this.currentNode = currentNode.next;
            return this;
        }
        public LinkedListIterator<T> Previous()
        {
            this.currentNode = currentNode.back;
            return this;
        }
        public LinkedListNode<T> Current()
        {
            return this.currentNode;
        }

    }
}
