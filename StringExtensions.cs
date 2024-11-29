namespace StringExtensionsNamespace; // File-scoped namespace declaration

public static class StringExtensions
{
    // Extension method to check if a string starts with an uppercase letter
    public static bool StartsWithUpper(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return false;
        }

        char firstChar = str[0];
        return char.IsUpper(firstChar);
    }
}
