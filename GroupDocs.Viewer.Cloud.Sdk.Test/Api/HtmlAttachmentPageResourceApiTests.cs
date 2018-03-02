namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;

    public class HtmlAttachmentPageResourceApiTests : BaseApiTest
    {
        /// <summary>
        /// Test HtmlGetAttachmentPageResource
        /// </summary>
        [Test]
        public void HtmlGetAttachmentPageResourceTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var pagesCollection = GetPageCollection(file);
            var page = pagesCollection.Pages[0];

            foreach (var resource in page.Resources)
            {
                var request = new HtmlGetAttachmentPageResourceRequest
                {
                    FileName = file.FileName,
                    AttachmentName = file.AttachmentName,
                    PageNumber = page.Number,
                    ResourceName = resource.Name,
                    Folder = file.Folder,
                    Storage = null,
                };

                var response = ViewerApi.HtmlGetAttachmentPageResource(request);

                Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
                Assert.IsTrue(response.Length > 0);
            }
        }

        private HtmlAttachmentPageCollection GetPageCollection(TestFile file)
        {
            var request = new HtmlGetAttachmentPagesRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                ResourcePath = null,
                IgnoreResourcePathInResources = null,
                EmbedResources = false,
                StartPageNumber = 1,
                CountPages = 1,
                RenderComments = null,
                RenderHiddenPages = null,
                Password = null,
                AttachmentPassword = file.AttachmentPassword,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetAttachmentPages(request);
            Assert.IsInstanceOf<HtmlAttachmentPageCollection>(response, "Expected response type is HtmlAttachmentPageCollection");

            return response;
        }
    }
}