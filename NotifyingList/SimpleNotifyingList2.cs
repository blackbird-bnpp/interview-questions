using System;

namespace NotifyingList
{
    /// <summary>
    /// A different notifying list implementation
    /// </summary>
    public class SimpleNotifyingList2<T> : ISimpleList<T>
    {
        #region Events

        /// <summary>
        /// Event that is raised when the list is updated
        /// </summary>
        public event EventHandler<UpdatedEventArgs> Updated;

        #endregion

        #region SimpleList Implementation

        /// <summary>
        /// Add an item to the end of the list
        /// </summary>
        public void Add(T item)
        {
            m_simpleList.Add(item);
            Updated?.Invoke(this, new UpdatedEventArgs(UpdatedEventArgs.ActionEnum.Add));
        }

        /// <summary>
        /// Removes the first instance of item from the list
        /// </summary>
        /// <returns>
        /// True if the item was successfully remove from the list, false otherwise
        /// </returns>
        public bool Remove(T item)
        {
            var removed = m_simpleList.Remove(item);
            Updated?.Invoke(this, new UpdatedEventArgs(UpdatedEventArgs.ActionEnum.Remove));
            return removed;
        }

        /// <summary>
        /// Clear the contents of the list
        /// </summary>
        public void Clear()
        {
            m_simpleList.Clear();
            Updated?.Invoke(this, new UpdatedEventArgs(UpdatedEventArgs.ActionEnum.Add));
        }

        /// <summary>
        /// Determines whether the list contains the given value
        /// </summary>
        public bool Contains(T item)
        {
            return m_simpleList.Contains(item);
        }

        /// <summary>
        /// The number of elements in contained in the list
        /// </summary>
        public int Count => m_simpleList.Count;

        #endregion

        private readonly SimpleList<T> m_simpleList = new SimpleList<T>();

    }
}
