namespace Embedra
{
    public abstract class Payload
    {
        public abstract void Accept(IPayloadEmbedder embedder);
    }
}