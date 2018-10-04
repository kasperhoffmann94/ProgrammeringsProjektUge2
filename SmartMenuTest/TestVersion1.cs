using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartMenuLibrary;

namespace SmartMenuTest
{
    [TestClass]
    public class TestVersion1
    {
        SmartMenu menu;

        [TestInitialize]
        public void TestInitialize()
        {
            menu = new SmartMenu();
            menu.LoadMenu("MenuSpec.txt");
        }

            [TestMethod]
        public void TestTitle()
        {
            Assert.AreEqual("Beregningsalgoritmer", menu.GetTitle());
        }

            [TestMethod]
        public void TestDescribtion()
        {
            Assert.AreEqual("Tast nummer for menupunkt eller 0 for at afslutte", menu.GetDescription());
        }

            [TestMethod]
        public void testMenuDimensions()
        {
            string[,] menuPoints = menu.GetMenu();
            Assert.AreEqual(4, menuPoints.GetLength(0));
            Assert.AreEqual(2, menuPoints.GetLength(1));
        }

            [TestMethod]
        public void testMenuNames()
        {
            string[,] menuPoints = menu.GetMenu();

            Assert.AreEqual("Beregn rektanglets areal", menuPoints[0,0]);
            Assert.AreEqual("Indlæs talserie", menuPoints[1, 0]);
            Assert.AreEqual("Beregn polyline længde", menuPoints[2, 0]);
            Assert.AreEqual("Livets mening?", menuPoints[3, 0]);
        }

        [TestMethod]
        public void testMenuId()
        {
            string[,] menuPoints = menu.GetMenu();

            Assert.AreEqual("this", menuPoints[0, 1]);
            Assert.AreEqual("that", menuPoints[1, 1]);
            Assert.AreEqual("something", menuPoints[2, 1]);
            Assert.AreEqual("another", menuPoints[3, 1]);
        }

    }
}

