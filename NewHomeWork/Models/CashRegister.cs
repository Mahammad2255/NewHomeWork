using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork.Models
{
    class CashRegister
    {
        public double TotalAmount { get; set; }
        public Currency Currency { get; set; }
        public int TotalSalesCount;
        public PaymentType PaymentType { get; set; }
        public CashRegister(double totalamount)
        {

            TotalAmount = totalamount;

        }
        public void AddNewSale(double value, Currency currency, PaymentType paymentType)
        {
            TotalSalesCount++;
            switch (PaymentType)
            {
                case PaymentType.Kart:
                    Console.WriteLine("Kartla odenis olundu");
                    break;
                case PaymentType.Nagd:
                    Console.WriteLine("Nagd odenis olundu");
                    break;
                default:
                    break;
            }
            switch (Currency)
            {
                case Currency.Azn:
                    TotalAmount += value;
                    break;
                case Currency.Sterling:
                    TotalAmount += value * 2;
                    break;
                case Currency.Dollar:
                    TotalAmount += value * 1.7;
                    break;
                default:

                    break;
            }
        }
        public void RemoveSale(double value, Currency currency)
        {



            switch (Currency)
            {
                case Currency.Azn:
                    TotalAmount -= value;
                    break;
                case Currency.Sterling:
                    TotalAmount -= value * 2;
                    break;
                case Currency.Dollar:
                    TotalAmount -= value * 1.7;
                    break;
                default:

                    break;
            }

        }

        public override string ToString()
        {
            return $" {TotalAmount}{TotalSalesCount}";

        }
    }
}