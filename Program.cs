RekeningBank newRekening = new RekeningBank("12341234");

string pilihan;
double jumlah;

while (true)
{
    Console.Clear();

    Console.WriteLine("Selamat datang di ATM Evann");
    Console.WriteLine("1. Display info rekening");
    Console.WriteLine("2. Setor uang");
    Console.WriteLine("3. Tarik Uang");
    Console.WriteLine("4. Keluar");
    Console.WriteLine("pilihan anda: ");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        newRekening.Displayinfo();

    }
    else if (pilihan == "2")
    {
        Console.Write("\nMasukkan jumlah uang: Rp ");
        jumlah = double.Parse(Console.ReadLine());

        newRekening.SetorUang(jumlah);
    }
    else if(pilihan == "3")
    {
        Console.WriteLine("\nMasukan jumlah uang: Rp ");
        jumlah = double.Parse(Console.ReadLine());

        newRekening.TarikUang(jumlah);
    }
    else if (pilihan == "4")
    {
        Console.WriteLine("\nTerimkasih telah menggunakan layanan ATM Evann");
        break;
    }
    else
    {
        Console.WriteLine("pilihan anda tidak valid");
    }

    Console.ReadLine();
}



public class RekeningBank
{
    private double _saldo;
    private string _noRekening;

    public double Saldo
    {
        get { return _saldo; }
        set
        {
            if (value <= 0) _saldo = value;
            else Console.WriteLine("Saldo tidak boleh Negatif");
        }
    }
    public string NoRekening
    {
        get { return _noRekening; }
    }

    public RekeningBank(string norekenig)
    {
        _saldo = 100000;
        _noRekening = norekenig;
    }
    public void TarikUang(double jumlah)
    {
        if (jumlah > 0)
        {
            if (Saldo >= jumlah)
            {
                Saldo -= jumlah;
                Console.WriteLine("Berhasil tarik uang");
            }
            else
            {
                Console.WriteLine("Saldo tidak mencukupi");
            }

        }
        else
        {
            Console.WriteLine("jumlah uang tidak valid");
        }
        
    }
    public void SetorUang(double jumlah)
    {
        if(jumlah > 0)
        {
            Saldo += jumlah;
            Console.WriteLine("berhasil setor uang");
        }
        else
        {
            Console.WriteLine("jumlah uang tidak valid");
        }
    }

    public void Displayinfo()
    {
        Console.WriteLine("\nDisplay info Rekening");
        Console.WriteLine($"No . Rekening: {NoRekening}");
        Console.WriteLine($"Saldo saat ini: Rp {Saldo}");
    }
}


