/* 
 * Programmer: Baran Topal                   *
 * Solution name: Some.Routing              *
 * Folder name: com.some.Routing            *
 * Project name: Routing.Application         *
 * File name: Program.cs                     *
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
using Routing.Entity;

namespace Routing.Application
{
    /// <summary>
    /// Program to access main gate
    /// </summary>
    class Program
    {
        #region methods

        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args">No command line argument is expected</param>
        static void Main(string[] args)
        {

            // Enter the alphanumeric characters
            // E.g. +46-73-212345
            Console.WriteLine("Enter the alphanumeric characters: ");

            // Create WorkItem object and pass it to its constructor
            WorkItem workItem = new WorkItem();
            workItem.Alphanumeric = Console.ReadLine();

            // Pass the file string to ReadAdd function
            // e.g. C:\Users\Baran\Documents\visual studio 2010\Projects\Some.Routing\List.txt
            //workItem.Read(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\List.txt")));
            workItem.Read("List.txt");

            // Search content
            workItem.Search();

            // Display all results
            workItem.DisplayAll();

            // Display cheapest result
            workItem.DisplayCheapest();
        }
        #endregion methods
    }
}
