namespace C__Session_5_Assignment
{
    internal class Program
    {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
            

        public static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book Title: {title}");
        }

        public static void AddBonusPages(int pages)
        {
            pages = pages + 50;
        }

        static void Main(string[] args)
        {
            //Assinment 4 file - Q1

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);

            //------------------------------------------------------------

            //Assinment 4 file - Q2

            //int[,] shelfCopies =
            //{
            //    {3,5 },
            //    {1,4 }
            //};

            //Console.WriteLine(shelfCopies[1,0]);

            //-------------------------------------------------------------

            //Assinment 4 file - Q3

            //PrintWelcomeMessage();

            //-------------------------------------------------------------

            //Assinment 4 file - Q4

            //string title = "Clean Code";
            //PrintBookTitle(title);

            //-------------------------------------------------------------

            //Assinment 4 file - Q5

            //I expect that no changes on the variable because its pass by value

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
        }
    }
}
