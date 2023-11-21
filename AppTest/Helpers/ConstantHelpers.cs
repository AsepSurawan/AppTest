namespace AppTest.Helpers
{
    public static class ConstantHelpers
    {
        public static Dictionary<int, string> Gender = new Dictionary<int, string>()
        {
                {1, "Pria"},
                {2, "Wanita"},
        };

        public static Dictionary<string, string> Hobby = new Dictionary<string, string>()
        {
                { "A", "Sebak Bola"},
                { "B", "Badminton"},
                { "C", "Tennis"},
                { "D", "Renang"},
                { "E", "Bersepeda"},
        };
    }
}
