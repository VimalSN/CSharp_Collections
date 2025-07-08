using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Collections
{
    public class ArrayListExample
    {
        public void Ex_ArrayList()
        {
            ArrayList list = new ArrayList(); 
            list.Add(1);
            list.Add("Eric");
            list.Add(900.890);
            list.Add('C');
            list.Add(8900.78f);

            //foreach (var item in list)
            //    Console.WriteLine(item);
            IEnumerator enumerator = list.GetEnumerator();
            while (enumerator.MoveNext()) {  Console.WriteLine(enumerator.Current); }
            int res = list.Capacity;
            Console.WriteLine(res);
        }
        public void Ex_SortedList()
        {
            SortedList list = new SortedList();
            list.Add("1", 9000);
            list.Add("2", "Rajesh");
            list.Add("3", 789089.90);
            list.Add("4", 'C');

            /*list[0] = 78900;
            list[1] = "PPPP";
            list[2] = 67890.900;*/
            var r2 = list.GetKeyList();
            foreach (var item in list.Values)
                Console.WriteLine(item.ToString());

        }
        public void Ex_HashTable()
        {
            Hashtable ht = new Hashtable(5);
            ht.Add("1", "PPPP");
            ht.Add("2", 8900);
            ht.Add("3", 78900.90);
            ht.Add("4", 'C');
            ht.Add("5", 89789.90f);
            foreach (var item in ht.Values)
                Console.WriteLine(item.ToString());
        }
        public void Ex_StringCollections()
        {
            StringCollection str1 = new StringCollection();
            str1.Add("PPPP");
            str1.Add("uer");
            str1.Add("fghh");
            foreach (var str in str1)
                Console.WriteLine(str);
        }
        public void Ex_Stack()
        {
            Stack stack = new Stack();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            foreach (var r1 in stack)
                Console.WriteLine(r1);
            stack.Pop();
        }
        public void Ex_Queue()
        {
            Queue queue = new Queue();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            foreach (var r1 in queue)
                Console.WriteLine(r1);

            queue.Dequeue();
        }
    }
}
