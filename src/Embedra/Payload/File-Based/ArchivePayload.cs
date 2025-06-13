namespace Embedra
{
    public class ArchivePayload : FileBasedPayload
    {
        public ArchivePayload(string payloadFilePath) : base(payloadFilePath)
        {
        }

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}