namespace Inverter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine() ?? "";
                string invertedInput = StringReverse(input);
                Console.WriteLine($"Reversed input: {invertedInput}");

                Console.Write("\nTry again? (y/n) ");
                string tryAgain = Console.ReadLine() ?? "";

                if (tryAgain.ToLower() != "y")
                {
                    break;
                }
                Console.Clear();
            }
        }

        public static string StringReverse(string input)
        {
            char[] chars = input.ToCharArray();
            string output = "";
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                output += chars[i];
            }
            return output;
        }
    }
}