using NewHomeWork.Models;
using System;

namespace NewHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cashRegister = new CashRegister(1000);
            cashRegister.AddNewSale(100, Currency.Azn, PaymentType.Kart);
            Console.WriteLine(cashRegister.TotalAmount);
            cashRegister.AddNewSale(42, Currency.Azn, PaymentType.Nagd);
            Console.WriteLine(cashRegister.TotalAmount);
            cashRegister.AddNewSale(37, Currency.Sterling, PaymentType.Kart);
            Console.WriteLine(cashRegister.TotalAmount);
            cashRegister.AddNewSale(100, Currency.Dollar, PaymentType.Nagd);
            Console.WriteLine(cashRegister.TotalAmount);
            cashRegister.AddNewSale(200, Currency.Azn, PaymentType.Kart);
            Console.WriteLine(cashRegister.TotalAmount);
            Console.Write("Satislar silindikden sonra son netice:");
            cashRegister.RemoveSale(100, Currency.Azn);
            Console.WriteLine(cashRegister.TotalAmount);
            Console.Write("Emeliyyatlarin sayi:");
            Console.WriteLine(cashRegister.TotalSalesCount);
        }
    }
}
