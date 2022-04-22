using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// COLLECTIONS-CLASS-DYNAMIC MEMORY ALLOCATION-GENERIC/NON-GENERIC
    /// GENERIC-System.Collections.Generic;
    /// NON-GENERIC-System.Collections;
    /// COLLECTIONS-DATA STRUCTURE OF AN ARRAY
    /// ArrayList,Hashtable,Stack,Queue,Dictionary etc
    /// </summary>
    internal class Collections
    {
        public static void Main()
        {
            ArrayListDemo();
            ListGenericDemo();
            SortedListDemo();
            StackQueueDemo();
            DictionaryDemo();
            HashtableDemo();
        }
        /// <summary>
        /// ArrayList-Collections-Non-generic
        /// </summary>
        public static void ArrayListDemo()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("John");
            arrayList.Add(2);
            arrayList.Add("Peter");
            arrayList.Add(3.14);
            Console.WriteLine("ARRAYLIST");
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Remove(1);
            Console.WriteLine("ARRAYLIST AFTER REMOVE METHOD");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Clear();
            Console.WriteLine("ARRAYLIST AFTER CLEAR METHOD");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// LIST GENERIC
        /// </summary>

        public static void ListGenericDemo()
        {
            List<int> list= new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine("LIST GENERIC DEMO");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

        }
        /// <summary>
        /// SortedList Generic
        /// </summary>

        public static void SortedListDemo()
        {
            SortedList<int,string> keyValuePairs = new SortedList<int,string>();
            keyValuePairs.Add(1, "John");
            keyValuePairs.Add(5, "Peter");
            keyValuePairs.Add(4, "Paul");
            keyValuePairs.Add(2, "Jancy");
            keyValuePairs.Add(3, "Daisy");
            Console.WriteLine("SORTED LIST");
            foreach(var pair in keyValuePairs)
            {
                Console.WriteLine(pair);
            }
        }
        /// <summary>
        /// Generic Stack and Queue
        /// Stack-LIFO-PUSH-POP-PEEK
        /// Queue-FIFO-ENQUEUE-DEQUEUE-PEEK
        /// </summary>
        public static void StackQueueDemo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("STACK");
            foreach(var i in stack)
            {
                Console.WriteLine(i); //4 3 2 1
            }
            Console.WriteLine("Top element in the stack:{0}", stack.Peek());//4
            stack.Pop();
            Console.WriteLine("STACK AFTER POP");
            foreach (var i in stack)
            {
                Console.WriteLine(i); //3 2 1 
            }
            Console.WriteLine("Top element in the stack:{0}", stack.Peek());//3
        }
        /// <summary>
        /// Dictionary-Generic-keyvaluepair
        /// FASTER THAN HASHTABLE,NON KEY VALUE WHEN REFERRED RAISES AN EXCEPTION
        /// TYPE SAFETY
        /// </summary>
        public static void DictionaryDemo()
        {
            //json-data tranfer
            Dictionary<string,string> dictionary=new Dictionary<string,string>();
            dictionary.Add("in", "India");
            dictionary.Add("us", "United States");
            dictionary.Add("uk", "United Kingdom");
            Console.WriteLine("Keys in the Dictionary");
            var key=new List<string>(dictionary.Keys);
            foreach(var k in key)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Values in the Dictionary");
            var value = new List<string>(dictionary.Values);
            foreach (var v in value)
            {
                Console.WriteLine(v);
            }
            //Console.WriteLine("Non key value:{0}", dictionary["ja"]);

        }
        /// <summary>
        /// HASHTABLE-NON-GENERIC-RANDOM RETRIEVAL
        /// NOT TYPE SPECIFIC-BOXING/UNBOXING-NONKEY VALUE RETURN NULL
        /// </summary>

        public static void HashtableDemo()
        {
            Hashtable hashtable=new Hashtable();
            hashtable.Add(1, "John");
            hashtable.Add(2, "Jancy");
            hashtable.Add("J", "Jamie");
            Console.WriteLine("HASHTABLE");
            ICollection collection = hashtable.Keys;
            foreach(var k in collection)
            {
                Console.WriteLine(hashtable[k]);
            }
            Console.WriteLine("Non-key value:{0}", hashtable[3]);

        }


    }
}
