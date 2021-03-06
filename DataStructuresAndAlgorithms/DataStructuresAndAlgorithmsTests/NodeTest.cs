﻿using System;
using DataStructuresAndAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlgorithmsTests
{
    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        public void Constructor()
        {
            var node = new Node<int>(2);

            Assert.AreEqual(2, node.Data);
        }

        [TestMethod]
        public void NextProperty()
        {
            var node = new Node<int>(3);
            var nextNode = new Node<int>(6);

            node.Next = nextNode;

            Assert.AreEqual(nextNode, node.Next);
        }

        [TestMethod]
        public void PreviousProperty()
        {
            var node = new Node<int>(4);
            var prevNode = new Node<int>(67);

            node.Previous = prevNode;

            Assert.AreEqual(prevNode, node.Previous);
        }

        [TestMethod]
        public void DataProperty()
        {
            var node = new Node<int>(5);

            node.Data = 9001;

            Assert.AreEqual(9001, node.Data);
        }
    }
}
