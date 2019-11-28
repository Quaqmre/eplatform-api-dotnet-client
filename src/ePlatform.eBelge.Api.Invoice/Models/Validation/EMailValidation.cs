using System.Text.RegularExpressions;

namespace ePlatform.eBelge.Api.Models.Models.Validation
{
    public static class EMailValidation
    {
        /// <summary>
        /// Regular expression, which is used to validate an E-Mail address.
        /// </summary>
        public const string MatchEmailPattern = @"^(([\w-+]+\.)+[\w-+]+|([a-zA-Z]{1}|[\w-+]{2,}))@((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

        public const string MatchEmailPattern2 = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

        /// <summary>
        /// Checks whether the given Email-Parameter is a valid E-Mail address.
        /// </summary>
        /// <param name="email">Parameter-string that contains an E-Mail address.</param>
        /// <returns>True, wenn Parameter-string is not null and contains a valid E-Mail address;
        /// otherwise false.</returns>
        public static bool IsValidEmail(string email)
        {
            if (email != null)
            {
                var result = Regex.IsMatch(email, MatchEmailPattern);
                if (result)
                {
                    email = email.ToLowerInvariant();
                    return Regex.IsMatch(email, MatchEmailPattern2, RegexOptions.IgnoreCase);
                }
                else
                    return false;
            }
            else return false;
        }
    }
}
