using System;
using System.Collections.Generic;
using System.Collections;
namespace PracticeDec18_2PM
{
    internal class Program
    {
        static void jaggedArray()
        {
            Console.WriteLine("Enter number of arrays");
            int n=Convert.ToInt32(Console.ReadLine());  
            int[][] arr= new int[n][];
            for(int i=0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter number of elements in {i+1} array");
                int el=Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[el];
                for(int j=0; j < el; j++)
                {
                    arr[i][j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void multiArray()
        {
            Console.WriteLine("Enter the number of rows and columns");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n1, n2];

            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The elements of the array are:");

            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                
            }
        }
        static void ArrayListEx()
        {
            ArrayList x = new ArrayList();
            while (true)
            {
                
                string input = Console.ReadLine();

                if (input.Equals(""))
                {
                    break;
                }
                else
                {
                    /* if (int.TryParse(input, out int number))
                     {
                         x.Add(number);
                     }
                     else
                     {
                         break;
                     }*/
                    x.Add(input);
                }
            }

            Console.WriteLine("Elements in the ArrayList:");
            foreach (var element in x)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(x.Count);
        }
        static void sortedlist()
        {
            SortedList sl = new SortedList();
            sl.Add(1, "suresh");
            sl.Add(3, "Ramesh");
            sl.Add(2, "Naresh");
            sl.Add(6, "abc");
            sl.Add(7, "ABC");

            foreach (DictionaryEntry i in sl)
            {
                Console.WriteLine(i.Key+" "+i.Value);
            }
        }
    static void hashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "dog");
            ht.Add(2, "cat");
            ICollection collection = ht.Keys;
       
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine( "Key "+ de.Key+" value "+ de.Value);
                
            }
            Console.WriteLine(ht.ContainsKey(1));
            Console.WriteLine(ht.ContainsValue("cat"));
        }
        static void stack()
        {
            Stack st=new Stack();
            st.Push(1);
            st.Push(2); 
            st.Push(3);
            Console.WriteLine("original stack");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("pop element\n"+st.Pop());
            Console.WriteLine("\nafter pop");
            foreach (var item2 in st)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("peek element is " +st.Peek());
        }
        static void ListWGenaric()
        {
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(2);
            li.Add(3);

        }
        static void quee()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
        }
        static void Main(string[] args)
        {
            // multiArray();
            //ArrayListEx();
            //hashTable();
            //sortedlist();
            //stack();
            //quee();
            jaggedArray();


        }
    }
}
