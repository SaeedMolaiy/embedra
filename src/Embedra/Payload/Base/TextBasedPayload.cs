using System.Text;

namespace Embedra
{
    public abstract class TextBasedPayload : Payload
    {
        protected readonly PayloadEncoding _encoding;
        protected readonly string _payload;

        protected TextBasedPayload(string payload, PayloadEncoding encoding = PayloadEncoding.Utf8)
        {
            Guard.ThrowIfNullOrWhiteSpace(payload);

            _encoding = encoding;
            _payload = payload;
        }

        public PayloadEncoding Encoding => _encoding;

        public sealed override byte[] GetBytes()
        {
            return _encoding switch
            {
                PayloadEncoding.Utf8 => System.Text.Encoding.UTF8.GetBytes(_payload),
                PayloadEncoding.Utf16 => System.Text.Encoding.Unicode.GetBytes(_payload),
                PayloadEncoding.Utf32 => System.Text.Encoding.UTF32.GetBytes(_payload),
                PayloadEncoding.Base64 => Convert.FromBase64String(_payload),

                _ => throw new NotSupportedException($"Unsupported encoding: {_encoding}")
            };
        }
    }
}