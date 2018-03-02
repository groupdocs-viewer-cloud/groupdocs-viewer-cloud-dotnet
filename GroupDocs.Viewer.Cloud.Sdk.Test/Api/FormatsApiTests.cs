namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

    public class FormatsApiTests : BaseApiTest
    {
        /// <summary>
        /// Test GetSupportedFileFormats
        /// </summary>
        [Test]
        public void GetSupportedFileFormatsTest()
        {
            var request = new GetSupportedFileFormatsRequest();

            var response = ViewerApi.GetSupportedFileFormats(request);

            Assert.IsTrue(response.Formats.Count > 0);
            foreach (var entry in response.Formats)
            {
                Assert.IsNotEmpty(entry.Extension);
                Assert.IsNotEmpty(entry.FileFormat);
            }
        }
    }
}