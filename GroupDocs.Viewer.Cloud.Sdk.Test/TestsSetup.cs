using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;

namespace GroupDocs.Viewer.Cloud.Sdk.Test
{
    using GroupDocs.Storage.Cloud.Sdk;
    using GroupDocs.Storage.Cloud.Sdk.Api;
    using GroupDocs.Storage.Cloud.Sdk.Model.Requests;

    [SetUpFixture]
    public class TestsSetup
    {
        private readonly string _appSid = Config.AppSID;
        private readonly string _appKey = Config.AppKey;
        private readonly string _apiBaseUrl = Config.ApiBaseUrl;

        private readonly StorageApi _storageApi;

        public TestsSetup()
        {
            var storageConfig = new Configuration
            {
                AuthType = AuthType.OAuth2,
                AppSid = _appSid,
                AppKey = _appKey,
                ApiBaseUrl = _apiBaseUrl
            };

            _storageApi = new StorageApi(storageConfig);
        }

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            UploadTestFiles();
        }

        private void UploadTestFiles()
        {
            var path = GetTestDataPath();

            var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (var dir in dirs)
            {
                var relativeDirPath = dir.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

                var response = _storageApi.GetIsExist(new GetIsExistRequest(relativeDirPath));
                if (!response.FileExist.IsExist.GetValueOrDefault())
                    _storageApi.PutCreateFolder(new PutCreateFolderRequest(relativeDirPath));
            }

            var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var relativeFilePath = file.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

                var response = _storageApi.GetIsExist(new GetIsExistRequest(relativeFilePath));
                if (!response.FileExist.IsExist.GetValueOrDefault())
                {
                    using (FileStream fs = File.OpenRead(file))
                    {
                        var request = new PutCreateRequest(relativeFilePath, fs);
                        _storageApi.PutCreate(request);
                    }
                }
            }
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