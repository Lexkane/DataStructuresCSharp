using System.Collections;



namespace Collection
{
	
	public class UserCollection<T>
	{
	    readonly T[] elements = new T[4];

		public T this[int index]
		{
			get { return elements[index]; }
			set { elements[index] = value; }
		}

		int position = -1;

		
		public void Reset()
		{
			position = -1;
		}

		
		public IEnumerator GetEnumerator()
		{
            while (true)
            {
                if (position < elements.Length - 1)
                {
                    position++;
                    yield return elements[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }

            //foreach (var element in elements)
            //{
            //    yield return element;
            //}

            //return elements.GetEnumerator();
		}
	}
}
