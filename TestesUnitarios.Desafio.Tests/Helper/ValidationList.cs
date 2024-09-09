namespace TestesUnitarios.Desafio.Tests.Helper;

public class ValidationList
{
    public List<int> OriginalList { get; set; } = new List<int>();
    public List<int> NonNegativeList { get; set; } = new List<int>();
    public List<int> MultipliedList { get; set; } = new List<int>();
    public int MultiplicationFactor { get; set; }
    public int Biggest { get; set; } = int.MinValue;
    public int Smallest { get; set; } = int.MaxValue;

    public ValidationList(int listLength)
    {
        MultiplicationFactor = new Random().Next(3, 9);
        for (int i = 0; i < listLength; i++)
        {
            int number = new Random().Next(-10, 10);
            OriginalList.Add(number);
            if (number > 0)
            {
                NonNegativeList.Add(number);
            }
            MultipliedList.Add(number * MultiplicationFactor);
            if (number > Biggest)
            {
                Biggest = number;
            }
            if (number < Smallest)
            {
                Smallest = number;
            }
        }
    }
}