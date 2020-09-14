namespace Helpers
{
    public static class StringHelpers
    {
        public static string ReduceLength(this string input, int maxLength)
        {
            input = input?.Trim();

            if (input == null || input.Length <= maxLength)
                return input;

            return input.Substring(0, maxLength) + " ...";
        }

        public static string WithEnglishDigits(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            string englishNumber = "";
            foreach (char ch in input)
            {
                englishNumber += char.GetNumericValue(ch);
            }
            return englishNumber;
        }

        public static string WithPersianLetters(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            input = input.Replace("ي", "ی").Replace("ك", "ک");

            return input;
        }
    }
}
