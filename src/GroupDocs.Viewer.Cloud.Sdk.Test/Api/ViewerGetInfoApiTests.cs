// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2020 Aspose Pty Ltd
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
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{    
    public class ViewerGetInfoApiTests : BaseApiTest
    {
        [Test]
        public void TestGetInfoReturnsMissingFileInfo()
        {
            // Arrange
            var viewOptions = new ViewOptions();
            var request = new GetInfoRequest(viewOptions);

            // Act & Assert    
            Assert.Throws<ApiException>(() => {
                InfoApi.GetInfo(request);
            });
        }

        [Test]
        public void TestGetInfoReturnsFileNotFound()
        {
            // Arrange
            var viewOptions = new ViewOptions
            {
                FileInfo = TestFiles.NotExist.ToFileInfo()
            };
            var request = new GetInfoRequest(viewOptions);

            // Act & Assert
            Assert.Throws<ApiException>(() => {
                InfoApi.GetInfo(request);
            });
        }

        [Test]
        public void TestGetInfoWithMinimalViewOptions()
        {
            // Arrange
            var viewOptions = new ViewOptions
            {
                FileInfo = TestFiles.PasswordProtectedDocx.ToFileInfo()
            };
            var request = new GetInfoRequest(viewOptions);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);

            Assert.AreEqual(4, infoResult.Pages.Count);
            Assert.AreEqual(0, infoResult.Attachments.Count);
        }

        [Test]
        public void TestGetInfoWithDefaultViewFormat()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
            };

            var request = new GetInfoRequest(viewOptions);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);

            Assert.AreEqual(1, infoResult.Pages.Count);
            Assert.AreEqual(0, infoResult.Attachments.Count);

            var page = infoResult.Pages[0];
            Assert.AreEqual(1, page.Number);
        }

        [Test]
        public void TestGetInfoWithHtmlViewFormat()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                ViewFormat = ViewOptions.ViewFormatEnum.HTML
            };

            var request = new GetInfoRequest(viewOptions);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);

            Assert.AreEqual(1, infoResult.Pages.Count);
            Assert.AreEqual(0, infoResult.Attachments.Count);

            var page = infoResult.Pages[0];
            Assert.AreEqual(1, page.Number);
        }

        [TestCase(ViewOptions.ViewFormatEnum.JPG)]
        [TestCase(ViewOptions.ViewFormatEnum.PNG)]
        public void TestGetInfoWithImageViewFormat(ViewOptions.ViewFormatEnum format)
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                ViewFormat = format
            };
            var request = new GetInfoRequest(viewOptions);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);

            Assert.AreEqual(1, infoResult.Pages.Count);
            Assert.AreEqual(0, infoResult.Attachments.Count);

            var page = infoResult.Pages[0];
            Assert.AreEqual(1, page.Number);
            Assert.Greater(page.Width, 0);
        }

        [Test]
        public void TestGetInfoWithRenderHiddenPages()
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
            var request = new GetInfoRequest(viewOptions);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);

            Assert.AreEqual(3, infoResult.Pages.Count);
        }

        [Test]
        public void TestGetInfoWithSpreadsheetPaginateSheetsOption()
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
            var request = new GetInfoRequest(viewOptions);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);
            Assert.AreEqual(2, infoResult.Pages.Count);
        }

        [Test]
        public void TestGetInfoWithSpreadsheetRenderHiddenRowsOption()
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
            var request = new GetInfoRequest(viewOptions);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);
            Assert.AreEqual(3, infoResult.Pages.Count);
        }

        [Test]
        public void TestGetInfoWithCadOptions()
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
                        ScaleFactor = 5f
                    }
                }
            };
            var request = new GetInfoRequest(viewOptions);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);
            Assert.AreEqual(3, infoResult.Pages.Count);
        }

        [Test]
        public void TestGetInfoWithProjectOptions()
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
            var request = new GetInfoRequest(viewOptions);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);
            Assert.IsTrue(infoResult.Pages.Count == 1 || infoResult.Pages.Count == 2);
        }


        [Test]
        public void TestGetInfoWithImageViewOptions()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                ViewFormat = ViewOptions.ViewFormatEnum.PNG,
                RenderOptions = new ImageOptions { ExtractText = true }
            };

            var request = new GetInfoRequest(viewOptions);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);

            Assert.AreEqual(1, infoResult.Pages.Count);
            Assert.AreEqual(0, infoResult.Attachments.Count);

            var page = infoResult.Pages[0];
            Assert.AreEqual(1, page.Number);
            Assert.Greater(page.Lines.Count, 0);
        }
    }
}
