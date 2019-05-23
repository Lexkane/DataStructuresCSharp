using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// ICollection<T> - определяет методы, используемые для управления универсальными коллекциями.

namespace Collection
{
    class UserCollection<T> : ICollection<T>
    {
        T[] elements = new T[0];

        
        public void Add(T item)
        {
            var newArray = new T[elements.Length + 1]; 
            elements.CopyTo(newArray, 0);             
            newArray[newArray.Length - 1] = item;      
            elements = newArray;                       
        }

        
        public void Clear()
        {
            elements = new T[0];
        }

        
        public bool Contains(T item)
        {
            foreach (var element in elements)
            {
                if (element.Equals(item))
                    return true;
            }

            return false; 

           
            return elements.Contains(item);
        }

        
        public void CopyTo(T[] array, int arrayIndex)
        {
            elements.CopyTo(array, arrayIndex);
        }

       
        public int Count
        {
            get { return elements.Length; }
        }

      
        public bool IsReadOnly
        {
            get { return false; }
        }

       
        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>) elements).GetEnumerator();
        }

        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }
    }
}
