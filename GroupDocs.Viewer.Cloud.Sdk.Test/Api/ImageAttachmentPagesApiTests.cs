namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Internal;

    public class ImageAttachmentPagesApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ImageGetAttachmentPage
        /// </summary>
        [Test]
        public void ImageGetAttachmentPageTest()
        {
            var file = TestFiles.WithAttachmentMsg;
            var pageNumber = 1;

            var request = new ImageGetAttachmentPageRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                PageNumber = pageNumber,
                Format = null,
                Width = null,
                Height = null,
                Quality = null,
                Password = null,
                AttachmentPassword = file.AttachmentPassword,
                ExtractText = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetAttachmentPage(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageGetAttachmentPages
        /// </summary>
        [Test]
        public void ImageGetAttachmentPagesTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new ImageGetAttachmentPagesRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                Format = null,
                Width = null,
                Height = null,
                Quality = null,
                StartPageNumber = null,
                CountPages = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Password = null,
                AttachmentPassword = file.AttachmentPassword,
                ExtractText = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetAttachmentPages(request);

            Assert.AreEqual(1, response.Pages.Count);
            Assert.AreEqual("with-attachment.msg", response.FileName);
            Assert.AreEqual("password-protected.docx", response.AttachmentName);
            Assert.AreEqual("email\\msg", response.Folder);
        }

        /// <summary>
        /// Test ImageGetZipWithAttachmentPages
        /// </summary>
        [Test]
        public void ImageGetZipWithImageAttachmentPagesTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new ImageGetZipWithAttachmentPagesRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                Format = null,
                Width = null,
                Height = null,
                Quality = null,
                StartPageNumber = null,
                CountPages = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Password = null,
                AttachmentPassword = file.AttachmentPassword,
                ExtractText = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetZipWithAttachmentPages(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageCreateAttachmentPagesCache
        /// </summary>
        [Test]
        public void ImageCreateAttachmentPagesCacheTest()
        {
            var file = TestFiles.WithAttachmentPdf;

            var request = new ImageCreateAttachmentPagesCacheRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                ImageOptions = new ImageOptions
                {
                    AttachmentPassword = file.AttachmentPassword
                },
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageCreateAttachmentPagesCache(request);

            Assert.AreEqual(1, response.Pages.Count);
            Assert.AreEqual("with-attachment.pdf", response.FileName);
            Assert.AreEqual("password-protected.docx", response.AttachmentName);
            Assert.AreEqual("pdf\\pdf", response.Folder);
        }

        /// <summary>
        /// Test ImageDeleteAttachmentPagesCache
        /// </summary>
        [Test]
        public void ImageDeleteAttachmentPagesCacheTest()
        {
            var file = TestFiles.WithAttachmentPdf;

            var request = new ImageDeleteAttachmentPagesCacheRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                Folder = file.Folder,
                Storage = null
            };

            ViewerApi.ImageDeleteAttachmentPagesCache(request);
        }
    }
}