namespace GroupDocs.Viewer.Cloud.Sdk.Test.Api.Internal
{
    public class TestFile
    {
        public string FileName { get; set; }

        public string Folder { get; set; }

        public string Password { get; set; }

        public string Url { get; set; }

        public string AttachmentName { get; set; }

        public string AttachmentPassword { get; set; }

        public TestFile(string fileName)
        {
            FileName = fileName;
        }

        public TestFile(string fileName, string folder)
        {
            FileName = fileName;
            Folder = folder;
        }
    }
}