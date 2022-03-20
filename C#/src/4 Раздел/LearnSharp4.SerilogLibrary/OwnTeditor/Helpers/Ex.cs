using System;

namespace OwnTeditor.Helpers
{
    internal static class Ex
    {
        internal static void ThrowIfEmptyOrNull(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException(nameof(text) + " was empty or null");
        }

        internal static void ThrowIfNullObject<T>(T toCheck)
        {
            if(toCheck == null)
                throw new ArgumentNullException(nameof(toCheck) + " was null");
        }
    }
}
