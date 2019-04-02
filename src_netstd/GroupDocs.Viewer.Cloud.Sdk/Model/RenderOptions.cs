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
using JsonSubTypes;
using SwaggerDateConverter = GroupDocs.Viewer.Cloud.Sdk.Client.SwaggerDateConverter;

namespace GroupDocs.Viewer.Cloud.Sdk.Model
{
    /// <summary>
    /// Rendering options
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(ImageOptions), "ImageOptions")]
    [JsonSubtypes.KnownSubType(typeof(HtmlOptions), "HtmlOptions")]
    public partial class RenderOptions
    {
        /// <summary>
        /// Page number from which rendering should be started
        /// </summary>
        /// <value>Page number from which rendering should be started</value>
        [DataMember(Name="StartPageNumber", EmitDefaultValue=false)]
        public int? StartPageNumber { get; set; }

        /// <summary>
        /// Count pages which should be rendered
        /// </summary>
        /// <value>Count pages which should be rendered</value>
        [DataMember(Name="CountPagesToRender", EmitDefaultValue=false)]
        public int? CountPagesToRender { get; set; }

        /// <summary>
        /// Default font name may be specified in following cases: - You want to generally specify the default font to fall back on, if particular font   in the document cannot be found during rendering. - Your document uses fonts, that contain non-English characters and you want to make sure   any missing font is replaced with one that has the same character set available.
        /// </summary>
        /// <value>Default font name may be specified in following cases: - You want to generally specify the default font to fall back on, if particular font   in the document cannot be found during rendering. - Your document uses fonts, that contain non-English characters and you want to make sure   any missing font is replaced with one that has the same character set available.</value>
        [DataMember(Name="DefaultFontName", EmitDefaultValue=false)]
        public string DefaultFontName { get; set; }

        /// <summary>
        /// Default encoding for the plain text files such as .csv, .txt and .eml files when encoding is not specified in header
        /// </summary>
        /// <value>Default encoding for the plain text files such as .csv, .txt and .eml files when encoding is not specified in header</value>
        [DataMember(Name="DefaultEncoding", EmitDefaultValue=false)]
        public string DefaultEncoding { get; set; }

        /// <summary>
        /// When enabled comments will be rendered to the output.
        /// </summary>
        /// <value>When enabled comments will be rendered to the output.</value>
        [DataMember(Name="RenderComments", EmitDefaultValue=false)]
        public bool? RenderComments { get; set; }

        /// <summary>
        /// When enabled hidden pages, sheets or slides will be rendered to the output
        /// </summary>
        /// <value>When enabled hidden pages, sheets or slides will be rendered to the output</value>
        [DataMember(Name="RenderHiddenPages", EmitDefaultValue=false)]
        public bool? RenderHiddenPages { get; set; }

        /// <summary>
        /// Rendering options for Spreadsheet file formats. Spreadsheet file formats include files with extensions: .xls, .xlsx, .xlsm, .xlsb, .csv, .ods, .ots, .xltx, .xltm, .tsv 
        /// </summary>
        /// <value>Rendering options for Spreadsheet file formats. Spreadsheet file formats include files with extensions: .xls, .xlsx, .xlsm, .xlsb, .csv, .ods, .ots, .xltx, .xltm, .tsv </value>
        [DataMember(Name="SpreadsheetOptions", EmitDefaultValue=false)]
        public SpreadsheetOptions SpreadsheetOptions { get; set; }

        /// <summary>
        /// Rendering options for CAD file formats. CAD file formats include files with extensions: .dwg, .dxf, .dgn, .ifc, .stl
        /// </summary>
        /// <value>Rendering options for CAD file formats. CAD file formats include files with extensions: .dwg, .dxf, .dgn, .ifc, .stl</value>
        [DataMember(Name="CadOptions", EmitDefaultValue=false)]
        public CadOptions CadOptions { get; set; }

        /// <summary>
        /// Rendering options for Email file formats. Email file formats include files with extensions: .msg, .eml, .emlx, .ifc, .stl
        /// </summary>
        /// <value>Rendering options for Email file formats. Email file formats include files with extensions: .msg, .eml, .emlx, .ifc, .stl</value>
        [DataMember(Name="EmailOptions", EmitDefaultValue=false)]
        public EmailOptions EmailOptions { get; set; }

        /// <summary>
        /// Rendering options for Project file formats. Project file formats include files with extensions: .mpt, .mpp
        /// </summary>
        /// <value>Rendering options for Project file formats. Project file formats include files with extensions: .mpt, .mpp</value>
        [DataMember(Name="ProjectManagementOptions", EmitDefaultValue=false)]
        public ProjectManagementOptions ProjectManagementOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenderOptions {\n");
            sb.Append("  StartPageNumber: ").Append(StartPageNumber).Append("\n");
            sb.Append("  CountPagesToRender: ").Append(CountPagesToRender).Append("\n");
            sb.Append("  DefaultFontName: ").Append(DefaultFontName).Append("\n");
            sb.Append("  DefaultEncoding: ").Append(DefaultEncoding).Append("\n");
            sb.Append("  RenderComments: ").Append(RenderComments).Append("\n");
            sb.Append("  RenderHiddenPages: ").Append(RenderHiddenPages).Append("\n");
            sb.Append("  SpreadsheetOptions: ").Append(SpreadsheetOptions).Append("\n");
            sb.Append("  CadOptions: ").Append(CadOptions).Append("\n");
            sb.Append("  EmailOptions: ").Append(EmailOptions).Append("\n");
            sb.Append("  ProjectManagementOptions: ").Append(ProjectManagementOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
} 
