using System;
using System.Collections;


namespace Collection.Collection
{

    public class UserCollection : IEnumerable, IEnumerator, IDisposable
    {
        readonly Element[] elements = new Element[4];

        public Element this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        int position = -1;


        bool IEnumerator.MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }


        object IEnumerator.Current
        {
            get { return elements[position]; }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }


        void IEnumerator.Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            ((IEnumerator)this).Reset();
        }
    }
}
