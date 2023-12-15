using System.Text.RegularExpressions;

namespace ITBlog.Extension.HelperExtensions
{
    public static class StringExtension
    {
        public static string RemoveHtmlTags(this string text)
        {
            return Regex.Replace(text, "<.*?>", string.Empty);
        }
    }
}
