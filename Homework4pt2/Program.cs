internal class Program
{
    private static void Main(string[] args)
    {
        int totalTosses = 0;
        String userInput;
        int counter = 0;
        int totalHeads = 0;
        int totalTails = 0;
        double percentTails;
        double percentHeads;

        Console.WriteLine("For each coin toss enter either 'h' for heads or 't' for tails");

        do
        {
            Console.Write("Toss # " + totalTosses + " : ");
            userInput = Console.ReadLine();
            if (userInput == "h")
            {
                totalHeads++;
                totalTosses++;
            }
            else if (userInput == "t")
            {
                totalTails++;
                totalTosses++;
            }
            //percentHeads = (totalHeads / totalTosses) * 100.00;
            //percentTails = (totalTails / totalTosses) * 100.00;

        } while (totalTosses < 8);

        percentHeads = (totalHeads / (double)totalTosses) * 100.00;
        percentTails = (totalTails / (double)totalTosses) * 100.00;
        Console.WriteLine("Number of heads: " + totalHeads);
        Console.WriteLine("Number of tails: " + totalTails);
        Console.WriteLine("Percent of heads: " + percentHeads);
        Console.WriteLine("Percent of tails: " + percentTails);

    }
}