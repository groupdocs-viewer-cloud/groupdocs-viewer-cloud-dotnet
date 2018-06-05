# GroupDocs.Viewer Cloud SDK for .NET
This repository contains GroupDocs.Viewer Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Viewer Cloud REST APIs in your .NET applications.

## How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/display/viewercloud/Available+SDKs#AvailableSDKs-.NET).

## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

## Dependencies
- [FubarCoder.RestSharp.Portable.Core](https://www.nuget.org/packages/Newtonsoft.Json) >=4.0.7
- [FubarCoder.RestSharp.Portable.HttpClient](https://www.nuget.org/packages/StyleCop.MSBuild) >=4.0.7
- [Newtonsoft.Json](https://www.nuget.org/packages/StyleCop.MSBuild) >=10.0.3
- [JsonSubTypes](https://www.nuget.org/packages/StyleCop.MSBuild) >=1.1.3

NOTE: The DLLs included in the package may not be up to date. We recommended using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package FubarCoder.RestSharp.Portable.Core
Install-Package FubarCoder.RestSharp.Portable.HttpClient
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
``` 

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
        public void Main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            
            var appSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
            var appKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"

            var api = new ViewerApi(appSid, appKey);

            try
            {
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
All GroupDocs.Viewer for Cloud SDKs are licensed under [MIT License](LICENSE).

## Resources
+ [**Website**](https://www.groupdocs.cloud)
+ [**Product Home**](https://products.groupdocs.cloud/viewer/cloud)
+ [**Documentation**](https://docs.groupdocs.cloud/display/viewercloud/Home)
+ [**Free Support Forum**](https://forum.groupdocs.cloud/c/viewer)
+ [**Blog**](https://blog.groupdocs.cloud/category/groupdocs-viewer-cloud-product-family)

## Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.groupdocs.cloud/c/viewer).
