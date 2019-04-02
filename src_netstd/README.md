# GroupDocs.Viewer.Cloud.Sdk - the C# library for the GroupDocs.Viewer Cloud API

- API version: 19.3
- SDK version: 19.3.1
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=9.0.1

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new ViewerApi();

            try
            {
                // Removes fonts cache.
                apiInstance.DeleteFontsCache();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewerApi.DeleteFontsCache: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.groupdocs.cloud/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ViewerApi* | [**DeleteFontsCache**](docs/ViewerApi.md#deletefontscache) | **DELETE** /viewer/fonts/cache | Removes fonts cache.
*ViewerApi* | [**GetFonts**](docs/ViewerApi.md#getfonts) | **GET** /viewer/fonts | List installed fonts.
*ViewerApi* | [**GetSupportedFileFormats**](docs/ViewerApi.md#getsupportedfileformats) | **GET** /viewer/formats | Retrieves list of supported file formats.
*ViewerApi* | [**HtmlCreateAttachmentPagesCache**](docs/ViewerApi.md#htmlcreateattachmentpagescache) | **POST** /viewer/{fileName}/html/attachments/{attachmentName}/pages | Creates attachment cache. 
*ViewerApi* | [**HtmlCreatePagesCache**](docs/ViewerApi.md#htmlcreatepagescache) | **POST** /viewer/{fileName}/html/pages | Creates document pages as HTML and saves them in cache. Pages created before will be removed from cache.
*ViewerApi* | [**HtmlCreatePagesCacheFromContent**](docs/ViewerApi.md#htmlcreatepagescachefromcontent) | **POST** /viewer/html/pages | Creates posted document pages as HTML and saves them in cache. Content with document or multipart content is expected where first part is document and second is HtmlOptions. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**HtmlCreatePagesCacheFromUrl**](docs/ViewerApi.md#htmlcreatepagescachefromurl) | **PUT** /viewer/html/pages | Creates pages as HTML and saves them in cache for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**HtmlCreatePdfFile**](docs/ViewerApi.md#htmlcreatepdffile) | **POST** /viewer/{fileName}/html/pdf | Creates PDF document.  Removes PDF document if it was created before.
*ViewerApi* | [**HtmlCreatePdfFileFromContent**](docs/ViewerApi.md#htmlcreatepdffilefromcontent) | **POST** /viewer/html/pdf | Creates PDF document from document passed in request body and saves it in cache. Content with document or multipart content is expected where first part is document and second is PdfFileOptions. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**HtmlCreatePdfFileFromUrl**](docs/ViewerApi.md#htmlcreatepdffilefromurl) | **PUT** /viewer/html/pdf | Creates PDF document for document at provided URL and saves it in cache.  Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. Expects PdfFileOptions﻿ object data in request body.
*ViewerApi* | [**HtmlDeleteAttachmentPagesCache**](docs/ViewerApi.md#htmldeleteattachmentpagescache) | **DELETE** /viewer/{fileName}/html/attachments/{attachmentName}/pages/cache | Removes attachment cache.
*ViewerApi* | [**HtmlDeletePagesCache**](docs/ViewerApi.md#htmldeletepagescache) | **DELETE** /viewer/{fileName}/html/pages/cache | Removes document cache.
*ViewerApi* | [**HtmlGetAttachment**](docs/ViewerApi.md#htmlgetattachment) | **GET** /viewer/{fileName}/html/attachments/{attachmentName} | Downloads attachment.
*ViewerApi* | [**HtmlGetAttachmentInfo**](docs/ViewerApi.md#htmlgetattachmentinfo) | **GET** /viewer/{fileName}/html/attachments/{attachmentName}/info | Retrieves attachment information.
*ViewerApi* | [**HtmlGetAttachmentInfoWithOptions**](docs/ViewerApi.md#htmlgetattachmentinfowithoptions) | **POST** /viewer/{fileName}/html/attachments/{attachmentName}/info | Retrieves attachment information with specified DocumentInfoOptions. Expects DocumentInfoOptions object data in request body.
*ViewerApi* | [**HtmlGetAttachmentPage**](docs/ViewerApi.md#htmlgetattachmentpage) | **GET** /viewer/{fileName}/html/attachments/{attachmentName}/pages/{pageNumber} | Downloads attachment page as HTML.
*ViewerApi* | [**HtmlGetAttachmentPageResource**](docs/ViewerApi.md#htmlgetattachmentpageresource) | **GET** /viewer/{fileName}/html/attachments/{attachmentName}/pages/{pageNumber}/resources/{resourceName} | Downloads HTML page resource (image, style, graphics or font).
*ViewerApi* | [**HtmlGetAttachmentPages**](docs/ViewerApi.md#htmlgetattachmentpages) | **GET** /viewer/{fileName}/html/attachments/{attachmentName}/pages | Retrieves attachment pages as HTML.
*ViewerApi* | [**HtmlGetAttachments**](docs/ViewerApi.md#htmlgetattachments) | **GET** /viewer/{fileName}/html/attachments | Retrieves list of document attachments.
*ViewerApi* | [**HtmlGetDocumentInfo**](docs/ViewerApi.md#htmlgetdocumentinfo) | **GET** /viewer/{fileName}/html/info | Retrieves document information.
*ViewerApi* | [**HtmlGetDocumentInfoFromContent**](docs/ViewerApi.md#htmlgetdocumentinfofromcontent) | **POST** /viewer/html/info | Retrieves document information for posted document. Content with document or multipart content is expected where first part is document and second is DocumentInfoOptions. Saves file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**HtmlGetDocumentInfoFromUrl**](docs/ViewerApi.md#htmlgetdocumentinfofromurl) | **GET** /viewer/html/info | Retrieves document information for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**HtmlGetDocumentInfoFromUrlWithOptions**](docs/ViewerApi.md#htmlgetdocumentinfofromurlwithoptions) | **PUT** /viewer/html/info | Retrieves document information for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**HtmlGetDocumentInfoWithOptions**](docs/ViewerApi.md#htmlgetdocumentinfowithoptions) | **POST** /viewer/{fileName}/html/info | Retrieves document information with specified DocumentInfoOptions. Expects DocumentInfoOptions object data in request body.
*ViewerApi* | [**HtmlGetPage**](docs/ViewerApi.md#htmlgetpage) | **GET** /viewer/{fileName}/html/pages/{pageNumber} | Downloads document page as HTML.
*ViewerApi* | [**HtmlGetPageResource**](docs/ViewerApi.md#htmlgetpageresource) | **GET** /viewer/{fileName}/html/pages/{pageNumber}/resources/{resourceName} | Downloads HTML page resource (image, style, graphics or font).
*ViewerApi* | [**HtmlGetPages**](docs/ViewerApi.md#htmlgetpages) | **GET** /viewer/{fileName}/html/pages | Retrieves list of document pages as HTML.
*ViewerApi* | [**HtmlGetPagesFromUrl**](docs/ViewerApi.md#htmlgetpagesfromurl) | **GET** /viewer/html/pages | Retrieves list of document pages as HTML.
*ViewerApi* | [**HtmlGetPdfFile**](docs/ViewerApi.md#htmlgetpdffile) | **GET** /viewer/{fileName}/html/pdf | Downloads document as PDF.
*ViewerApi* | [**HtmlGetPdfFileFromUrl**](docs/ViewerApi.md#htmlgetpdffilefromurl) | **GET** /viewer/html/pdf | Downloads document at provided URL as PDF.  Document will be retrieved from the passed URL and added to Storage.
*ViewerApi* | [**HtmlGetZipWithAttachmentPages**](docs/ViewerApi.md#htmlgetzipwithattachmentpages) | **GET** /viewer/{fileName}/html/attachments/{attachmentName}/pages/zip | Retrieves attachment pages as HTML.
*ViewerApi* | [**HtmlGetZipWithPages**](docs/ViewerApi.md#htmlgetzipwithpages) | **GET** /viewer/{fileName}/html/pages/zip | Retrieves list of document pages as HTML.
*ViewerApi* | [**HtmlTransformPages**](docs/ViewerApi.md#htmltransformpages) | **PUT** /viewer/{fileName}/html/pages | Rotates or reorders document page(s).
*ViewerApi* | [**ImageCreateAttachmentPagesCache**](docs/ViewerApi.md#imagecreateattachmentpagescache) | **POST** /viewer/{fileName}/image/attachments/{attachmentName}/pages | Creates attachment cache.
*ViewerApi* | [**ImageCreatePagesCache**](docs/ViewerApi.md#imagecreatepagescache) | **POST** /viewer/{fileName}/image/pages | Creates document pages as image and saves them in cache.  Pages created before will be removed from cache.
*ViewerApi* | [**ImageCreatePagesCacheFromContent**](docs/ViewerApi.md#imagecreatepagescachefromcontent) | **POST** /viewer/image/pages | Creates posted document pages as image and saves them in cache. Content with document or multipart content is expected where first part is document and second is HtmlOptions. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**ImageCreatePagesCacheFromUrl**](docs/ViewerApi.md#imagecreatepagescachefromurl) | **PUT** /viewer/image/pages | Creates pages as image and saves them in cache for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**ImageCreatePdfFile**](docs/ViewerApi.md#imagecreatepdffile) | **POST** /viewer/{fileName}/image/pdf | Creates PDF document.  Removes PDF document if it was created before.
*ViewerApi* | [**ImageCreatePdfFileFromContent**](docs/ViewerApi.md#imagecreatepdffilefromcontent) | **POST** /viewer/image/pdf | Creates PDF document from document passed in request body and saves it in cache. Content with document or multipart content is expected where first part is document and second is PdfFileOptions. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**ImageCreatePdfFileFromUrl**](docs/ViewerApi.md#imagecreatepdffilefromurl) | **PUT** /viewer/image/pdf | Creates PDF document for document at provided URL and saves it in cache.  Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file. Expects PdfFileOptions﻿ object data in request body.
*ViewerApi* | [**ImageDeleteAttachmentPagesCache**](docs/ViewerApi.md#imagedeleteattachmentpagescache) | **DELETE** /viewer/{fileName}/image/attachments/{attachmentName}/pages/cache | Removes attachment cache.
*ViewerApi* | [**ImageDeletePagesCache**](docs/ViewerApi.md#imagedeletepagescache) | **DELETE** /viewer/{fileName}/image/pages/cache | Removes document cache.
*ViewerApi* | [**ImageGetAttachment**](docs/ViewerApi.md#imagegetattachment) | **GET** /viewer/{fileName}/image/attachments/{attachmentName} | Downloads attachment.
*ViewerApi* | [**ImageGetAttachmentInfo**](docs/ViewerApi.md#imagegetattachmentinfo) | **GET** /viewer/{fileName}/image/attachments/{attachmentName}/info | Retrieves attachment information.
*ViewerApi* | [**ImageGetAttachmentInfoWithOptions**](docs/ViewerApi.md#imagegetattachmentinfowithoptions) | **POST** /viewer/{fileName}/image/attachments/{attachmentName}/info | Retrieves attachment information with specified DocumentInfoOptions. Expects DocumentInfoOptions object data in request body.
*ViewerApi* | [**ImageGetAttachmentPage**](docs/ViewerApi.md#imagegetattachmentpage) | **GET** /viewer/{fileName}/image/attachments/{attachmentName}/pages/{pageNumber} | Downloads attachment page as image.
*ViewerApi* | [**ImageGetAttachmentPages**](docs/ViewerApi.md#imagegetattachmentpages) | **GET** /viewer/{fileName}/image/attachments/{attachmentName}/pages | Retrieves attachment pages as images.
*ViewerApi* | [**ImageGetAttachments**](docs/ViewerApi.md#imagegetattachments) | **GET** /viewer/{fileName}/image/attachments | Retrieves list of document attachments.
*ViewerApi* | [**ImageGetDocumentInfo**](docs/ViewerApi.md#imagegetdocumentinfo) | **GET** /viewer/{fileName}/image/info | Retrieves document information.
*ViewerApi* | [**ImageGetDocumentInfoFromContent**](docs/ViewerApi.md#imagegetdocumentinfofromcontent) | **POST** /viewer/image/info | Retrieves document information for posted document. Content with document or multipart content is expected where first part is document and second is DocumentInfoOptions. Saves file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**ImageGetDocumentInfoFromUrl**](docs/ViewerApi.md#imagegetdocumentinfofromurl) | **GET** /viewer/image/info | Retrieves document information for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**ImageGetDocumentInfoFromUrlWithOptions**](docs/ViewerApi.md#imagegetdocumentinfofromurlwithoptions) | **PUT** /viewer/image/info | Retrieves document information for document at provided URL. Retrieves file from specified URL and tries to detect file type when fileName parameter is not specified. Saves retrieved file in storage. Use fileName and folder parameters to specify desired file name and folder to save file. When file with specified name already exists in storage new unique file name will be used for file.
*ViewerApi* | [**ImageGetDocumentInfoWithOptions**](docs/ViewerApi.md#imagegetdocumentinfowithoptions) | **POST** /viewer/{fileName}/image/info | Retrieves document information with specified options. Expects DocumentInfoOptions object data in request body.
*ViewerApi* | [**ImageGetPage**](docs/ViewerApi.md#imagegetpage) | **GET** /viewer/{fileName}/image/pages/{pageNumber} | Downloads document page as image.
*ViewerApi* | [**ImageGetPages**](docs/ViewerApi.md#imagegetpages) | **GET** /viewer/{fileName}/image/pages | Retrieves list of document pages as image.
*ViewerApi* | [**ImageGetPagesFromUrl**](docs/ViewerApi.md#imagegetpagesfromurl) | **GET** /viewer/image/pages | Retrieves list of document pages as image.
*ViewerApi* | [**ImageGetPdfFile**](docs/ViewerApi.md#imagegetpdffile) | **GET** /viewer/{fileName}/image/pdf | Downloads document as PDF.
*ViewerApi* | [**ImageGetPdfFileFromUrl**](docs/ViewerApi.md#imagegetpdffilefromurl) | **GET** /viewer/image/pdf | Downloads document at provided URL as PDF.  Document will be retrieved from the passed URL and added to Storage.
*ViewerApi* | [**ImageGetZipWithAttachmentPages**](docs/ViewerApi.md#imagegetzipwithattachmentpages) | **GET** /viewer/{fileName}/image/attachments/{attachmentName}/pages/zip | Retrieves attachment pages as images.
*ViewerApi* | [**ImageGetZipWithPages**](docs/ViewerApi.md#imagegetzipwithpages) | **GET** /viewer/{fileName}/image/pages/zip | Retrieves list of document pages as image.
*ViewerApi* | [**ImageTransformPages**](docs/ViewerApi.md#imagetransformpages) | **PUT** /viewer/{fileName}/image/pages | Rotates or reorders document page(s).


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AttachmentCollection](docs/AttachmentCollection.md)
 - [Model.AttachmentInfo](docs/AttachmentInfo.md)
 - [Model.CadOptions](docs/CadOptions.md)
 - [Model.CellsOptions](docs/CellsOptions.md)
 - [Model.DocumentInfo](docs/DocumentInfo.md)
 - [Model.EmailOptions](docs/EmailOptions.md)
 - [Model.FileResponse](docs/FileResponse.md)
 - [Model.FontCollection](docs/FontCollection.md)
 - [Model.FontFamily](docs/FontFamily.md)
 - [Model.Format](docs/Format.md)
 - [Model.FormatCollection](docs/FormatCollection.md)
 - [Model.HtmlAttachmentPageCollection](docs/HtmlAttachmentPageCollection.md)
 - [Model.HtmlPageCollection](docs/HtmlPageCollection.md)
 - [Model.ImageAttachmentPageCollection](docs/ImageAttachmentPageCollection.md)
 - [Model.PageInfo](docs/PageInfo.md)
 - [Model.PageInfoCollection](docs/PageInfoCollection.md)
 - [Model.PdfOptions](docs/PdfOptions.md)
 - [Model.ProjectOptions](docs/ProjectOptions.md)
 - [Model.RenderOptionsBase](docs/RenderOptionsBase.md)
 - [Model.ResourceUrl](docs/ResourceUrl.md)
 - [Model.RowInfo](docs/RowInfo.md)
 - [Model.SlidesOptions](docs/SlidesOptions.md)
 - [Model.TransformOptionsBase](docs/TransformOptionsBase.md)
 - [Model.Watermark](docs/Watermark.md)
 - [Model.WordsOptions](docs/WordsOptions.md)
 - [Model.Attachment](docs/Attachment.md)
 - [Model.DocumentInfoOptions](docs/DocumentInfoOptions.md)
 - [Model.HtmlPage](docs/HtmlPage.md)
 - [Model.ImagePage](docs/ImagePage.md)
 - [Model.ImagePageCollection](docs/ImagePageCollection.md)
 - [Model.PdfFileInfo](docs/PdfFileInfo.md)
 - [Model.PdfFileOptions](docs/PdfFileOptions.md)
 - [Model.RenderOptions](docs/RenderOptions.md)
 - [Model.ReorderOptions](docs/ReorderOptions.md)
 - [Model.Resource](docs/Resource.md)
 - [Model.RotateOptions](docs/RotateOptions.md)
 - [Model.HtmlOptions](docs/HtmlOptions.md)
 - [Model.ImageOptions](docs/ImageOptions.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="appsid"></a>
### appsid

- **Type**: API key
- **API key parameter name**: Appsid
- **Location**: URL query string

<a name="oauth"></a>
### oauth

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: localhost/oauth2/token
- **Scopes**: N/A

<a name="signature"></a>
### signature

- **Type**: API key
- **API key parameter name**: Signature
- **Location**: URL query string

