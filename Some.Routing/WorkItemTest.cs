/* 
 * * * * * * * * * * * * * * * * * * * * * * *
 * Company: Xylem                            *            
 * Assignment: Routing Search                *
 * Deadline: Today                           *
 * Programmer: Baran Topal                   *
 * Solution name: Xylem.Routing              *
 * Folder name: com.xylem.Routing            *
 * Project name: Routing.Test                *
 * File name: WorkItemTest.cs                *
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
using System.IO;
using System.Diagnostics;

namespace Routing.Test
{
    /// <summary>
    /// This is a test class for WorkItemTest and is intended
    /// to contain all the WorkItemTest for unit tests
    /// </summary>
    [TestClass]
    public class WorkItemTest
    {
        public WorkItemTest()
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
        /// Setting alphanumeric input with "" by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Empty()
        {
            // Arrange
            var alphanumeric = "";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = alphanumeric;

            // Assert
            Assert.AreEqual(alphanumeric, target.Alphanumeric);
        }

        /// <summary>
        /// Setting alphanumeric input with "a" by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_One_Alpha()
        {
            // Arrange
            var alpha = "a";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = alpha;

            // Assert
            Assert.AreEqual(alpha, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with 1 by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_One_Numeric()
        {
            // Arrange
            var numeric = "1";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = numeric;

            // Assert
            Assert.AreEqual(numeric, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with _ delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_One_Delimiter()
        {
            // Arrange
            var delimiter = "-";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = delimiter;

            // Assert
            Assert.AreEqual(delimiter, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with +_ delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Two_Delimiters1()
        {
            // Arrange
            var delimiters = "+-";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = delimiters;

            // Assert
            Assert.AreEqual(delimiters, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with _+ delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Two_Delimiters2()
        {
            // Arrange
            var delimiters = "-+";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = delimiters;

            // Assert
            Assert.AreEqual(delimiters, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with -- delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Two_Delimiters_Diff()
        {
            // Arrange
            var delimiters = "--";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = delimiters;

            // Assert
            Assert.AreEqual(delimiters, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with 1- delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Delimiter_With_One_Numeric()
        {
            // Arrange
            var numericWithDelim = "1-";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = numericWithDelim;

            // Assert
            Assert.AreEqual(numericWithDelim, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with 1-- delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Two_Delimiter_With_One_Numeric1()
        {
            // Arrange
            var numericWithDelim = "1--";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = numericWithDelim;

            // Assert
            Assert.AreEqual(numericWithDelim, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with -1- delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Two_Delimiter_With_One_Numeric2()
        {
            // Arrange
            var numericWithDelim = "-1-";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = numericWithDelim;

            // Assert
            Assert.AreEqual(numericWithDelim, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with --1 delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Two_Delimiter_With_One_Numeric3()
        {
            // Arrange
            var numericWithDelim = "--1";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = numericWithDelim;

            // Assert
            Assert.AreEqual(numericWithDelim, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with 12- delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Delimiter_Two_Numerics()
        {
            // Arrange
            var numericsWithDelim = "12-";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = numericsWithDelim;

            // Assert
            Assert.AreEqual(numericsWithDelim, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with 12-+ delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Two_Delims_Two_Numerics1()
        {
            // Arrange
            var numericsWithDelims = "12-+";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = numericsWithDelims;

            // Assert
            Assert.AreEqual(numericsWithDelims, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with 1-2+ delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Two_Delims_Two_Numerics2()
        {
            // Arrange
            var numericsWithDelims = "1-2+";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = numericsWithDelims;

            // Assert
            Assert.AreEqual(numericsWithDelims, target.Alphanumeric);
        }

        /// <summary>
        /// Setting numeric input with 1-+2 delimiter by WorkItem default constructor
        /// </summary>
        [TestMethod]
        public void WorkItem_Constructor_Sets_Two_Delims_Two_Numerics3()
        {
            // Arrange
            var numericsWithDelims = "1-+2";

            // Actual
            var target = new WorkItem();
            target.Alphanumeric = numericsWithDelims;

            // Assert
            Assert.AreEqual(numericsWithDelims, target.Alphanumeric);
        }

        /// <summary>
        /// Reading the file by giving the path (valid path)
        /// </summary>
        [TestMethod]
        public void CanRead_Path()
        {
            // Arrange
            string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\List.txt"));
            var target = new WorkItem();
            var expected = true;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Actual
            var actual = target.Read(path);

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Reading the single block file by giving the path (valid path)
        /// </summary>
        [TestMethod]
        public void CanRead_PartialListTextFile1()
        {
            // Arrange
            string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Xylem.Routing\TestFiles\PartialList1.txt"));

            var target = new WorkItem();
            var expected = true;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Actual
            var actual = target.Read(path);

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Reading the single block with one alpha line by giving the path (valid path)
        /// </summary>
        [TestMethod]
        public void CanRead_PartialListTextFile2()
        {
            // Arrange
            string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Xylem.Routing\TestFiles\PartialList2.txt"));

            var target = new WorkItem();
            var expected = true;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Actual
            var actual = target.Read(path);

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Reading the multi block file by giving the path (valid path)
        /// </summary>
        [TestMethod]
        public void CanRead_PartialListTextFile3()
        {
            // Arrange
            string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Xylem.Routing\TestFiles\PartialList3.txt"));

            var target = new WorkItem();
            var expected = true;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Actual
            var actual = target.Read(path);

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Reading the file by giving the path (non-matching path)
        /// </summary>
        [TestMethod]
        public void CannotRead_NoTextFile()
        {
            // Arrange
            var target = new WorkItem();
            var expected = false;
            var actual = false;
            try
            {
                // Actual
                actual = target.Read(@"D:\List.txt");
            }
            // Assert
            catch (Exception ex) { Assert.AreEqual(expected, actual); }
        }

        /// <summary>
        /// Reading the empty file
        /// </summary>
        [TestMethod]
        public void CanRead_EmptyTextFile()
        {
            // Arrange
            string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Xylem.Routing\TestFiles\ListEmpty.txt"));
            var target = new WorkItem();
            var expected = false;

            // Actual
            var actual = target.Read(path);

            // Assert
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// Reading the gibberish file
        /// </summary>
        [TestMethod]
        public void CannotRead_Gibberish()
        {
            // Arrange
            string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Xylem.Routing\TestFiles\ListGibberish.txt"));
            var target = new WorkItem();
            var expected = true;

            // Actual
            var actual = target.Read(path);

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Join the empty alphanumeric
        /// </summary>
        [TestMethod]
        public void CanJoin_Empty()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "";
            var expected = "";

            // Actual
            var actual = target.Joined;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Join the one alpha
        /// </summary>
        [TestMethod]
        public void CanJoin_OneAlpha()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "a";
            var expected = "a";

            // Actual
            var actual = target.Joined;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Join the one delimiter
        /// </summary>
        [TestMethod]
        public void CanJoin_OneDelim()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "+";
            var expected = "";

            // Actual
            var actual = target.Joined;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Join one delimiter and one alpha
        /// </summary>
        [TestMethod]
        public void CanJoin_OneDelimOneAlpha()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "+a";
            var expected = "a";

            // Actual
            var actual = target.Joined;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Join one numerical
        /// </summary>
        [TestMethod]
        public void CanJoin_OneNumeric()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "1";
            var expected = "1";

            // Actual
            var actual = target.Joined;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Join one delimiter and one numeric
        /// </summary>
        [TestMethod]
        public void CanJoin_OneDelimOneNumeric()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "+1";
            var expected = "1";

            // Actual
            var actual = target.Joined;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Join one delimiter and two numerics
        /// </summary>
        [TestMethod]
        public void CanJoin_OneDelimTwoNumeric()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "+12";
            var expected = "12";

            // Actual
            var actual = target.Joined;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Join two numerics
        /// </summary>
        [TestMethod]
        public void CanJoin_TwoNumeric()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "12";
            var expected = "12";

            // Actual
            var actual = target.Joined;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Join two delimiters and one numeric
        /// </summary>
        [TestMethod]
        public void CanJoin_TwoDelims_OneNumeric()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "+-1";
            var expected = "1";

            // Actual
            var actual = target.Joined;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Join a non alpha with numerics
        /// </summary>
        [TestMethod]
        public void CannotJoin_NonAlpha()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "1/2";
            var expected = "1/2";

            // Actual
            var actual = target.Joined;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Get Occurence of empty string, prefix => 1
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_Empty1()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "";

            Operator op = new Operator();
            op.Prefix = 1;
            op.Price = 1.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(target.Alphanumeric, op.Prefix + "\t" + op.Price);

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");
            // Assert
            Assert.IsNull(expected);
        }

        /// <summary>
        /// Get Occurence of empty string, prefix => 0
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_Empty2()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "";

            Operator op = new Operator();
            op.Prefix = 0;
            op.Price = 1.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(target.Alphanumeric, op.Prefix + "\t" + op.Price);

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNull(expected);
        }

        /// <summary>
        /// Get Occurence of 0 value string, prefix => 0
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_AlphaZeroMatch()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "0";

            Operator op = new Operator();
            op.Prefix = 0;
            op.Price = 1.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");
            var expected = target.GetOccurence(target.Alphanumeric, op.Prefix + "\t" + op.Price);

            // Assert
            Assert.IsNull(expected);
        }

        /// <summary>
        /// Get Occurence of 1 value string, prefix => 1
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_AlphaOneMatch()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "1";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 1;
            op.Price = 1.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNotNull(expected);
        }

        /// <summary>
        /// /// Get Occurence of perfect no match, single alpha
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_NoMatchAtAll1()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "0";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 1;
            op.Price = 1.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNull(expected);
        }

        /// <summary>
        /// Get Occurence of perfect no match, multi alpha
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_NoMatchAtAll2()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "52";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 1;
            op.Price = 1.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNull(expected);
        }

        /// <summary>
        /// Get Occurence, Partial matching discard
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_PartialMatch_Discard()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "+46-73-212345";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 4620; //Discarding due to consecutive non-match
            op.Price = 0.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNull(expected);
        }

        /// <summary>
        /// Get Occurence, Perfect Match
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_Perfect_Match()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "+46-73-2";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 46732;
            op.Price = 0.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNotNull(expected);
        }

        /// <summary>
        /// Get Occurence, Perfect Match, long limitation
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_Perfect_Match_Long_Limit()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "+46-73-212345";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = unchecked((int)4673212345);
            op.Price = 0.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNull(expected);
        }

        /// <summary>
        /// Get occurence perfect match
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_ExampleData()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "+46-73-212345";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 4673;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNotNull(expected);
        }

        /// <summary>
        /// Get Occurence multi match
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_MultiMatch()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "+46-73-212345";
            string joined = target.Joined;
            Operator op1 = new Operator();
            op1.Prefix = 46; // Discarding due to shortest match

            Operator op2 = new Operator();
            op2.Prefix = 46732;

            List<string> list = new List<string>();
            list.Add(op1.Prefix.ToString());
            list.Add(op2.Prefix.ToString());

            int i = 0;
            bool flag = true;
            List<char> tempList = null;
            var expected = tempList;
            foreach (string s in list)
            {
                if (target.Joined.Substring(0, list[0].Length) == list[i])
                    flag = true;
                else flag = false;
            }

            if (flag)
                if (op1.Prefix.ToString().Length < op2.Prefix.ToString().Length)
                {
                    // Timer starts
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();

                    expected = target.GetOccurence(target.Joined, op2.Prefix + "");

                    //Timer stops
                    stopwatch.Stop();
                    double s = stopwatch.Elapsed.TotalMilliseconds;

                    Console.WriteLine("The search found execution takes for " + s + " milliseconds");
                }

            // Assert
            Assert.IsNotNull(expected);
        }

        /// <summary>
        /// Integer upper bound: 2,147,483,647 exceed partial match discard
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_InputUpBoundaryExceedIntegerPartialMatchDiscard()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "2147483648";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 2120; //Discarding due to consecutive non-match
            op.Price = 0.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNull(expected);
        }

        /// <summary>
        /// Integer upper bound: 2,147,483,647 exceed longest match
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_InputUpBoundaryExceedIntegerLongestMatch()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "2147483648";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 2147;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNotNull(expected);
        }

        /// <summary>
        /// Integer upper bound: 2,147,483,647 exceed partial multi match
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_InputUpBoundaryExceedIntegerMultiMatch()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "2147483648";
            string joined = target.Joined;
            Operator op1 = new Operator();
            op1.Prefix = 21; // Discarding due to shortest match

            Operator op2 = new Operator();
            op2.Prefix = 21474;

            List<string> list = new List<string>();
            list.Add(op1.Prefix.ToString());
            list.Add(op2.Prefix.ToString());

            int i = 0;
            bool flag = true;
            List<char> tempList = null;
            var expected = tempList;
            foreach (string s in list)
            {
                if (target.Joined.Substring(0, list[0].Length) == list[i])
                    flag = true;
                else flag = false;
            }

            if (flag)
                if (op1.Prefix.ToString().Length < op2.Prefix.ToString().Length)
                {
                    // Timer starts
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();

                    expected = target.GetOccurence(target.Joined, op2.Prefix + "");

                    //Timer stops
                    stopwatch.Stop();
                    double s = stopwatch.Elapsed.TotalMilliseconds;

                    Console.WriteLine("The search found execution takes for " + s + " milliseconds");
                }

            // Assert
            Assert.IsNotNull(expected);
        }

        /// <summary>
        /// Integer upper bound: 2,147,483,647 exceed partial no match
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_InputUpBoundaryExceedIntegerNoMatch()
        {
            // Arrange
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "2147483648";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 1;
            op.Price = 1.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNull(expected);
        }

        /// <summary>
        /// Integer lower bound: -2,147,483,648 exceed no match
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_InputLowBoundaryExceedIntegerNoMatch()
        {
            // Arrange
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "-2147483649";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 1;
            op.Price = 1.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNull(expected);
        }

        /// <summary>
        /// Integer lower bound: -2,147,483,648 exceed partial match discard
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_InputLowBoundaryExceedIntegerPartialMatchDiscard()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "-2147483649";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 2120; //Discarding due to consecutive non-match
            op.Price = 0.0F;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNull(expected);
        }

        /// <summary>
        /// Integer lower bound: -2,147,483,648 exceed longest match
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_InputLowBoundaryExceedIntegerLongestMatch()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "-2147483649";
            string joined = target.Joined;

            Operator op = new Operator();
            op.Prefix = 2147;

            // Timer starts
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var expected = target.GetOccurence(joined, op.Prefix + "");

            //Timer stops
            stopwatch.Stop();
            double s = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine("The search found execution takes for " + s + " milliseconds");

            // Assert
            Assert.IsNotNull(expected);
        }

        /// <summary>
        /// Integer lower bound: -2,147,483,648 exceed multi match
        /// </summary>
        [TestMethod]
        public void CanGetOccurence_InputLowBoundaryExceedIntegerMultiMatch()
        {
            // Arrange
            var target = new WorkItem();
            target.Alphanumeric = "-2147483649";
            string joined = target.Joined;
            Operator op1 = new Operator();
            op1.Prefix = 21; // Discarding due to shortest match

            Operator op2 = new Operator();
            op2.Prefix = 21474;

            List<string> list = new List<string>();
            list.Add(op1.Prefix.ToString());
            list.Add(op2.Prefix.ToString());

            int i = 0;
            bool flag = true;
            List<char> tempList = null;
            var expected = tempList;
            foreach (string s in list)
            {
                if (target.Joined.Substring(0, list[0].Length) == list[i])
                    flag = true;
                else flag = false;
            }

            if (flag)
                if (op1.Prefix.ToString().Length < op2.Prefix.ToString().Length)
                {
                    // Timer starts
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();

                    expected = target.GetOccurence(target.Joined, op2.Prefix + "");

                    //Timer stops
                    stopwatch.Stop();
                    double s = stopwatch.Elapsed.TotalMilliseconds;

                    Console.WriteLine("The search found execution takes for " + s + " milliseconds");
                }

            // Assert
            Assert.IsNotNull(expected);
        }
    }
}
