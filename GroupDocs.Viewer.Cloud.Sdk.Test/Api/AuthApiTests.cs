using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    public class AuthApiTests
    {
        /// <summary>
        /// Test Auth Error
        /// </summary>
        [Test]
        public void AuthErrorWhenAppSidNotFoundTest()
        {
            var appSid = "test";
            var appKey = "test";

            var viewerConfig = new Configuration(appSid, appKey)
            {
                ApiBaseUrl = Config.ApiBaseUrl
            };

            var viewerApi = new ViewerApi(viewerConfig);

            var ex = Assert.Throws<ApiException>(() =>
            {
                viewerApi.GetSupportedFileFormats();
            });

            Assert.AreEqual("Client 'test' is not registered in the system.", ex.Message);
        }

        /// <summary>
        /// Test Auth Error
        /// </summary>
        [Test]
        public void AuthErrorWhenAppKeyNotFoundTest()
        {
            var appSid = Config.AppSID;
            var appKey = "test";

            var viewerConfig = new Configuration(appSid, appKey)
            {
                ApiBaseUrl = Config.ApiBaseUrl
            };

            var viewerApi = new ViewerApi(viewerConfig);

            var ex = Assert.Throws<ApiException>(() =>
            {
                viewerApi.GetSupportedFileFormats();
            });

            Assert.AreEqual("Client secret is invalid.", ex.Message);
        }
    }
}