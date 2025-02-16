namespace Arrays;

public class ArrayPrinter : IArrayPrinter
{
    public void Print(ref Array arrayToPrint)
    {
        // And here's the catch. :) We do not have access to the internal array anymore
        // so we need to either take advantage of the Size property and something
        // to display values at a certian index which does not exists.
        // Or simpler have a to string method that displays values
        // in a comma separated format and use it here
        Console.Write($"[{arrayToPrint.ToString()}]");
    }
}