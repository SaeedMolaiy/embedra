namespace Embedra
{
    public class TextPayload : TextBasedPayload
    {
        public TextPayload(string payload) : base(payload)
        {
        }

        public TextPayload(string payload, PayloadEncoding encoding) : base(payload, encoding)
        {
        }

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}