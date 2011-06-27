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

using System.Collections.Generic;
using Client.Models;

namespace Client.Controllers
{
    internal class TaskHeaderController
    {
        #region Properties

        public List<TaskHeader> CurrentTasks { get; set; }

        #endregion

        #region public

        /// <summary>
        /// Filter a list of task headers by userName and return only the task 
        /// where the start date is more than a week old.
        /// </summary>
        /// <param name="tasks"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public List<TaskHeader> GetOverdueUserTasks(List<TaskHeader> tasks, string userName)
        {
            return null;
        }

        /// <summary>
        /// Load the list of tasks from a sql server database.
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public List<TaskHeader> LoadFromDatabase(string connectionString)
        {
            return null;
        }

        /// <summary>
        /// Load the list of tasks from the flat file format.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<TaskHeader> LoadFromFile(string fileName)
        {
            return null;
        }

        #endregion
    }
}