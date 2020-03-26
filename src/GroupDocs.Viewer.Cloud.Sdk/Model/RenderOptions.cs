// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RenderOptions.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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
    /// Rendering options
    /// </summary>  
    public class RenderOptions 
    {                       
        /// <summary>
        /// Page number from which rendering should be started
        /// </summary>  
        public int? StartPageNumber { get; set; }

        /// <summary>
        /// Count pages which should be rendered
        /// </summary>  
        public int? CountPagesToRender { get; set; }

        /// <summary>
        /// Default font name may be specified in following cases: - You want to generally specify the default font to fall back on, if particular font   in the document cannot be found during rendering. - Your document uses fonts, that contain non-English characters and you want to make sure   any missing font is replaced with one that has the same character set available.
        /// </summary>  
        public string DefaultFontName { get; set; }

        /// <summary>
        /// Default encoding for the plain text files such as .csv, .txt and .eml files when encoding is not specified in header
        /// </summary>  
        public string DefaultEncoding { get; set; }

        /// <summary>
        /// When enabled comments will be rendered to the output.
        /// </summary>  
        public bool? RenderComments { get; set; }

        /// <summary>
        /// When enabled hidden pages, sheets or slides will be rendered to the output
        /// </summary>  
        public bool? RenderHiddenPages { get; set; }

        /// <summary>
        /// Rendering options for Spreadsheet file formats. Spreadsheet file formats include files with extensions: .xls, .xlsx, .xlsm, .xlsb, .csv, .ods, .ots, .xltx, .xltm, .tsv 
        /// </summary>  
        public SpreadsheetOptions SpreadsheetOptions { get; set; }

        /// <summary>
        /// Rendering options for CAD file formats. CAD file formats include files with extensions: .dwg, .dxf, .dgn, .ifc, .stl
        /// </summary>  
        public CadOptions CadOptions { get; set; }

        /// <summary>
        /// Rendering options for Email file formats. Email file formats include files with extensions: .msg, .eml, .emlx, .ifc, .stl
        /// </summary>  
        public EmailOptions EmailOptions { get; set; }

        /// <summary>
        /// Rendering options for Project file formats. Project file formats include files with extensions: .mpt, .mpp
        /// </summary>  
        public ProjectManagementOptions ProjectManagementOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RenderOptions {\n");
          sb.Append("  StartPageNumber: ").Append(this.StartPageNumber).Append("\n");
          sb.Append("  CountPagesToRender: ").Append(this.CountPagesToRender).Append("\n");
          sb.Append("  DefaultFontName: ").Append(this.DefaultFontName).Append("\n");
          sb.Append("  DefaultEncoding: ").Append(this.DefaultEncoding).Append("\n");
          sb.Append("  RenderComments: ").Append(this.RenderComments).Append("\n");
          sb.Append("  RenderHiddenPages: ").Append(this.RenderHiddenPages).Append("\n");
          sb.Append("  SpreadsheetOptions: ").Append(this.SpreadsheetOptions).Append("\n");
          sb.Append("  CadOptions: ").Append(this.CadOptions).Append("\n");
          sb.Append("  EmailOptions: ").Append(this.EmailOptions).Append("\n");
          sb.Append("  ProjectManagementOptions: ").Append(this.ProjectManagementOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
