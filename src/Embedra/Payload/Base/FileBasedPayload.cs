namespace Embedra
{
    public abstract class FileBasedPayload : Payload
    {
        private readonly string _payloadFilePath;

        protected FileBasedPayload(string payloadFilePath)
        {
            _payloadFilePath = payloadFilePath;
        }
    }
}