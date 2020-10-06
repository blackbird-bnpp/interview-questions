using System;

namespace NotifyingList
{
    /// <summary>
    /// A notifying List implementation
    /// </summary>
    public class SimpleNotifyingList1 <T> : SimpleList<T>
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
        public new void Add(T item)
        {
            base.Add(item);
            Updated?.Invoke(this, new UpdatedEventArgs(UpdatedEventArgs.ActionEnum.Add));
        }

        /// <summary>
        /// Removes the first instance of item from the list
        /// </summary>
        /// <returns>
        /// True if the item was successfully remove from the list, false otherwise
        /// </returns>
        public new bool Remove(T item)
        {
            var removed = base.Remove(item);
            Updated?.Invoke(this, new UpdatedEventArgs(UpdatedEventArgs.ActionEnum.Remove));
            return removed;
        }

        /// <summary>
        /// Clear the contents of the list
        /// </summary>
        public new void Clear()
        {
            base.Clear();
            Updated?.Invoke(this, new UpdatedEventArgs(UpdatedEventArgs.ActionEnum.Clear));
        }

        #endregion
    }
}
