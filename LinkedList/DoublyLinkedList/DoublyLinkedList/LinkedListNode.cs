using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class LinkedListNode<T>
    {
        public T data {  get; set; }
        public LinkedListNode<T>? next { get; set; }
        public LinkedListNode<T>? back { get; set; }

        public LinkedListNode(T data)
        {
            this.data = data;
            this.next = null;
            this.back = null;
        }
    }
}
