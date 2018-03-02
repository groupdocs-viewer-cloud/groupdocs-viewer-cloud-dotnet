// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ImageGetDocumentInfoRequest.cs">
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
  /// Request model for <see cref="GroupDocs.Viewer.Cloud.Sdk.ViewerApi.ImageGetDocumentInfo" /> operation.
  /// </summary>  
  public class ImageGetDocumentInfoRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGetDocumentInfoRequest"/> class.
        /// </summary>        
        public ImageGetDocumentInfoRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGetDocumentInfoRequest"/> class.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <param name="password">The document password.</param>
        /// <param name="extractText">When this options is set to true text contained in document will be extracted and returned along with other information.</param>
        /// <param name="renderComments">Allows to render document comments. Not required if PDF document was created before.</param>
        /// <param name="renderHiddenPages">Enables document hidden pages, sheets or slides rendering.</param>
        /// <param name="folder">The folder which contains specified file in storage.</param>
        /// <param name="storage">The file storage which have to be used.</param>
        public ImageGetDocumentInfoRequest(string fileName, string password = null, bool? extractText = null, bool? renderComments = null, bool? renderHiddenPages = null, string folder = null, string storage = null)             
        {
            this.FileName = fileName;
            this.Password = password;
            this.ExtractText = extractText;
            this.RenderComments = renderComments;
            this.RenderHiddenPages = renderHiddenPages;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// The document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// When this options is set to true text contained in document will be extracted and returned along with other information.
        /// </summary>  
        public bool? ExtractText { get; set; }

        /// <summary>
        /// Allows to render document comments. Not required if PDF document was created before.
        /// </summary>  
        public bool? RenderComments { get; set; }

        /// <summary>
        /// Enables document hidden pages, sheets or slides rendering.
        /// </summary>  
        public bool? RenderHiddenPages { get; set; }

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
