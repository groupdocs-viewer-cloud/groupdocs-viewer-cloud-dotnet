// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfOptions.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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
        /// The password required to open the PDF document
        /// </summary>  
        public string DocumentOpenPassword { get; set; }

        /// <summary>
        /// The password required to change permission settings; Using a permissions password  you can restrict printing, modification and data extraction
        /// </summary>  
        public string PermissionsPassword { get; set; }

        /// <summary>
        /// The array of PDF document permissions. Allowed values are: AllowAll, DenyPrinting, DenyModification, DenyDataExtraction, DenyAll Default value is AllowAll, if now permissions are set.
        /// </summary>  
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Contains options for rendering documents into PDF format.
        /// </summary>  
        public PdfOptimizationOptions PdfOptimizationOptions { get; set; }

        /// <summary>
        /// Max width of an output image in pixels. (When converting single image to HTML only)
        /// </summary>  
        public int? ImageMaxWidth { get; set; }

        /// <summary>
        /// Max height of an output image in pixels. (When converting single image to HTML only)
        /// </summary>  
        public int? ImageMaxHeight { get; set; }

        /// <summary>
        /// The width of the output image in pixels. (When converting single image to HTML only)
        /// </summary>  
        public int? ImageWidth { get; set; }

        /// <summary>
        /// The height of an output image in pixels. (When converting single image to HTML only)
        /// </summary>  
        public int? ImageHeight { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfOptions {\n");
          sb.Append("  DocumentOpenPassword: ").Append(this.DocumentOpenPassword).Append("\n");
          sb.Append("  PermissionsPassword: ").Append(this.PermissionsPassword).Append("\n");
          sb.Append("  Permissions: ").Append(this.Permissions).Append("\n");
          sb.Append("  PdfOptimizationOptions: ").Append(this.PdfOptimizationOptions).Append("\n");
          sb.Append("  ImageMaxWidth: ").Append(this.ImageMaxWidth).Append("\n");
          sb.Append("  ImageMaxHeight: ").Append(this.ImageMaxHeight).Append("\n");
          sb.Append("  ImageWidth: ").Append(this.ImageWidth).Append("\n");
          sb.Append("  ImageHeight: ").Append(this.ImageHeight).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
