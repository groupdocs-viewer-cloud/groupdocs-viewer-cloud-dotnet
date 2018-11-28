using System.Collections.Generic;

namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal
{
    public static class TestFiles
    {
        public static readonly TestFile WithAttachmentMsg = new TestFile("with-attachment.msg", "email\\msg")
        {
            AttachmentName = "password-protected.docx",
            AttachmentPassword = "password"
        };

        public static readonly TestFile FromUrlOnePageDocx = new TestFile("one-page.docx")
        {
            Url = "https://www.dropbox.com/s/j260ve4f90h1p41/one-page.docx?dl=1"
        };

        public static readonly TestFile FromUrlWithNotesPptx = new TestFile("with-notes.pptx")
        {
            Url = "https://www.dropbox.com/s/r2eioe2atushqcf/with-notes.pptx?dl=1"
        };

        public static readonly TestFile UsesCustomFontPptx = new TestFile("uses-custom-font.pptx", "slides\\pptx");

        public static readonly TestFile OnePageDocx = new TestFile("one-page.docx", "words\\docx");

        public static readonly TestFile FourPagesDocx = new TestFile("four-pages.docx", "words\\docx");

        public static readonly TestFile PasswordProtectedDocx = new TestFile("password-protected.docx", "words\\docx")
        {
            Password = "password"
        };

        public static readonly TestFile WithAttachmentPdf = new TestFile("with-attachment.pdf", "pdf\\pdf")
        {
            AttachmentName = "password-protected.docx",
            AttachmentPassword = "password"
        };

        public static readonly TestFile TwoHiddenPagesVsd = new TestFile("two-hidden-pages.vsd", "diagram\\vsd");

        public static readonly TestFile CorruptedPdf = new TestFile("corrupted.pdf", "pdf\\pdf");

        public static readonly TestFile ProjectMpp = new TestFile("sample.mpp", "project\\mpp");

        public static readonly TestFile OutlookPst = new TestFile("sample.pst", "email\\outlook");

        public static readonly TestFile ImageCgm = new TestFile("nasa.cgm", "image");

        public static readonly TestFile PrintPs = new TestFile("sample.ps", "print");

        public static readonly TestFile PrintPcl = new TestFile("print.pcl", "print");

        public static IEnumerable<TestFile> Supported
        {
            get
            {
                yield return WithAttachmentMsg;
                yield return FromUrlOnePageDocx;
                yield return WithAttachmentPdf;
                yield return TwoHiddenPagesVsd;
                yield return ProjectMpp;
                yield return OutlookPst;
                yield return ImageCgm;
                yield return PrintPs;
                yield return PrintPcl;
            }
        }
    }
}