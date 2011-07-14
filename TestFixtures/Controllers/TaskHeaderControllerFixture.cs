#region Copyright © 2010, Blue Dot Solutions

// *********************************************************************
// 
// Copyright © 2010, Blue Dot Solutions and/or its affiliates 
// and subsidiaries.  All rights reserved.
// www.bluedotsolutions.com
//       
// Blue Dot Solutions has intellectual property rights relating  
// to technology embodied in this product. In particular, and 
// without limitation, these intellectual property rights may 
// include one or more of U.S. patents or pending patent applications
// in the U.S. and/or other countries.
//      
// This product is distributed under licenses restricting its use, 
// copying, distribution, and decompilation. No part of this product 
// may be reproduced in any form by any means without prior written 
// authorization of Blue Dot Solutions.
//       
// Blue Dot, mNOW!, mNOW! Mobile Framework, mCORE!, mfLY!,
// mCORE! Command Center, mCORE! Communication Agent, mCORE! 
// Communication Server, and mCORE! Integration Engine are trademarks of 
// Blue Dot Solutions.
//  
// *********************************************************************

#endregion

using System;
using System.Collections.Generic;
using Client.Controllers;
using Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFixtures.Controllers
{
    /// <summary>
    /// Summary description for TaskHeaderControllerFixture
    /// </summary>
    [TestClass]
    public class TaskHeaderControllerFixture
    {
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

        #region Tests

        [TestMethod]
        public void CanGetOverdueUserTasks()
        {
            var list = new List<TaskHeader>
                           {
                               new TaskHeader {TaskId = 1, Description = "Test1", StartDate = DateTime.Today, UserName = "ME"},
                               new TaskHeader {TaskId = 2, Description = "Test2", StartDate = DateTime.Today.AddDays(5), UserName = "ME"},
                               new TaskHeader {TaskId = 3, Description = "Test3", StartDate = DateTime.Today.AddDays(-7), UserName = "YOU"},
                               new TaskHeader {TaskId = 4, Description = "Test4", StartDate = DateTime.Today.AddDays(-10), UserName = "HER"},
                               new TaskHeader {TaskId = 5, Description = "Test5", StartDate = DateTime.Today.AddDays(-10), UserName = "YOU"},
                           };

            var c = new TaskHeaderController();
            var result = c.GetOverdueUserTasks(list, "YOU");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(5, result[0].TaskId);
        }

        [TestMethod]
        public void CanGetOverdueUserTasksForNullList()
        {
            var c = new TaskHeaderController();
            var result = c.GetOverdueUserTasks(null, "YOU");
            Assert.IsNotNull(result);
        }

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }
    }
}