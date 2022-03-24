using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.CustomArray
{
    public class CustomArray<T> : IEnumerable<T>
    {
        private T[] _customArray;
        public T this[int index]
        {
            get 
            {
                if(index < 0 && index > _customArray.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _customArray[index]; 
            }
            set { _customArray[index] = value; }
        }
        public int Length { get; }

        public CustomArray(int length)
        {
            _customArray = new T[length];
            Length = length;
        }

        public CustomArray() : this(0)
        {
            _customArray = new T[0];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _customArray.Length; i++)
            {
                yield return _customArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < _customArray.Length; i++)
            {
                yield return _customArray[i];
            }
        }
    }
}
