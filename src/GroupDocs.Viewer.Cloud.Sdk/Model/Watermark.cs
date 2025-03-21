// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="Watermark.cs">
//  Copyright (c) Aspose Pty Ltd
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
    /// Text watermark
    /// </summary>  
    public class Watermark 
    {                       
        /// <summary>
        /// Watermark position. Default value is \&quot;Diagonal\&quot;.
        /// </summary>
        /// <value>Watermark position. Default value is \&quot;Diagonal\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PositionEnum
        { 
            /// <summary>
            /// Enum Diagonal for "Diagonal"
            /// </summary>            
            Diagonal,
            
            /// <summary>
            /// Enum TopLeft for "TopLeft"
            /// </summary>            
            TopLeft,
            
            /// <summary>
            /// Enum TopCenter for "TopCenter"
            /// </summary>            
            TopCenter,
            
            /// <summary>
            /// Enum TopRight for "TopRight"
            /// </summary>            
            TopRight,
            
            /// <summary>
            /// Enum BottomLeft for "BottomLeft"
            /// </summary>            
            BottomLeft,
            
            /// <summary>
            /// Enum BottomCenter for "BottomCenter"
            /// </summary>            
            BottomCenter,
            
            /// <summary>
            /// Enum BottomRight for "BottomRight"
            /// </summary>            
            BottomRight            
        }

        /// <summary>
        /// Watermark position. Default value is \&quot;Diagonal\&quot;.
        /// </summary>
        public PositionEnum? Position { get; set; }

        /// <summary>
        /// Watermark text.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Watermark color. Supported formats {Magenta|(112,222,11)|(50,112,222,11)}. Default value is \"Red\".
        /// </summary>  
        public string Color { get; set; }

        /// <summary>
        /// Watermark size in percents. Default value is 100.
        /// </summary>  
        public int? Size { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Watermark {\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  Color: ").Append(this.Color).Append("\n");
          sb.Append("  Position: ").Append(this.Position).Append("\n");
          sb.Append("  Size: ").Append(this.Size).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
