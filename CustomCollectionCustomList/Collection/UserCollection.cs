using System;
using System.Collections;



namespace Collection
{
    class UserCollection : ICollection
    {
        readonly object syncRoot = new object();

        readonly object[] elements = { 1, 2, 3, 4 };
        
        
        public void CopyTo(Array array, int userArrayIndex)
        {
            var arr = array as object[];

            if (arr == null)
                throw new ArgumentException("Expecting array to be object[]");

            for (int i = 0; i < array.Length; i++)
            {
                arr[userArrayIndex++] = elements[i];
            }
        }

       
        public int Count
        {
            get { return elements.Length; }
        }

       
        public bool IsSynchronized
        {
            get { return true; }
        }

        
        public object SyncRoot
        {
            get { return syncRoot; }
        }

     
        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }
}
