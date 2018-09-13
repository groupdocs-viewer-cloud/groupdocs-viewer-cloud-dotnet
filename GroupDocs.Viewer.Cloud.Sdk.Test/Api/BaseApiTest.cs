using System;
using System.IO;
using System.Reflection;
using System.Text;
using GroupDocs.Storage.Cloud.Sdk.Model.Requests;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using Configuration = GroupDocs.Viewer.Cloud.Sdk.Client.Configuration;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using Newtonsoft.Json;
    using NUnit.Framework;
    using GroupDocs.Storage.Cloud.Sdk.Api;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal;

    public class BaseApiTest
    {
        protected const string FromUrlFolder = "tests\\from_url";
        protected const string FromContentFolder = "tests\\from_content";

        private readonly string _appSid = Config.AppSID;
        private readonly string _appKey = Config.AppKey;
        private readonly string _apiBaseUrl = Config.ApiBaseUrl;

        protected ViewerApi ViewerApi;
        protected StorageApi StorageApi;

        [SetUp]
        public void BeforeEachTest()
        {
            var viewerConfig = new Configuration(_appSid, _appKey)
            {
                ApiBaseUrl = _apiBaseUrl
            };

            ViewerApi = new ViewerApi(viewerConfig);

            var storageConfig = new Storage.Cloud.Sdk.Configuration
            {
                AppSid = _appSid,
                AppKey = _appKey,
                ApiBaseUrl = _apiBaseUrl
            };

            StorageApi = new StorageApi(storageConfig);
        }

        [TearDown]
        public void AfterEachTest()
        {
            RemoveTempFiles();
        }

        private void RemoveTempFiles()
        {
            DeleteFolderFromStorage("cache");
            DeleteFolderFromStorage("tests");
        }

        private void DeleteFolderFromStorage(string folderName)
        {
            var request = new DeleteFolderRequest(folderName, null, true);
            var response = StorageApi.DeleteFolder(request);

            Assert.AreEqual("OK", response.Status);
        }

        private byte[] GetTestFileBytes(TestFile file)
        {
            var filePath = Path.Combine(GetTestDataPath(), file.Folder, file.FileName);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found: " + filePath);
            }

            return File.ReadAllBytes(filePath);
        }

        protected Stream GetTestFileStream(TestFile file)
        {
            var bytes = GetTestFileBytes(file);

            return new MemoryStream(bytes);
        }

        protected Stream SerializeObject(object obj)
        {
            var options = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            var json = JsonConvert.SerializeObject(obj, options);

            var bytes = Encoding.UTF8.GetBytes(json);

            return new MemoryStream(bytes);
        }

        private string GetTestDataPath()
        {
            var uri = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            var workingDir = Path.GetDirectoryName(uri.LocalPath);
            if (workingDir == null)
                workingDir = Directory.GetCurrentDirectory();

            var baseDir = Path.Combine(workingDir, "Resources", "TestData");

            return Path.GetFullPath(baseDir);
        }
    }
}