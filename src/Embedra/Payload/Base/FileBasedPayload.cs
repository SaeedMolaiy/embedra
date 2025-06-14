namespace Embedra
{
    public abstract class FileBasedPayload : Payload
    {
        protected readonly string _payloadFilePath;
        protected readonly byte[] _payload;

        protected FileBasedPayload(string payloadFilePath)
        {
            ValidatePayloadFile(payloadFilePath);

            _payloadFilePath = payloadFilePath;
            _payload = File.ReadAllBytes(_payloadFilePath);
        }

        protected abstract string[] SupportedFileExtensions { get; }

        public sealed override byte[] GetBytes() => _payload;

        private void ValidatePayloadFile(string payloadFilePath)
        {
            Guard.ThrowIfNullOrWhiteSpace(
                payloadFilePath, "payload file's path can not be null, empty or white space.");

            var payloadFileExtensions =
                Path.GetExtension(_payloadFilePath);

            if (payloadFileExtensions.NotIn(SupportedFileExtensions))
                throw new ArgumentException(
                    "Invalid file extension for payload file.");

            Guard.ThrowIfFileDoesNotExists(_payloadFilePath);
        }
    }
}