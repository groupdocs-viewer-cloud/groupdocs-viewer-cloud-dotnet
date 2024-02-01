// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{    
    public class ViewerCreateViewApiTests : BaseApiTest
    {
        [Test]
        public void TestCreateViewReturnsMissingFileInfo()
        {
            // Arrange
            var viewOptions = new ViewOptions();
            var request = new CreateViewRequest(viewOptions);

            // Act & Assert    
            var ex = Assert.Throws<ApiException>(() => {
                ViewApi.CreateView(request);
            });
            Assert.AreEqual("Parameter 'FileInfo' is not specified.", ex.Message);
        }

        [Test]
        public void TestCreateViewReturnsFileNotFound()
        {
            // Arrange
            var viewOptions = new ViewOptions
            {
                FileInfo = TestFiles.NotExist.ToFileInfo()
            };
            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var ex = Assert.Throws<ApiException>(() => {
                ViewApi.CreateView(request);
            });
            Assert.AreEqual("Can't find file located at 'some-folder/NotExist.docx'.", ex.Message);
        }

        [Test]
        public void TestCreateViewWithMinimalViewOptions()
        {
            // Arrange
            var viewOptions = new ViewOptions
            {
                FileInfo = TestFiles.PasswordProtectedDocx.ToFileInfo()
            };
            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);

            Assert.AreEqual(4, viewResult.Pages.Count);
            Assert.AreEqual(0, viewResult.Attachments.Count);

            // Download result
            var dlRequest = new DownloadFileRequest { path = viewResult.Pages[0].Path };
            var response = FileApi.DownloadFile(dlRequest);
            Assert.Greater(response.Length, 0);
        }

        [Test]
        public void TestCreateViewWithDefaultViewFormat()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
            };

            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);

            Assert.AreEqual(1, viewResult.Pages.Count);
            Assert.AreEqual(0, viewResult.Attachments.Count);

            var page = viewResult.Pages[0];
            Assert.AreEqual(1, page.Number);
        }

        [Test]
        public void TestCreateViewWithHtmlViewFormat()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                ViewFormat = ViewOptions.ViewFormatEnum.HTML
            };

            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);

            Assert.AreEqual(1, viewResult.Pages.Count);
            Assert.AreEqual(0, viewResult.Attachments.Count);

            var page = viewResult.Pages[0];
            Assert.AreEqual(1, page.Number);
        }

        [TestCase(ViewOptions.ViewFormatEnum.JPG)]
        [TestCase(ViewOptions.ViewFormatEnum.PNG)]
        public void TestCreateViewWithImageViewFormat(ViewOptions.ViewFormatEnum format)
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                ViewFormat = format
            };
            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);

            Assert.AreEqual(1, viewResult.Pages.Count);
            Assert.AreEqual(0, viewResult.Attachments.Count);

            var page = viewResult.Pages[0];
            Assert.AreEqual(1, page.Number);
        }

        [Test]
        public void TestCreateViewWithRenderHiddenPages()
        {
            // Arrange
            var testFile = TestFiles.TwoHiddenPagesVsd;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                RenderOptions = new RenderOptions
                {
                    RenderHiddenPages = true
                }
            };
            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);

            Assert.AreEqual(3, viewResult.Pages.Count);
        }

        [Test]
        public void TestCreateViewWithSpreadsheetPaginateSheetsOption()
        {
            // Arrange
            var testFile = TestFiles.WithHiddenRowsAndColumns;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                RenderOptions = new RenderOptions
                {
                    SpreadsheetOptions = new SpreadsheetOptions
                    {
                        PaginateSheets = true,
                        CountRowsPerPage = 5
                    }
                }
            };
            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);
            Assert.AreEqual(3, viewResult.Pages.Count);
        }

        [Test]
        public void TestCreateViewWithSpreadsheetRenderHiddenRowsOption()
        {
            // Arrange
            var testFile = TestFiles.WithHiddenRowsAndColumns;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                RenderOptions = new RenderOptions
                {
                    SpreadsheetOptions = new SpreadsheetOptions
                    {
                        PaginateSheets = true,
                        CountRowsPerPage = 5,
                        RenderHiddenRows = true
                    }
                }
            };
            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);
            Assert.AreEqual(3, viewResult.Pages.Count);
        }

        [Test]
        public void TestCreateViewWithCadOptions()
        {
            // Arrange
            var testFile = TestFiles.ThreeLayoutsDwf;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                RenderOptions = new RenderOptions
                {
                    CadOptions = new CadOptions
                    {
                        Width = 800
                    }
                }
            };
            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);
            Assert.AreEqual(3, viewResult.Pages.Count);
        }

        [Test]
        public void TestCreateViewWithProjectOptions()
        {
            // Arrange
            var testFile = TestFiles.ProjectMpp;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                RenderOptions = new RenderOptions
                {
                    ProjectManagementOptions = new ProjectManagementOptions
                    {
                        PageSize = ProjectManagementOptions.PageSizeEnum.Unspecified,
                        TimeUnit = ProjectManagementOptions.TimeUnitEnum.Months,
                        StartDate = new DateTime(2008, 7, 1),
                        EndDate = new DateTime(2008, 7, 31)
                    }
                }
            };
            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);
            Assert.IsTrue(viewResult.Pages.Count == 1 || viewResult.Pages.Count == 2);
        }

        [Test]
        public void TestCreateViewWithFontsPathOption()
        {
            // Arrange
            var testFile = TestFiles.UsesCustomFontPptx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                ViewFormat = ViewOptions.ViewFormatEnum.PNG,
                FontsPath = "font/ttf"
            };
            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);
            Assert.AreEqual(1, viewResult.Pages.Count);
        }

        [Test]
        public void TestCreateViewWithStartPageAndCountPages()
        {
            // Arrange
            var testFile = TestFiles.FourPagesDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                RenderOptions = new RenderOptions
                {
                    StartPageNumber = 2,
                    CountPagesToRender = 2
                }
            };
            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);
            Assert.AreEqual(2, viewResult.Pages.Count);
            var page = viewResult.Pages[0];
            Assert.AreEqual(2, page.Number);
        }

        [Test]
        public void TestCreateViewWithHtmlViewOptions()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                RenderOptions = new HtmlOptions { ExternalResources = true }
            };

            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);

            Assert.AreEqual(1, viewResult.Pages.Count);
            Assert.AreEqual(0, viewResult.Attachments.Count);

            var page = viewResult.Pages[0];
            Assert.AreEqual(1, page.Number);
            Assert.Greater(page.Resources.Count, 0);
        }

        [Test]
        public void TestCreateViewWithResponsiveOption()
        {
            TestCompareOptions(TestFiles.OnePageDocx, new HtmlOptions(), new HtmlOptions { IsResponsive = true });
        }

        /// <summary>
        /// Tests create view against two options with compare results
        /// </summary>
        private void TestCompareOptions(TestFile testFile, RenderOptions options1, RenderOptions options2)
        {
            var viewOptions1 = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                RenderOptions = options1
            };            
            var viewResult1 = ViewApi.CreateView(new CreateViewRequest(viewOptions1));
            var response1 = FileApi.DownloadFile(new DownloadFileRequest { path = viewResult1.Pages[0].Path });
            Assert.Greater(response1.Length, 0);

            Cleanup();

            var viewOptions2 = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                RenderOptions = options2
            };
            var viewResult2 = ViewApi.CreateView(new CreateViewRequest(viewOptions2));
            var response2 = FileApi.DownloadFile(new DownloadFileRequest { path = viewResult2.Pages[0].Path });
            Assert.Greater(response2.Length, 0);

            Assert.AreNotEqual(response1.Length, response2.Length);
        }

        [Test]
        public void TestCreateViewWithPdfViewOptions()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                ViewFormat = ViewOptions.ViewFormatEnum.PDF,
                RenderOptions = new PdfOptions
                {
                    PermissionsPassword = "12345",
                    Permissions = new List<string> { "DenyPrinting" }
                }
            };

            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewApi.CreateView(request);

            Assert.NotNull(viewResult.File.DownloadUrl);
        }
    }
}
