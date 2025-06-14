namespace Embedra
{
    public class ArchivePayload : FileBasedPayload
    {
        public static readonly string[] SupportedArchiveFileExtensions =
            new[] { ".zip", ".rar", ".7z", ".cab", ".iso" };

        public ArchivePayload(string payloadFilePath) : base(payloadFilePath)
        {
        }

        protected override string[] SupportedFileExtensions => SupportedArchiveFileExtensions;

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}