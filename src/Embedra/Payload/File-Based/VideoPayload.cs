namespace Embedra
{
    public class VideoPayload : FileBasedPayload
    {
        public VideoPayload(string payloadFilePath) : base(payloadFilePath)
        {
        }

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}