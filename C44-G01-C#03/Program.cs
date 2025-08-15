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

        }
    }
}
