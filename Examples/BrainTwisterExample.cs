//Dette er kun et eksempel på hvordan en Hjerne Twister kan sættes op, kopier ikke
class BrainTwisterExample
{
    static void Main()
    {
        Console.Write("Give me a number to do some math: ");
        int input = Convert.ToInt32(Console.ReadLine()), n = 5, m = -2;

        for (int i = 0; i < input; i++)
        {
            int result = i * n + m;
            switch (result)
            {
                case < 20:
                    Console.WriteLine($"The resutling number {result} is less than 20");
                    break;
                default:
                    Console.WriteLine($"The resulting number {result} is more than 20");
                    break;
            }
        }


    }
}