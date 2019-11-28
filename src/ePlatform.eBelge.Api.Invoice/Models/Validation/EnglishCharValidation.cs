using System.Text.RegularExpressions;

namespace ePlatform.eBelge.Api.Models.Models.Validation
{
    public static class EnglishCharValidation
    {
        /// <summary>
        /// Regular expression, which is used to validate an English CharacterList.
        /// </summary>
        public const string MatchPattern = @"[A-Z0-9]{3}";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text">
        /// <returns>
        /// otherwise false.</returns>
        public static bool IsValid(string text)
        {
            if (text != null)
            {
                return Regex.IsMatch(text, MatchPattern);
            }
            else
                return false;
        }
    }
}
