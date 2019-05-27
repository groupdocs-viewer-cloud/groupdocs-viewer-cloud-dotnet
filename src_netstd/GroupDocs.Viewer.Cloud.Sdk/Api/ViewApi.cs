// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ViewApi.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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

using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp.Portable;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IViewApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Render document pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewOptions">View options</param>
        /// <returns>ViewResult</returns>
        ViewResult CreateView(CreateViewRequest request);

        /// <summary>
        /// Render document pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewOptions">View options</param>
        /// <returns>ApiResponse of ViewResult</returns>
        ApiResponse<ViewResult> CreateViewWithHttpInfo (CreateViewRequest request);
        /// <summary>
        /// Delete rendered pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteViewOptions">Delete options</param>
        /// <returns></returns>
        void DeleteView(DeleteViewRequest request);

        /// <summary>
        /// Delete rendered pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteViewOptions">Delete options</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteViewWithHttpInfo (DeleteViewRequest request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Render document pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewOptions">View options</param>
        /// <returns>Task of ViewResult</returns>
        System.Threading.Tasks.Task<ViewResult> CreateViewAsync(CreateViewRequest request);

        /// <summary>
        /// Render document pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewOptions">View options</param>
        /// <returns>Task of ApiResponse (ViewResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ViewResult>> CreateViewAsyncWithHttpInfo(CreateViewRequest request);
        /// <summary>
        /// Delete rendered pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteViewOptions">Delete options</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteViewAsync(DeleteViewRequest request);

        /// <summary>
        /// Delete rendered pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteViewOptions">Delete options</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteViewAsyncWithHttpInfo(DeleteViewRequest request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ViewApi : IViewApi
    {
        private GroupDocs.Viewer.Cloud.Sdk.Client.ExceptionFactoryDelegate _exceptionFactory = GroupDocs.Viewer.Cloud.Sdk.Client.ExceptionFactory.Default;
        private GroupDocs.Viewer.Cloud.Sdk.Client.Configuration _configuration;
        private GroupDocs.Viewer.Cloud.Sdk.Client.ApiClient _apiClient;
        private GroupDocs.Viewer.Cloud.Sdk.Client.IAuthorization _authorization;
        private List<Parameter> _defaultParameters = new List<Parameter>
        {
            new Parameter
            {
                Type = ParameterType.HttpHeader,
                Name = "x-groupdocs-client",
                Value = ".net standard sdk"
            },
            new Parameter
            {
                Type = ParameterType.HttpHeader,
                Name = "x-groupdocs-client-version",
                Value = "19.5"
            }
        };

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
        /// Initializes a new instance of the <see cref="ViewApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ViewApi(Configuration configuration)
        {
            this._configuration = configuration;
            this._apiClient = new ApiClient(configuration, _defaultParameters);
            this._authorization = new Auth(configuration, _defaultParameters);
        }

        /// <summary>
        /// Render document pages 
        /// </summary>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewOptions">View options</param>
        /// <returns>ViewResult</returns>
        public ViewResult CreateView(CreateViewRequest request)
        {
             ApiResponse<ViewResult> localVarResponse = CreateViewWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Render document pages 
        /// </summary>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewOptions">View options</param>
        /// <returns>ApiResponse of ViewResult</returns>
        public ApiResponse<ViewResult> CreateViewWithHttpInfo(CreateViewRequest request)
        {
            // verify the required parameter 'CreateView.viewOptions' is set
            if (request.viewOptions == null)
                throw new ApiException(400, "Missing required parameter 'CreateView.viewOptions' when calling ViewApi->CreateView");

            var localVarPath = "./viewer/view";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.viewOptions != null && request.viewOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.viewOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.viewOptions; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("CreateView", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<ViewResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ViewResult) _apiClient.Deserialize(localVarResponse, typeof(ViewResult)));
        }

        /// <summary>
        /// Render document pages 
        /// </summary>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewOptions">View options</param>
        /// <returns>Task of ViewResult</returns>
        public async System.Threading.Tasks.Task<ViewResult> CreateViewAsync(CreateViewRequest request)
        {
             ApiResponse<ViewResult> localVarResponse = await CreateViewAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Render document pages 
        /// </summary>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewOptions">View options</param>
        /// <returns>Task of ApiResponse (ViewResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ViewResult>> CreateViewAsyncWithHttpInfo(CreateViewRequest request)
        {
            // verify the required parameter 'CreateView.viewOptions' is set
            if (request.viewOptions == null)
                throw new ApiException(400, "Missing required parameter 'CreateView.viewOptions' when calling ViewApi->CreateView");

            var localVarPath = "./viewer/view";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.viewOptions != null && request.viewOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.viewOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.viewOptions; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("CreateView", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<ViewResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ViewResult) _apiClient.Deserialize(localVarResponse, typeof(ViewResult)));
        }

        /// <summary>
        /// Delete rendered pages 
        /// </summary>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteViewOptions">Delete options</param>
        /// <returns></returns>
        public void DeleteView(DeleteViewRequest request)
        {
             DeleteViewWithHttpInfo(request);
        }

        /// <summary>
        /// Delete rendered pages 
        /// </summary>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteViewOptions">Delete options</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteViewWithHttpInfo(DeleteViewRequest request)
        {
            // verify the required parameter 'DeleteView.deleteViewOptions' is set
            if (request.deleteViewOptions == null)
                throw new ApiException(400, "Missing required parameter 'DeleteView.deleteViewOptions' when calling ViewApi->DeleteView");

            var localVarPath = "./viewer/view";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.deleteViewOptions != null && request.deleteViewOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.deleteViewOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.deleteViewOptions; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("DeleteView", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete rendered pages 
        /// </summary>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteViewOptions">Delete options</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteViewAsync(DeleteViewRequest request)
        {
             await DeleteViewAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Delete rendered pages 
        /// </summary>
        /// <exception cref="GroupDocs.Viewer.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteViewOptions">Delete options</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteViewAsyncWithHttpInfo(DeleteViewRequest request)
        {
            // verify the required parameter 'DeleteView.deleteViewOptions' is set
            if (request.deleteViewOptions == null)
                throw new ApiException(400, "Missing required parameter 'DeleteView.deleteViewOptions' when calling ViewApi->DeleteView");

            var localVarPath = "./viewer/view";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.deleteViewOptions != null && request.deleteViewOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.deleteViewOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.deleteViewOptions; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("DeleteView", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CreateViewRequest.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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
