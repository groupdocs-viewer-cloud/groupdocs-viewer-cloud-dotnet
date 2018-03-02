namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;

    public class ImageAttachmentsApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ImageGetAttachment
        /// </summary>
        [Test]
        public void ImageGetAttachmentFromMsgTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new ImageGetAttachmentRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetAttachment(request);

            Assert.IsInstanceOf<System.IO.Stream> (response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageGetAttachment
        /// </summary>
        [Test]
        public void ImageGetAttachmentFromPdfTest()
        {
            var file = TestFiles.WithAttachmentPdf;

            var request = new ImageGetAttachmentRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetAttachment(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageGetAttachments
        /// </summary>
        [Test]
        public void ImageGetAttachmentsFromMsgTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new ImageGetAttachmentsRequest
            {
                FileName = file.FileName,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetAttachments(request);

            Assert.AreEqual(1, response.Attachments.Count);
            Assert.AreEqual("password-protected.docx", response.Attachments[0].Name);
        }

        /// <summary>
        /// Test ImageGetAttachments
        /// </summary>
        [Test]
        public void ImageGetAttachmentsFromPdfTest()
        {
            var file = TestFiles.WithAttachmentPdf;

            var request = new ImageGetAttachmentsRequest
            {
                FileName = file.FileName,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetAttachments(request);

            Assert.AreEqual(1, response.Attachments.Count);
            Assert.AreEqual("password-protected.docx", response.Attachments[0].Name);
        }
    }
}