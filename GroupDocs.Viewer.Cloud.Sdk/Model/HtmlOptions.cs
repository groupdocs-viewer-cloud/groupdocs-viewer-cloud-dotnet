// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="HtmlOptions.cs">
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
    /// Provides options for rendering document pages as HTML.
    /// </summary>  
    public class HtmlOptions : RenderOptions 
    {                       
        /// <summary>
        /// Allows to specify HTML resources (styles, images and fonts) path. For example when resource path is http://example.com/api/pages/{page-number}/resources/{resource-name} the {page-number} and {resource-name} templates will be replaced with page number and resource name accordingly. Ignored when EmbedResources option is set to true.
        /// </summary>  
        public string ResourcePath { get; set; }

        /// <summary>
        /// Allows to ignore ResourcePath when processing *.css files.  When this options is enabled ResourcePath won't be added to resource references in *.css file.
        /// </summary>  
        public bool? IgnoreResourcePathInResources { get; set; }

        /// <summary>
        /// Controls output HTML document resources (styles, images and fonts) saving. When this options set to true all resources will be embedded into HTML document and ResourcePath option value will be ignored.
        /// </summary>  
        public bool? EmbedResources { get; set; }

        /// <summary>
        /// Enables content (HTML, CSS and SVG) minification.
        /// </summary>  
        public bool? EnableMinification { get; set; }

        /// <summary>
        /// Indicates whether rendering will provide responsive web pages, that look well on different device types.
        /// </summary>  
        public bool? EnableResponsiveRendering { get; set; }

        /// <summary>
        /// Prevents adding fonts to the output HTML document.  
        /// </summary>  
        public bool? ExcludeFonts { get; set; }

        /// <summary>
        /// The list of font names, that will be excluded from HTML.
        /// </summary>  
        public List<string> ExcludeFontsList { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HtmlOptions {\n");
          sb.Append("  ResourcePath: ").Append(this.ResourcePath).Append("\n");
          sb.Append("  IgnoreResourcePathInResources: ").Append(this.IgnoreResourcePathInResources).Append("\n");
          sb.Append("  EmbedResources: ").Append(this.EmbedResources).Append("\n");
          sb.Append("  EnableMinification: ").Append(this.EnableMinification).Append("\n");
          sb.Append("  EnableResponsiveRendering: ").Append(this.EnableResponsiveRendering).Append("\n");
          sb.Append("  ExcludeFonts: ").Append(this.ExcludeFonts).Append("\n");
          sb.Append("  ExcludeFontsList: ").Append(this.ExcludeFontsList).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
