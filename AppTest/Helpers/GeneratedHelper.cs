namespace AppTest.Helpers
{
    public static class GeneratedHelper
    {
        public static string RandomString(int length, string chars)
        {
            Random random = new Random();

            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string GetRandAlphanumeric(int length)
        {
            return RandomString(length, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
        }

        public static string GetRandAlphanumericInLowAndUp(int length)
        {
            return RandomString(length, "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789");
        }

        public static string GetRandNumeric(int length)
        {
            return RandomString(length, "0123456789");
        }

        public static string GetRandAlphabet(int length)
        {
            return RandomString(length, "ABCDE");
        }

        public static int GetRandomInt(int start,int end) 
        {
            Random r = new Random();
            return  r.Next(start, end);
        }
    }
}
