// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace LinkedListDS
{
    using System;

    /// <summary>
    /// Program class contains Main function
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.PushInAscendingOrder(56);
            linkedList.Traverse();
            linkedList.PushInAscendingOrder(30);
            linkedList.Traverse();
            linkedList.PushInAscendingOrder(40);
            linkedList.Traverse();
            linkedList.PushInAscendingOrder(70);
            linkedList.Traverse();
            linkedList.PushInAscendingOrder(32);
            linkedList.Traverse();
        }
    }
}
