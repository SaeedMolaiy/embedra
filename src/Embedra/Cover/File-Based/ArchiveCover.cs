namespace Embedra
{
    public class ArchiveCover : Cover
    {
        internal const string ArchiveCoverKey = "ARCH";

        public ArchiveCover(string filePath) : base(filePath, ArchiveCoverKey)
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