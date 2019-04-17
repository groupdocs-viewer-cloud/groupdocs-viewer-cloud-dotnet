using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    public class ViewerOutputPathTests : BaseApiTest
    {
        private const string OutputPath = "Output";

        [Test]
        public void TestCreateViewWithDefaultOutputPath()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo()
            };

            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewerApi.CreateView(request);

            Assert.AreEqual(1, viewResult.Pages.Count);

            var page = viewResult.Pages[0];
            Assert.IsTrue(page.Path.StartsWith(DefaultOutputPath));
        }

        [Test]
        public void TestCreateViewHtmlWithOutputPath()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = OutputPath
            };

            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewerApi.CreateView(request);

            Assert.AreEqual(1, viewResult.Pages.Count);

            var page = viewResult.Pages[0];
            Assert.IsTrue(page.Path.StartsWith(OutputPath));
        }

        [Test]
        public void TestCreateViewImageWithOutputPath()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                ViewFormat = ViewOptions.ViewFormatEnum.JPG,
                OutputPath = OutputPath
            };

            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewerApi.CreateView(request);

            Assert.AreEqual(1, viewResult.Pages.Count);

            var page = viewResult.Pages[0];
            Assert.IsTrue(page.Path.StartsWith(OutputPath));
        }

        [Test]
        public void TestCreateViewPdfWithOutputPath()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var viewOptions = new ViewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                ViewFormat = ViewOptions.ViewFormatEnum.PDF,
                OutputPath = OutputPath
            };

            var request = new CreateViewRequest(viewOptions);

            // Act & Assert
            var viewResult = ViewerApi.CreateView(request);
            Assert.IsTrue(viewResult.File.Path.StartsWith(OutputPath));
        }

        [TearDown]
        public void CleanupOutputPath()
        {
            DeleteFolderFromStorage(OutputPath);
        }
    }
}
