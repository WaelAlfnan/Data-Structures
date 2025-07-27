using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Stack<T>
    {
        LinkedList<T> stack;
        Stack() 
        {
            stack = new LinkedList<T>(); 
        }

        public void Push(T data)
        {
            stack.InsertFirst(data);
        }


    }
}
