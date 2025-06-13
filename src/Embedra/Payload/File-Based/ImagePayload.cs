namespace Embedra
{
    public class ImagePayload : FileBasedPayload
    {
        public ImagePayload(string payloadFilePath) : base(payloadFilePath)
        {
        }

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}