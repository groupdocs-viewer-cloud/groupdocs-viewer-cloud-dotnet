namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    public class FormatsApiTests : BaseApiTest
    {
        /// <summary>
        /// Test GetSupportedFileFormats
        /// </summary>
        [Test]
        public void GetSupportedFileFormatsTest()
        {
            var response = ViewerApi.GetSupportedFileFormats();

            Assert.IsTrue(response.Formats.Count > 0);
            foreach (var entry in response.Formats)
            {
                Assert.IsNotEmpty(entry.Extension);
                Assert.IsNotEmpty(entry.FileFormat);
            }
        }
    }
}