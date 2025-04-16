using System;
using System.Globalization;
using modul8_103022300052;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        BankTransferConvig bank = new BankTransferConvig();   
      if (bank.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer:");
        }
        else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");
        }
    }
}