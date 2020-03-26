// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ViewOptions.cs">
//  Copyright (c) 2003-2020 Aspose Pty Ltd
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
    /// View options
    /// </summary>  
    public class ViewOptions 
    {                       
        /// <summary>
        /// View format (HTML, PNG, JPG, or PDF) Default value is HTML.
        /// </summary>
        /// <value>View format (HTML, PNG, JPG, or PDF) Default value is HTML.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ViewFormatEnum
        { 
            /// <summary>
            /// Enum HTML for "HTML"
            /// </summary>            
            HTML,
            
            /// <summary>
            /// Enum PNG for "PNG"
            /// </summary>            
            PNG,
            
            /// <summary>
            /// Enum JPG for "JPG"
            /// </summary>            
            JPG,
            
            /// <summary>
            /// Enum PDF for "PDF"
            /// </summary>            
            PDF            
        }

        /// <summary>
        /// View format (HTML, PNG, JPG, or PDF) Default value is HTML.
        /// </summary>
        public ViewFormatEnum? ViewFormat { get; set; }

        /// <summary>
        /// File info
        /// </summary>  
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// The output path Default value is 'viewer\\{input file path}_{file extension}\\'
        /// </summary>  
        public string OutputPath { get; set; }

        /// <summary>
        /// The path to directory containing custom fonts in storage
        /// </summary>  
        public string FontsPath { get; set; }

        /// <summary>
        /// Text watermark
        /// </summary>  
        public Watermark Watermark { get; set; }

        /// <summary>
        /// Rendering options
        /// </summary>  
        public RenderOptions RenderOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ViewOptions {\n");
          sb.Append("  FileInfo: ").Append(this.FileInfo).Append("\n");
          sb.Append("  ViewFormat: ").Append(this.ViewFormat).Append("\n");
          sb.Append("  OutputPath: ").Append(this.OutputPath).Append("\n");
          sb.Append("  FontsPath: ").Append(this.FontsPath).Append("\n");
          sb.Append("  Watermark: ").Append(this.Watermark).Append("\n");
          sb.Append("  RenderOptions: ").Append(this.RenderOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
