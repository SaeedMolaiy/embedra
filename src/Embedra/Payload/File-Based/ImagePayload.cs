namespace Embedra
{
    public class ImagePayload : FileBasedPayload
    {
        public static readonly string[] SupportedImageFileExtensions =
            new[] { ".bmp", ".jpg", ".jpeg", ".png", ".gif", ".tiff", ".ico" };

        public ImagePayload(string payloadFilePath) : base(payloadFilePath)
        {
        }

        protected override string[] SupportedFileExtensions => SupportedImageFileExtensions;

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}