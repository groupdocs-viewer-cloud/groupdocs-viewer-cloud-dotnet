namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Api;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;

    public class HtmlAttachmentInfoApiTests : BaseApiTest
    {
        /// <summary>
        /// Test HtmlGetAttachmentInfo
        /// </summary>
        [Test]
        public void HtmlGetAttachmentInfoTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new HtmlGetAttachmentInfoRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                Password = null,
                AttachmentPassword = file.AttachmentPassword,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetAttachmentInfo(request);

            Assert.AreEqual(1, response.Pages.Count);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual("password-protected.docx", response.FileName);
        }

        /// <summary>
        /// Test HtmlGetAttachmentInfo
        /// </summary>
        [Test]
        public void HtmlGetAttachmentInfoReturnsAttachmentNotFoundTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new HtmlGetAttachmentInfoRequest
            {
                FileName = file.FileName,
                AttachmentName = "not-found.pdf",
                Password = null,
                AttachmentPassword = null,
                Folder = file.Folder,
                Storage = null,
            };

            var ex = Assert.Throws<ApiException>(() =>
            {
                ViewerApi.HtmlGetAttachmentInfo(request);
            });

            Assert.AreEqual("Can't find attachment with given name 'not-found.pdf'.", ex.Message);
        }

        /// <summary>
        /// Test HtmlGetAttachmentInfo
        /// </summary>
        [Test]
        public void HtmlGetAttachmentInfoReturnsPasswordNotProvidedTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new HtmlGetAttachmentInfoRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                Password = null,
                AttachmentPassword = null,
                Folder = file.Folder,
                Storage = null,
            };

            var ex = Assert.Throws<ApiException>(() =>
            {
                ViewerApi.HtmlGetAttachmentInfo(request);
            });

            Assert.AreEqual("The password was not provided. The specified file 'password-protected.docx' is password-protected.", ex.Message);
        }

        /// <summary>
        /// Test  HtmlGetAttachmentInfo
        /// </summary>
        [Test]
        public void HtmlGetAttachmentInfoReturnsInvalidPasswordTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new HtmlGetAttachmentInfoRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                Password = null,
                AttachmentPassword = "not-a-password",
                Folder = file.Folder,
                Storage = null,
            };

            var ex = Assert.Throws<ApiException>(() =>
            {
                ViewerApi.HtmlGetAttachmentInfo(request);
            });

            Assert.AreEqual("Password provided for file with name 'password-protected.docx' is incorrect.", ex.Message);
        }

        /// <summary>
        /// Test HtmlGetAttachmentInfoWithOptions
        /// </summary>
        [Test]
        public void HtmlGetAttachmentInfoWithOptions()
        {
            var file = TestFiles.WithAttachmentPdf;

            var request = new HtmlGetAttachmentInfoWithOptionsRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                DocumentInfoOptions = new DocumentInfoOptions
                {
                    AttachmentPassword = file.AttachmentPassword
                },
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.HtmlGetAttachmentInfoWithOptions(request);

            Assert.AreEqual(1, response.Pages.Count);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual("password-protected.docx", response.FileName);
        }
    }
}