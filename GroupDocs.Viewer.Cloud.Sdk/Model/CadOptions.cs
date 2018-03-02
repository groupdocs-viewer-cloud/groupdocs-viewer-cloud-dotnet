// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CadOptions.cs">
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
  /// The CAD documents rendering options.
  /// </summary>  
  public class CadOptions 
  {                       
        /// <summary>
        /// The scale factor affects the size of an output document.        
        /// </summary>  
        public double? ScaleFactor { get; set; }

        /// <summary>
        /// The width of the render result in pixels.        
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// The height of the render result in pixels.        
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Indicates whether layouts from CAD document should be rendered.
        /// </summary>  
        public bool? RenderLayouts { get; set; }

        /// <summary>
        /// The name of the specific layout to render.
        /// </summary>  
        public string LayoutName { get; set; }

        /// <summary>
        /// The list of document layers to render. By default all layers will be rendered. Layer names are case sensitive.
        /// </summary>  
        public List<string> Layers { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CadOptions {\n");
          sb.Append("  ScaleFactor: ").Append(this.ScaleFactor).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  RenderLayouts: ").Append(this.RenderLayouts).Append("\n");
          sb.Append("  LayoutName: ").Append(this.LayoutName).Append("\n");
          sb.Append("  Layers: ").Append(this.Layers).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
