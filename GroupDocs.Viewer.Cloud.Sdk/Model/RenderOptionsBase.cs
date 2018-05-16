// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RenderOptionsBase.cs">
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
  /// Base render options.
  /// </summary>  
  public class RenderOptionsBase 
  {                       
        /// <summary>
        /// Allows to specify document password in case when document is password-protected.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Allows to specify attachment password in case when attachment is password-protected.
        /// </summary>  
        public string AttachmentPassword { get; set; }

        /// <summary>
        /// Enables document text extraction. For rendering document as image only.
        /// </summary>  
        public bool? ExtractText { get; set; }

        /// <summary>
        /// Enables document comments rendering.
        /// </summary>  
        public bool? RenderComments { get; set; }

        /// <summary>
        /// Enables rendering of document hidden pages, sheets or slides.
        /// </summary>  
        public bool? RenderHiddenPages { get; set; }

        /// <summary>
        /// Transforms to apply. Available transforms [\"Rotate\",\"Reorder\",\"AddPrintAction\"]. 1. Rotate - pages will be rotated on angle if angle was set before. 2. Reorder - for rendering document as PDF only. Pages will be ordered according to rearrangements made before. 3. AddPrintAction - for rendering document as PDF only. An JavaScript action will be added which opens print dialog when PDF document is opened.   
        /// </summary>  
        public List<string> Transforms { get; set; }

        /// <summary>
        /// The name of the default font. Default font name may be specified in following cases: - You want to generally specify the default font to fall back on, if particular font   in the document cannot be found during rendering. - Your document uses fonts, that contain non-English characters and you want to make sure   any missing font is replaced with one that has the same character set available.
        /// </summary>  
        public string DefaultFontName { get; set; }

        /// <summary>
        /// Allows to specify watermark.
        /// </summary>  
        public Watermark Watermark { get; set; }

        /// <summary>
        /// The Spreadsheet documents rendering options.
        /// </summary>  
        public CellsOptions CellsOptions { get; set; }

        /// <summary>
        /// The CAD documents rendering options.
        /// </summary>  
        public CadOptions CadOptions { get; set; }

        /// <summary>
        /// The Email documents rendering options.
        /// </summary>  
        public EmailOptions EmailOptions { get; set; }

        /// <summary>
        /// The Text documents rendering options.
        /// </summary>  
        public WordsOptions WordsOptions { get; set; }

        /// <summary>
        /// The PDF documents rendering options.
        /// </summary>  
        public PdfOptions PdfOptions { get; set; }

        /// <summary>
        /// The Presentation documents rendering options.
        /// </summary>  
        public SlidesOptions SlidesOptions { get; set; }

        /// <summary>
        /// The Microsoft Project documents rendering options.
        /// </summary>  
        public ProjectOptions ProjectOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RenderOptionsBase {\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  AttachmentPassword: ").Append(this.AttachmentPassword).Append("\n");
          sb.Append("  ExtractText: ").Append(this.ExtractText).Append("\n");
          sb.Append("  RenderComments: ").Append(this.RenderComments).Append("\n");
          sb.Append("  RenderHiddenPages: ").Append(this.RenderHiddenPages).Append("\n");
          sb.Append("  Transforms: ").Append(this.Transforms).Append("\n");
          sb.Append("  DefaultFontName: ").Append(this.DefaultFontName).Append("\n");
          sb.Append("  Watermark: ").Append(this.Watermark).Append("\n");
          sb.Append("  CellsOptions: ").Append(this.CellsOptions).Append("\n");
          sb.Append("  CadOptions: ").Append(this.CadOptions).Append("\n");
          sb.Append("  EmailOptions: ").Append(this.EmailOptions).Append("\n");
          sb.Append("  WordsOptions: ").Append(this.WordsOptions).Append("\n");
          sb.Append("  PdfOptions: ").Append(this.PdfOptions).Append("\n");
          sb.Append("  SlidesOptions: ").Append(this.SlidesOptions).Append("\n");
          sb.Append("  ProjectOptions: ").Append(this.ProjectOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
