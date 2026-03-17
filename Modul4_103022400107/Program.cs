
//public class KodePaket
//{
//    public string getKodePaket(string namaPaket)
//    {
//        switch (namaPaket)
//        {
//            case "Basic": return "P201";
//            case "Standard ": return "P202";
//            case "Premium ": return "P203";
//            case "Unlimited": return "P204";
//            case "Gaming": return "P205";
//            case "Streaming": return "P206";
//            case "Family": return "P207";
//            case "Business": return "P208";
//            case "Student": return "P209";
//            case "Traveler": return "P2010";
//            default: return "KodePaket tidak ada";
//        }
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        KodePaket objekPaket = new KodePaket();

//        Console.WriteLine("Masukkan nama paket: ");

//        string nama = Console.ReadLine();
//        string hasil = objekPaket.getKodePaket(nama);


//        Console.WriteLine("Nama Paket: " + nama);
//        Console.WriteLine("Kode Paket: " + hasil);
//    }
//}

public class MesinKopi
{
    public enum State { OFF, STANDBY, BREWING, MAINRENANCE };
    public State stateSekarang = State.OFF;
    public void PerubahanState(String command)
    {
        State stateAwal = stateSekarang;

        switch (stateSekarang)
        {
            case State.OFF:
                if (command == "POWER_OFF") stateSekarang = State.STANDBY;
                break;

            case State.STANDBY:
                if (command == "START_BREW") stateSekarang = State.BREWING;
                else if (command == "START_MAINTENANCE") stateSekarang = State.MAINRENANCE;
                else if (command == "POWER_OFF") stateSekarang = State.OFF;
                break;

            case State.BREWING:
                if (command == "FINISH_BREW") stateSekarang = State.STANDBY;
                break;

            case State.MAINRENANCE:
                if (command == "FINISH_MAINTENANCE") stateSekarang = State.STANDBY;
                break;
        }

        if (stateSekarang != stateAwal)
        {
            Console.WriteLine("Mesin " + stateAwal + "merubah " + stateSekarang);
        }
        else
        {
             Console.WriteLine("Perubahan state tidak valid");
        }
    }
}


    public class Program
    {
        public static void Main(string[] args)
        {
            MesinKopi mesin = new MesinKopi();

            mesin.inputCommand("POWER_ON");
            mesin.inputCommand("START_BREW");
            mesin.inputCommand("FINISH_BREW");
            mesin.inputCommand("START_MAINTENANCE");
            mesin.inputCommand("FINISH_MAINTENANCE");
            mesin.inputCommand("Power_OFF");
        }
    }
}