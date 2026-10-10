public static class StatisticsHelper
{
    public static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers) {
            sum += number;
        }
        return sum;
    }

    public static double CalculateAverage(int[] numbers)
    {
        return numbers != null && numbers.Length != 0 ? numbers.Average() : 0;
    }

    public static int CalculateMax(int[] numbers)
    {
        return numbers != null ? numbers.Max() : 0;
    }
}