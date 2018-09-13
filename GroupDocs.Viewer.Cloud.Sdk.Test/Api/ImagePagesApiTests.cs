using System.IO;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;

    public class ImagePagesApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ImageGetPage
        /// </summary>
        [Test]
        public void ImageGetPageTest()
        {
            var file = TestFiles.FourPagesDocx;
            var pageNumber = 1;

            var request = new ImageGetPageRequest
            {
                FileName = file.FileName,
                PageNumber = pageNumber,
                Format = null,
                Width = null,
                Height = null,
                Quality = null,
                Password = null,
                ExtractText = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetPage(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageGetPage
        /// </summary>
        [Test]
        public void ImageGetPageWithExtractTextTest()
        {
            var file = TestFiles.OnePageDocx;
            var pageNumber = 1;

            var request = new ImageGetPageRequest
            {
                FileName = file.FileName,
                PageNumber = pageNumber,
                Format = null,
                Width = null,
                Height = null,
                Quality = null,
                Password = null,
                ExtractText = true,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetPage(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageGetPage
        /// </summary>
        [Test]
        public void ImageGetPageWithCustomFontTest()
        {
            var file = TestFiles.UsesCustomFontPptx;
            var pageNumber = 1;

            var request = new ImageGetPageRequest
            {
                FileName = file.FileName,
                PageNumber = pageNumber,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = "fonts",
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.ImageGetPage(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageGetPage
        /// </summary>
        [Test]
        public void ImageGetPageWithWidthTest()
        {
            var file = TestFiles.OnePageDocx;
            var pageNumber = 1;

            var request = new ImageGetPageRequest
            {
                FileName = file.FileName,
                PageNumber = pageNumber,
                Format = null,
                Width = 800,
                Height = null,
                Quality = null,
                Password = null,
                ExtractText = true,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetPage(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageGetPage
        /// </summary>
        [Test]
        public void ImageGetPageWithHeightTest()
        {
            var file = TestFiles.OnePageDocx;
            var pageNumber = 1;

            var request = new ImageGetPageRequest
            {
                FileName = file.FileName,
                PageNumber = pageNumber,
                Format = null,
                Width = null,
                Height = 800,
                Quality = null,
                Password = null,
                ExtractText = true,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetPage(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageGetPage
        /// </summary>
        [Test]
        public void ImageGetPageWithQualityTest()
        {
            var file = TestFiles.OnePageDocx;
            var pageNumber = 1;

            var request = new ImageGetPageRequest
            {
                FileName = file.FileName,
                PageNumber = pageNumber,
                Format = null,
                Width = null,
                Height = null,
                Quality = 90,
                Password = null,
                ExtractText = true,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetPage(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageGetPages
        /// </summary>
        [Test]
        public void ImageGetPagesTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new ImageGetPagesRequest
            {
                FileName = file.FileName,
                Format = null,
                Width = null,
                Height = null,
                Quality = null,
                StartPageNumber = null,
                CountPages = null,
                Password = null,
                ExtractText = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = file.Folder,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetPages(request);

            Assert.AreEqual("four-pages.docx", response.FileName);
            Assert.AreEqual("words\\docx", response.Folder);
            Assert.AreEqual(4, response.Pages.Count);
        }

        /// <summary>
        /// Test ImageGetPagesFromUrl
        /// </summary>
        [Test]
        public void ImageGetPagesFromUrlTest()
        {
            var file = TestFiles.FromUrlWithNotesPptx;

            var request = new ImageGetPagesFromUrlRequest
            {
                Url = file.Url,
                FileName = file.FileName,
                Format = null,
                Width = null,
                Height = null,
                Quality = null,
                StartPageNumber = null,
                CountPages = null,
                Password = null,
                ExtractText = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = FromUrlFolder,
                Storage = null
            };

            var response = ViewerApi.ImageGetPagesFromUrl(request);

            Assert.AreEqual("with-notes.pptx", response.FileName);
            Assert.AreEqual(1, response.Pages.Count);
        }

        /// <summary>
        /// Test ImageGetZipWithPages
        /// </summary>
        [Test]
        public void ImageGetZipWithPages()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new ImageGetZipWithPagesRequest
            {
                FileName = file.FileName,
                Format = null,
                Width = null,
                Height = null,
                Quality = null,
                StartPageNumber = null,
                CountPages = null,
                Password = null,
                ExtractText = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetZipWithPages(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test ImageCreatePagesCache
        /// </summary>
        [Test]
        public void ImageCreatePagesCacheTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new ImageCreatePagesCacheRequest
            {
                FileName = file.FileName,
                ImageOptions = new ImageOptions
                {
                    Format = "jpg"
                },
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageCreatePagesCache(request);

            Assert.AreEqual("four-pages.docx", response.FileName);
            Assert.AreEqual("words\\docx", response.Folder);
            Assert.AreEqual(4, response.Pages.Count);
        }

        /// <summary>
        /// Test ImageCreatePagesCacheFromContent
        /// </summary>
        [Test]
        public void ImageCreatePagesCacheFromContentTest()
        {
            var file = TestFiles.OnePageDocx;
            var imageOptions = new ImageOptions
            {
                Format = "jpg"
            };

            var request = new ImageCreatePagesCacheFromContentRequest
            {
                ImageOptions = this.SerializeObject(imageOptions),
                File = this.GetTestFileStream(file),
                FileName = null,
                FontsFolder = null,
                Folder = FromContentFolder,
                Storage = null
            };

            var response = ViewerApi.ImageCreatePagesCacheFromContent(request);

            Assert.AreEqual(".docx", Path.GetExtension(response.FileName));
            Assert.AreEqual(FromContentFolder, response.Folder);
            Assert.AreEqual(1, response.Pages.Count);
        }

        /// <summary>
        /// Test ImageTransformPages
        /// </summary>
        [Test]
        public void ImageRotatePageTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new ImageTransformPagesRequest
            {
                FileName = file.FileName,
                TransformOptions = new RotateOptions
                {
                    PageNumber = 1,
                    Angle = 90
                },
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.ImageTransformPages(request);

            Assert.AreEqual(90, response.Pages[0].Angle);
        }

        /// <summary>
        /// Test ImageTransformPages
        /// </summary>
        [Test]
        public void ImageReorderPagesTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new ImageTransformPagesRequest
            {
                FileName = file.FileName,
                TransformOptions = new ReorderOptions
                {
                    PageNumber = 1,
                    NewPosition = 2
                },
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.ImageTransformPages(request);

            Assert.AreEqual(2, response.Pages[0].Number);
            Assert.AreEqual(1, response.Pages[1].Number);
        }

        /// <summary>
        /// Test  ImageCreatePagesCacheFromUrl
        /// </summary>
        [Test]
        public void ImageCreatePagesCacheFromUrlTest()
        {
            var file = TestFiles.FromUrlWithNotesPptx;

            var request = new ImageCreatePagesCacheFromUrlRequest
            {
                Url = file.Url,
                ImageOptions = new ImageOptions
                {
                    Format = "jpg"
                },
                FileName = null,
                FontsFolder = null,
                Folder = FromUrlFolder,
                Storage = null
            };

            var response = ViewerApi.ImageCreatePagesCacheFromUrl(request);

            Assert.AreEqual(1, response.Pages.Count);
            Assert.AreEqual("with-notes.pptx", response.FileName);
        }

        /// <summary>
        /// Test ImageDeletePagesCache
        /// </summary>
        [Test]
        public void ImageDeletePagesCacheTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new ImageDeletePagesCacheRequest
            {
                FileName = file.FileName,
                Folder = file.Folder,
                Storage = null,
            };

            ViewerApi.ImageDeletePagesCache(request);
        }
    }
}