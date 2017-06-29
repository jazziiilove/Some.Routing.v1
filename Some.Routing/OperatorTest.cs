/* 
 * * * * * * * * * * * * * * * * * * * * * * *
 * Company: Xylem                            *            
 * Assignment: Routing Search                *
 * Deadline: -                               *
 * Programmer: Baran Topal                   *
 * Solution name: Xylem.Routing              *
 * Folder name: com.xylem.Routing            *
 * Project name: Routing.Test                *
 * File name: OperatorTest.cs                *
 *                                           *      
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 *	                                                                                         *
 *  LICENSE: This source file is subject to have the protection of GNU General               *
 *	Public License. You can distribute the code freely but storing this license information. *
 *	Contact Baran Topal if you have any questions. barantopal@barantopal.com                 *
 *	                                                                                         *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Routing.Entity;

namespace Routing.Test
{
    /// <summary>
    /// This is a test class for OperatorTest and is intended
    /// to contain all the OperatorTest for unit tests
    /// </summary>
    [TestClass]
    public class OperatorTest
    {
        public OperatorTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /// <summary>
        /// Setting prefix with 0 by Operator default constructor
        /// </summary>
        [TestMethod]
        public void Set_Prefix_With_0_By_Constructor()
        {
            // Arrange
            int prefix = 0;
            float price = 0.0F;

            // target operator object
            Operator target = new Operator();
            target.Prefix = prefix;
            target.Price = price;
            // Actual
            var actual = target.Prefix;

            // Assert
            Assert.AreEqual(prefix, actual);
        }

        /// <summary>
        /// Setting prefix with 1 by Operator default constructor
        /// </summary>
        [TestMethod]
        public void Set_Prefix_With_1_By_Constructor()
        {
            // Arrange
            int prefix = 0;
            float price = 0.0F;

            // target operator object
            Operator target = new Operator();
            target.Prefix = prefix;
            target.Price = price;

            // Actual
            var actual = target.Prefix;

            // Assert
            Assert.AreEqual(prefix, actual);

        }

        /// <summary>
        /// Setting prefix with -1 by Operator default constructor
        /// </summary>
        [TestMethod]
        public void Set_Prefix_With_Negative_By_Constructor()
        {
            // Arrange
            int prefix = -1;
            float price = 0.0F;

            // target operator object
            Operator target = new Operator();
            target.Prefix = prefix;
            target.Price = price;

            // Actual
            var actual = target.Prefix;

            // Assert
            Assert.AreEqual(prefix, actual);

        }

        /// <summary>
        /// Setting prefix with Uzbekistan => 998 by Operator default constructor
        /// </summary>
        [TestMethod]
        public void Set_Prefix_With_Boundary_By_Constructor()
        {
            // Arrange
            int prefix = 998; //Uzbekistan
            float price = 0.0F;

            // target operator object
            Operator target = new Operator();
            target.Prefix = prefix;
            target.Price = price;

            // Actual
            var actual = target.Prefix;

            // Assert
            Assert.AreEqual(prefix, actual);
        }

        /// <summary>
        /// Setting prefix with Kyrgyzstan => 996 by Operator default constructor
        /// </summary>
        [TestMethod]
        public void Set_Price_Prefix_With_Boundary_1_By_Constructor()
        {
            // Arrange
            int prefix = 996; //Kyrgyzstan
            float price = 0.0F;

            // target operator object
            Operator target = new Operator();
            target.Prefix = prefix;
            target.Price = price;

            // Actual
            var actual = target.Prefix;

            // Assert
            Assert.AreEqual(prefix, actual);
        }
    }
}
