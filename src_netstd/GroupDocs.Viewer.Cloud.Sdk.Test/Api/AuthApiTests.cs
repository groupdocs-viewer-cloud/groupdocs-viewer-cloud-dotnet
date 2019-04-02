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

using System;
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

            var ex = Assert.Throws<AggregateException>(() =>
            {
                viewerApi.GetSupportedFileFormats();
            });

            Assert.AreEqual("One or more errors occurred. ({\"error\":\"invalid_client\"})", ex.Message);
        }

        /// <summary>
        /// Test Auth Error
        /// </summary>
        [Test]
        public void AuthErrorWhenAppKeyNotFoundTest()
        {
            var appSid = Config.AppSid;
            var appKey = "test";

            var viewerConfig = new Configuration(appSid, appKey)
            {
                ApiBaseUrl = Config.ApiBaseUrl
            };

            var viewerApi = new ViewerApi(viewerConfig);

            var ex = Assert.Throws<AggregateException>(() =>
            {
                viewerApi.GetSupportedFileFormats();
            });

            Assert.AreEqual("One or more errors occurred. ({\"error\":\"invalid_client\"})", ex.Message);
        }
    }
}