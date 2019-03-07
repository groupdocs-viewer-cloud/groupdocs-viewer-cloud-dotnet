// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="TestFiles.cs">
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

using System.Collections.Generic;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal
{
    public static class TestFiles
    {
        public static readonly TestFile OnePageDocx = new TestFile("one-page.docx", "words\\docx\\");
        public static readonly TestFile NotExist = new TestFile("NotExist.docx", "some-folder/");
        public static readonly TestFile PasswordProtectedDocx = new TestFile("password-protected.docx", "words\\docx\\")
        {
            Password = "password"
        };
        public static readonly TestFile TwoHiddenPagesVsd = new TestFile("two-hidden-pages.vsd", "diagram\\vsd\\");
        public static readonly TestFile WithHiddenRowsAndColumns = new TestFile("with-hidden-rows-and-columns.xlsx", "cells\\xlsx\\");
        public static readonly TestFile ThreeLayoutsDwf = new TestFile("three-layouts.dwf", "cad\\dwf\\");
        public static readonly TestFile ProjectMpp = new TestFile("sample.mpp", "project\\mpp\\");
        public static readonly TestFile UsesCustomFontPptx = new TestFile("uses-custom-font.pptx", "slides\\pptx\\");
        public static readonly TestFile FontTtf = new TestFile("foo.ttf", "font\\ttf\\");
        public static readonly TestFile FourPagesDocx = new TestFile("four-pages.docx", "words\\docx\\");

        public static IEnumerable<TestFile> TestFilesList
        {
            get
            {
                yield return OnePageDocx;
                yield return PasswordProtectedDocx;
                yield return TwoHiddenPagesVsd;
                yield return WithHiddenRowsAndColumns;
                yield return ThreeLayoutsDwf;
                yield return ProjectMpp;
                yield return UsesCustomFontPptx;
                yield return FontTtf;
                yield return FourPagesDocx;
            }
        }
    }
}
