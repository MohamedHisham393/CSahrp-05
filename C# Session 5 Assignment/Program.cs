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

        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        public static void AddBonusPagesByRef(ref int pages)
        {
            pages = pages + 50;
        }

        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code" )
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }

        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
        }

        public static void PrintAllTitles(params string[] titles)
        {
            for(int i = 0; i< titles.Length; i++)
            {
                Console.WriteLine(titles[i]);
            }
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

            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);

            //-------------------------------------------------------------

            //Assinment 4 file - Q6

            //I expect it with change after calling because its passing by value - reference type so the 2 variables refer to same addres

            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine(prices[0]);

            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);

            //-------------------------------------------------------------

            //Assinment 4 file - Q7

            //I expect it variable with change after calling beacause its calling by reference

            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);

            //-------------------------------------------------------------

            //Assinment 4 file - Q8

            //double[] prices = { 20.5, 5.5, 60, 6 };
            //ReplaceArray(ref prices);

            //foreach(double price in prices) { Console.WriteLine(price); }

            //=============================================================

            //Assignment 5 file - Q1

            //string title = "Clean Code";
            //bool flag = TryGetPrice(title, out double price);
            //Console.WriteLine(flag);
            //Console.WriteLine(price);

            //=============================================================

            //Assignment 5 file - Q2

            //string title = "C#";
            //PrintBookInfo(title);

            //string title02 = "Code";
            //int pages = 50;
            //PrintBookInfo(title02, pages);

            //=============================================================

            //Assignment 5 file - Q3

            //PrintBookInfo(pages: 30, title: "CSharp");


            //=============================================================

            //Assignment 5 file - Q4

            string book01 = "Coding";
            string book02 = "C#";
            string book03 = "Clean Code";
            PrintAllTitles(book01, book02, book03);
        }
    }
}
