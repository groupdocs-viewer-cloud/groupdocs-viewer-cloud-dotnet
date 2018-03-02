namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;

    public class HtmlAttachmentsApiTests : BaseApiTest
    {
        /// <summary>
        /// Test HtmlGetAttachment
        /// </summary>
        [Test]
        public void HtmlGetAttachmentFromMsgTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new HtmlGetAttachmentRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.HtmlGetAttachment(request);

            Assert.IsInstanceOf<System.IO.Stream> (response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test HtmlGetAttachment
        /// </summary>
        [Test]
        public void HtmlGetAttachmentFromPdfTest()
        {
            var file = TestFiles.WithAttachmentPdf;

            var request = new HtmlGetAttachmentRequest
            {
                FileName = file.FileName,
                AttachmentName = file.AttachmentName,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.HtmlGetAttachment(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test HtmlGetAttachments
        /// </summary>
        [Test]
        public void HtmlGetAttachmentsFromMsgTest()
        {
            var file = TestFiles.WithAttachmentMsg;

            var request = new HtmlGetAttachmentsRequest
            {
                FileName = file.FileName,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.HtmlGetAttachments(request);

            Assert.AreEqual(1, response.Attachments.Count);
            Assert.AreEqual("password-protected.docx", response.Attachments[0].Name);
        }

        /// <summary>
        /// Test HtmlGetAttachments
        /// </summary>
        [Test]
        public void HtmlGetAttachmentsFromPdfTest()
        {
            var file = TestFiles.WithAttachmentPdf;

            var request = new HtmlGetAttachmentsRequest
            {
                FileName = file.FileName,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.HtmlGetAttachments(request);

            Assert.AreEqual(1, response.Attachments.Count);
            Assert.AreEqual("password-protected.docx", response.Attachments[0].Name);
        }
    }
}