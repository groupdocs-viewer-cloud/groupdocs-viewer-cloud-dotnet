// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WebDocumentOptions.cs">
//  Copyright (c) Aspose Pty Ltd
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
    /// This rendering options enables you to customize the appearance of the output HTML/PDF/PNG/JPEG when rendering Web documents.
    /// </summary>  
    public class WebDocumentOptions 
    {                       
        /// <summary>
        /// The size of the output page. The default value is GroupDocs.Viewer.Options.PageSize.Letter 792 x 612 points. When contents does not fit set a larger page size e.g. GroupDocs.Viewer.Options.PageSize.A3.             
        /// </summary>
        /// <value>The size of the output page. The default value is GroupDocs.Viewer.Options.PageSize.Letter 792 x 612 points. When contents does not fit set a larger page size e.g. GroupDocs.Viewer.Options.PageSize.A3.             </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageSizeEnum
        { 
            /// <summary>
            /// Enum Unspecified for "Unspecified"
            /// </summary>            
            Unspecified,
            
            /// <summary>
            /// Enum Letter for "Letter"
            /// </summary>            
            Letter,
            
            /// <summary>
            /// Enum Ledger for "Ledger"
            /// </summary>            
            Ledger,
            
            /// <summary>
            /// Enum A0 for "A0"
            /// </summary>            
            A0,
            
            /// <summary>
            /// Enum A1 for "A1"
            /// </summary>            
            A1,
            
            /// <summary>
            /// Enum A2 for "A2"
            /// </summary>            
            A2,
            
            /// <summary>
            /// Enum A3 for "A3"
            /// </summary>            
            A3,
            
            /// <summary>
            /// Enum A4 for "A4"
            /// </summary>            
            A4            
        }

        /// <summary>
        /// The size of the output page. The default value is GroupDocs.Viewer.Options.PageSize.Letter 792 x 612 points. When contents does not fit set a larger page size e.g. GroupDocs.Viewer.Options.PageSize.A3.             
        /// </summary>
        public PageSizeEnum? PageSize { get; set; }

        /// <summary>
        /// The distance (in points) between the left edge of the page and the left boundary  of the body text. The default value is 5 points.
        /// </summary>  
        public double? LeftMargin { get; set; }

        /// <summary>
        /// The distance (in points) between the right edge of the page and the right boundary of the body text. The default value is 5 points.
        /// </summary>  
        public double? RightMargin { get; set; }

        /// <summary>
        /// The distance (in points) between the top edge of the page and the top boundary of the body text. The default value is 72 points.
        /// </summary>  
        public double? TopMargin { get; set; }

        /// <summary>
        /// The distance (in points) between the bottom edge of the page and the bottom boundary of the body text. The default value is 72 points.
        /// </summary>  
        public double? BottomMargin { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WebDocumentOptions {\n");
          sb.Append("  PageSize: ").Append(this.PageSize).Append("\n");
          sb.Append("  LeftMargin: ").Append(this.LeftMargin).Append("\n");
          sb.Append("  RightMargin: ").Append(this.RightMargin).Append("\n");
          sb.Append("  TopMargin: ").Append(this.TopMargin).Append("\n");
          sb.Append("  BottomMargin: ").Append(this.BottomMargin).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
