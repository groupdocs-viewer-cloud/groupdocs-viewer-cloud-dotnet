// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SpreadsheetOptions.cs">
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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = GroupDocs.Viewer.Cloud.Sdk.Client.SwaggerDateConverter;

namespace GroupDocs.Viewer.Cloud.Sdk.Model
{
    /// <summary>
    /// Rendering options for Spreadsheet file formats. Spreadsheet file formats include files with extensions: .xls, .xlsx, .xlsm, .xlsb, .csv, .ods, .ots, .xltx, .xltm, .tsv 
    /// </summary>
    [DataContract]
    public partial class SpreadsheetOptions
    {
        /// <summary>
        /// Allows to enable worksheets pagination. By default one worksheet is rendered into one page.
        /// </summary>
        /// <value>Allows to enable worksheets pagination. By default one worksheet is rendered into one page.</value>
        [DataMember(Name="PaginateSheets", EmitDefaultValue=false)]
        public bool? PaginateSheets { get; set; }

        /// <summary>
        /// The number of rows rendered into one page when PaginateSheets is enabled. Default value is 50.
        /// </summary>
        /// <value>The number of rows rendered into one page when PaginateSheets is enabled. Default value is 50.</value>
        [DataMember(Name="CountRowsPerPage", EmitDefaultValue=false)]
        public int? CountRowsPerPage { get; set; }

        /// <summary>
        /// Indicates whether to render grid lines
        /// </summary>
        /// <value>Indicates whether to render grid lines</value>
        [DataMember(Name="RenderGridLines", EmitDefaultValue=false)]
        public bool? RenderGridLines { get; set; }

        /// <summary>
        /// By default empty rows are skipped. Enable this option in case you want to render empty rows.
        /// </summary>
        /// <value>By default empty rows are skipped. Enable this option in case you want to render empty rows.</value>
        [DataMember(Name="RenderEmptyRows", EmitDefaultValue=false)]
        public bool? RenderEmptyRows { get; set; }

        /// <summary>
        /// By default empty columns are skipped. Enable this option in case you want to render empty columns.
        /// </summary>
        /// <value>By default empty columns are skipped. Enable this option in case you want to render empty columns.</value>
        [DataMember(Name="RenderEmptyColumns", EmitDefaultValue=false)]
        public bool? RenderEmptyColumns { get; set; }

        /// <summary>
        /// Enables rendering of hidden rows.
        /// </summary>
        /// <value>Enables rendering of hidden rows.</value>
        [DataMember(Name="RenderHiddenRows", EmitDefaultValue=false)]
        public bool? RenderHiddenRows { get; set; }

        /// <summary>
        /// Enables rendering of hidden columns.
        /// </summary>
        /// <value>Enables rendering of hidden columns.</value>
        [DataMember(Name="RenderHiddenColumns", EmitDefaultValue=false)]
        public bool? RenderHiddenColumns { get; set; }

        /// <summary>
        /// Enables rendering worksheet(s) sections which is defined as print area. Renders each print area in a worksheet as a separate page.
        /// </summary>
        /// <value>Enables rendering worksheet(s) sections which is defined as print area. Renders each print area in a worksheet as a separate page.</value>
        [DataMember(Name="RenderPrintAreaOnly", EmitDefaultValue=false)]
        public bool? RenderPrintAreaOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpreadsheetOptions {\n");
            sb.Append("  PaginateSheets: ").Append(PaginateSheets).Append("\n");
            sb.Append("  CountRowsPerPage: ").Append(CountRowsPerPage).Append("\n");
            sb.Append("  RenderGridLines: ").Append(RenderGridLines).Append("\n");
            sb.Append("  RenderEmptyRows: ").Append(RenderEmptyRows).Append("\n");
            sb.Append("  RenderEmptyColumns: ").Append(RenderEmptyColumns).Append("\n");
            sb.Append("  RenderHiddenRows: ").Append(RenderHiddenRows).Append("\n");
            sb.Append("  RenderHiddenColumns: ").Append(RenderHiddenColumns).Append("\n");
            sb.Append("  RenderPrintAreaOnly: ").Append(RenderPrintAreaOnly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
} 
