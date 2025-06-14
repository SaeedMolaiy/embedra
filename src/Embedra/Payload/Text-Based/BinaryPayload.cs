using System.Text;

namespace Embedra
{
    public class BinaryPayload : TextBasedPayload
    {
        public BinaryPayload(byte[] payload) : base(Convert.ToBase64String(payload), PayloadEncoding.Base64)
        {
        }

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}