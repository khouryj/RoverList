using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here
        private int count = 0;
        Node tail;

        public RoverList ()
        {
            count = 0;
            head = null;
            tail = null;
        }
  
        public override int Count => count;
    
        public override void Add(object data)
        {
            if (head == null)
            {
                head = new Node(data);
                tail = head;
            }
            else
            {
                tail.Next = new Node(data);
                tail = tail.Next;
            }
            count++;
        }

        public override void Add(int Position, object data)
        {
            Node temp;
            int counter = 0;
            tail = head;
            while (counter < Position-1)
            {
                tail = tail.Next;
                counter++;
            }
            temp = tail.Next;
            tail.Next = new Node(data);
            tail = tail.Next;
            tail.Next = temp;
            count++;
        }

        public override void Clear()
        {
            head = null;
            tail = null;
            tail = head;
            count = 0;
        }

        public override Node ElementAt(int Position)
        {
            int counter = 0;
            Node current = head;
            if (Position > Count || Position < 0)
            {
                return new Node(null);
            }
            while (counter < Position)
            {
                current = current.Next;
                counter++;
            }
            return current;

        }

        public override void ListNodes()
        {
            Node current = head;
            while (current.Next != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.WriteLine(current.Data);
        }

        public override bool RemoveAt(int Position)
        {
            Node current = head;
            Node temp;
            int counter = 0;
            if (Position < 0 || Position > Count)
            {
                return false;
            }
            if (Position == 0)
            {
                temp = head.Next;
                head = null;
                head = temp;
                count--;
                return true;
            }
            while (counter < Position-1)
            {
                current = current.Next;
                counter++;
            }
            temp = current.Next.Next;
            current.Next = null;
            current.Next = temp;
            count--;
            return true;
        }
    }
}
