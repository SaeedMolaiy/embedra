namespace Embedra
{
    public abstract class TextBasedPayload : Payload
    {
        private readonly string _payload;

        protected TextBasedPayload(string payload)
        {
            _payload = payload;
        }
    }
}