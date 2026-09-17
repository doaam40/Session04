namespace Session04_AssignmentC_
{
    internal class Helper
    {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the library!");
        }

        public static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " +title);
        }

        public static void AddBonusPages(int pages)
        {
            pages += 50;
        }
    }
}
