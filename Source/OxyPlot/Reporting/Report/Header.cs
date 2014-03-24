﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Header.cs" company="OxyPlot">
//   The MIT License (MIT)
//   
//   Copyright (c) 2014 OxyPlot contributors
//   
//   Permission is hereby granted, free of charge, to any person obtaining a
//   copy of this software and associated documentation files (the
//   "Software"), to deal in the Software without restriction, including
//   without limitation the rights to use, copy, modify, merge, publish,
//   distribute, sublicense, and/or sell copies of the Software, and to
//   permit persons to whom the Software is furnished to do so, subject to
//   the following conditions:
//   
//   The above copyright notice and this permission notice shall be included
//   in all copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
//   OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//   MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
//   IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
//   CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//   SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary>
//   Represents a header.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot.Reporting
{
    /// <summary>
    /// Represents a header.
    /// </summary>
    public class Header : ReportItem
    {
        /// <summary>
        /// Gets or sets the chapter number(s).
        /// </summary>
        public string Chapter { get; set; }

        /// <summary>
        /// Gets or sets the level of the header (1-5).
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the header text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Returns a string that represents the header.
        /// </summary>
        /// <returns>
        /// A string that represents the header.
        /// </returns>
        public override string ToString()
        {
            string h = string.Empty;
            if (this.Chapter != null)
            {
                h += this.Chapter + " ";
            }

            h += this.Text;
            return h;
        }

        /// <summary>
        /// The write content.
        /// </summary>
        /// <param name="w">
        /// The w.
        /// </param>
        public override void WriteContent(IReportWriter w)
        {
            w.WriteHeader(this);
        }
    }
}