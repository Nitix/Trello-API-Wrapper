using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trello_API_Wrapper.Utils
{
    /// <summary>
    /// LazyList is a list that is Lazy. It will search items only when needed.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LazyList<T> : IList<T>
    {
        private List<T> Values;

        private ILazyLoader<T> Loader;

        private int Range;

        public LazyList(ILazyLoader<T> loader, int range)
        {
            Loader = loader;
            Values = new List<T>();
            Range = range;
        }

        public LazyList(ILazyLoader<T> loader, int range, int capacity)
        {
            Loader = loader;
            Values = new List<T>(capacity);
            Range = range;
        }

        public T this[int index]
        {
            get
            {
                try
                {
                    return Values.ElementAt(index);
                }
                catch { }
                int start = index % Range * Range;
                Values.InsertRange(start, Loader.Retrieve(start, Range));
                return Values.ElementAt(index);
            }

            set
            {
                throw new ReadOnlyListException();
            }
        }

        /// <summary>
        /// Return the current loaded item in the list
        /// </summary>
        public int Count
        {
            get
            {
                return Values.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return true;
            }
        }

        public void Add(T item)
        {
            throw new ReadOnlyListException();
        }

        public void Clear()
        {
            throw new ReadOnlyListException();
        }

        /// <summary>
        /// Check if the parameter is in the list. This will not trigger the lazy loading.
        /// It will only check if the item is already loaded
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            return Values.Contains(item);
        }

        /// <summary>
        /// Copy the current loaded items to array
        /// Keep in mind this can take times if the list is huge
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Values.GetEnumerator();
        }

        /// <summary>
        /// Search the index of the given object
        /// Search only on loaded items
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOf(T item)
        {
            return Values.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            throw new ReadOnlyListException();
        }

        public bool Remove(T item)
        {
            throw new ReadOnlyListException();
        }

        public void RemoveAt(int index)
        {
            throw new ReadOnlyListException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Values.GetEnumerator();
        }
    }
}
