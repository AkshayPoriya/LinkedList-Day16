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
            linkedList.PushAtIndex(2, 40);
        }

        /// <summary>
        /// Tests the Search method.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="expected">The expected.</param>
        [DataRow(56,0)]
        [DataRow(30, 1)]
        [DataRow(70, 3)]
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

        /// <summary>
        /// Tests the PushAtIndex function.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="expected">The expected.</param>
        [DataRow(56, 0)]
        [DataRow(30, 1)]
        [DataRow(40, 2)]
        [DataRow(70, 3)]
        [DataRow(50, -1)]
        [TestMethod]
        public void TestPushAtIndex(int data, int expected)
        {
            //Arrange
            //Act
            int actual = linkedList.Search(data);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests the PopFromGivenIndex method.
        /// </summary>
        [TestMethod]
        public void TestPopFromGivenIndex()
        {
            //arrange
            linkedList.PopFromGivenIndex(2);
            //act
            int actual1 = linkedList.Search(56);
            int expected1 = 0;
            int actual2 = linkedList.Search(30);
            int expected2 = 1;
            int actual3 = linkedList.Search(40);
            int expected3 = -1;
            int actual4 = linkedList.Search(70);
            int expected4 = 2;
            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }
    }
}
