namespace NotifyingList
{
    /// <summary>
    /// A simple list that supports adding, removing and clearing items
    /// </summary>
    public interface ISimpleList<T>
    {
        /// <summary>
        /// Add an item to the end of the list
        /// </summary>
        void Add(T item);

        /// <summary>
        /// Removes the first instance of item from the list
        /// </summary>
        /// <returns>
        /// True if the item was successfully remove from the list, false otherwise
        /// </returns>
        bool Remove(T item);

        /// <summary>
        /// Clear the contents of the list
        /// </summary>
        void Clear();

        /// <summary>
        /// Determines whether the list contains the given value
        /// </summary>
        bool Contains(T item);

        /// <summary>
        /// The number of elements in contained in the list
        /// </summary>
        int Count { get; }

    }
}
