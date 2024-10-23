using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02;


namespace _04
{
    public static class ExClass
    {
        public static T[] GetArray<T>(this IEnumerable list)
        {


            int Count = 0;
            foreach(var item in list)
                Count++;
            // або
            // 
            // ICollection col = list as ICollection;
            // Count = col.Count;

            // або 
            // Count = (list as MyList<T>).Count

            T[] arr = new T[Count];

            int i = 0;
            foreach (var item in list)
                arr[i++] = (T)item;

            return arr;
        }
    }

    internal class Program
    {

        
        

        static void Main(string[] args)
        {


            MyList<string> myList = new MyList<string>();
            myList.Add("zero");
            myList.Add("one");
            myList.Add("two");
            myList.Add("three");

            string[] arr = myList.GetArray<string>();



            foreach (var item in arr)
                Console.WriteLine(item);








            int[] a = { 1, 2, 3 };
            int[] arr1 = a.GetArray<int>();


            MyList<B> l1 = new MyList<B>();
            l1.Add(new B());
            l1.Add(new B());
            l1.Add(new B());
            l1.Add(new B());

            A[] arr2 = l1.GetArray<A>();

            Console.ReadKey();
        }
        class A
        { }
        class B : A { }
    }
}
