
using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using Microsoft.Diagnostics.Tracing.Parsers.IIS_Trace;
using Microsoft.VisualBasic;
using System.Runtime.Versioning;

namespace data_structures
{

    public static class LinkedListChalange
    {
        
        public class node
        {
            public int val;
            public node next;

            public node(int val) { this.val = val; }
        }

        public static node Particionando(node first, int val) {
            var n = first;

            node head = new node(n.val);
            var top = head;

            n = n.next;

            while (n != null) 
            {
                var newnode = new node(n.val);

                if (n.val <= val)
                {
                    newnode.next = head;
                    head = newnode;
                    
                }
                else if (n.val > val)
                {
                    top.next = newnode;
                    top = top.next;
                }

                n = n.next;
            }

            return head;
        }

        public static void RemoveMidlle(node first) { 
            var minor = first;
            var greather = first.next?.next;
            var prev = first;

            if (greather == null) return;

            while (greather != null) {
                prev = minor;
              
                minor = minor.next;

                greather = greather.next?.next;
            }

            prev.next = minor.next;
        
        }

        public static void RemoveDuplicates(node first) {

            node current = first;
            node previus = first;


            HashSet<int> hash = new HashSet<int>();

            while (current != null)
            {
                if (hash.Contains(current.val))
                {
                    previus.next = current.next;
                }
                else {
                    hash.Add(current.val);
                }

                previus = current;
                current = current.next;
            }
        
        }
      
    }
}
