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
            linkedList.Traverse();
            linkedList.PushBack(56);
            linkedList.Traverse();
            linkedList.PushBack(70);
            linkedList.Traverse();
            linkedList.PushAtIndex(1, 30);
            linkedList.Traverse();
        }
    }
}
