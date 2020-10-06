using System.Collections.Generic;

namespace NotifyingList
{
    /// <summary>
    /// Simple list implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SimpleList<T> : ISimpleList<T>
    {
        /// <summary>
        /// Add an item to the end of the list
        /// </summary>
        public void Add(T item)
        {
            m_list.Add(item);
        }

        /// <summary>
        /// Removes the first instance of item from the list
        /// </summary>
        /// <returns>
        /// True if the item was successfully remove from the list, false otherwise
        /// </returns>
        public bool Remove(T item)
        {
            return m_list.Remove(item);
        }

        /// <summary>
        /// Clear the contents of the list
        /// </summary>
        public void Clear()
        {
            m_list.Clear();
        }

        /// <summary>
        /// Determines whether the list contains the given value
        /// </summary>
        public bool Contains(T item)
        {
            return m_list.Contains(item);
        }

        /// <summary>
        /// The number of elements in contained in the list
        /// </summary>
        public int Count => m_list.Count;

        private readonly List<T> m_list = new List<T>();
    }
}
