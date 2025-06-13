namespace Embedra
{
    public interface IPayloadEmbedder
    {
        #region Text-Based

        void Embed(TextPayload payload);

        void Embed(BinaryPayload payload);

        #endregion

        #region File-Based

        void Embed(ArchivePayload payload);

        void Embed(AudioPayload payload);

        void Embed(ImagePayload payload);

        void Embed(VideoPayload payload);

        #endregion

    }
}