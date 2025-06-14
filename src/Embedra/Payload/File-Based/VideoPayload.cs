namespace Embedra
{
    public class VideoPayload : FileBasedPayload
    {
        public static readonly string[] SupportedVideoFileExtensions =
            new[] { ".mp4", ".avi", ".mov", ".mkv", ".wmv", ".flv", ".webm" };

        public VideoPayload(string payloadFilePath) : base(payloadFilePath)
        {
        }

        protected override string[] SupportedFileExtensions => SupportedVideoFileExtensions;

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}