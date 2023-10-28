// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aralarında boşluk bırakarak 67'den büyük veya küçük olacak şekilde sayıları girin : ");

        string inputs = Console.ReadLine();

        string[] arrInpusts = inputs.Split(' ');
        int[] arrNumbers = new int[arrInpusts.Length];

        int diff = 0;
        double absolute = 0;

        for (int i = 0; i < arrInpusts.Length ; i++)
        {
            int current = int.Parse(arrInpusts[i]);

            arrNumbers[i] = current;

            if (arrNumbers[i] < 67 )
            {
                diff += 67 - arrNumbers[i];
            }
            else if (arrNumbers[i] >= 67)
            {

                absolute += Math.Pow(Convert.ToDouble(arrNumbers[i] - 67), 2);

            }

        }

        Console.WriteLine($"Farkların toplamı: + {diff}");
        Console.Write($"Farkların mutlak karelerinin toplamı: + {absolute}");


        Console.ReadLine();

    }
}