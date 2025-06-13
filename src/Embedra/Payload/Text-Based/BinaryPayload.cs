namespace Embedra
{
    public class BinaryPayload : TextBasedPayload
    {
        public BinaryPayload(string payload) : base(payload)
        {
        }

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}