// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SpreadsheetOptions.cs">
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
    /// Rendering options for Spreadsheet file formats. Spreadsheet file formats include files with extensions: .xls, .xlsx, .xlsm, .xlsb, .csv, .ods, .ots, .xltx, .xltm, .tsv 
    /// </summary>  
    public class SpreadsheetOptions 
    {                       
        /// <summary>
        /// The text overflow mode for rendering spreadsheet documents into HTML
        /// </summary>
        /// <value>The text overflow mode for rendering spreadsheet documents into HTML</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextOverflowModeEnum
        { 
            /// <summary>
            /// Enum Overlay for "Overlay"
            /// </summary>            
            Overlay,
            
            /// <summary>
            /// Enum OverlayIfNextIsEmpty for "OverlayIfNextIsEmpty"
            /// </summary>            
            OverlayIfNextIsEmpty,
            
            /// <summary>
            /// Enum AutoFitColumn for "AutoFitColumn"
            /// </summary>            
            AutoFitColumn,
            
            /// <summary>
            /// Enum HideText for "HideText"
            /// </summary>            
            HideText            
        }

        /// <summary>
        /// The text overflow mode for rendering spreadsheet documents into HTML
        /// </summary>
        public TextOverflowModeEnum? TextOverflowMode { get; set; }

        /// <summary>
        /// Allows to enable worksheets pagination. By default one worksheet is rendered into one page.
        /// </summary>  
        public bool? PaginateSheets { get; set; }

        /// <summary>
        /// The number of rows rendered into one page when PaginateSheets is enabled. Default value is 50.
        /// </summary>  
        public int? CountRowsPerPage { get; set; }

        /// <summary>
        /// Indicates whether to render grid lines
        /// </summary>  
        public bool? RenderGridLines { get; set; }

        /// <summary>
        /// By default empty rows are skipped. Enable this option in case you want to render empty rows.
        /// </summary>  
        public bool? RenderEmptyRows { get; set; }

        /// <summary>
        /// By default empty columns are skipped. Enable this option in case you want to render empty columns.
        /// </summary>  
        public bool? RenderEmptyColumns { get; set; }

        /// <summary>
        /// Enables rendering of hidden rows.
        /// </summary>  
        public bool? RenderHiddenRows { get; set; }

        /// <summary>
        /// Enables rendering of hidden columns.
        /// </summary>  
        public bool? RenderHiddenColumns { get; set; }

        /// <summary>
        /// Enables rendering worksheet(s) sections which is defined as print area. Renders each print area in a worksheet as a separate page.
        /// </summary>  
        public bool? RenderPrintAreaOnly { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SpreadsheetOptions {\n");
          sb.Append("  PaginateSheets: ").Append(this.PaginateSheets).Append("\n");
          sb.Append("  CountRowsPerPage: ").Append(this.CountRowsPerPage).Append("\n");
          sb.Append("  RenderGridLines: ").Append(this.RenderGridLines).Append("\n");
          sb.Append("  RenderEmptyRows: ").Append(this.RenderEmptyRows).Append("\n");
          sb.Append("  RenderEmptyColumns: ").Append(this.RenderEmptyColumns).Append("\n");
          sb.Append("  RenderHiddenRows: ").Append(this.RenderHiddenRows).Append("\n");
          sb.Append("  RenderHiddenColumns: ").Append(this.RenderHiddenColumns).Append("\n");
          sb.Append("  RenderPrintAreaOnly: ").Append(this.RenderPrintAreaOnly).Append("\n");
          sb.Append("  TextOverflowMode: ").Append(this.TextOverflowMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
