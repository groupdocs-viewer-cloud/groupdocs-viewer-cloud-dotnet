// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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

using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    public class FileApiTests : BaseApiTest
    {
        [Test]
        public void TestDeleteFile()
        {
            // Arrange
            var testFile = TestFiles.FourPagesDocx;
            var deleteRequest = new DeleteFileRequest {path = testFile.FullName};
            var existsRequest = new ObjectExistsRequest { path = testFile.FullName };
            var uploadRequest = new UploadFileRequest(testFile.FullName, GetTestFileStream(testFile));

            // Act & Assert 
            FileApi.DeleteFile(deleteRequest);
            var response = StorageApi.ObjectExists(existsRequest);            
            Assert.IsFalse(response.Exists);
            FileApi.UploadFile(uploadRequest);
            response = StorageApi.ObjectExists(existsRequest);
            Assert.IsTrue(response.Exists);
        }

        [Test]
        public void TestGetDownloadFile()
        {
            // Arrange
            var testFile = TestFiles.FourPagesDocx;
            var request = new DownloadFileRequest { path = testFile.FullName };

            // Act & Assert             
            var response = FileApi.DownloadFile(request);
            Assert.Greater(response.Length, 0);
        }

        [Test]
        public void TestPutCopyMoveFile()
        {
            var testFile = TestFiles.FourPagesDocx;

            // Create temp folder
            var cRequest = new CreateFolderRequest("temp");
            FolderApi.CreateFolder(cRequest);

            // Copy file
            var destPath = $"temp/{testFile.FileName}";
            var request = new CopyFileRequest(testFile.FullName, destPath);
            FileApi.CopyFile(request);

            // Check copied file
            var eRequest = new ObjectExistsRequest(destPath);
            var eResponse = StorageApi.ObjectExists(eRequest);
            Assert.IsTrue(eResponse.Exists);

            // Move file
            var newDestPath = $"temp/{testFile.FileName.Replace(".", "_1.")}";            
            var mRequest = new MoveFileRequest(destPath, newDestPath);
            FileApi.MoveFile(mRequest);

            // Check moved file
            eRequest = new ObjectExistsRequest(newDestPath);
            eResponse = StorageApi.ObjectExists(eRequest);
            Assert.IsTrue(eResponse.Exists);

            // Delete temp folder
            var delRequest = new DeleteFolderRequest("temp", null, true);
            FolderApi.DeleteFolder(delRequest);
        }
    }
}
