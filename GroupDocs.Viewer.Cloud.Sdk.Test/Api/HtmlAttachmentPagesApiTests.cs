namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;

    public class HtmlAttachmentPagesApiTests : BaseApiTest
    {
        /// <summary>
        /// Test HtmlGetAttachmentPage
        /// </summary>
        [Test]
        public void HtmlGetAttachmentPageTest()
        {
            var file = TestFiles.WithAttachmentMsg;
            var pageNumber = 1;

            var request = new HtmlGetAttachmentPageRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                PageNumber = pageNumber,
                ResourcePath = null,
                IgnoreResourcePathInResources = null,
                EmbedResources = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Password = null,
                AttachmentPassword = file.AttachmentPassword,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetAttachmentPage(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test HtmlGetAttachmentPages
        /// </summary>
        [Test]
        public void HtmlGetAttachmentPagesTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new HtmlGetAttachmentPagesRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                ResourcePath = null,
                IgnoreResourcePathInResources = null,
                EmbedResources = null,
                StartPageNumber = null,
                CountPages = null,
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

            Assert.AreEqual(1, response.Pages.Count);
            Assert.AreEqual("with-attachment.msg", response.FileName);
            Assert.AreEqual("password-protected.docx", response.AttachmentName);
            Assert.AreEqual("email\\msg", response.Folder);
        }

        /// <summary>
        /// Test HtmlGetZipWithAttachmentPages
        /// </summary>
        [Test]
        public void HtmlGetZipWithAttachmentPagesTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new HtmlGetZipWithAttachmentPagesRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                ResourcePath = "./r{page-number}/{resource-name}",
                IgnoreResourcePathInResources = null,
                EmbedResources = null,
                StartPageNumber = null,
                CountPages = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Password = null,
                AttachmentPassword = file.AttachmentPassword,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetZipWithAttachmentPages(request);

            Assert.IsInstanceOf<System.IO.Stream> (response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test HtmlCreateAttachmentPagesCache
        /// </summary>
        [Test]
        public void HtmlCreateAttachmentPagesCacheTest()
        {
            var file = TestFiles.WithAttachmentPdf;

            var request = new HtmlCreateAttachmentPagesCacheRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                HtmlOptions = new HtmlOptions
                {
                    AttachmentPassword = file.AttachmentPassword
                },
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlCreateAttachmentPagesCache(request);

            Assert.AreEqual(1, response.Pages.Count);
            Assert.AreEqual("with-attachment.pdf", response.FileName);
            Assert.AreEqual("password-protected.docx", response.AttachmentName);
            Assert.AreEqual("pdf\\pdf", response.Folder);
        }

        /// <summary>
        /// Test HtmlDeleteAttachmentPagesCache
        /// </summary>
        [Test]
        public void HtmlDeleteAttachmentPagesCacheTest()
        {
            var file = TestFiles.WithAttachmentPdf;

            var request = new HtmlDeleteAttachmentPagesCacheRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                Folder = file.Folder,
                Storage = null,
            };

            ViewerApi.HtmlDeleteAttachmentPagesCache(request);
        }
    }
}