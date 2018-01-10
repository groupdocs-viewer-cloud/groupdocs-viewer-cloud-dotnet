using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Viewer.Cloud.Sdk.Api;
    using GroupDocs.Viewer.Cloud.Sdk.Internal;
    using GroupDocs.Viewer.Cloud.Sdk.Test.Internal;

    public class BaseApiTest
    {
        protected const string FromUrlFolder = "tests\\from_url";
        protected const string FromContentFolder = "tests\\from_content";

        private readonly string _appSid = ConfigurationManager.AppSettings["AppSID"];
        private readonly string _appKey = ConfigurationManager.AppSettings["AppKey"];
        private readonly string _apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];

        protected ViewerApi ViewerApi;
        protected StorageApi StorageApi;

        [SetUp]
        public void BeforeEachTest()
        {
            var viewerConfig = new Configuration
            {
                AuthType = AuthType.OAuth2,
                AppSid = _appSid,
                AppKey = _appKey,
                ApiBaseUrl = _apiBaseUrl
            };

            ViewerApi = new ViewerApi(viewerConfig);

            var storageConfig = new Configuration
            {
                AuthType = AuthType.OAuth2,
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
            StorageApi.DeleteFolder("cache");
            StorageApi.DeleteFolder("tests");
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
            var json = SerializationHelper.Serialize(obj);
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