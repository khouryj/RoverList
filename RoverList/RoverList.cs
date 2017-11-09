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
            tail = head;
            count = 0;
        }

        public override Node ElementAt(int Position)
        {
            int counter = 0;
            while (counter < Position-1)
            {
                
            }
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
            throw new NotImplementedException();
        }
    }
}
