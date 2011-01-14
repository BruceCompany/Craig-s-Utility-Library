﻿/*
Copyright (c) 2011 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings
using System.Collections.Generic;
using System.Text;
#endregion

namespace Utilities.Cisco
{
    /// <summary>
    /// Execute class
    /// </summary>
    public class Execute
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Execute()
        {
            ExecuteItems = new List<ExecuteItem>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Execute items
        /// </summary>
        public List<ExecuteItem> ExecuteItems { get; set; }

        #endregion

        #region Overridden Functions

        public override string ToString()
        {
            StringBuilder Builder = new StringBuilder();
            Builder.Append("<CiscoIPPhoneExecute>");
            foreach (ExecuteItem Item in ExecuteItems)
            {
                Builder.Append(Item.ToString());
            }
            Builder.Append("</CiscoIPPhoneExecute>");
            return Builder.ToString();
        }

        #endregion
    }
}