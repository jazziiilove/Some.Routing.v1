/* 
 * Programmer: Baran Topal                   *
 * Solution name: Some.Routing               *
 * Folder name: com.some.Routing             *
 * Project name: Routing.Entity              *
 * File name: Operator.cs                    *
 *                                           *      
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 *	                                                                                         *
 *  LICENSE: This source file is subject to have the protection of GNU General               *
 *	Public License. You can distribute the code freely but storing this license information. *
 *	Contact Baran Topal if you have any questions. barantopal@barantopal.com                 *
 *	                                                                                         *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */

//entity to store prefix and price in an operator

namespace Routing.Entity
{
    /// <summary>
    /// Operator class to store prefix, price member variables
    /// </summary>
    public class Operator
    {
        #region member variables

        /// <summary>
        /// variable storing prefix
        /// </summary>
        private int prefix;

        /// <summary>
        /// variable storing price
        /// </summary>
        private float price;

        /// <summary>
        /// variable storing operator letter
        /// </summary>
        private char operatorLetter;

        #endregion member variables

        #region accessors


        /// <summary>
        /// accessor Prefix to reach private variable prefix
        /// </summary>
        public int Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }

        /// <summary>
        /// accessor Price to reach private variable price
        /// </summary>
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// accessor OperatorLetter to reach private operatorLetter
        /// </summary>
        public char OperatorLetter
        {
            get { return operatorLetter; }
            set { operatorLetter = value; }
        }

        #endregion accessors

        #region constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public Operator()
        { }

        #endregion constructors
    }
}
