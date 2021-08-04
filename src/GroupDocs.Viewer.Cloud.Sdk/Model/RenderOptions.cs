// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RenderOptions.cs">
//  Copyright (c) 2003-2021 Aspose Pty Ltd
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
        /// Pages list to render. Ignored, if StartPageNumber and CountPagesToRender are provided
        /// </summary>  
        public List<int?> PagesToRender { get; set; }

        /// <summary>
        /// Page rotations
        /// </summary>  
        public List<PageRotation> PageRotations { get; set; }

        /// <summary>
        /// Default font name may be specified in following cases: - You want to generally specify the default font to fall back on, if particular font   in the document cannot be found during rendering. - Your document uses fonts, that contain non-English characters and you want to make sure   any missing font is replaced with one that has the same character set available.
        /// </summary>  
        public string DefaultFontName { get; set; }

        /// <summary>
        /// Default encoding for the plain text files such as .csv, .txt and .eml files when encoding is not specified in header
        /// </summary>  
        public string DefaultEncoding { get; set; }

        /// <summary>
        /// When enabled comments will be rendered to the output
        /// </summary>  
        public bool? RenderComments { get; set; }

        /// <summary>
        /// When enabled notes will be rendered to the output
        /// </summary>  
        public bool? RenderNotes { get; set; }

        /// <summary>
        /// When enabled hidden pages, sheets or slides will be rendered to the output
        /// </summary>  
        public bool? RenderHiddenPages { get; set; }

        /// <summary>
        /// Rendering options for Spreadsheet source file formats Spreadsheet file formats include files with extensions: .xls, .xlsx, .xlsm, .xlsb, .csv, .ods, .ots, .xltx, .xltm, .tsv 
        /// </summary>  
        public SpreadsheetOptions SpreadsheetOptions { get; set; }

        /// <summary>
        /// Rendering options for CAD source file formats CAD file formats include files with extensions: .dwg, .dxf, .dgn, .ifc, .stl
        /// </summary>  
        public CadOptions CadOptions { get; set; }

        /// <summary>
        /// Rendering options for Email source file formats Email file formats include files with extensions: .msg, .eml, .emlx, .ifc, .stl
        /// </summary>  
        public EmailOptions EmailOptions { get; set; }

        /// <summary>
        /// Rendering options for MS Project source file formats Project file formats include files with extensions: .mpt, .mpp
        /// </summary>  
        public ProjectManagementOptions ProjectManagementOptions { get; set; }

        /// <summary>
        /// Rendering options for PDF source file formats
        /// </summary>  
        public PdfDocumentOptions PdfDocumentOptions { get; set; }

        /// <summary>
        /// Rendering options for WordProcessing source file formats
        /// </summary>  
        public WordProcessingOptions WordProcessingOptions { get; set; }

        /// <summary>
        /// Rendering options for Outlook source file formats
        /// </summary>  
        public OutlookOptions OutlookOptions { get; set; }

        /// <summary>
        /// Rendering options for Archive source file formats
        /// </summary>  
        public ArchiveOptions ArchiveOptions { get; set; }

        /// <summary>
        /// Rendering options for Text source file formats
        /// </summary>  
        public TextOptions TextOptions { get; set; }

        /// <summary>
        /// Rendering options for Mail storage (Lotus Notes, MBox) data files.
        /// </summary>  
        public MailStorageOptions MailStorageOptions { get; set; }

        /// <summary>
        /// Rendering options for Visio source file formats
        /// </summary>  
        public VisioRenderingOptions VisioRenderingOptions { get; set; }

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
          sb.Append("  PagesToRender: ").Append(this.PagesToRender).Append("\n");
          sb.Append("  PageRotations: ").Append(this.PageRotations).Append("\n");
          sb.Append("  DefaultFontName: ").Append(this.DefaultFontName).Append("\n");
          sb.Append("  DefaultEncoding: ").Append(this.DefaultEncoding).Append("\n");
          sb.Append("  RenderComments: ").Append(this.RenderComments).Append("\n");
          sb.Append("  RenderNotes: ").Append(this.RenderNotes).Append("\n");
          sb.Append("  RenderHiddenPages: ").Append(this.RenderHiddenPages).Append("\n");
          sb.Append("  SpreadsheetOptions: ").Append(this.SpreadsheetOptions).Append("\n");
          sb.Append("  CadOptions: ").Append(this.CadOptions).Append("\n");
          sb.Append("  EmailOptions: ").Append(this.EmailOptions).Append("\n");
          sb.Append("  ProjectManagementOptions: ").Append(this.ProjectManagementOptions).Append("\n");
          sb.Append("  PdfDocumentOptions: ").Append(this.PdfDocumentOptions).Append("\n");
          sb.Append("  WordProcessingOptions: ").Append(this.WordProcessingOptions).Append("\n");
          sb.Append("  OutlookOptions: ").Append(this.OutlookOptions).Append("\n");
          sb.Append("  ArchiveOptions: ").Append(this.ArchiveOptions).Append("\n");
          sb.Append("  TextOptions: ").Append(this.TextOptions).Append("\n");
          sb.Append("  MailStorageOptions: ").Append(this.MailStorageOptions).Append("\n");
          sb.Append("  VisioRenderingOptions: ").Append(this.VisioRenderingOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
