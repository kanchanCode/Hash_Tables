using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hash_Tables
{
    public class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public object linkedList { get; private set; }

        //public int Count { get; internal set; }
        //public virtual int Count { get; }


        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int getArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }

            }
            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        public void Remove(K key)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }

                if (itemFound)
                {
                    linkedList.Remove(foundItem);
                }
            
        }

        /* public string occurence(string x)
         {
             string frequency = items.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count()).ToString();

             return frequency; 
         }*/

        /*public void frequency(V value)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkList = GetLinkedList(position);
            string[] myArr = new string[size];
            linkedList.CopyTo(myArr, 0);
            LinkedList.Enumerator.to
            foreach (string str in myArr)
            {
                Console.WriteLine(str);
            }
        }*/

    protected LinkedList<KeyValue<K, V>>GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        
    }
    public struct KeyValue<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }


    

    
}


