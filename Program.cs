namespace Session04_AssignmentC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine($"price[1]: {prices[1]}");
            #endregion

            #region Q2
            //int[,] shelfCopies = {
            //    { 3, 5 },
            //    { 1, 4 }
            //};
            //Console.WriteLine($"shelfCopies[1, 0]: {shelfCopies[1,0]}");
            #endregion

            #region Q3
            //Helper.PrintWelcomeMessage();
            #endregion

            #region Q4
            //Helper.PrintBookTitle("Clean Code");
            #endregion

            #region Q5
            int pages = 400;
            Helper.AddBonusPages(pages);
            Console.WriteLine(pages);
            //I expect to see 400 also, because it is value type call by value and the change happened in the AddBonusPages stack frame
            //not in pages varaiable in memory
            #endregion
        }
    }
}
