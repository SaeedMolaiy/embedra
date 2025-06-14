namespace Embedra
{
    public class AudioPayload : FileBasedPayload
    {
        public static readonly string[] SupportedAudioFileExtensions =
            new[] { ".mp3", ".wav", ".wma", ".aac", ".flac", ".ogg", ".m4a" };

        public AudioPayload(string payloadFilePath) : base(payloadFilePath)
        {
        }

        protected override string[] SupportedFileExtensions => SupportedAudioFileExtensions;

        public override void Accept(IPayloadEmbedder embedder) => embedder.Embed(this);
    }
}