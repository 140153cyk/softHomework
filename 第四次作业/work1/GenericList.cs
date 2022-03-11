using System;
using System.Collections.Generic;
using System.Text;

namespace work1
{
    class GenericList<T>
    {
        Node<T> head, tail;

        public GenericList(){
            head=null;
            tail=null;
        }

        public Node<T> Head { get => head; }

        public void add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> node=head;
            while (node != null)
            {
                action(node.Data);
                node = node.Next;
            }
        }
      
    }

    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T data) {
            Next = null;
            Data = data;        
        }

    }
}
