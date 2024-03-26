using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    public class ConvertAndDownloadApiTests : BaseApiTest
    {
        [Test]
        public void ConvertAndDownloadJpgTest()
        {
            var format = "jpg";
            var testFile = TestFiles.OnePageDocx;

            var request = new ConvertAndDownloadRequest(format, GetTestFileStream(testFile));
            var result = ViewApi.ConvertAndDownload(request);

            Assert.IsNotNull(result);
            Assert.Greater(result.Length, 0);
        }
    }
}
