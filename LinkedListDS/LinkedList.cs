// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya "/>
// --------------------------------------------------------------------------------------------------------------------
namespace LinkedListDS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// LinkedList Class
    /// </summary>
    /// <typeparam name="T"> Generic Type</typeparam>
    public class LinkedList<T>
    {
        /// <summary>
        /// The head Node
        /// </summary>
        public Node<T> head;

        /// <summary>
        /// The tail Node
        /// </summary>
        public Node<T> tail;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList{T}"/> class.
        /// </summary>
        public LinkedList()
        {
            this.head = null;
            this.tail = this.head;
        }

        /// <summary>
        /// Adds the Node.
        /// </summary>
        /// <param name="data">The data.</param>
        public void PushBack(T data)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(data);
                this.tail = this.head;
                return;
            }

            Node<T> temp = new Node<T>(data);
            this.tail.next = temp;
            this.tail = temp;
        }

        public void PushFront(T data)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(data);
                this.tail = this.head;
                return;
            }

            Node<T> temp = new Node<T>(data);
            temp.next = this.head;
            this.head = temp;
        }
        /// <summary>
        /// Traverses this instance.
        /// </summary>
        public void Traverse()
        {
            Node<T> temp = this.head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

            Console.WriteLine();
        }
    }
}
