namespace DesignPatterns.Application.Creational.Builder.AutoFixtureBuilder
{
    public class ValueGenerator
    {
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        private Random random;
        public ValueGenerator()
        {
            random = new Random();
        }

        public string GenerateString(int lenght = 50)
        {
            var result = new char[lenght];
            for (var i = 0; i < lenght; i++)
            {
                result[i] = Chars[random.Next(Chars.Length)];
            }

            return new string(result);
        }

        public int GenerateInt()
        {
            return random.Next(0, 1000);
        }

        public bool GenerateBool()
        {
            return random.Next(0, 2) == 1;
        }

        public DateTime GenerateDateTime()
        {
            var randomNumber = random.Next(-50000, 50000);
            var dateShift = new TimeSpan(randomNumber, randomNumber, randomNumber, randomNumber);
            return DateTime.Now.Add(dateShift);
        }
    }
}
