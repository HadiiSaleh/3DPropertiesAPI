
namespace _3DPropertiesAPI.Helpers
{
    public class AppSettings
    {
        //Properties for JWT Token Signature
        public string Site { get; set; }
        public string Audience { get; set; }
        public string ExpireTime { get; set; }
        public string Secret { get; set; }

        // Media Validation
        public string[] permittedExtensions = { ".png", ".jpeg", ".jpg", ".gif", ".pdf", ".mp4", ".flv", ".3gp", ".mp3", ".webm", ".mkv", ".m4a", ".aac", ".wma" };
        public int FileSizeLimit { get; set; }
        public string FileNameRegex { get; set; }
    }
}
