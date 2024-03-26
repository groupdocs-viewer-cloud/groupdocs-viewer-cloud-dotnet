// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ViewApi.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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

namespace GroupDocs.Viewer.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using GroupDocs.Viewer.Cloud.Sdk.Client;
    using GroupDocs.Viewer.Cloud.Sdk.Client.RequestHandlers;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Viewer Cloud API.
    /// </summary>
    public class ViewApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public ViewApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public ViewApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Converts input document file to format specified 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertAndDownloadRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ConvertAndDownload(ConvertAndDownloadRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling ConvertAndDownload");
            }

            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling ConvertAndDownload");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/convertAndDownload";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pages", request.pages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.password);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "PUT", 
                    null, 
                    null, 
                    formParams);
        }

        /// <summary>
        /// Render document pages 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateViewRequest" /></param>
        /// <returns><see cref="ViewResult"/></returns>
        public ViewResult CreateView(CreateViewRequest request)
        {
            // verify the required parameter 'viewOptions' is set
            if (request.viewOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'viewOptions' when calling CreateView");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/view";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.viewOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (ViewResult)SerializationHelper.Deserialize(response, typeof(ViewResult));
            }

            return null;
        }

        /// <summary>
        /// Delete rendered pages 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteViewRequest" /></param>
        public void DeleteView(DeleteViewRequest request)
        {
            // verify the required parameter 'deleteViewOptions' is set
            if (request.deleteViewOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'deleteViewOptions' when calling DeleteView");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/view";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.deleteViewOptions); // http body (model) parameter
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                postBody, 
                null, 
                null);
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ConvertAndDownloadRequest.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Viewer.Cloud.Sdk.Api.ViewApi.ConvertAndDownload" /> operation.
    /// </summary>  
    public class ConvertAndDownloadRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="ConvertAndDownloadRequest"/> class.
          /// </summary>        
          public ConvertAndDownloadRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="ConvertAndDownloadRequest"/> class.
          /// </summary>
          /// <param name="format">Requested conversion format: HTML, JPG, PNG or PDF</param>
          /// <param name="file">Input file to convert</param>
          /// <param name="pages">Pages range to render, like \&quot;1,2\&quot; or \&quot;3-5,10\&quot;</param>
          /// <param name="password">Input document password</param>
          public ConvertAndDownloadRequest(string format, System.IO.Stream file, string pages = null, string password = null)             
          {
              this.format = format;
              this.File = file;
              this.pages = pages;
              this.password = password;
          }
          
          /// <summary>
          /// Requested conversion format: HTML, JPG, PNG or PDF
          /// </summary>  
          public string format { get; set; }
          
          /// <summary>
          /// Input file to convert
          /// </summary>  
          public System.IO.Stream File { get; set; }
          
          /// <summary>
          /// Pages range to render, like \"1,2\" or \"3-5,10\"
          /// </summary>  
          public string pages { get; set; }
          
          /// <summary>
          /// Input document password
          /// </summary>  
          public string password { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CreateViewRequest.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Viewer.Cloud.Sdk.Api.ViewApi.CreateView" /> operation.
    /// </summary>  
    public class CreateViewRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="CreateViewRequest"/> class.
          /// </summary>        
          public CreateViewRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="CreateViewRequest"/> class.
          /// </summary>
          /// <param name="viewOptions">View options</param>
          public CreateViewRequest(ViewOptions viewOptions)             
          {
              this.viewOptions = viewOptions;
          }
          
          /// <summary>
          /// View options
          /// </summary>  
          public ViewOptions viewOptions { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DeleteViewRequest.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Viewer.Cloud.Sdk.Api.ViewApi.DeleteView" /> operation.
    /// </summary>  
    public class DeleteViewRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="DeleteViewRequest"/> class.
          /// </summary>        
          public DeleteViewRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="DeleteViewRequest"/> class.
          /// </summary>
          /// <param name="deleteViewOptions">Delete options</param>
          public DeleteViewRequest(DeleteViewOptions deleteViewOptions)             
          {
              this.deleteViewOptions = deleteViewOptions;
          }
          
          /// <summary>
          /// Delete options
          /// </summary>  
          public DeleteViewOptions deleteViewOptions { get; set; }
    }
}
