// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfOptimizationOptions.cs">
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
    /// Contains the PDF optimization options to apply to the output PDF file.
    /// </summary>  
    public class PdfOptimizationOptions 
    {                       
        /// <summary>
        /// Enables optimization the output PDF file for viewing online with a web browser. This optimization allows a browser to display the first pages of a PDF file when     you open the document, instead of waiting for the entire file to download.
        /// </summary>  
        public bool? Lineriaze { get; set; }

        /// <summary>
        /// Enables removing annotation from the output PDF file.
        /// </summary>  
        public bool? RemoveAnnotations { get; set; }

        /// <summary>
        /// Enables removing form fields from a PDF file.
        /// </summary>  
        public bool? RemoveFormFields { get; set; }

        /// <summary>
        /// Enables converting the output PDF file to a grayscale.
        /// </summary>  
        public bool? ConvertToGrayScale { get; set; }

        /// <summary>
        /// Subsets fonts in the output PDF file. If the file uses embedded fonts, it contains all font data. GroupDocs.Viewer can subset embedded fonts to reduce the file size.
        /// </summary>  
        public bool? SubsetFonts { get; set; }

        /// <summary>
        /// Enables compressing images in the output PDF file. Use this option to allow other compressing options: PdfOptimizationOptions.ImageQuality and PdfOptimizationOptions.MaxResolution.
        /// </summary>  
        public bool? CompressImages { get; set; }

        /// <summary>
        /// Sets the image quality in the output PDF file (in percent). To change the image quality, first set the PdfOptimizationOptions.CompressImages property to true.
        /// </summary>  
        public int? ImageQuality { get; set; }

        /// <summary>
        /// Enables setting the maximum resolution in the output PDF file. To allow this option, set the GroupDocs.Viewer.Options.PdfOptimizationOptions.CompressImages property to true. This option allows setting the GroupDocs.Viewer.Options.PdfOptimizationOptions.MaxResolution property.
        /// </summary>  
        public bool? ResizeImages { get; set; }

        /// <summary>
        /// Sets the maximum resolution in the output PDF file. To allow this option, set the GroupDocs.Viewer.Options.PdfOptimizationOptions.CompressImages and GroupDocs.Viewer.Options.PdfOptimizationOptions.MaxResolution properties to true. The default value is 300.
        /// </summary>  
        public int? MaxResolution { get; set; }

        /// <summary>
        /// Enables optimization of spreadsheets in the PDF files. This optimization allows to reduce the output file size by setting up border lines. Besides that, it removes the Arial and Times New Roman characters of 32-127 codes.
        /// </summary>  
        public bool? OptimizeSpreadsheets { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfOptimizationOptions {\n");
          sb.Append("  Lineriaze: ").Append(this.Lineriaze).Append("\n");
          sb.Append("  RemoveAnnotations: ").Append(this.RemoveAnnotations).Append("\n");
          sb.Append("  RemoveFormFields: ").Append(this.RemoveFormFields).Append("\n");
          sb.Append("  ConvertToGrayScale: ").Append(this.ConvertToGrayScale).Append("\n");
          sb.Append("  SubsetFonts: ").Append(this.SubsetFonts).Append("\n");
          sb.Append("  CompressImages: ").Append(this.CompressImages).Append("\n");
          sb.Append("  ImageQuality: ").Append(this.ImageQuality).Append("\n");
          sb.Append("  ResizeImages: ").Append(this.ResizeImages).Append("\n");
          sb.Append("  MaxResolution: ").Append(this.MaxResolution).Append("\n");
          sb.Append("  OptimizeSpreadsheets: ").Append(this.OptimizeSpreadsheets).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
