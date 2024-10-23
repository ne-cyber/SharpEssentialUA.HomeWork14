using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {

        class MyDictionary<TKey, TValue> : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < array.Length; i++)
                    yield return array[i].key + " ---- " + array[i].value;
                yield break;
            }

            struct Entry
            {
                public TKey key;
                public TValue value;
            }

            public MyDictionary()
            {
                array = new Entry[0];
            }

            private Entry[] array;

            public int Add(TKey key, TValue value)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = new Entry() { key = key, value = value};
                return array.Length - 1;
            }
            public TValue this[int index]
            {
                get
                {
                    if (index >= 0 && index <= array.Length - 1)
                        return array[index].value;
                    else
                        throw new Exception("Index out of array");
                }
                set
                {
                    if (index >= 0 && index <= array.Length - 1)
                        array[index].value = value;
                    else
                        throw new Exception("Index out of array");
                }
            }
            //public TValue this[string index]
            //{
            //    get
            //    {
            //        if (index >= 0 && index <= array.Length - 1)
            //            return array[index].value;
            //        else
            //            throw new Exception("Index out of array");
            //    }
            //    set
            //    {
            //        if (index >= 0 && index <= array.Length - 1)
            //            array[index].value = value;
            //        else
            //            throw new Exception("Index out of array");
            //    }
            //}
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


        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(0, "zero");
            myDictionary.Add(1, "one");
            myDictionary.Add(2, "two");
            myDictionary.Add(3, "three");

            foreach(string a in myDictionary)
                Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
