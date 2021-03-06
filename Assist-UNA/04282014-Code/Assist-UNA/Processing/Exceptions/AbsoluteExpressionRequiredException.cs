﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************************************************
 * 
 * Name: AbsoluteExpressionRequiredException
 * 
 * ================================================================================================
 * 
 * Description: This class is an exception handler for illegal constant types.
 *                       
 * ================================================================================================        
 * 
 * Modification History
 * --------------------
 * 04/27/2014   THH     Original version.
 *                       
 *************************************************************************************************/

namespace Assist_UNA
{
    class AbsoluteExpressionRequiredException : Exception
    {

        /* Public methods. */

        /******************************************************************************************
         * 
         * Name:        AbsoluteExpressionRequiredException        
         * 
         * Author(s):   Travis Hunt     
         *              
         * Input:       N/A   
         * Return:      N/A
         * Description: The default constructor.
         *              
         *****************************************************************************************/
        public AbsoluteExpressionRequiredException() : base() { }

        /******************************************************************************************
         * 
         * Name:        AbsoluteExpressionRequiredException        
         * 
         * Author(s):   Travis Hunt     
         *              
         * Input:       The message to set as string.   
         * Return:      N/A
         * Description: The overloaded constructor that sets the message for the exception.
         *              
         *****************************************************************************************/
        public AbsoluteExpressionRequiredException(string message) : base(message) { }

        /******************************************************************************************
         * 
         * Name:        AbsoluteExpressionRequiredException        
         * 
         * Author(s):   Travis Hunt     
         *              
         * Input:       The message to set as string and the inner exception.   
         * Return:      N/A
         * Description: The overloaded constructor that sets the message for the exception as well
         *              as the inner exception.
         *              
         *****************************************************************************************/
        public AbsoluteExpressionRequiredException(string message, System.Exception inner) : base(message, inner) { }
    }
}
