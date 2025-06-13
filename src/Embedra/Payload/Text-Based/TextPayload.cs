namespace Embedra
{
    public class TextPayload : TextBasedPayload
    {
        public TextPayload(string payload) : base(payload)
        {
        }

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}