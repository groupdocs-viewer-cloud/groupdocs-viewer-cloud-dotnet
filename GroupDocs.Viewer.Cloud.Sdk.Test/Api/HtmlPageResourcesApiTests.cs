namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;

    public class HtmlPageResourcesApiTests : BaseApiTest
    {
        /// <summary>
        /// Test HtmlGetPageResource
        /// </summary>
        [Test]
        public void HtmlGetPageResourceTest()
        {
            var file = TestFiles.OnePageDocx;

            var pageCollection = GetPageCollection(file);
            var page = pageCollection.Pages[0];

            Assert.IsTrue(page.Resources.Count > 0);

            foreach (var resource in page.Resources)
            {
                var request = new HtmlGetPageResourceRequest
                {
                    FileName = file.FileName,
                    PageNumber = page.Number,
                    ResourceName = resource.Name,
                    Folder = file.Folder,
                    Storage = null,
                };

                var response = ViewerApi.HtmlGetPageResource(request);

                Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
                Assert.IsTrue(response.Length > 0);
            }
        }

        private HtmlPageCollection GetPageCollection(TestFile file)
        {
            var request = new HtmlGetPagesRequest
            {
                FileName = file.FileName,
                ResourcePath = null,
                IgnoreResourcePathInResources = null,
                EmbedResources = false,
                StartPageNumber = null,
                CountPages = null,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null,
            };

            return ViewerApi.HtmlGetPages(request);
        }
    }
}