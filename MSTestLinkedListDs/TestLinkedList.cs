// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestLinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------

namespace MSTestLinkedListDs
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using LinkedListDS;

    /// <summary>
    /// Class to test various function LinkedList
    /// </summary>
    [TestClass]
    public class TestLinkedList
    {
        /// <summary>
        /// The linked list
        /// </summary>
        LinkedList<int> linkedList;

        /// <summary>
        /// This method will run first of all
        /// </summary>
        [TestInitialize]
        public void Initialization()
        {
            linkedList = new LinkedList<int>();
            linkedList.PushBack(56);
            linkedList.PushBack(30);
            linkedList.PushBack(70);
        }

        /// <summary>
        /// Tests the Search method.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="expected">The expected.</param>
        [DataRow(56,0)]
        [DataRow(30, 1)]
        [DataRow(70, 2)]
        [DataRow(50, -1)]
        [TestMethod]
        public void TestSearchMethod(int data, int expected)
        {
            //arrange
            //act
            int actual = linkedList.Search(data);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataRow(40,2)]
        [TestMethod]
        public void TestPushAtIndex(int data, int expected)
        {
            //Arrange
            linkedList.PushAtIndex(2, data);
            //Act
            int actual = linkedList.Search(data);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
