// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="HtmlGetPagesFromUrlRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
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
  /// Request model for <see cref="GroupDocs.Viewer.Cloud.Sdk.Api.ViewerApi.HtmlGetPagesFromUrl" /> operation.
  /// </summary>  
  public class HtmlGetPagesFromUrlRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlGetPagesFromUrlRequest"/> class.
        /// </summary>        
        public HtmlGetPagesFromUrlRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlGetPagesFromUrlRequest"/> class.
        /// </summary>
        /// <param name="url">The URL to retrieve document.</param>
        /// <param name="fileName">The file name.</param>
        /// <param name="resourcePath">The HTML resource path.</param>
        /// <param name="ignoreResourcePathInResources">When this option enabled ResourcePath won&#39;t be added to resource reference in *.css and *.svg files.</param>
        /// <param name="embedResources">Whether to embed HTML resources or save them separate.</param>
        /// <param name="startPageNumber">The starting document page number to render.</param>
        /// <param name="countPages">The count of document pages to render.</param>
        /// <param name="password">The document password.</param>
        /// <param name="renderComments">Allows to render document comments.</param>
        /// <param name="renderHiddenPages">Enables document hidden pages, sheets or slides rendering.</param>
        /// <param name="defaultFontName">The name of the default font.</param>
        /// <param name="fontsFolder">The folder with custom fonts in storage.</param>
        /// <param name="folder">The folder which contains specified file in storage.</param>
        /// <param name="storage">The file storage which have to be used.</param>
        public HtmlGetPagesFromUrlRequest(string url, string fileName = null, string resourcePath = null, bool? ignoreResourcePathInResources = null, bool? embedResources = null, int? startPageNumber = null, int? countPages = null, string password = null, bool? renderComments = null, bool? renderHiddenPages = null, string defaultFontName = null, string fontsFolder = null, string folder = null, string storage = null)             
        {
            this.Url = url;
            this.FileName = fileName;
            this.ResourcePath = resourcePath;
            this.IgnoreResourcePathInResources = ignoreResourcePathInResources;
            this.EmbedResources = embedResources;
            this.StartPageNumber = startPageNumber;
            this.CountPages = countPages;
            this.Password = password;
            this.RenderComments = renderComments;
            this.RenderHiddenPages = renderHiddenPages;
            this.DefaultFontName = defaultFontName;
            this.FontsFolder = fontsFolder;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// The URL to retrieve document.
        /// </summary>  
        public string Url { get; set; }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// The HTML resource path.
        /// </summary>  
        public string ResourcePath { get; set; }

        /// <summary>
        /// When this option enabled ResourcePath won't be added to resource reference in *.css and *.svg files.
        /// </summary>  
        public bool? IgnoreResourcePathInResources { get; set; }

        /// <summary>
        /// Whether to embed HTML resources or save them separate.
        /// </summary>  
        public bool? EmbedResources { get; set; }

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
        /// Allows to render document comments.
        /// </summary>  
        public bool? RenderComments { get; set; }

        /// <summary>
        /// Enables document hidden pages, sheets or slides rendering.
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
