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

    [TestClass]
    public class TestLinkedList
    {
        LinkedList<int> linkedList;
        
        [TestInitialize]
        public void Initialization()
        {
            linkedList = new LinkedList<int>();
            linkedList.PushBack(56);
            linkedList.PushBack(30);
            linkedList.PushBack(70);
        }

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
    }
}
