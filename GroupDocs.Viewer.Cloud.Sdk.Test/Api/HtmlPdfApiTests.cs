namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;

    public class HtmlPdfApiTests : BaseApiTest
    {
        /// <summary>
        /// Test HtmlGetPdfFile
        /// </summary>
        [Test]
        public void HtmlGetPdfFileTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new HtmlGetPdfFileRequest
            {
                FileName = file.FileName,
                RenderComments = null,
                RenderHiddenPages = null,
                Password = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetPdfFile(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test HtmlGetPdfFileFromUrl
        /// </summary>
        [Test]
        public void HtmlGetPdfFileFromUrlTest()
        {
            var file = TestFiles.FromUrlOnePageDocx;

            var request = new HtmlGetPdfFileFromUrlRequest
            {
                Url = file.Url,
                FileName = null,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = FromUrlFolder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetPdfFileFromUrl(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test HtmlCreatePdfFile
        /// </summary>
        [Test]
        public void HtmlCreatePdfFile()
        {
            var file = TestFiles.PasswordProtectedDocx;
            var pdfFileOptions = new PdfFileOptions
            {
                Password = file.Password
            };

            var request = new HtmlCreatePdfFileRequest
            {
                FileName = file.FileName,
                PdfFileOptions = pdfFileOptions,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlCreatePdfFile(request);

            Assert.IsNotEmpty(response.FileName);
            Assert.IsNotEmpty(response.Folder);
            Assert.IsNotEmpty(response.PdfFileName);
        }

        /// <summary>
        /// Test HtmlCreatePdfFileFromContent
        /// </summary>
        [Test]
        public void HtmlCreatePdfFileFromContentTest()
        {
            var file = TestFiles.PasswordProtectedDocx;
            var pdfFileOptions = new PdfFileOptions
            {
                Password = file.Password
            };

            var request = new HtmlCreatePdfFileFromContentRequest
            {
                PdfFileOptions = this.SerializeObject(pdfFileOptions),
                File = this.GetTestFileStream(file),
                FileName = null,
                FontsFolder = null,
                Folder = FromContentFolder,
                Storage = null,
            };

            var response = ViewerApi.HtmlCreatePdfFileFromContent(request);

            Assert.IsNotEmpty(response.FileName);
            Assert.IsNotEmpty(response.Folder);
            Assert.IsNotEmpty(response.PdfFileName);
        }

        /// <summary>
        /// Test HtmlCreatePdfFileFromUrl
        /// </summary>
        [Test]
        public void HtmlCreatePdfFileFromUrl()
        {
            var file = TestFiles.FromUrlWithNotesPptx;
            var pdfFileOptions = new PdfFileOptions();

            var request = new HtmlCreatePdfFileFromUrlRequest
            {
                Url = file.Url,
                PdfFileOptions = pdfFileOptions,
                FileName = null,
                FontsFolder = null,
                Folder = FromUrlFolder,
                Storage = null,
            };

            var response = ViewerApi.HtmlCreatePdfFileFromUrl(request);

            Assert.IsNotEmpty(response.FileName);
            Assert.IsNotEmpty(response.Folder);
            Assert.IsNotEmpty(response.PdfFileName);
        }
    }
}