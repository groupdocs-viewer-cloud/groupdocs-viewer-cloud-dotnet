// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="Configuration.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
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

namespace GroupDocs.Viewer.Cloud.Sdk.Client
{
    using System;

    /// <summary>
    /// Represents a set of configuration settings.
    /// </summary>
    public class Configuration
    {
        private string version = "v1";
        private string apiBaseUrl = "https://api.groupdocs.cloud";

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public Configuration(string appSid, string appKey)
        {
            if (string.IsNullOrEmpty(appSid))
            {
                throw new ArgumentNullException("appSid",
                    "Get your App SID and App Key at https://dashboard.groupdocs.cloud");
            }

            if (string.IsNullOrEmpty(appKey))
            {
                throw new ArgumentNullException("appKey",
                    "Get your App SID and App Key at https://dashboard.groupdocs.cloud");
            }

            this.AppSid = appSid;
            this.AppKey = appKey;
        }

        /// <summary>
        /// GroupDocs Cloud API base URL.
        /// </summary>
        public string ApiBaseUrl
        {
            get { return this.apiBaseUrl; }
            set { this.apiBaseUrl = value; }
        }

        /// <summary>
        /// The app key.
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// The app sid.
        /// </summary>
        public string AppSid { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether debug mode.
        /// </summary>
        public bool DebugMode { get; set; }

        /// <summary>
        /// Authentication type.
        /// Default is OAuth 2.0
        /// </summary>
        public AuthType AuthType { get; set; }

        internal string GetApiRootUrl()
        {
            var result = this.apiBaseUrl + "/" + this.version;
            return result.EndsWith("/") ? result.Substring(0, result.Length - 1) : result;
        }
    }
}