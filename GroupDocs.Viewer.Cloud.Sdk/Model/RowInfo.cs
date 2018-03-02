// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RowInfo.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
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
  /// The page text row information.
  /// </summary>  
  public class RowInfo 
  {                       
        /// <summary>
        /// Row text.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Row left coordinate.
        /// </summary>  
        public double? RowLeft { get; set; }

        /// <summary>
        /// Row top coordinate.
        /// </summary>  
        public double? RowTop { get; set; }

        /// <summary>
        /// Row width.
        /// </summary>  
        public double? RowWidth { get; set; }

        /// <summary>
        /// Row height.
        /// </summary>  
        public double? RowHeight { get; set; }

        /// <summary>
        /// Text coordinates.
        /// </summary>  
        public List<double?> TextCoordinates { get; set; }

        /// <summary>
        /// Characters coordinates.
        /// </summary>  
        public List<double?> CharacterCoordinates { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RowInfo {\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  RowLeft: ").Append(this.RowLeft).Append("\n");
          sb.Append("  RowTop: ").Append(this.RowTop).Append("\n");
          sb.Append("  RowWidth: ").Append(this.RowWidth).Append("\n");
          sb.Append("  RowHeight: ").Append(this.RowHeight).Append("\n");
          sb.Append("  TextCoordinates: ").Append(this.TextCoordinates).Append("\n");
          sb.Append("  CharacterCoordinates: ").Append(this.CharacterCoordinates).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
