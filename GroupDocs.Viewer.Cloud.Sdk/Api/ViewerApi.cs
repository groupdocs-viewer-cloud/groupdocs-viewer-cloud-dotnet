// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ViewerApi.cs">
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
    public class ViewerApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewerApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public ViewerApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewerApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public ViewerApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Removes fonts cache. 
        /// </summary>
        public void DeleteFontsCache()
        {
            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/fonts/cache";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// List installed fonts. 
        /// </summary>
        /// <returns><see cref="FontCollection"/></returns>
        public FontCollection GetFonts()
        {
            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/fonts";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (FontCollection)SerializationHelper.Deserialize(response, typeof(FontCollection));
            }

            return null;
        }

        /// <summary>
        /// Retrieves list of supported file formats. 
        /// </summary>
        /// <returns><see cref="FormatCollection"/></returns>
        public FormatCollection GetSupportedFileFormats()
        {
            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/formats";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (FormatCollection)SerializationHelper.Deserialize(response, typeof(FormatCollection));
            }

            return null;
        }

        /// <summary>
        /// Creates attachment cache.  
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlCreateAttachmentPagesCacheRequest" /></param>
        /// <returns><see cref="HtmlAttachmentPageCollection"/></returns>
        public HtmlAttachmentPageCollection HtmlCreateAttachmentPagesCache(HtmlCreateAttachmentPagesCacheRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlCreateAttachmentPagesCache");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling HtmlCreateAttachmentPagesCache");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/attachments/{attachmentName}/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.HtmlOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (HtmlAttachmentPageCollection)SerializationHelper.Deserialize(response, typeof(HtmlAttachmentPageCollection));
            }

            return null;
        }

        /// <summary>
        /// Creates document pages as HTML and saves them in cache. Pages created before will be removed from cache. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlCreatePagesCacheRequest" /></param>
        /// <returns><see cref="HtmlPageCollection"/></returns>
        public HtmlPageCollection HtmlCreatePagesCache(HtmlCreatePagesCacheRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlCreatePagesCache");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.HtmlOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (HtmlPageCollection)SerializationHelper.Deserialize(response, typeof(HtmlPageCollection));
            }

            return null;
        }

        /// <summary>
        /// Creates posted document pages as HTML and saves them in cache. Content with document or multipart content is expected where first part is document and second is HtmlOptions. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlCreatePagesCacheFromContentRequest" /></param>
        /// <returns><see cref="HtmlPageCollection"/></returns>
        public HtmlPageCollection HtmlCreatePagesCacheFromContent(HtmlCreatePagesCacheFromContentRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling HtmlCreatePagesCacheFromContent");
            }

            // verify the required parameter 'htmlOptions' is set
            if (request.HtmlOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'htmlOptions' when calling HtmlCreatePagesCacheFromContent");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/html/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            if (request.HtmlOptions != null) 
            {
                formParams.Add("htmlOptions", this.apiInvoker.ToFileInfo(request.HtmlOptions, "HtmlOptions"));
            }
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);

            if (response != null)
            {
                return (HtmlPageCollection)SerializationHelper.Deserialize(response, typeof(HtmlPageCollection));
            }

            return null;
        }

        /// <summary>
        /// Creates pages as HTML and saves them in cache for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlCreatePagesCacheFromUrlRequest" /></param>
        /// <returns><see cref="HtmlPageCollection"/></returns>
        public HtmlPageCollection HtmlCreatePagesCacheFromUrl(HtmlCreatePagesCacheFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling HtmlCreatePagesCacheFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/html/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.HtmlOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (HtmlPageCollection)SerializationHelper.Deserialize(response, typeof(HtmlPageCollection));
            }

            return null;
        }

        /// <summary>
        /// Creates PDF document.  Removes PDF document if it was created before. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlCreatePdfFileRequest" /></param>
        /// <returns><see cref="PdfFileInfo"/></returns>
        public PdfFileInfo HtmlCreatePdfFile(HtmlCreatePdfFileRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlCreatePdfFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.PdfFileOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (PdfFileInfo)SerializationHelper.Deserialize(response, typeof(PdfFileInfo));
            }

            return null;
        }

        /// <summary>
        /// Creates PDF document from document passed in request body and saves it in cache. Content with document or multipart content is expected where first part is document and second is PdfFileOptions. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlCreatePdfFileFromContentRequest" /></param>
        /// <returns><see cref="PdfFileInfo"/></returns>
        public PdfFileInfo HtmlCreatePdfFileFromContent(HtmlCreatePdfFileFromContentRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling HtmlCreatePdfFileFromContent");
            }

            // verify the required parameter 'pdfFileOptions' is set
            if (request.PdfFileOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pdfFileOptions' when calling HtmlCreatePdfFileFromContent");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/html/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            if (request.PdfFileOptions != null) 
            {
                formParams.Add("pdfFileOptions", this.apiInvoker.ToFileInfo(request.PdfFileOptions, "PdfFileOptions"));
            }
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);

            if (response != null)
            {
                return (PdfFileInfo)SerializationHelper.Deserialize(response, typeof(PdfFileInfo));
            }

            return null;
        }

        /// <summary>
        /// Creates PDF document for document at provided URL and saves it in cache.  Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. Expects PdfFileOptions object data in request body. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlCreatePdfFileFromUrlRequest" /></param>
        /// <returns><see cref="PdfFileInfo"/></returns>
        public PdfFileInfo HtmlCreatePdfFileFromUrl(HtmlCreatePdfFileFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling HtmlCreatePdfFileFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/html/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.PdfFileOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (PdfFileInfo)SerializationHelper.Deserialize(response, typeof(PdfFileInfo));
            }

            return null;
        }

        /// <summary>
        /// Removes attachment cache. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlDeleteAttachmentPagesCacheRequest" /></param>
        public void HtmlDeleteAttachmentPagesCache(HtmlDeleteAttachmentPagesCacheRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlDeleteAttachmentPagesCache");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling HtmlDeleteAttachmentPagesCache");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/attachments/{attachmentName}/pages/cache";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes document cache. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlDeletePagesCacheRequest" /></param>
        public void HtmlDeletePagesCache(HtmlDeletePagesCacheRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlDeletePagesCache");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/pages/cache";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Downloads attachment. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetAttachmentRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream HtmlGetAttachment(HtmlGetAttachmentRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetAttachment");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling HtmlGetAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/attachments/{attachmentName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Retrieves attachment information. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetAttachmentInfoRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo HtmlGetAttachmentInfo(HtmlGetAttachmentInfoRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetAttachmentInfo");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling HtmlGetAttachmentInfo");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/attachments/{attachmentName}/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "attachmentPassword", request.AttachmentPassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves attachment information with specified DocumentInfoOptions. Expects DocumentInfoOptions object data in request body. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetAttachmentInfoWithOptionsRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo HtmlGetAttachmentInfoWithOptions(HtmlGetAttachmentInfoWithOptionsRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetAttachmentInfoWithOptions");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling HtmlGetAttachmentInfoWithOptions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/attachments/{attachmentName}/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.DocumentInfoOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Downloads attachment page as HTML. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetAttachmentPageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream HtmlGetAttachmentPage(HtmlGetAttachmentPageRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetAttachmentPage");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling HtmlGetAttachmentPage");
            }

            // verify the required parameter 'pageNumber' is set
            if (request.PageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling HtmlGetAttachmentPage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/attachments/{attachmentName}/pages/{pageNumber}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "pageNumber", request.PageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resourcePath", request.ResourcePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreResourcePathInResources", request.IgnoreResourcePathInResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "embedResources", request.EmbedResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableMinification", request.EnableMinification);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableResponsiveRendering", request.EnableResponsiveRendering);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "excludeFonts", request.ExcludeFonts);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "attachmentPassword", request.AttachmentPassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Downloads HTML page resource (image, style, graphics or font). 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetAttachmentPageResourceRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream HtmlGetAttachmentPageResource(HtmlGetAttachmentPageResourceRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetAttachmentPageResource");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling HtmlGetAttachmentPageResource");
            }

            // verify the required parameter 'pageNumber' is set
            if (request.PageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling HtmlGetAttachmentPageResource");
            }

            // verify the required parameter 'resourceName' is set
            if (request.ResourceName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'resourceName' when calling HtmlGetAttachmentPageResource");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/attachments/{attachmentName}/pages/{pageNumber}/resources/{resourceName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "pageNumber", request.PageNumber);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "resourceName", request.ResourceName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Retrieves attachment pages as HTML. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetAttachmentPagesRequest" /></param>
        /// <returns><see cref="HtmlAttachmentPageCollection"/></returns>
        public HtmlAttachmentPageCollection HtmlGetAttachmentPages(HtmlGetAttachmentPagesRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetAttachmentPages");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling HtmlGetAttachmentPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/attachments/{attachmentName}/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resourcePath", request.ResourcePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreResourcePathInResources", request.IgnoreResourcePathInResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "embedResources", request.EmbedResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableMinification", request.EnableMinification);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableResponsiveRendering", request.EnableResponsiveRendering);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "excludeFonts", request.ExcludeFonts);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startPageNumber", request.StartPageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countPages", request.CountPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "attachmentPassword", request.AttachmentPassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (HtmlAttachmentPageCollection)SerializationHelper.Deserialize(response, typeof(HtmlAttachmentPageCollection));
            }

            return null;
        }

        /// <summary>
        /// Retrieves list of document attachments. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetAttachmentsRequest" /></param>
        /// <returns><see cref="AttachmentCollection"/></returns>
        public AttachmentCollection HtmlGetAttachments(HtmlGetAttachmentsRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetAttachments");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/attachments";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (AttachmentCollection)SerializationHelper.Deserialize(response, typeof(AttachmentCollection));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetDocumentInfoRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo HtmlGetDocumentInfo(HtmlGetDocumentInfoRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetDocumentInfo");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information for posted document. Content with document or multipart content is expected where first part is document and second is DocumentInfoOptions. Saves file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetDocumentInfoFromContentRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo HtmlGetDocumentInfoFromContent(HtmlGetDocumentInfoFromContentRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling HtmlGetDocumentInfoFromContent");
            }

            // verify the required parameter 'documentInfoOptions' is set
            if (request.DocumentInfoOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentInfoOptions' when calling HtmlGetDocumentInfoFromContent");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/html/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            if (request.DocumentInfoOptions != null) 
            {
                formParams.Add("documentInfoOptions", this.apiInvoker.ToFileInfo(request.DocumentInfoOptions, "DocumentInfoOptions"));
            }
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetDocumentInfoFromUrlRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo HtmlGetDocumentInfoFromUrl(HtmlGetDocumentInfoFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling HtmlGetDocumentInfoFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/html/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetDocumentInfoFromUrlWithOptionsRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo HtmlGetDocumentInfoFromUrlWithOptions(HtmlGetDocumentInfoFromUrlWithOptionsRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling HtmlGetDocumentInfoFromUrlWithOptions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/html/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.DocumentInfoOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information with specified DocumentInfoOptions. Expects DocumentInfoOptions object data in request body. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetDocumentInfoWithOptionsRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo HtmlGetDocumentInfoWithOptions(HtmlGetDocumentInfoWithOptionsRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetDocumentInfoWithOptions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.DocumentInfoOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Downloads document page as HTML. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetPageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream HtmlGetPage(HtmlGetPageRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetPage");
            }

            // verify the required parameter 'pageNumber' is set
            if (request.PageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling HtmlGetPage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/pages/{pageNumber}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "pageNumber", request.PageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resourcePath", request.ResourcePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreResourcePathInResources", request.IgnoreResourcePathInResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "embedResources", request.EmbedResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableMinification", request.EnableMinification);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableResponsiveRendering", request.EnableResponsiveRendering);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "excludeFonts", request.ExcludeFonts);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Downloads HTML page resource (image, style, graphics or font). 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetPageResourceRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream HtmlGetPageResource(HtmlGetPageResourceRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetPageResource");
            }

            // verify the required parameter 'pageNumber' is set
            if (request.PageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling HtmlGetPageResource");
            }

            // verify the required parameter 'resourceName' is set
            if (request.ResourceName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'resourceName' when calling HtmlGetPageResource");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/pages/{pageNumber}/resources/{resourceName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "pageNumber", request.PageNumber);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "resourceName", request.ResourceName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Retrieves list of document pages as HTML. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetPagesRequest" /></param>
        /// <returns><see cref="HtmlPageCollection"/></returns>
        public HtmlPageCollection HtmlGetPages(HtmlGetPagesRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resourcePath", request.ResourcePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreResourcePathInResources", request.IgnoreResourcePathInResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "embedResources", request.EmbedResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableMinification", request.EnableMinification);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableResponsiveRendering", request.EnableResponsiveRendering);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "excludeFonts", request.ExcludeFonts);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startPageNumber", request.StartPageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countPages", request.CountPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (HtmlPageCollection)SerializationHelper.Deserialize(response, typeof(HtmlPageCollection));
            }

            return null;
        }

        /// <summary>
        /// Retrieves list of document pages as HTML. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetPagesFromUrlRequest" /></param>
        /// <returns><see cref="HtmlPageCollection"/></returns>
        public HtmlPageCollection HtmlGetPagesFromUrl(HtmlGetPagesFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling HtmlGetPagesFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/html/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resourcePath", request.ResourcePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreResourcePathInResources", request.IgnoreResourcePathInResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "embedResources", request.EmbedResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableMinification", request.EnableMinification);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableResponsiveRendering", request.EnableResponsiveRendering);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "excludeFonts", request.ExcludeFonts);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startPageNumber", request.StartPageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countPages", request.CountPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (HtmlPageCollection)SerializationHelper.Deserialize(response, typeof(HtmlPageCollection));
            }

            return null;
        }

        /// <summary>
        /// Downloads document as PDF. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetPdfFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream HtmlGetPdfFile(HtmlGetPdfFileRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetPdfFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Downloads document at provided URL as PDF.  Document will be retrieved from the passed URL and added to Storage. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetPdfFileFromUrlRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream HtmlGetPdfFileFromUrl(HtmlGetPdfFileFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling HtmlGetPdfFileFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/html/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Retrieves attachment pages as HTML. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetZipWithAttachmentPagesRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream HtmlGetZipWithAttachmentPages(HtmlGetZipWithAttachmentPagesRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetZipWithAttachmentPages");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling HtmlGetZipWithAttachmentPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/attachments/{attachmentName}/pages/zip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resourcePath", request.ResourcePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreResourcePathInResources", request.IgnoreResourcePathInResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "embedResources", request.EmbedResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableMinification", request.EnableMinification);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableResponsiveRendering", request.EnableResponsiveRendering);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "excludeFonts", request.ExcludeFonts);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startPageNumber", request.StartPageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countPages", request.CountPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "attachmentPassword", request.AttachmentPassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Retrieves list of document pages as HTML. 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlGetZipWithPagesRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream HtmlGetZipWithPages(HtmlGetZipWithPagesRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlGetZipWithPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/pages/zip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resourcePath", request.ResourcePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreResourcePathInResources", request.IgnoreResourcePathInResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "embedResources", request.EmbedResources);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableMinification", request.EnableMinification);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableResponsiveRendering", request.EnableResponsiveRendering);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "excludeFonts", request.ExcludeFonts);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startPageNumber", request.StartPageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countPages", request.CountPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Rotates or reorders document page(s). 
        /// </summary>
        /// <param name="request">Request. <see cref="HtmlTransformPagesRequest" /></param>
        /// <returns><see cref="PageInfoCollection"/></returns>
        public PageInfoCollection HtmlTransformPages(HtmlTransformPagesRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling HtmlTransformPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/html/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.TransformOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (PageInfoCollection)SerializationHelper.Deserialize(response, typeof(PageInfoCollection));
            }

            return null;
        }

        /// <summary>
        /// Creates attachment cache. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageCreateAttachmentPagesCacheRequest" /></param>
        /// <returns><see cref="ImageAttachmentPageCollection"/></returns>
        public ImageAttachmentPageCollection ImageCreateAttachmentPagesCache(ImageCreateAttachmentPagesCacheRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageCreateAttachmentPagesCache");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling ImageCreateAttachmentPagesCache");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/attachments/{attachmentName}/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.ImageOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (ImageAttachmentPageCollection)SerializationHelper.Deserialize(response, typeof(ImageAttachmentPageCollection));
            }

            return null;
        }

        /// <summary>
        /// Creates document pages as image and saves them in cache.  Pages created before will be removed from cache. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageCreatePagesCacheRequest" /></param>
        /// <returns><see cref="ImagePageCollection"/></returns>
        public ImagePageCollection ImageCreatePagesCache(ImageCreatePagesCacheRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageCreatePagesCache");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.ImageOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (ImagePageCollection)SerializationHelper.Deserialize(response, typeof(ImagePageCollection));
            }

            return null;
        }

        /// <summary>
        /// Creates posted document pages as image and saves them in cache. Content with document or multipart content is expected where first part is document and second is HtmlOptions. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageCreatePagesCacheFromContentRequest" /></param>
        /// <returns><see cref="ImagePageCollection"/></returns>
        public ImagePageCollection ImageCreatePagesCacheFromContent(ImageCreatePagesCacheFromContentRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling ImageCreatePagesCacheFromContent");
            }

            // verify the required parameter 'imageOptions' is set
            if (request.ImageOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageOptions' when calling ImageCreatePagesCacheFromContent");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/image/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            if (request.ImageOptions != null) 
            {
                formParams.Add("imageOptions", this.apiInvoker.ToFileInfo(request.ImageOptions, "ImageOptions"));
            }
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);

            if (response != null)
            {
                return (ImagePageCollection)SerializationHelper.Deserialize(response, typeof(ImagePageCollection));
            }

            return null;
        }

        /// <summary>
        /// Creates pages as image and saves them in cache for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageCreatePagesCacheFromUrlRequest" /></param>
        /// <returns><see cref="ImagePageCollection"/></returns>
        public ImagePageCollection ImageCreatePagesCacheFromUrl(ImageCreatePagesCacheFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling ImageCreatePagesCacheFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/image/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.ImageOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (ImagePageCollection)SerializationHelper.Deserialize(response, typeof(ImagePageCollection));
            }

            return null;
        }

        /// <summary>
        /// Creates PDF document.  Removes PDF document if it was created before. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageCreatePdfFileRequest" /></param>
        /// <returns><see cref="PdfFileInfo"/></returns>
        public PdfFileInfo ImageCreatePdfFile(ImageCreatePdfFileRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageCreatePdfFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.PdfFileOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (PdfFileInfo)SerializationHelper.Deserialize(response, typeof(PdfFileInfo));
            }

            return null;
        }

        /// <summary>
        /// Creates PDF document from document passed in request body and saves it in cache. Content with document or multipart content is expected where first part is document and second is PdfFileOptions. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageCreatePdfFileFromContentRequest" /></param>
        /// <returns><see cref="PdfFileInfo"/></returns>
        public PdfFileInfo ImageCreatePdfFileFromContent(ImageCreatePdfFileFromContentRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling ImageCreatePdfFileFromContent");
            }

            // verify the required parameter 'pdfFileOptions' is set
            if (request.PdfFileOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pdfFileOptions' when calling ImageCreatePdfFileFromContent");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/image/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            if (request.PdfFileOptions != null) 
            {
                formParams.Add("pdfFileOptions", this.apiInvoker.ToFileInfo(request.PdfFileOptions, "PdfFileOptions"));
            }
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);

            if (response != null)
            {
                return (PdfFileInfo)SerializationHelper.Deserialize(response, typeof(PdfFileInfo));
            }

            return null;
        }

        /// <summary>
        /// Creates PDF document for document at provided URL and saves it in cache.  Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. Expects PdfFileOptions object data in request body. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageCreatePdfFileFromUrlRequest" /></param>
        /// <returns><see cref="PdfFileInfo"/></returns>
        public PdfFileInfo ImageCreatePdfFileFromUrl(ImageCreatePdfFileFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling ImageCreatePdfFileFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/image/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.PdfFileOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (PdfFileInfo)SerializationHelper.Deserialize(response, typeof(PdfFileInfo));
            }

            return null;
        }

        /// <summary>
        /// Removes attachment cache. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageDeleteAttachmentPagesCacheRequest" /></param>
        public void ImageDeleteAttachmentPagesCache(ImageDeleteAttachmentPagesCacheRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageDeleteAttachmentPagesCache");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling ImageDeleteAttachmentPagesCache");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/attachments/{attachmentName}/pages/cache";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Removes document cache. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageDeletePagesCacheRequest" /></param>
        public void ImageDeletePagesCache(ImageDeletePagesCacheRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageDeletePagesCache");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/pages/cache";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Downloads attachment. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetAttachmentRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ImageGetAttachment(ImageGetAttachmentRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetAttachment");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling ImageGetAttachment");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/attachments/{attachmentName}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Retrieves attachment information. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetAttachmentInfoRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo ImageGetAttachmentInfo(ImageGetAttachmentInfoRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetAttachmentInfo");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling ImageGetAttachmentInfo");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/attachments/{attachmentName}/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "extractText", request.ExtractText);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "attachmentPassword", request.AttachmentPassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves attachment information with specified DocumentInfoOptions. Expects DocumentInfoOptions object data in request body. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetAttachmentInfoWithOptionsRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo ImageGetAttachmentInfoWithOptions(ImageGetAttachmentInfoWithOptionsRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetAttachmentInfoWithOptions");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling ImageGetAttachmentInfoWithOptions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/attachments/{attachmentName}/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.DocumentInfoOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Downloads attachment page as image. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetAttachmentPageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ImageGetAttachmentPage(ImageGetAttachmentPageRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetAttachmentPage");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling ImageGetAttachmentPage");
            }

            // verify the required parameter 'pageNumber' is set
            if (request.PageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling ImageGetAttachmentPage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/attachments/{attachmentName}/pages/{pageNumber}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "pageNumber", request.PageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.Quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "attachmentPassword", request.AttachmentPassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "extractText", request.ExtractText);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Retrieves attachment pages as images. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetAttachmentPagesRequest" /></param>
        /// <returns><see cref="ImageAttachmentPageCollection"/></returns>
        public ImageAttachmentPageCollection ImageGetAttachmentPages(ImageGetAttachmentPagesRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetAttachmentPages");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling ImageGetAttachmentPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/attachments/{attachmentName}/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.Quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startPageNumber", request.StartPageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countPages", request.CountPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "attachmentPassword", request.AttachmentPassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "extractText", request.ExtractText);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (ImageAttachmentPageCollection)SerializationHelper.Deserialize(response, typeof(ImageAttachmentPageCollection));
            }

            return null;
        }

        /// <summary>
        /// Retrieves list of document attachments. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetAttachmentsRequest" /></param>
        /// <returns><see cref="AttachmentCollection"/></returns>
        public AttachmentCollection ImageGetAttachments(ImageGetAttachmentsRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetAttachments");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/attachments";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (AttachmentCollection)SerializationHelper.Deserialize(response, typeof(AttachmentCollection));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetDocumentInfoRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo ImageGetDocumentInfo(ImageGetDocumentInfoRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetDocumentInfo");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "extractText", request.ExtractText);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information for posted document. Content with document or multipart content is expected where first part is document and second is DocumentInfoOptions. Saves file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetDocumentInfoFromContentRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo ImageGetDocumentInfoFromContent(ImageGetDocumentInfoFromContentRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling ImageGetDocumentInfoFromContent");
            }

            // verify the required parameter 'documentInfoOptions' is set
            if (request.DocumentInfoOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentInfoOptions' when calling ImageGetDocumentInfoFromContent");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/image/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            if (request.DocumentInfoOptions != null) 
            {
                formParams.Add("documentInfoOptions", this.apiInvoker.ToFileInfo(request.DocumentInfoOptions, "DocumentInfoOptions"));
            }
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetDocumentInfoFromUrlRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo ImageGetDocumentInfoFromUrl(ImageGetDocumentInfoFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling ImageGetDocumentInfoFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/image/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "extractText", request.ExtractText);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetDocumentInfoFromUrlWithOptionsRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo ImageGetDocumentInfoFromUrlWithOptions(ImageGetDocumentInfoFromUrlWithOptionsRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling ImageGetDocumentInfoFromUrlWithOptions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/image/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.DocumentInfoOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Retrieves document information with specified options. Expects DocumentInfoOptions object data in request body. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetDocumentInfoWithOptionsRequest" /></param>
        /// <returns><see cref="DocumentInfo"/></returns>
        public DocumentInfo ImageGetDocumentInfoWithOptions(ImageGetDocumentInfoWithOptionsRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetDocumentInfoWithOptions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.DocumentInfoOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentInfo)SerializationHelper.Deserialize(response, typeof(DocumentInfo));
            }

            return null;
        }

        /// <summary>
        /// Downloads document page as image. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetPageRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ImageGetPage(ImageGetPageRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetPage");
            }

            // verify the required parameter 'pageNumber' is set
            if (request.PageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling ImageGetPage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/pages/{pageNumber}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "pageNumber", request.PageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.Quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "extractText", request.ExtractText);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Retrieves list of document pages as image. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetPagesRequest" /></param>
        /// <returns><see cref="ImagePageCollection"/></returns>
        public ImagePageCollection ImageGetPages(ImageGetPagesRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.Quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startPageNumber", request.StartPageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countPages", request.CountPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "extractText", request.ExtractText);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (ImagePageCollection)SerializationHelper.Deserialize(response, typeof(ImagePageCollection));
            }

            return null;
        }

        /// <summary>
        /// Retrieves list of document pages as image. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetPagesFromUrlRequest" /></param>
        /// <returns><see cref="ImagePageCollection"/></returns>
        public ImagePageCollection ImageGetPagesFromUrl(ImageGetPagesFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling ImageGetPagesFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/image/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.Quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startPageNumber", request.StartPageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countPages", request.CountPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "extractText", request.ExtractText);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (ImagePageCollection)SerializationHelper.Deserialize(response, typeof(ImagePageCollection));
            }

            return null;
        }

        /// <summary>
        /// Downloads document as PDF. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetPdfFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ImageGetPdfFile(ImageGetPdfFileRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetPdfFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Downloads document at provided URL as PDF.  Document will be retrieved from the passed URL and added to Storage. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetPdfFileFromUrlRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ImageGetPdfFileFromUrl(ImageGetPdfFileFromUrlRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null) 
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling ImageGetPdfFileFromUrl");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/image/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Retrieves attachment pages as images. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetZipWithAttachmentPagesRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ImageGetZipWithAttachmentPages(ImageGetZipWithAttachmentPagesRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetZipWithAttachmentPages");
            }

            // verify the required parameter 'attachmentName' is set
            if (request.AttachmentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'attachmentName' when calling ImageGetZipWithAttachmentPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/attachments/{attachmentName}/pages/zip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "attachmentName", request.AttachmentName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.Quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startPageNumber", request.StartPageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countPages", request.CountPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "attachmentPassword", request.AttachmentPassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "extractText", request.ExtractText);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Retrieves list of document pages as image. 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageGetZipWithPagesRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ImageGetZipWithPages(ImageGetZipWithPagesRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageGetZipWithPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/pages/zip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "quality", request.Quality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startPageNumber", request.StartPageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countPages", request.CountPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "extractText", request.ExtractText);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderComments", request.RenderComments);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "renderHiddenPages", request.RenderHiddenPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "defaultFontName", request.DefaultFontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Rotates or reorders document page(s). 
        /// </summary>
        /// <param name="request">Request. <see cref="ImageTransformPagesRequest" /></param>
        /// <returns><see cref="PageInfoCollection"/></returns>
        public PageInfoCollection ImageTransformPages(ImageTransformPagesRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling ImageTransformPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/viewer/{fileName}/image/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.TransformOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (PageInfoCollection)SerializationHelper.Deserialize(response, typeof(PageInfoCollection));
            }

            return null;
        }
    }
}
