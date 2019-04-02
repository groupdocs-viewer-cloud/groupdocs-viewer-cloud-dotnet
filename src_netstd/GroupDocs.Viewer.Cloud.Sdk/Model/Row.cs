// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="Row.cs">
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
    /// Page row with text
    /// </summary>
    [DataContract]
    public partial class Row
    {
        /// <summary>
        /// Row text
        /// </summary>
        /// <value>Row text</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Row left coordinate
        /// </summary>
        /// <value>Row left coordinate</value>
        [DataMember(Name="RowLeft", EmitDefaultValue=false)]
        public double? RowLeft { get; set; }

        /// <summary>
        /// Row top coordinate
        /// </summary>
        /// <value>Row top coordinate</value>
        [DataMember(Name="RowTop", EmitDefaultValue=false)]
        public double? RowTop { get; set; }

        /// <summary>
        /// Row width
        /// </summary>
        /// <value>Row width</value>
        [DataMember(Name="RowWidth", EmitDefaultValue=false)]
        public double? RowWidth { get; set; }

        /// <summary>
        /// Row height
        /// </summary>
        /// <value>Row height</value>
        [DataMember(Name="RowHeight", EmitDefaultValue=false)]
        public double? RowHeight { get; set; }

        /// <summary>
        /// Text coordinates
        /// </summary>
        /// <value>Text coordinates</value>
        [DataMember(Name="TextCoordinates", EmitDefaultValue=false)]
        public List<double?> TextCoordinates { get; set; }

        /// <summary>
        /// Characters coordinates
        /// </summary>
        /// <value>Characters coordinates</value>
        [DataMember(Name="CharacterCoordinates", EmitDefaultValue=false)]
        public List<double?> CharacterCoordinates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Row {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  RowLeft: ").Append(RowLeft).Append("\n");
            sb.Append("  RowTop: ").Append(RowTop).Append("\n");
            sb.Append("  RowWidth: ").Append(RowWidth).Append("\n");
            sb.Append("  RowHeight: ").Append(RowHeight).Append("\n");
            sb.Append("  TextCoordinates: ").Append(TextCoordinates).Append("\n");
            sb.Append("  CharacterCoordinates: ").Append(CharacterCoordinates).Append("\n");
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
