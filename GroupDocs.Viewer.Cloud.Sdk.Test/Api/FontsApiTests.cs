namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

    public class FontsApiTests : BaseApiTest
    {
        /// <summary>
        /// Test GetFonts
        /// </summary>
        [Test]
        public void GetFontsTest()
        {
            var request = new GetFontsRequest();

            var response = ViewerApi.GetFonts(request);

            Assert.IsTrue(response.Families.Count > 0);
            foreach (var entry in response.Families)
                Assert.IsNotEmpty(entry.Name);
        }

        /// <summary>
        /// Test DeleteFontsCache
        /// </summary>
        [Test]
        public void DeleteFontsCacheTest()
        {
            var request = new DeleteFontsCacheRequest();

            ViewerApi.DeleteFontsCache(request);
        }
    }
}