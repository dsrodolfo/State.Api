using System.Globalization;
using System.Text;

namespace State.Application.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveDiacritics(this string text)
        {
            var clearText = new string(text.Normalize(NormalizationForm.FormD)
                                           .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                                           .ToArray());
            return clearText.Trim();
        }
    }
}
