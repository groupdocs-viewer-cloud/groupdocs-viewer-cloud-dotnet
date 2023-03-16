// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="InfoResult.cs">
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
    /// View result information
    /// </summary>  
    public class InfoResult 
    {                       
        /// <summary>
        /// File format extension
        /// </summary>  
        public string FormatExtension { get; set; }

        /// <summary>
        /// File format
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// View result pages
        /// </summary>  
        public List<PageInfo> Pages { get; set; }

        /// <summary>
        /// Attachments
        /// </summary>  
        public List<AttachmentInfo> Attachments { get; set; }

        /// <summary>
        /// Represents view information for archive file
        /// </summary>  
        public ArchiveViewInfo ArchiveViewInfo { get; set; }

        /// <summary>
        /// Represents view information for CAD drawing
        /// </summary>  
        public CadViewInfo CadViewInfo { get; set; }

        /// <summary>
        /// Represents view information for MS Project document
        /// </summary>  
        public ProjectManagementViewInfo ProjectManagementViewInfo { get; set; }

        /// <summary>
        /// Represents view information for Outlook Data file
        /// </summary>  
        public OutlookViewInfo OutlookViewInfo { get; set; }

        /// <summary>
        /// Represents view information for PDF document
        /// </summary>  
        public PdfViewInfo PdfViewInfo { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class InfoResult {\n");
          sb.Append("  FormatExtension: ").Append(this.FormatExtension).Append("\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  Pages: ").Append(this.Pages).Append("\n");
          sb.Append("  Attachments: ").Append(this.Attachments).Append("\n");
          sb.Append("  ArchiveViewInfo: ").Append(this.ArchiveViewInfo).Append("\n");
          sb.Append("  CadViewInfo: ").Append(this.CadViewInfo).Append("\n");
          sb.Append("  ProjectManagementViewInfo: ").Append(this.ProjectManagementViewInfo).Append("\n");
          sb.Append("  OutlookViewInfo: ").Append(this.OutlookViewInfo).Append("\n");
          sb.Append("  PdfViewInfo: ").Append(this.PdfViewInfo).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
