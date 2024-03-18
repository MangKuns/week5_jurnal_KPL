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
public class SimpleDataBase<T>
{
    List<T> StoreData;
    List<DateTime> inputDate;

    public SimpleDataBase()
    {
        StoreData = new List<T>();
        inputDate = new List<DateTime>();
    }

   public void AddNewData(T data)
    {
        StoreData.Add(data);
        inputDate.Add(DateTime.Now);
    }
    
    public void printAllData() 
    {
        for (int i = 0; i < StoreData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " Berisi: " + StoreData[i] + ", yang disimpan pada waktu " + inputDate[i]);
        }
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

        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(13.0);
        data.AddNewData(02.0);
        data.AddNewData(22.0);

        data.printAllData();
    }

}