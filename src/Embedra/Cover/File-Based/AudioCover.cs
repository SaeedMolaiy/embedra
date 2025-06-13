namespace Embedra
{
    public class AudioCover : Cover
    {
        internal const string AudioCoverKey = "AUD";

        public AudioCover(string filePath) : base(filePath, AudioCoverKey)
        {
        }

        public override void Embed(TextPayload payload)
        {
            throw new NotImplementedException();
        }

        public override void Embed(BinaryPayload payload)
        {
            throw new NotImplementedException();
        }

        public override void Embed(ArchivePayload payload)
        {
            throw new NotImplementedException();
        }

        public override void Embed(AudioPayload payload)
        {
            throw new NotImplementedException();
        }

        public override void Embed(ImagePayload payload)
        {
            throw new NotImplementedException();
        }

        public override void Embed(VideoPayload payload)
        {
            throw new NotImplementedException();
        }
    }
}