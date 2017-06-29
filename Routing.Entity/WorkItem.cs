/* 
 * Programmer: Baran Topal                   *
 * Solution name: Some.Routing               *
 * Folder name: com.some.Routing             *
 * Project name: Routing.Entity              *
 * File name: WorkItem.cs                    *
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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace Routing.Entity
{
    public class WorkItem
    {
        private string alphanumeric;
        private Operator moperator = new Operator();
        private List<Dictionary<int, float>> list = new List<Dictionary<int, float>>();
        private Dictionary<int, float> dictionary;

        // List of matching pattern per operator
        private List<Operator> operatorList = new List<Operator>();

        /// <summary>
        /// Strip out the alpha characters and join the numerical values into one string
        /// </summary>

        public string Alphanumeric
        {
            get
            {
                return alphanumeric;
            }
            set
            {
                alphanumeric = value;
            }
        }

        public string Joined
        {
            get
            {
                // Strip out the alpha characters and join the numerical values into one string
                { return Regex.Replace(alphanumeric, "[+-]", ""); }
            }
        }

        /// <summary>
        /// Read one line at a time, explode the line content, and add to the dictionary
        /// </summary>
        /// <param name="filePath"></param>
        public bool Read(string filePath)
        {
            using (var sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // First line will be the operator and it will fall into exception to create a dictionary and populate a list with dictionary
                    // Algorithm-wise approach, single round of reading the file and adding into the dictionary
                    try
                    {
                        {
                            // Splitting line into atoms where the first atom represents prefix, and second atom represents a operator numerical code
                            string[] atoms = line.Split(' ');

                            moperator.Prefix = Int32.Parse(atoms[0]);
                            moperator.Price = Convert.ToSingle(atoms[1]);
                            dictionary.Add(moperator.Prefix, moperator.Price);
                        }
                    }
                    catch (FormatException e)
                    {
                        // A disputable and deliberate hack to read the file and population once without if checks for everyline, let the run-time handle fixes the check.
                        dictionary = new Dictionary<int, float>();
                        list.Add(dictionary);
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                        return false;
                    }
                }
                sr.Close();
                return true;
            }
        }


        /// <summary>
        /// Gets the occurence of a pattern which is an input, and a target string where it has the origin from the file
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="targetString"></param>
        /// <returns>Arraylist of occurence storing each character, stringbuilder can also be used</returns>
        public List<char> GetOccurence(string pattern, string targetString)
        {
            // Arraylist storing the matched value
            var result = new List<char>();            

            // Keeps track of the pattern index
            int k = 0;

            // The key value in the file
            char[] targetArray = targetString.ToCharArray();

            // The input value that user inputted
            char[] patternArray = pattern.ToCharArray();

            // Iterate over user input
            for (var i = 0; i < patternArray.Length; i++)
            {
                // If there is a match
                if (targetArray[i] == patternArray[k])
                {
                    // Move the pattern index by one
                    k++;
                    result.Add(targetArray[i]);

                    // Check whether it's end of the target string
                    if (i == targetArray.Length - 1)
                    {

                        // Return the matched string
                        return result;
                    }
                }
                // Before, partial match but after, consecutive non match, break since it's unnecesary to check the rest
                else break;
            }
            // No match at all
            return null;
        }

        /// <summary>
        /// Search function to find out the occurence
        /// </summary>
        /// <returns>List of operators having the match or non-match</returns>
        public void Search()
        {
            // Nullify the Operator object since it has the last values of dictionary
            // We will store the matching value in it
            moperator = null;

            //ASCII 'A' character value
            const int t = 'A';

            // String array changed to integer array via LINQ query
            var intArray = Joined.Cast<int>();

            // ArrayList to store the occurence
            List<char> store;

            // Max length of the matched string
            string max = "";

            //Placeholder for price due to TryGetValue out restriction
            float price = 0.0F;

            //Iterate over the list denoting the operator letters, A, B...
            for (int m = 0; m < list.Count; m++)
            {
                //Iterate over the dictionary
                for (int i = 0; i < list[m].Count; i++)
                {
                    int k = list[m].ElementAt(i).Key;
                    string key = k.ToString(CultureInfo.InvariantCulture);

                    // Get the occurence
                    store = GetOccurence(Joined, key);

                    // If there is a occurence
                    if (store != null)
                    {
                        // Check for the maximality of the occurence
                        if (key.Length > max.Length)
                        {
                            // Assign the key to max
                            max = key;

                            // Get the value of the corresponding key which ought to be the max value
                            list[m].TryGetValue(Int32.Parse(max), out price);
                        }
                    }
                }
                // If there is a max value
                if (max != "")
                {
                    // Create the Operator object
                    moperator = new Operator();

                    // Assign the Prefix and Price for Operator object
                    moperator.Prefix = Int32.Parse(max);
                    moperator.Price = price;

                    // Assign the Operator Letter 
                    // t is the initial value which is 65 which is 'A'
                    // Add the list iteration to find the letter
                    moperator.OperatorLetter = (char)(t + m);
                    // Assign max to empty string for the incoming iteration
                    max = "";
                }
                // Add the Operator Object to operator list whether it is null or not.
                operatorList.Add(moperator);
            }
        }

        /// <summary>
        /// Display all results
        /// </summary>
        public void DisplayAll()
        {
            // Variable to hold the character letter
            int i = 0;

            // For each operator in the list
            foreach (var op in operatorList)
            {
                // If the operator is null
                if (operatorList == null)
                    // Add i + integer representation of A which is 65 as value
                    // Cannot use the Operator object's OperatorLetter member variable since Operator object is null
                    Console.WriteLine("Operator " + (char)(i + 65) + " has no deal");
                else
                {
                    // Output down the cheapest deal for the closest and longest match
                    Console.WriteLine("Operator " + op.OperatorLetter + " having prefix: " + op.Prefix + " has the cheapest deal which is as: " + op.Price);
                }
            }
        }

        /// <summary>
        /// Display cheapest result
        /// </summary>
        public void DisplayCheapest()
        {
            // Find the cheapest deal
            var cheapest = operatorList[0].Price;
            var index = 0;
            for (var j = 1; j < operatorList.Count; j++)
            {
                float tempPrice = operatorList[j].Price;
                if (tempPrice < cheapest)
                {
                    cheapest = tempPrice;
                    index = j;
                }
            }

            Console.WriteLine("Operator " + operatorList[index].OperatorLetter + " has the cheapest deal as: prefix, " + operatorList[index].Prefix + " and price, " + operatorList[index].Price);

            #region oneliner LINQ query

            /*
            //This one liner also finds out the cheapest deal
            var cheapestResult = operatorList.FirstOrDefault(arg => arg.Price == operatorList.Min(arg1 => arg1.Price));
            Console.WriteLine("One Liner -> Operator " + cheapestResult.OperatorLetter + " has the cheapest deal as: prefix, " + cheapestResult.Prefix + " and price, " + cheapestResult.Price);
            */

            #endregion oneliner
        }
    }
}
