# GroupDocs.Viewer Cloud SDK for .NET
This repository contains GroupDocs.Viewer Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Viewer Cloud REST APIs in your .NET applications.

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

## Dependencies
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Viewer.Cloud.Sdk.Api;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            var appSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";
            var appKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

            var api = new InfoApi(appSid, appKey);

            try
            {
                // Get supported file formats
                var response = api.GetSupportedFileFormats();

                foreach (var format in response.Formats)
                {
                    Debug.Print(format.ToString());
                }
            }
            catch (Exception e)
            {
                Debug.Print("Something went wrong: " + e.Message);
            }
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