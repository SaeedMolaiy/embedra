namespace Embedra
{
    internal static class Guard
    {
        public static void ThrowIfNull(object obj, string message = "")
        {
            if (obj == null)
                throw new ArgumentNullException(message);
        }

        public static void ThrowIfNullOrWhiteSpace(string text, string message = "")
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(message);
        }

        public static void ThrowIfFileDoesNotExists(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException(
                    "Payload file not found.", filePath);
        }
    }
}