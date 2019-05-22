using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_HashTable_Get_Clear_LoadFactor
{
    class HashTable<TKey, TValue>
    {
        private LinkedList<HashTableItem<TKey, TValue>>[] _array;
        private int _capacity;
        private int _size;
        private const double LOAD_FACTOR = 0.75;

        public HashTable (int size)
        {
            _capacity = size;
            _array = new LinkedList<HashTableItem<TKey, TValue>>[_capacity];
        }

        private int hash (TKey key)
        {
            return Math.Abs(key.GetHashCode()) % _capacity;

            //  или использовать любой другой подход
            // return ((Math.Abs(key.GetHashCode()) << 5) + 13) % _size;
            // return (int)Math.Floor(((Math.Abs(key.GetHashCode()) * 0.13) % 1) * _size);
        }

        private double getLoadFactor ()
        {
            return _size / _capacity;
        }

        private void Resize ()
        {
            _capacity = _capacity * 2;
            var oldArr = _array;
            _size = 0;
            _array = new LinkedList<HashTableItem<TKey, TValue>>[_capacity];

            foreach (var item in oldArr)
            {
                if (item != null)
                {
                    foreach (var pair in item)
                    {
                        if (pair != null)
                            this.Add(pair.Key, pair.Value);
                    }
                }
            }
        }

        public void Add (TKey key, TValue val)
        {
            if (getLoadFactor() >= LOAD_FACTOR)
            {
                this.Resize();
            }


            int index = hash(key);

            if (_array[index] == null)
            {
                _array[index] = new LinkedList<HashTableItem<TKey, TValue>>();
            }

            var hashTableItem = new HashTableItem<TKey, TValue>(key, val);

            var listNode = new LinkedListNode<HashTableItem<TKey, TValue>>(hashTableItem);

            _array[index].AddFirst(listNode);

            _size++;
        }

        public bool Remove (TKey key)
        {
            int index = hash(key);
            if (_array[index] == null)
                return false;

            foreach (var item in _array[index])
            {
                if (item.Key.Equals(key))
                {
                    _array[index].Remove(item);
                    break;
                }
            }
            return true;
        }

        public TValue GetValue (TKey key)
        {
            int index = hash(key);

            if (_array[index] == null)
                return default(TValue);

            foreach (var item in _array[index])
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(TValue);
        }

        public void Clear ()
        {
            _size = 0;
            _array = new LinkedList<HashTableItem<TKey, TValue>>[_capacity];
        }
    }
}
