using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1.Helpers
{
    public static class Validator
    {
        private const string _nameSurnamePattern = "^([A-z-]+)$";
        private const string _emailPattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                                           @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

        public static bool ValidateNameOrSurname(string name)
        {
            return !string.IsNullOrEmpty(name) && Regex.IsMatch(name, _nameSurnamePattern);
        }

        public static bool ValidateDate(string date)
        {
            CultureInfo lvCulture = CultureInfo.GetCultureInfo("lv");
            try
            {
                DateTime enteredDate = DateTime.ParseExact(date, "d", lvCulture);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidateEmail(string email)
        {
            return !string.IsNullOrEmpty(email) && Regex.IsMatch(email, _emailPattern, RegexOptions.IgnoreCase);
        }

        public static bool ValidateSsn(string ssn, DateTime? birthday)
        {
            string ssnFirstHalf = Generator.GenerateSsn(birthday);
            return Regex.IsMatch(ssn, "^" + ssnFirstHalf + "\\d{5}$");
        }

        public static bool ValidateNumber(string phone)
        {
            return !string.IsNullOrEmpty(phone) && phone.All(char.IsDigit);
        }

        
    }
}
