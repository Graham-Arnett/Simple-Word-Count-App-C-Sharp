namespace WordCountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my sentence word counting app!");
            string choice;
            //int spaceCount = 0;
            //int wordCount = 0;
            do
            {
                int spaceCount = 0;

                Console.Write("\n\nPlease enter a sentence: ");
                string yourSentence = Console.ReadLine();

                for (int i = yourSentence.Length - 1; i >= 0; i--)
                {
                    if (yourSentence[i] == ' ')
                    {
                        spaceCount++;
                    }

                }
                int wordCount = spaceCount + 1; //if there are no spaces it's one word
                Console.WriteLine($"Your word count is {wordCount} words.");
                Console.Write("\n\nWould you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
            //int wordCount = spaceCount + 1;
            //wordCount = spaceCount + 1; //if there are no spaces it's one word
            //Console.WriteLine($"Your word count is {wordCount} words.");
        }
    }
}
