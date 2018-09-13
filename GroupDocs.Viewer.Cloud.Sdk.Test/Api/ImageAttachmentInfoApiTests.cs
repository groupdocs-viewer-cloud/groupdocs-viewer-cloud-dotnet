using GroupDocs.Viewer.Cloud.Sdk.Client;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;


    public class ImageAttachmentInfoApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ImageGetAttachmentInfo
        /// </summary>
        [Test]
        public void ImageGetAttachmentInfoTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new ImageGetAttachmentInfoRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                ExtractText = null,
                Password = null,
                AttachmentPassword = file.AttachmentPassword,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetAttachmentInfo(request);

            Assert.AreEqual(1, response.Pages.Count);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual("password-protected.docx", response.FileName);
        }

        /// <summary>
        /// Test ImageGetAttachmentInfo
        /// </summary>
        [Test]
        public void ImageGetAttachmentInfoReturnsAttachmentNotFoundTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new ImageGetAttachmentInfoRequest
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
                ViewerApi.ImageGetAttachmentInfo(request);
            });

            Assert.AreEqual("Can't find attachment with given name 'not-found.pdf'.", ex.Message);
        }

        /// <summary>
        /// Test ImageGetAttachmentInfo
        /// </summary>
        [Test]
        public void ImageGetAttachmentInfoReturnsPasswordNotProvidedTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new ImageGetAttachmentInfoRequest
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
                ViewerApi.ImageGetAttachmentInfo(request);
            });

            Assert.AreEqual("The password was not provided. The specified file 'password-protected.docx' is password-protected.", ex.Message);
        }

        /// <summary>
        /// Test ImageGetAttachmentInfo
        /// </summary>
        [Test]
        public void ImageGetAttachmentInfoReturnsInvalidPasswordTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new ImageGetAttachmentInfoRequest
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
                ViewerApi.ImageGetAttachmentInfo(request);
            });

            Assert.AreEqual("Password provided for file with name 'password-protected.docx' is incorrect.", ex.Message);
        }

        /// <summary>
        /// Test ImageGetAttachmentInfoWithOptions
        /// </summary>
        [Test]
        public void ImageGetAttachmentInfoWithOptionsTest()
        {
            var file = TestFiles.WithAttachmentPdf;

            var request = new ImageGetAttachmentInfoWithOptionsRequest
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

            var response = ViewerApi.ImageGetAttachmentInfoWithOptions(request);

            Assert.AreEqual(1, response.Pages.Count);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual("password-protected.docx", response.FileName);
        }
    }
}