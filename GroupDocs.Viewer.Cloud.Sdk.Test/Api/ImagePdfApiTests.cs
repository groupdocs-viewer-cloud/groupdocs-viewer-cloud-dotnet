namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;

    public class ImagePdfApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ImageGetPdfFilePdf
        /// </summary>
        [Test]
        public void ImageGetPdfFileTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new ImageGetPdfFileRequest
            {
                FileName = file.FileName,
                RenderComments = null,
                RenderHiddenPages = null,
                Password = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetPdfFile(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageGetPdfFileFromUrl
        /// </summary>
        [Test]
        public void ImageGetPdfFileFromUrlTest()
        {
            var file = TestFiles.FromUrlOnePageDocx;

            var request = new ImageGetPdfFileFromUrlRequest
            {
                Url = file.Url,
                FileName = null,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = FromUrlFolder,
                Storage = null
            };

            var response = ViewerApi.ImageGetPdfFileFromUrl(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageCreatePdfFile
        /// </summary>
        [Test]
        public void ImageCreatePdfFileTest()
        {
            var file = TestFiles.PasswordProtectedDocx;
            var pdfFileOptions = new PdfFileOptions
            {
                Password = file.Password
            };

            var request = new ImageCreatePdfFileRequest
            {
                FileName = file.FileName,
                PdfFileOptions = pdfFileOptions,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageCreatePdfFile(request);

            Assert.IsNotEmpty(response.FileName);
            Assert.IsNotEmpty(response.Folder);
            Assert.IsNotEmpty(response.PdfFileName);
            Assert.IsNotEmpty(response.Url);
        }

        /// <summary>
        /// Test ImageCreatePdfFileFromContent
        /// </summary>
        [Test]
        public void ImageCreatePdfFileFromContentTest()
        {
            var file = TestFiles.PasswordProtectedDocx;
            var pdfFileOptions = new PdfFileOptions
            {
                Password = file.Password
            };

            var request = new ImageCreatePdfFileFromContentRequest
            {
                PdfFileOptions = this.SerializeObject(pdfFileOptions),
                File = this.GetTestFileStream(file),
                FileName = null,
                FontsFolder = null,
                Folder = FromContentFolder,
                Storage = null
            };

            var response = ViewerApi.ImageCreatePdfFileFromContent(request);

            Assert.IsNotEmpty(response.FileName);
            Assert.IsNotEmpty(response.Folder);
            Assert.IsNotEmpty(response.PdfFileName);
            Assert.IsNotEmpty(response.Url);
        }

        /// <summary>
        /// Test ImageCreatePdfFileFromUrl
        /// </summary>
        [Test]
        public void ImageCreatePdfFileFromUrlTest()
        {
            var file = TestFiles.FromUrlWithNotesPptx;
            var pdfFileOptions = new PdfFileOptions();

            var request = new ImageCreatePdfFileFromUrlRequest
            {
                Url = file.Url,
                PdfFileOptions = pdfFileOptions,
                FileName = null,
                FontsFolder = null,
                Folder = FromUrlFolder,
                Storage = null
            };

            var response = ViewerApi.ImageCreatePdfFileFromUrl(request);

            Assert.IsNotEmpty(response.FileName);
            Assert.IsNotEmpty(response.Folder);
            Assert.IsNotEmpty(response.PdfFileName);
            Assert.IsNotEmpty(response.Url);
        }
    }
}