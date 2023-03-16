// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WordProcessingOptions.cs">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Viewer.Cloud.Sdk.Model 
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// Provides options for rendering word processing documents
    /// </summary>  
    public class WordProcessingOptions 
    {                       
        /// <summary>
        /// Enables tracked changes (revisions) rendering
        /// </summary>  
        public bool? RenderTrackedChanges { get; set; }

        /// <summary>
        /// Left page margin (for HTML rendering only)
        /// </summary>  
        public double? LeftMargin { get; set; }

        /// <summary>
        /// Right page margin (for HTML rendering only)
        /// </summary>  
        public double? RightMargin { get; set; }

        /// <summary>
        /// Top page margin (for HTML rendering only)
        /// </summary>  
        public double? TopMargin { get; set; }

        /// <summary>
        /// Bottom page margin (for HTML rendering only)
        /// </summary>  
        public double? BottomMargin { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WordProcessingOptions {\n");
          sb.Append("  RenderTrackedChanges: ").Append(this.RenderTrackedChanges).Append("\n");
          sb.Append("  LeftMargin: ").Append(this.LeftMargin).Append("\n");
          sb.Append("  RightMargin: ").Append(this.RightMargin).Append("\n");
          sb.Append("  TopMargin: ").Append(this.TopMargin).Append("\n");
          sb.Append("  BottomMargin: ").Append(this.BottomMargin).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
