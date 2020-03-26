// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfOptions.cs">
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
    /// Options for rendering document into PDF
    /// </summary>  
    public class PdfOptions : RenderOptions 
    {                       
        /// <summary>
        /// The PDF document permissions such as printing, modification and data extraction
        /// </summary>
        /// <value>The PDF document permissions such as printing, modification and data extraction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionsEnum
        { 
            /// <summary>
            /// Enum AllowAll for "AllowAll"
            /// </summary>            
            AllowAll,
            
            /// <summary>
            /// Enum DenyPrinting for "DenyPrinting"
            /// </summary>            
            DenyPrinting,
            
            /// <summary>
            /// Enum DenyModification for "DenyModification"
            /// </summary>            
            DenyModification,
            
            /// <summary>
            /// Enum DenyDataExtraction for "DenyDataExtraction"
            /// </summary>            
            DenyDataExtraction,
            
            /// <summary>
            /// Enum DenyAll for "DenyAll"
            /// </summary>            
            DenyAll            
        }

        /// <summary>
        /// The PDF document permissions such as printing, modification and data extraction
        /// </summary>
        public PermissionsEnum? Permissions { get; set; }

        /// <summary>
        /// The quality of the JPG images contained by output PDF document; Valid values are between 1 and 100; Default value is 90
        /// </summary>  
        public int? JpgQuality { get; set; }

        /// <summary>
        /// The password required to open the PDF document
        /// </summary>  
        public string DocumentOpenPassword { get; set; }

        /// <summary>
        /// The password required to change permission settings; Using a permissions password  you can restrict printing, modification and data extraction
        /// </summary>  
        public string PermissionsPassword { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfOptions {\n");
          sb.Append("  JpgQuality: ").Append(this.JpgQuality).Append("\n");
          sb.Append("  DocumentOpenPassword: ").Append(this.DocumentOpenPassword).Append("\n");
          sb.Append("  PermissionsPassword: ").Append(this.PermissionsPassword).Append("\n");
          sb.Append("  Permissions: ").Append(this.Permissions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
