// See https://aka.ms/new-console-template for more information

public class Penjumlahan<T>
{
    
    //method
    public void doSum<T>(List<T> input)
    {
        dynamic sum = 0.0;
        for (int i = 0; i < input.Count; i++)
        {
            sum = sum + input[i];
        }
        Console.WriteLine("hasil sum = " + sum);
    }

   
}

class Program
{
    public static void Main(String[] args)
    {
        Penjumlahan<double> testing = new Penjumlahan<double>();
        List<double> input = new List<double>();
        input.Add(13.0);
        input.Add(2.0);
        input.Add(22.0);
        testing.doSum(input);
    }
}