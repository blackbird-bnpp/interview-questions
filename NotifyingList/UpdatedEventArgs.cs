using System;

namespace NotifyingList
{
    /// <summary>
    /// Event that fires when a notifying list updates
    /// </summary>
    public class UpdatedEventArgs : EventArgs
    {
        /// <summary>
        /// The update action
        /// </summary>
        public enum ActionEnum
        {
            Add,
            Remove,
            Clear
        }

        /// <summary>
        /// Constructor
        /// </summary>
        internal UpdatedEventArgs(ActionEnum action)
        {
            Action = action;
        }

        /// <summary>
        /// The action
        /// </summary>
        public ActionEnum Action { get; }
    }
}
