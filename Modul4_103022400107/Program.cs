
public class KodePaket
{
    public string getKodePaket(string namaPaket)
    {
        switch (namaPaket)
        {
            case "Basic": return "P201";
            case "Standard ": return "P202";
            case "Premium ": return "P203";
            case "Unlimited": return "P204";
            case "Gaming": return "P205";
            case "Streaming": return "P206";
            case "Family": return "P207";
            case "Business": return "P208";
            case "Student": return "P209";
            case "Traveler": return "P2010";
            default: return "KodePaket tidak ada";
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        KodePaket objekPaket = new KodePaket();

        Console.WriteLine("Masukkan nama paket: ");
        
        string nama = Console.ReadLine();
        string hasil = objekPaket.getKodePaket(nama);


        Console.WriteLine("Nama Paket: " + nama);
        Console.WriteLine("Kode Paket: " + hasil);
    }
}