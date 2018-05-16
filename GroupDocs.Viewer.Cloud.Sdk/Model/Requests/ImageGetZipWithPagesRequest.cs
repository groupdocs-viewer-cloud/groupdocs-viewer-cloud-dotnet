// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ImageGetZipWithPagesRequest.cs">
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

namespace GroupDocs.Viewer.Cloud.Sdk.Model.Requests 
{
  using GroupDocs.Viewer.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="GroupDocs.Viewer.Cloud.Sdk.ViewerApi.ImageGetZipWithPages" /> operation.
  /// </summary>  
  public class ImageGetZipWithPagesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGetZipWithPagesRequest"/> class.
        /// </summary>        
        public ImageGetZipWithPagesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGetZipWithPagesRequest"/> class.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <param name="format">The image format (jpg, png or bmp). Default value is png.</param>
        /// <param name="width">The image width.</param>
        /// <param name="height">The image height.</param>
        /// <param name="quality">The image quality for jpg format. Default value is 90.</param>
        /// <param name="startPageNumber">The starting document page number to render.</param>
        /// <param name="countPages">The count of document pages to render.</param>
        /// <param name="password">The document password.</param>
        /// <param name="extractText">When this options is set to true text contained in document will be extracted and returned along with other information.</param>
        /// <param name="renderComments">Allows to render document comments.</param>
        /// <param name="renderHiddenPages">Enables rendering of document hidden pages, sheets or slides.</param>
        /// <param name="defaultFontName">The name of the default font.</param>
        /// <param name="fontsFolder">The folder with custom fonts in storage.</param>
        /// <param name="folder">The folder which contains specified file in storage.</param>
        /// <param name="storage">The file storage which have to be used.</param>
        public ImageGetZipWithPagesRequest(string fileName, string format = null, int? width = null, int? height = null, int? quality = null, int? startPageNumber = null, int? countPages = null, string password = null, bool? extractText = null, bool? renderComments = null, bool? renderHiddenPages = null, string defaultFontName = null, string fontsFolder = null, string folder = null, string storage = null)             
        {
            this.FileName = fileName;
            this.Format = format;
            this.Width = width;
            this.Height = height;
            this.Quality = quality;
            this.StartPageNumber = startPageNumber;
            this.CountPages = countPages;
            this.Password = password;
            this.ExtractText = extractText;
            this.RenderComments = renderComments;
            this.RenderHiddenPages = renderHiddenPages;
            this.DefaultFontName = defaultFontName;
            this.FontsFolder = fontsFolder;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// The image format (jpg, png or bmp). Default value is png.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// The image width.
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// The image height.
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// The image quality for jpg format. Default value is 90.
        /// </summary>  
        public int? Quality { get; set; }

        /// <summary>
        /// The starting document page number to render.
        /// </summary>  
        public int? StartPageNumber { get; set; }

        /// <summary>
        /// The count of document pages to render.
        /// </summary>  
        public int? CountPages { get; set; }

        /// <summary>
        /// The document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// When this options is set to true text contained in document will be extracted and returned along with other information.
        /// </summary>  
        public bool? ExtractText { get; set; }

        /// <summary>
        /// Allows to render document comments.
        /// </summary>  
        public bool? RenderComments { get; set; }

        /// <summary>
        /// Enables rendering of document hidden pages, sheets or slides.
        /// </summary>  
        public bool? RenderHiddenPages { get; set; }

        /// <summary>
        /// The name of the default font.
        /// </summary>  
        public string DefaultFontName { get; set; }

        /// <summary>
        /// The folder with custom fonts in storage.
        /// </summary>  
        public string FontsFolder { get; set; }

        /// <summary>
        /// The folder which contains specified file in storage.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// The file storage which have to be used.
        /// </summary>  
        public string Storage { get; set; }
  }
}
