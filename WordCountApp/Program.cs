namespace WordCountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my sentence word counting app!");
            string choice;
            int wordCount = 0;
            do
            {
                Console.Write("\n\nPlease enter a sentence: ");
                string yourSentence = Console.ReadLine();

                for (int i = yourSentence.Length - 1; i >= 0; i--)
                {
                    if (yourSentence[i] == ' ')
                    {
                        wordCount++;
                    }

                }
                Console.WriteLine($"Your word count is {wordCount} words.");
                Console.Write("\n\nWould you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
