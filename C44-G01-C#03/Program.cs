namespace C44_G01_C_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 - Divisible by 3 and 4
            static string CheckDivisibility(int number)
            {
                return (number % 3 == 0 && number % 4 == 0) ? "Yes" : "No";
            }
            #endregion
            #region Question 2 - Positive or Negative
            static string CheckPositiveNegative(int number)
            {
                return (number < 0) ? "negative" : "positive";
            }
            #endregion
            #region Question 3 - Find Min and Max
            static void FindMinMax(int a, int b, int c)
            {
                int max = Math.Max(a, Math.Max(b, c));
                int min = Math.Min(a, Math.Min(b, c));
                Console.WriteLine($"Max element = {max}");
                Console.WriteLine($"Min element = {min}");
            }
            #endregion
            #region Question 4 - Even or Odd
            static string CheckEvenOdd(int number)
            {
                return (number % 2 == 0) ? "Even" : "Odd";
            }
            #endregion
            #region Question 5 - Vowel or Consonant
            static string CheckVowel(char ch)
            {
                char lowerCh = char.ToLower(ch);
                return (lowerCh == 'a' || lowerCh == 'e' || lowerCh == 'i' ||
                        lowerCh == 'o' || lowerCh == 'u') ? "vowel" : "consonant";
            }
            #endregion
            #region Question 6 - Print Numbers
            static void PrintNumbers(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + (i < n ? ", " : ""));
                }
                Console.WriteLine();
            }
            #endregion


        }
    }
}
