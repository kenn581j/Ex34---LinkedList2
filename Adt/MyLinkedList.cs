using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex32_linkedlist
{
    public class MyLinkedList
    {
        private int count;
        public int Count
        {
            get => count;
            set { count = value; }
        }
        private Node head = new Node();
        private Node tail = new Node();       
        
        
        public void Insert(object clubMember)
        {
            Insert(clubMember, Count);
        }

        public void Insert(object clubMember, int index)
        {
            if(index > Count)
            {
                throw new IndexOutOfRangeException();
            }
            
            Node n = new Node();
            n.Data = clubMember;

            if (index == 0)
            {

                if(Count == 0)
                {
                    n.Next = tail;
                    n.Prev = head;
                    tail.Prev = n;
                    head.Next = n;
                    head = n;
                }
                else
                {
                    n.Next = head;
                    n.Next.Prev = n;
                    head = n;
                }
                Count++;
            }
            else
            {
                Node p = head;

                for (int i = 0; i < index; i++)
                {
                    p = p.Next;
                }

                n.Next = p;
                n.Prev = p.Prev;
                p.Prev.Next = n;
                p.Prev = n;

                Count++;
            }
        }

        public override string ToString()
        {
            string v = "";
            Node Pegepind;
            Pegepind = head;

            for (int i = 0; i < Count; i++)
            {
                v += Pegepind.Data.ToString() + "\n";
                Pegepind = Pegepind.Next;
            }

            return v;
        }

        public void Delete()
        {
            Delete(0);
        }
        public void Delete(int index)
        {
            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            Node pegepind;
            
            if(index == 0)
            {
                pegepind = head.Next;
                head = pegepind;
                Count--;
            }
            else
            {
                pegepind = head;
                Node previous;
                for (int i = 0; i < index; i++)
                {
                    previous = pegepind;
                    pegepind = pegepind.Next;
                }

                previous = pegepind.Next;
                pegepind.Next = null;
                count--;
            } 
        }
        
        public object ItemAt(int index)
        {
            Node Pegepind;
            Pegepind = head;
            object v = Pegepind.Data;          
            for (int i = 0; i < index; i++)
            {
                Pegepind = Pegepind.Next;
                v = Pegepind.Data;                               
            }          
            
            return v;
        }

        public void Rervers()
        {
            /*
             *Virker, kopi data på index o, sæt ind på Count, altså efter sidste element i listen, og slet index 0
            for (int i = 0; i < Count; i++)
            {
                Insert(head.Data, Count - i);
                Delete();
            }
            */
            Node newHead;
            Node newTail;



        }

        public void Swap(int v)
        {
            throw new NotImplementedException();
        }

        public string FremTilbage()
        {
            throw new NotImplementedException();
        }
    }
    class Node
    {
        private object data;
        private Node next;
        private Node prev;
        public object Data
        {
            get => data;
            set { data = value; }
        }
        public Node Next
        {
            get => next;
            set { next = value; }
        }

        public Node Prev
        {
            get => prev;
            set { prev = value; }
        }

    }
}
