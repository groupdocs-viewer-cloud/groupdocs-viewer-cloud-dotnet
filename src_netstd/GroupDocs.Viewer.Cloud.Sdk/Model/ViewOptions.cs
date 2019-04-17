// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ViewOptions.cs">
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
    /// View options
    /// </summary>
    [DataContract]
    public partial class ViewOptions
    {
        /// <summary>
        /// View format (HTML, PNG, JPG, BMP or PDF) Default value is HTML.
        /// </summary>
        /// <value>View format (HTML, PNG, JPG, BMP or PDF) Default value is HTML.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ViewFormatEnum
        {
            
            /// <summary>
            /// Enum HTML for "HTML"
            /// </summary>
            [EnumMember(Value = "HTML")]
            HTML,
            
            /// <summary>
            /// Enum PNG for "PNG"
            /// </summary>
            [EnumMember(Value = "PNG")]
            PNG,
            
            /// <summary>
            /// Enum JPG for "JPG"
            /// </summary>
            [EnumMember(Value = "JPG")]
            JPG,
            
            /// <summary>
            /// Enum BMP for "BMP"
            /// </summary>
            [EnumMember(Value = "BMP")]
            BMP,
            
            /// <summary>
            /// Enum PDF for "PDF"
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF
        }

        /// <summary>
        /// View format (HTML, PNG, JPG, BMP or PDF) Default value is HTML.
        /// </summary>
        /// <value>View format (HTML, PNG, JPG, BMP or PDF) Default value is HTML.</value>
        [DataMember(Name="ViewFormat", EmitDefaultValue=false)]
        public ViewFormatEnum ViewFormat { get; set; }
        /// <summary>
        /// File info
        /// </summary>
        /// <value>File info</value>
        [DataMember(Name="FileInfo", EmitDefaultValue=false)]
        public FileInfo FileInfo { get; set; }


        /// <summary>
        /// The output path. Default value is &#39;viewer\\{input file path}_{file extension}\\&#39;
        /// </summary>
        /// <value>The output path. Default value is &#39;viewer\\{input file path}_{file extension}\\&#39;</value>
        [DataMember(Name="OutputPath", EmitDefaultValue=false)]
        public string OutputPath { get; set; }

        /// <summary>
        /// The path to directory containing custom fonts in storage
        /// </summary>
        /// <value>The path to directory containing custom fonts in storage</value>
        [DataMember(Name="FontsPath", EmitDefaultValue=false)]
        public string FontsPath { get; set; }

        /// <summary>
        /// Text watermark
        /// </summary>
        /// <value>Text watermark</value>
        [DataMember(Name="Watermark", EmitDefaultValue=false)]
        public Watermark Watermark { get; set; }

        /// <summary>
        /// Rendering options
        /// </summary>
        /// <value>Rendering options</value>
        [DataMember(Name="RenderOptions", EmitDefaultValue=false)]
        public RenderOptions RenderOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewOptions {\n");
            sb.Append("  FileInfo: ").Append(FileInfo).Append("\n");
            sb.Append("  ViewFormat: ").Append(ViewFormat).Append("\n");
            sb.Append("  OutputPath: ").Append(OutputPath).Append("\n");
            sb.Append("  FontsPath: ").Append(FontsPath).Append("\n");
            sb.Append("  Watermark: ").Append(Watermark).Append("\n");
            sb.Append("  RenderOptions: ").Append(RenderOptions).Append("\n");
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
