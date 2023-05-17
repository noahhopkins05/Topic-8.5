namespace Topic_8._5
{
    internal class Program
    {
        public static string hangman;
        static void Main(string[] args)
        {
            int numberOfIncorrectGuesses = 0;
            string word = "COMPUTER";
            Random random = new Random();
            string displayWord = "--------";
            bool wordGuessed = false;
            char[] guess = 


            while (!wordGuessed || numberOfIncorrectGuesses <= 7)
            {
                drawHanger(numberOfIncorrectGuesses);
            }
        }
        private static void drawHanger(int numberOfIncorrectGuesses)
        {
            switch (numberOfIncorrectGuesses)
            {
                case (0):
                    Console.WriteLine("   +------+");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("   ========");
                    break;
                case (1):
                    Console.WriteLine("    +-----+");
                    Console.WriteLine("      |   |");
                    Console.WriteLine("      O   |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("    =======");
                    break;
                case (2):
                    Console.WriteLine("    +-----+");
                    Console.WriteLine("      |   |");
                    Console.WriteLine("      O   |");
                    Console.WriteLine("      |   |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("    =======");
                    break;
                case (3):
                    Console.WriteLine("    +-----+");
                    Console.WriteLine("      |   |");
                    Console.WriteLine("      O   |");
                    Console.WriteLine("     /|   |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("    =======");
                    break;
                case (4):
                    Console.WriteLine("    +-----+");
                    Console.WriteLine("      |   |");
                    Console.WriteLine("      O   |");
                    Console.WriteLine("     /|\\ |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("    =======");
                    break;
                case (5):
                    Console.WriteLine("    +-----+");
                    Console.WriteLine("      |   |");
                    Console.WriteLine("      O   |");
                    Console.WriteLine("     /|\\ |");
                    Console.WriteLine("     /    |");
                    Console.WriteLine("          |");
                    Console.WriteLine("    =======");
                    break;
                case (6):
                    Console.WriteLine("    +-----+");
                    Console.WriteLine("      |   |");
                    Console.WriteLine("      O   |");
                    Console.WriteLine("     /|\\ |");
                    Console.WriteLine("     / \\ |");
                    Console.WriteLine("          |");
                    Console.WriteLine("    =======");
                    break;
                case (7):
                    Console.WriteLine("    +-----+");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("     \\O/ |");
                    Console.WriteLine("      |   |");
                    Console.WriteLine("     / \\ |");
                    Console.WriteLine("    =======");
                    break;
            }
        }
    }
}