// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfOptions.cs">
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
  /// The PDF documents rendering options.
  /// </summary>  
  public class PdfOptions 
  {                       
        /// <summary>
        /// Indicates whether the PDF document is rendered in a precise mode or not. It is recommended to enable this option when rendering documents with complex content e.g. documents which contains hieroglyphs or any kind o glyphs which should be rendered separately from each other.
        /// </summary>  
        public bool? EnablePreciseRendering { get; set; }

        /// <summary>
        /// When this option is enabled content (graphics and text) will be added to HTML document accordingly Z-order in original PDF document. When this option is disabled content (graphics and text) will be added to a single layer.
        /// </summary>  
        public bool? EnableInitialContentOrdering { get; set; }

        /// <summary>
        /// When this option is enabled layers will be separated from each other in the HTML document.
        /// </summary>  
        public bool? RenderLayersSeparately { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfOptions {\n");
          sb.Append("  EnablePreciseRendering: ").Append(this.EnablePreciseRendering).Append("\n");
          sb.Append("  EnableInitialContentOrdering: ").Append(this.EnableInitialContentOrdering).Append("\n");
          sb.Append("  RenderLayersSeparately: ").Append(this.RenderLayersSeparately).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
