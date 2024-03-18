// See https://aka.ms/new-console-template for more information

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
    public static void Main(string[] args)
    {
        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(13.0);
        data.AddNewData(02.0);
        data.AddNewData(22.0);

        data.printAllData();
    }
    
}