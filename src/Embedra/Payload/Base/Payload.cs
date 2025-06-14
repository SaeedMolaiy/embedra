namespace Embedra
{
    public abstract class Payload
    {
        public abstract byte[] GetBytes();

        public abstract void Accept(IPayloadEmbedder embedder);
    }
}