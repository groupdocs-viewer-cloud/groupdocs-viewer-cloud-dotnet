// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ImageGetDocumentInfoFromContentRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Viewer.Cloud.Sdk.Api.ViewerApi.ImageGetDocumentInfoFromContent" /> operation.
    /// </summary>  
    public class ImageGetDocumentInfoFromContentRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="ImageGetDocumentInfoFromContentRequest"/> class.
          /// </summary>        
          public ImageGetDocumentInfoFromContentRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="ImageGetDocumentInfoFromContentRequest"/> class.
          /// </summary>
          /// <param name="file">File contents.</param>
          /// <param name="documentInfoOptions">Document info options &#39;DocumentInfoOptions&#39; as JSON or XML.</param>
          /// <param name="fileName">The document name.</param>
          /// <param name="folder">The folder which contains specified file in storage.</param>
          /// <param name="storage">The file storage which have to be used.</param>
          public ImageGetDocumentInfoFromContentRequest(System.IO.Stream file, System.IO.Stream documentInfoOptions, string fileName = null, string folder = null, string storage = null)             
          {
              this.File = file;
              this.DocumentInfoOptions = documentInfoOptions;
              this.FileName = fileName;
              this.Folder = folder;
              this.Storage = storage;
          }
          
          /// <summary>
          /// File contents.
          /// </summary>  
          public System.IO.Stream File { get; set; }
          
          /// <summary>
          /// Document info options 'DocumentInfoOptions' as JSON or XML.
          /// </summary>  
          public System.IO.Stream DocumentInfoOptions { get; set; }
          
          /// <summary>
          /// The document name.
          /// </summary>  
          public string FileName { get; set; }
          
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
