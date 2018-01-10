using GroupDocs.Viewer.Cloud.Sdk.Api;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Internal;

    public class HtmlInfoApiTests : BaseApiTest
    {
        /// <summary>
        /// Test HtmlGetInfo
        /// </summary>
        [Test]
        public void HtmlGetInfoTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new HtmlGetDocumentInfoRequest
            {
                FileName = file.FileName,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetDocumentInfo(request);

            Assert.AreEqual("four-pages.docx", response.FileName);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual(4, response.Pages.Count);
        }

        /// <summary>
        /// Test HtmlGetInfo
        /// </summary>
        [Test]
        public void HtmlGetInfoWithRenderHiddenPagesTest()
        {
            var file = TestFiles.TwoHiddenPagesVsd;

            var request = new HtmlGetDocumentInfoRequest
            {
                FileName = file.FileName,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = true,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetDocumentInfo(request);

            Assert.AreEqual("two-hidden-pages.vsd", response.FileName);
            Assert.AreEqual(".vsd", response.Extension);
            Assert.AreEqual(3, response.Pages.Count);
        }

        /// <summary>
        /// Test HtmlGetInfo
        /// </summary>
        [Test]
        public void HtmlGetInfoReturnsFileNotFoundTest()
        {
            var request = new HtmlGetDocumentInfoRequest
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
                ViewerApi.HtmlGetDocumentInfo(request);
            });

            Assert.AreEqual("Can't find file with given name 'file-not-found.docx' and folder ''.", ex.Message);
        }

        /// <summary>
        /// Test HtmlGetInfo
        /// </summary>
        [Test]
        public void HtmlGetInfoReturnsPasswordNotProvidedTest()
        {
            var file = TestFiles.PasswordProtectedDocx;

            var request = new HtmlGetDocumentInfoRequest
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
                ViewerApi.HtmlGetDocumentInfo(request);
            });

            Assert.AreEqual("The password was not provided. The specified file 'password-protected.docx' is password-protected.", ex.Message);
        }

        /// <summary>
        /// Test HtmlGetInfo
        /// </summary>
        [Test]
        public void HtmlGetInfoReturnsInvalidPasswordTest()
        {
            var file = TestFiles.PasswordProtectedDocx;

            var request = new HtmlGetDocumentInfoRequest
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
                ViewerApi.HtmlGetDocumentInfo(request);
            });

            Assert.AreEqual("Password provided for file with name 'password-protected.docx' is incorrect.", ex.Message);
        }

        /// <summary>
        /// Test HtmlGetInfo
        /// </summary>
        [Test]
        public void HtmlGetInfoReturnsFailedToReadFileTest()
        {
            var file = TestFiles.CorruptedPdf;

            var request = new HtmlGetDocumentInfoRequest
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
                ViewerApi.HtmlGetDocumentInfo(request);
            });

            Assert.AreEqual("Failed to read specified file 'corrupted.pdf'. File can be corrupted or damaged.", ex.Message);
        }

        /// <summary>
        /// Test HtmlGetInfoFromUrl
        /// </summary>
        [Test]
        public void HtmlGetDocumentInfoFromUrlTest()
        {
            var file = TestFiles.FromUrlOnePageDocx;

            var request = new HtmlGetDocumentInfoFromUrlRequest
            {
                Url = file.Url,
                FileName = file.FileName,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Folder = FromUrlFolder,
                Storage = null
            };

            var response = ViewerApi.HtmlGetDocumentInfoFromUrl(request);

            Assert.AreEqual("one-page.docx", response.FileName);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual(1, response.Pages.Count);
        }

        /// <summary>
        /// Test HtmlGetInfoFromUrl
        /// </summary>
        [Test]
        public void HtmlGetInfoFromUrlReturnsInvalidUrlTest()
        {
            var request = new HtmlGetDocumentInfoFromUrlRequest
            {
                Url = "invalid-url",
                FileName = null,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                Folder = null,
                Storage = null
            };

            var ex = Assert.Throws<ApiException>(() =>
            {
                ViewerApi.HtmlGetDocumentInfoFromUrl(request);
            });

            Assert.AreEqual("Can't parse specified URL 'invalid-url'.", ex.Message);
        }

        /// <summary>
        /// Test HtmlGetDocumentInfoWithOptions
        /// </summary>
        [Test]
        public void HtmlGetDocumentInfoWithOptionsTest()
        {
            var file = TestFiles.PasswordProtectedDocx;

            var request = new HtmlGetDocumentInfoWithOptionsRequest
            {
                FileName = file.FileName,
                DocumentInfoOptions = new DocumentInfoOptions
                {
                    Password = file.Password
                },
                Folder = file.Folder,
                Storage = null
            };

            var response = ViewerApi.HtmlGetDocumentInfoWithOptions(request);

            Assert.AreEqual("password-protected.docx", response.FileName);
            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual(1, response.Pages.Count);
        }

        /// <summary>
        /// Test HtmlGetDocumentInfoFromContent
        /// </summary>
        [Test]
        public void HtmlGetDocumentInfoFromContentTest()
        {
            var file = TestFiles.PasswordProtectedDocx;
            var documentInfoOptions = new DocumentInfoOptions
            {
                Password = file.Password
            };

            var request = new HtmlGetDocumentInfoFromContentRequest
            {
                DocumentInfoOptions = this.SerializeObject(documentInfoOptions),
                File = this.GetTestFileStream(file),
                FileName = null,
                Folder = FromContentFolder,
                Storage = null
            };

            var response = ViewerApi.HtmlGetDocumentInfoFromContent(request);

            Assert.AreEqual(".docx", response.Extension);
            Assert.AreEqual(1, response.Pages.Count);
        }

        /// <summary>
        /// Test HtmlGetDocumentInfoFromUrlWithOptions
        /// </summary>
        [Test]
        public void HtmlGetDocumentInfoFromUrlWithOptionsTest()
        {
            var file = TestFiles.FromUrlWithNotesPptx;
            var documentInfoOptions = new DocumentInfoOptions();

            var request = new HtmlGetDocumentInfoFromUrlWithOptionsRequest
            {
                Url = file.Url,
                
                DocumentInfoOptions = documentInfoOptions,
                FileName = file.FileName,
                Folder = FromUrlFolder,
                Storage = null
            };

            var response = ViewerApi.HtmlGetDocumentInfoFromUrlWithOptions(request);

            Assert.AreEqual("with-notes.pptx", response.FileName);
            Assert.AreEqual(".pptx", response.Extension);
            Assert.AreEqual(1, response.Pages.Count);
        }
    }
}