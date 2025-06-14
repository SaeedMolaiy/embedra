namespace Embedra
{
    internal static class Extensions
    {
        public static bool In<T>(this T obj, params T[] array) => array.Contains(obj);

        public static bool NotIn<T>(this T obj, params T[] array) => !In(obj, array);
    }
}