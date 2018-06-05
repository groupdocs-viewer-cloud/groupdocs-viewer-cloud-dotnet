namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    public class FontsApiTests : BaseApiTest
    {
        /// <summary>
        /// Test GetFonts
        /// </summary>
        [Test]
        public void GetFontsTest()
        {
            var response = ViewerApi.GetFonts();

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
            ViewerApi.DeleteFontsCache();
        }
    }
}