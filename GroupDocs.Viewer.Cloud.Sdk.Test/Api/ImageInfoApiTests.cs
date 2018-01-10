using GroupDocs.Viewer.Cloud.Sdk.Api;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Internal;

    public class ImageInfoApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ImageGetDocumentInfo
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new ImageGetDocumentInfoRequest
            {
                FileName = file.FileName,
                Password = null,
                ExtractText = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetDocumentInfo(request);

            Assert.AreEqual("four-pages.docx", response.FileName);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual(4, response.Pages.Count);
        }

        /// <summary>
        /// Test ImageGetDocumentInfo
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoWithRenderHiddenPagesTest()
        {
            var file = TestFiles.TwoHiddenPagesVsd;

            var request = new ImageGetDocumentInfoRequest
            {
                FileName = file.FileName,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = true,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.ImageGetDocumentInfo(request);

            Assert.AreEqual("two-hidden-pages.vsd", response.FileName);
            Assert.AreEqual(".vsd", response.Extension);
            Assert.AreEqual(3, response.Pages.Count);
        }

        /// <summary>
        /// Test ImageGetDocumentInfo
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoWithExtractTextTest()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ImageGetDocumentInfoRequest
            {
                FileName = file.FileName,
                Password = null,
                ExtractText = true,
                RenderComments = null,
                RenderHiddenPages = null,
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetDocumentInfo(request);

            Assert.AreEqual("one-page.docx", response.FileName);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual(1, response.Pages.Count);

            Assert.IsTrue(response.Pages[0].Rows.Count > 0);
            foreach (var row in response.Pages[0].Rows)
            {
                Assert.IsNotEmpty(row.Text);
                Assert.IsTrue(row.RowHeight > 0);
                Assert.IsTrue(row.RowWidth > 0);
                Assert.IsTrue(row.RowLeft > 0);
                Assert.IsTrue(row.RowTop > 0);
                Assert.IsTrue(row.TextCoordinates.Count > 0);
                Assert.IsTrue(row.CharacterCoordinates.Count > 0);
            }
        }

        /// <summary>
        /// Test ImageGetDocumentInfo
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoReturnsFileNotFoundTest()
        {
            var request = new ImageGetDocumentInfoRequest
            {
                FileName = "file-not-found.docx",
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Folder = null,
                Storage = null,
            };

            var ex = Assert.Throws<ApiException>(() =>
            {
                ViewerApi.ImageGetDocumentInfo(request);
            });

            Assert.AreEqual("Can't find file with given name 'file-not-found.docx' and folder ''.", ex.Message);
        }

        /// <summary>
        /// Test ImageGetDocumentInfo
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoReturnsPasswordNotProvidedTest()
        {
            var file = TestFiles.PasswordProtectedDocx;

            var request = new ImageGetDocumentInfoRequest
            {
                FileName = file.FileName,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Folder = file.Folder,
                Storage = null,
            };

            var ex = Assert.Throws<ApiException>(() =>
            {
                ViewerApi.ImageGetDocumentInfo(request);
            });

            Assert.AreEqual("The password was not provided. The specified file 'password-protected.docx' is password-protected.", ex.Message);
        }

        /// <summary>
        /// Test ImageGetDocumentInfo
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoReturnsInvalidPasswordTest()
        {
            var file = TestFiles.PasswordProtectedDocx;

            var request = new ImageGetDocumentInfoRequest
            {
                FileName = file.FileName,
                Password = "not-a-password",
                RenderComments = null,
                RenderHiddenPages = null,
                Folder = file.Folder,
                Storage = null,
            };

            var ex = Assert.Throws<ApiException>(() =>
            {
                ViewerApi.ImageGetDocumentInfo(request);
            });

            Assert.AreEqual("Password provided for file with name 'password-protected.docx' is incorrect.", ex.Message);
        }

        /// <summary>
        /// Test ImageGetDocumentInfo
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoReturnsFailedToReadFileTest()
        {
            var file = TestFiles.CorruptedPdf;

            var request = new ImageGetDocumentInfoRequest
            {
                FileName = file.FileName,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Folder = file.Folder,
                Storage = null,
            };

            var ex = Assert.Throws<ApiException>(() =>
            {
                ViewerApi.ImageGetDocumentInfo(request);
            });

            Assert.AreEqual("Failed to read specified file 'corrupted.pdf'. File can be corrupted or damaged.", ex.Message);
        }

        /// <summary>
        /// Test ImageGetDocumentInfoFromUrl
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoFromUrlTest()
        {
            var file = TestFiles.FromUrlOnePageDocx;

            var request = new ImageGetDocumentInfoFromUrlRequest
            {
                Url = file.Url,
                FileName = file.FileName,
                Password = null,
                ExtractText = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Folder = FromUrlFolder,
                Storage = null
            };

            var response = ViewerApi.ImageGetDocumentInfoFromUrl(request);

            Assert.AreEqual("one-page.docx", response.FileName);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual(1, response.Pages.Count);
        }

        /// <summary>
        /// Test ImageGetDocumentInfoFromUrl
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoFromUrlReturnsInvalidUrlTest()
        {
            var request = new ImageGetDocumentInfoFromUrlRequest
            {
                Url = "invalid-url",
                FileName = null,
                Password = null,
                ExtractText = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Folder = null,
                Storage = null
            };

            var ex = Assert.Throws<ApiException>(() =>
            {
                ViewerApi.ImageGetDocumentInfoFromUrl(request);
            });

            Assert.AreEqual("Can't parse specified URL 'invalid-url'.", ex.Message);
        }

        /// <summary>
        /// Test ImageGetDocumentInfoWithOptions
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoWithOptionsTest()
        {
            var file = TestFiles.PasswordProtectedDocx;

            var request = new ImageGetDocumentInfoWithOptionsRequest
            {
                FileName = file.FileName,
                DocumentInfoOptions = new DocumentInfoOptions
                {
                    Password = file.Password
                },
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetDocumentInfoWithOptions(request);

            Assert.AreEqual("password-protected.docx", response.FileName);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual(1, response.Pages.Count);
        }

        /// <summary>
        /// Test ImageGetDocumentInfoWithOptions
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoWithOptionsWithExtractTextTest()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ImageGetDocumentInfoWithOptionsRequest
            {
                FileName = file.FileName,
                DocumentInfoOptions = new DocumentInfoOptions
                {
                    ExtractText = true
                },
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.ImageGetDocumentInfoWithOptions(request);

            Assert.AreEqual("one-page.docx", response.FileName);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual(1, response.Pages.Count);

            Assert.IsTrue(response.Pages[0].Rows.Count > 0);
            foreach (var row in response.Pages[0].Rows)
            {
                Assert.IsNotEmpty(row.Text);
                Assert.IsTrue(row.RowHeight > 0);
                Assert.IsTrue(row.RowWidth > 0);
                Assert.IsTrue(row.RowLeft > 0);
                Assert.IsTrue(row.RowTop > 0);
                Assert.IsTrue(row.TextCoordinates.Count > 0);
                Assert.IsTrue(row.CharacterCoordinates.Count > 0);
            }
        }

        /// <summary>
        /// Test ImageGetDocumentInfoFromContent
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoFromContentTest()
        {
            var file = TestFiles.PasswordProtectedDocx;
            var documentInfoOptions = new DocumentInfoOptions
            {
                Password = file.Password
            };

            var request = new ImageGetDocumentInfoFromContentRequest
            {
                DocumentInfoOptions = this.SerializeObject(documentInfoOptions),
                File = this.GetTestFileStream(file),
                FileName = null,
                Folder = FromContentFolder,
                Storage = null
            };

            var response = ViewerApi.ImageGetDocumentInfoFromContent(request);

            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual(1, response.Pages.Count);
        }

        /// <summary>
        /// Test ImageGetDocumentInfoFromUrlWithOptions
        /// </summary>
        [Test]
        public void ImageGetDocumentInfoFromUrlWithOptionsTest()
        {
            var file = TestFiles.FromUrlOnePageDocx;
            var documentInfoOptions = new DocumentInfoOptions();

            var request = new ImageGetDocumentInfoFromUrlWithOptionsRequest
            {
                Url = file.Url,
                DocumentInfoOptions = documentInfoOptions,
                FileName = null,
                Folder = FromUrlFolder,
                Storage = null
            };

            var response = ViewerApi.ImageGetDocumentInfoFromUrlWithOptions(request);

            Assert.IsInstanceOf<DocumentInfo>(response, "Expected response type is DocumentInfo");
            Assert.AreEqual(".docx", response.Extension);
        }
    }
}