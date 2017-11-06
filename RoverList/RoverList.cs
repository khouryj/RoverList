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
            int counter = 0;
            while (counter < Position)
            {

            }
        }

        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override Node ElementAt(int Position)
        {
            throw new NotImplementedException();
        }

        public override void ListNodes()
        {
            while (tail.Next)
        }

        public override bool RemoveAt(int Position)
        {
            throw new NotImplementedException();
        }
    }
}
