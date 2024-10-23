using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{

    public class MyList<T> : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
                yield return array[i];
            yield break;
        }

        public MyList()
        {
            array = new T[0];
        }

        private T[] array;

        public int Add(T value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
            return array.Length - 1;
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index <= array.Length - 1)
                    return array[index];
                else
                    throw new Exception("Index out of array");
            }
            set
            {
                if (index >= 0 && index <= array.Length - 1)
                    array[index] = value;
                else
                    throw new Exception("Index out of array");
            }
        }
        public void Clear()
        {
            Array.Resize(ref array, 0);
        }
        public int Count => array.Length;



        //void Insert(int index, T value)
        //{ }
        //void RemoveAt(int index)
        //{ }
    }


    internal class Program
    {
        

        

        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(100);
            myList.Add(200);
            myList.Add(300);
            myList.Add(400);

            foreach (int a in myList)
                Console.WriteLine(a);

            Console.WriteLine(new string('-', 30));

            foreach (int a in myList)
                Console.WriteLine(a);



            Console.ReadKey();

        }
    }
}
