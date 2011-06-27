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

namespace Client.Models
{
    public class TaskHeader
    {
        #region Properties

        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int TaskId { get; set; }
        public string UserName { get; set; }

        #endregion
    }
}