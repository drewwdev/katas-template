public class Kata
{
    public static int CalculateTip(double amount, string rating)
    {
        Console.WriteLine("Your total was $100");
        Console.WriteLine("How was the service? Terrible? Poor? Good? Great? Excellent?");
        Console.WriteLine("0%, 5%, 10%, 15%, 20%");
        string tipRating = Console.ReadLine("Enter terrible, poor, good, great, or excellent ");
        double totalBeforeTip = 100.00;
        if (tipRating == "terrible")
            CalculateTip = totalBeforeTip;
        return totalBeforeTip;
        if (tipRating == "poor")
            CalculateTip = ((totalBeforeTip / 100) * 5) + totalBeforeTip;
        return CalculateTip;
        if (tipRating == "good")
            CalculateTip = ((totalBeforeTip / 100) * 10) + totalBeforeTip;
        return CalculateTip;
        if (tipRating == "great")
            CalculateTip = ((totalBeforeTip / 100) * 15) + totalBeforeTip;
        return CalculateTip;
        if (tipRating == "excellent")
            CalculateTip = ((totalBeforeTip / 100) * 20) + totalBeforeTip;
        return CalculateTip;


    }
}