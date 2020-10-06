using System;

namespace StackArray
{
    // 'Spec'
    // -------
    //
    // Implement a stack based on array. The stack should have a maximum size that the can optionally be provided when construction
    // (with a reasonable default size being used if none is provided). The stack should provide the following methods -
    // Push - push an element onto the stack.Throws an exception of type StackException if the operation would overflow the stack
    // Pop - pop an element from the stack. Throws an exception of type StackException if the operation would underflow the stack
    // Peek - gets (but does not remove) the element at the top of the stack.Throws an exception of type StackException if the stack is empty
    // IsEmpty – indicates whether or not the stack is empty

    /// <summary>
    /// The exception type thrown by the Stack class
    /// </summary>
    public class StackException : Exception
    {
        public StackException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// A Stack implementation
    /// </summary>
    public class Stack<T>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capacity"></param>
        public Stack(int capacity = 1000)
        {
            m_stack = new T[capacity];
            m_top = -1;
        }

        /// <summary>
        /// Is the stack empty?
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return m_top <= 0;
        }

        /// <summary>
        /// Push a value onto the stack
        /// </summary>
        public void Push(T data)
        {
            if (m_top > m_stack.Length)
            {
                throw new StackException("Stack overflow");
            }

            m_stack[m_top++] = data;
        }

        /// <summary>
        /// Pop a value off the stack
        /// </summary>  
        public T Pop()
        {
            if (m_top < 0)
            {
                throw new Exception("Stack underflow");
            }

            return m_stack[m_top--];
        }

        /// <summary>
        /// Peek the value at the top of the stack
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
           return m_stack[m_top--];
        }

        private int m_top;
        private readonly T[] m_stack;

    }
}


