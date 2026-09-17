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
            //int pages = 400;
            //Helper.AddBonusPages(pages);
            //Console.WriteLine(pages);
            ////I expect to see 400 also, because it is value type call by value and the change happened in the AddBonusPages stack frame
            ////not in pages varaiable in memory
            #endregion

            #region Q6
            //double[] prices = { 25.5, 40.0 };
            //Helper.ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            ////I expect to see 20.5, because it is reference type pass by value and the value is the address of the object in heap memory
            ////so the prices array in function is also has the address of the object in heap memory so the change occure
            #endregion

            #region Q7
            //int pages = 400;
            //Helper.AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            ////the result is 450 as it is value type pass by reference and the change happened in the same place in memory not in the
            ////AddBonusPagesByRef stack frame so the change occure
            #endregion

            #region Q8
            //double[] prices = { 25.5, 40.0 };
            //Helper.ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion

            #region Q9
            //string title = "Clean Code";
            //double price;
            //bool flag = Helper.TryGetPrice(title, out price);

            //if(flag)
            //    Console.WriteLine(price);
            #endregion

            #region Q10
            string title = "Clean Code";
            int pages = 400;
            //Helper.PrintBookInfo(title);
            //Helper.PrintBookInfo(title, pages);
            #endregion

            #region Q11
            Helper.PrintBookInfo(pages : 400, title : "Clean Code");
            #endregion
        }
    }
}
