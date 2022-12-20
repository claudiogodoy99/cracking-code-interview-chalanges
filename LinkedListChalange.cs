
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

            HashSet<int> set = new HashSet<int>();

            var current = first;
            var prev = first;

            while (current != null)
            {
                if (set.Contains(current.val))
                {
                    removeNode();
                }
                else set.Add(current.val);

                prev = current; 
                current = current.next;
            }

            #region 
            void removeNode() {
                prev.next = current.next;
            }
            #endregion
        }

        public static node AddTwoNumber(node fisrt,node second) { 
        
            Stack<int> stack_f = new Stack<int>();
            Stack<int> stack_s = new Stack<int>();

            node n = new node(0);


            while (fisrt != null)
            {
                stack_f.Push(fisrt.val);
                fisrt = fisrt.next;
            }

            while (second != null)
            {
                stack_s.Push(second.val);
                second = second.next;
            }

            while (stack_f.Any() || stack_s.Any())
            {
                int a =0;
                int b =0;
                if (stack_f.Any()) { 
                    a = stack_f.Pop();
                }

                if (stack_s.Any())
                {
                    b = stack_s.Pop();
                }


                //entender melhor como funciona essa soma e o sentido do carry 
                int total = a + b;

                n.val = total;

                n = n.next;

            }
        }
      
    }
}
