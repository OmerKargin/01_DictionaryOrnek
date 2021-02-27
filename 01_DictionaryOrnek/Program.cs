using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DictionaryOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burada eklemerli yapıp for döngüsü ile döndürdük
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(101, "Engin");
            ogrenciler.Add(102, "Ufuk");
            ogrenciler.Add(103, "Üzeyir");
            ogrenciler.Add(104, "Halit");
            ogrenciler.Add(105, "Duygu");

            for (int i = 0; i < ogrenciler.Count(); i++)
            {
                Console.WriteLine(ogrenciler.keys[i] + " " + ogrenciler.values[i]);
            }


            Console.WriteLine("Öğrenci sayısı :" + ogrenciler.Count());

            Console.ReadKey();
        }
    }

    class MyDictionary<TKey, TValue>
    {//Key ve value dizileri oluşturduk
        public TKey[] keys;
        public TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }


        public void Add(TKey key, TValue value)
        {
            TKey[] tempArray1 = keys;
            TValue[] tempArray2 = values;

            keys = new TKey[keys.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i];
            }

            keys[keys.Length - 1] = key;

            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempArray2.Length; i++)
            {
                values[i] = tempArray2[i];
            }
            values[values.Length - 1] = value;
        }

        public int Count()
        {
            return keys.Length;
        }



    }
}
