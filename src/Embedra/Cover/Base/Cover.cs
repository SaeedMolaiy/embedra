namespace Embedra
{
    public abstract class Cover : IPayloadEmbedder
    {
        private readonly string _filePath;
        private readonly string _coverKey;

        protected Cover(string filePath, string coverKey)
        {
            _filePath = filePath;
            _coverKey = coverKey;
        }

        public abstract void Embed(TextPayload payload);

        public abstract void Embed(BinaryPayload payload);

        public abstract void Embed(ArchivePayload payload);

        public abstract void Embed(AudioPayload payload);

        public abstract void Embed(ImagePayload payload);

        public abstract void Embed(VideoPayload payload);
    }
}