namespace Embedra
{
    public class AudioPayload : FileBasedPayload
    {
        public AudioPayload(string payloadFilePath) : base(payloadFilePath)
        {
        }

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}