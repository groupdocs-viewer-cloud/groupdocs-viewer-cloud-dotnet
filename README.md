# GroupDocs.Viewer Cloud SDK for .NET
This repository contains GroupDocs.Viewer Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Viewer Cloud REST APIs in your .NET applications, which allows rendering a specific document in HTML, image or PDF format with the flexibility to render the whole document or custom range of pages.

## How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/display/viewercloud/Available+SDKs#AvailableSDKs-.NET).

## Installation

Install GroupDocs.Viewer-Cloud via NuGet

From the command line:

	nuget install GroupDocs.Viewer-Cloud

From Package Manager:

	PM> Install-Package GroupDocs.Viewer-Cloud

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "GroupDocs.Viewer-Cloud".
5. Click on the GroupDocs.Viewer-Cloud package, select the appropriate version in the right-tab and click *Install*.

## Getting Started

Below is an example demonstrating how to preview document using GroupDocs.Viewer Cloud SDK for .NET.

```csharp
using System;
using System.IO;
using System.Diagnostics;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            // For complete examples and data files, please go to https://github.com/groupdocs-viewer-cloud/groupdocs-viewer-cloud-dotnet-samples
            string MyClientSecret = ""; // Get Client Id and Client Secret from https://dashboard.groupdocs.cloud
            string MyClientId = ""; // Get Client Id and Client Secret from https://dashboard.groupdocs.cloud

            var configuration = new Configuration(MyClientId, MyClientSecret);
            var apiInstance = new ViewApi(configuration);

            var format = "jpg";
            var request = new ConvertAndDownloadRequest(format, File.OpenRead("myfile.docx"));
            var result = apiInstance.ConvertAndDownload(request);
            
            // Use resulting stream (a *.jpg file) for your purpose
        }
    }
}
```

Below is an example demonstrating how to upload the document, render it, and download the result using GroupDocs.Viewer Cloud SDK for .NET.

```csharp
using System;
using System.IO;
using System.Diagnostics;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            // For complete examples and data files, please go to https://github.com/groupdocs-viewer-cloud/groupdocs-viewer-cloud-dotnet-samples
            string MyClientSecret = ""; // Get Client Id and Client Secret from https://dashboard.groupdocs.cloud
            string MyClientId = ""; // Get Client Id and Client Secret from https://dashboard.groupdocs.cloud

            var configuration = new Configuration(MyClientId, MyClientSecret);

            // Upload a file to cloud storage
            var fileApi = new FileApi(configuration);
            fileApi.UploadFile(new UploadFileRequest("myfile.docx", File.Open("myfile.docx", FileMode.Open)));

            // Render it to html
            var viewOptions = new ViewOptions
            {
                FileInfo = new FileInfo
                {
                    FilePath = "myfile.docx"
                },
                ViewFormat = ViewOptions.ViewFormatEnum.HTML,
                OutputPath = "myfile.html"
            };
            var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
            
            // Download the result
		    var result = fileApi.DownloadFile(new DownloadFileRequest("myfile.html"));
            
            //Use resulting stream (a *.html file in this example) for your purpose
        }
    }
}
```


## Licensing
All GroupDocs.Viewer Cloud SDKs are licensed under [MIT License](LICENSE).

## Resources
+ [**Website**](https://www.groupdocs.cloud)
+ [**Product Home**](https://products.groupdocs.cloud/viewer)
+ [**Documentation**](https://docs.groupdocs.cloud/display/viewercloud/Home)
+ [**Free Support Forum**](https://forum.groupdocs.cloud/c/viewer)
+ [**Blog**](https://blog.groupdocs.cloud/category/viewer)

## Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.groupdocs.cloud/c/viewer).