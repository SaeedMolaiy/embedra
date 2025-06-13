namespace Embedra
{
    public class ImageCover : Cover
    {
        internal const string ImageCoverKey = "IMG";

        public ImageCover(string filePath) : base(filePath, ImageCoverKey)
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