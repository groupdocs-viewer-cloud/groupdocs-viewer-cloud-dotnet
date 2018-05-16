// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="HtmlGetAttachmentPageRequest.cs">
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
  /// Request model for <see cref="GroupDocs.Viewer.Cloud.Sdk.ViewerApi.HtmlGetAttachmentPage" /> operation.
  /// </summary>  
  public class HtmlGetAttachmentPageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlGetAttachmentPageRequest"/> class.
        /// </summary>        
        public HtmlGetAttachmentPageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlGetAttachmentPageRequest"/> class.
        /// </summary>
        /// <param name="fileName">The document name.</param>
        /// <param name="attachmentName">Name of the attachment.</param>
        /// <param name="pageNumber">The attachment page number.</param>
        /// <param name="resourcePath">The attachment page HTML resource path.</param>
        /// <param name="ignoreResourcePathInResources">When this option enabled ResourcePath won&#39;t be added to resource reference in *.css and *.svg files.</param>
        /// <param name="embedResources">Whether to embed HTML resources or save them separate.</param>
        /// <param name="enableMinification">Enables content (HTML, CSS and SVG) minification.</param>
        /// <param name="enableResponsiveRendering">Indicates whether rendering will provide responsive web pages, that look well on different device types.</param>
        /// <param name="excludeFonts">Prevents adding fonts to the output HTML document.</param>
        /// <param name="renderComments">Allows to render document comments.</param>
        /// <param name="renderHiddenPages">Enables rendering of document hidden pages, sheets or slides.</param>
        /// <param name="password">The document password.</param>
        /// <param name="attachmentPassword">The attachment password.</param>
        /// <param name="defaultFontName">The name of the default font.</param>
        /// <param name="fontsFolder">The folder with custom fonts in storage.</param>
        /// <param name="folder">The folder which contains specified file in storage.</param>
        /// <param name="storage">The file storage which have to be used.</param>
        public HtmlGetAttachmentPageRequest(string fileName, string attachmentName, int? pageNumber, string resourcePath = null, bool? ignoreResourcePathInResources = null, bool? embedResources = null, bool? enableMinification = null, bool? enableResponsiveRendering = null, bool? excludeFonts = null, bool? renderComments = null, bool? renderHiddenPages = null, string password = null, string attachmentPassword = null, string defaultFontName = null, string fontsFolder = null, string folder = null, string storage = null)             
        {
            this.FileName = fileName;
            this.AttachmentName = attachmentName;
            this.PageNumber = pageNumber;
            this.ResourcePath = resourcePath;
            this.IgnoreResourcePathInResources = ignoreResourcePathInResources;
            this.EmbedResources = embedResources;
            this.EnableMinification = enableMinification;
            this.EnableResponsiveRendering = enableResponsiveRendering;
            this.ExcludeFonts = excludeFonts;
            this.RenderComments = renderComments;
            this.RenderHiddenPages = renderHiddenPages;
            this.Password = password;
            this.AttachmentPassword = attachmentPassword;
            this.DefaultFontName = defaultFontName;
            this.FontsFolder = fontsFolder;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// Name of the attachment.
        /// </summary>  
        public string AttachmentName { get; set; }

        /// <summary>
        /// The attachment page number.
        /// </summary>  
        public int? PageNumber { get; set; }

        /// <summary>
        /// The attachment page HTML resource path.
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
        /// Allows to render document comments.
        /// </summary>  
        public bool? RenderComments { get; set; }

        /// <summary>
        /// Enables rendering of document hidden pages, sheets or slides.
        /// </summary>  
        public bool? RenderHiddenPages { get; set; }

        /// <summary>
        /// The document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// The attachment password.
        /// </summary>  
        public string AttachmentPassword { get; set; }

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
