using System;
using System.IO;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Model;
    using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;

    public class HtmlPagesApiTests : BaseApiTest
    {
        /// <summary>
        /// Test HtmlGetPage
        /// </summary>
        [Test]
        public void HtmlGetPageTest()
        {
            var file = TestFiles.OnePageDocx;
            var pageNumber = 1;

            var request = new HtmlGetPageRequest
            {
                FileName = file.FileName,
                PageNumber = pageNumber,
                ResourcePath = null,
                IgnoreResourcePathInResources = null,
                EmbedResources = null,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetPage(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test HtmlGetPage
        /// </summary>
        [Test]
        public void HtmlGetPageWithCustomFontTest()
        {
            var file = TestFiles.UsesCustomFontPptx;
            var pageNumber = 1;

            var request = new HtmlGetPageRequest
            {
                FileName = file.FileName,
                PageNumber = pageNumber,
                ResourcePath = null,
                IgnoreResourcePathInResources = null,
                EmbedResources = true,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = "fonts",
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetPage(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test HtmlGetPages
        /// </summary>
        [Test]
        public void HtmlGetPagesTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new HtmlGetPagesRequest
            {
                FileName = file.FileName,
                ResourcePath = null,
                IgnoreResourcePathInResources = null,
                EmbedResources = null,
                StartPageNumber = null,
                CountPages = null,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetPages(request);

            Assert.AreEqual("four-pages.docx", response.FileName);
            Assert.AreEqual("words\\docx", response.Folder);
            Assert.AreEqual(4, response.Pages.Count);
        }

        /// <summary>
        /// Test HtmlGetPagesFromUrl
        /// </summary>
        [Test]
        public void HtmlGetPagesFromUrlTest()
        {
            var file = TestFiles.FromUrlWithNotesPptx;

            var request = new HtmlGetPagesFromUrlRequest
            {
                Url = file.Url,
                FileName = file.FileName,
                ResourcePath = null,
                IgnoreResourcePathInResources = null,
                EmbedResources = null,
                StartPageNumber = null,
                CountPages = null,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = FromUrlFolder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetPagesFromUrl(request);

            Assert.AreEqual("with-notes.pptx", response.FileName);
            Assert.AreEqual(1, response.Pages.Count);
        }

        /// <summary>
        /// Test HtmlGetZipWithPages
        /// </summary>
        [Test]
        public void HtmlGetZipWithPagesTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new HtmlGetZipWithPagesRequest
            {
                FileName = file.FileName,
                ResourcePath = null,
                IgnoreResourcePathInResources = null,
                EmbedResources = null,
                StartPageNumber = null,
                CountPages = null,
                Password = null,
                RenderComments = null,
                RenderHiddenPages = null,
                DefaultFontName = null,
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlGetZipWithPages(request);

            Assert.IsInstanceOf<System.IO.Stream>(response, "Expected response type is System.IO.Stream");
            Assert.IsTrue(response.Length > 0);
        }

        /// <summary>
        /// Test HtmlCreatePagesCache
        /// </summary>
        [Test]
        public void HtmlCreatePagesCacheTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new HtmlCreatePagesCacheRequest
            {
                FileName = file.FileName,
                HtmlOptions = new HtmlOptions
                {
                    EmbedResources = true
                },
                FontsFolder = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = ViewerApi.HtmlCreatePagesCache(request);

            Assert.AreEqual("four-pages.docx", response.FileName);
            Assert.AreEqual("words\\docx", response.Folder);
            Assert.AreEqual(4, response.Pages.Count);
        }

        /// <summary>
        /// Test HtmlCreatePagesCacheFromContentTest
        /// </summary>
        [Test]
        public void HtmlCreatePagesCacheFromContentTest()
        {
            var file = TestFiles.PasswordProtectedDocx;
            var htmlOptions = new HtmlOptions
            {
                Password = file.Password
            };

            var request = new HtmlCreatePagesCacheFromContentRequest
            {
                HtmlOptions = this.SerializeObject(htmlOptions),
                File = this.GetTestFileStream(file),
                FileName = null,
                FontsFolder = null,
                Folder = FromContentFolder,
                Storage = null,
            };

            var response = ViewerApi.HtmlCreatePagesCacheFromContent(request);

            Assert.AreEqual(".docx", Path.GetExtension(response.FileName));
            Assert.AreEqual(FromContentFolder, response.Folder);
            Assert.AreEqual(1, response.Pages.Count);
        }

        /// <summary>
        /// Test HtmlTransformPages
        /// </summary>
        [Test]
        public void HtmlRotatePageTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new HtmlTransformPagesRequest
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

            var response = ViewerApi.HtmlTransformPages(request);

            Assert.AreEqual(90, response.Pages[0].Angle);
        }

        /// <summary>
        /// Test HtmlTransformPages
        /// </summary>
        [Test]
        public void HtmlReorderPagesTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new HtmlTransformPagesRequest
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

            var response = ViewerApi.HtmlTransformPages(request);

            Assert.AreEqual(2, response.Pages[0].Number);
            Assert.AreEqual(1, response.Pages[1].Number);
        }

        /// <summary>
        /// Test HtmlCreatePagesCacheFromUrl
        /// </summary>
        [Test]
        public void HtmlCreatePagesCacheFromUrlTest()
        {
            var file = TestFiles.FromUrlWithNotesPptx;

            var request = new HtmlCreatePagesCacheFromUrlRequest
            {
                Url = file.Url,
                HtmlOptions = new HtmlOptions
                {
                    EmbedResources = false
                },
                FileName = null,
                FontsFolder = null,
                Folder = FromUrlFolder,
                Storage = null,
            };

            var response = ViewerApi.HtmlCreatePagesCacheFromUrl(request);

            Assert.AreEqual(1, response.Pages.Count);
            Assert.AreEqual("with-notes.pptx", response.FileName);
        }

        /// <summary>
        /// Test HtmlDeletePagesCacheTest
        /// </summary>
        [Test]
        public void HtmlDeletePagesCacheTest()
        {
            var file = TestFiles.FourPagesDocx;

            var request = new HtmlDeletePagesCacheRequest
            {
                FileName = file.FileName,
                Folder = file.Folder,
                Storage = null,
            };

            ViewerApi.HtmlDeletePagesCache(request);
        }

        /// <summary>
        /// Test HtmlCreatePagesCacheFromContentTest
        /// </summary>
        [Test]
        public void HtmlCreatePagesCacheWithProjectOptionsTest()
        {
            var file = TestFiles.ProjectMpp;
            var htmlOptions = new HtmlOptions
            {
                EmbedResources = true,
                ProjectOptions = new ProjectOptions
                {
                    TimeUnit = "Days",
                    StartDate = new DateTime(2008, 7, 1),
                    EndDate = new DateTime(2008, 7, 31)
                }
            };

            var request = new HtmlCreatePagesCacheFromContentRequest
            {
                HtmlOptions = this.SerializeObject(htmlOptions),
                File = this.GetTestFileStream(file),
                FileName = null,
                FontsFolder = null,
                Folder = FromContentFolder,
                Storage = null,
            };

            var response = ViewerApi.HtmlCreatePagesCacheFromContent(request);

            Assert.AreEqual(".mpp", Path.GetExtension(response.FileName));
            Assert.AreEqual(FromContentFolder, response.Folder);
            Assert.AreEqual(1, response.Pages.Count);
        }

        /// <summary>
        /// Test HtmlCreatePagesCacheFromContentTest
        /// </summary>
        [Test]
        public void HtmlCreatePagesCacheWithOutlookOptionsTest()
        {
            var file = TestFiles.OutlookPst;
            var htmlOptions = new HtmlOptions
            {
                EmbedResources = true,
                OutlookOptions = new OutlookOptions
                {
                    MaxItemsInFolder = 5
                }
            };

            var request = new HtmlCreatePagesCacheFromContentRequest
            {
                HtmlOptions = this.SerializeObject(htmlOptions),
                File = this.GetTestFileStream(file),
                FileName = null,
                FontsFolder = null,
                Folder = FromContentFolder,
                Storage = null,
            };

            var response = ViewerApi.HtmlCreatePagesCacheFromContent(request);

            Assert.AreEqual(".pst", Path.GetExtension(response.FileName));
            Assert.AreEqual(FromContentFolder, response.Folder);
            Assert.Greater(response.Pages.Count, 0);
        }
    }
}