using Kassa_Task.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassa_Task.Models
{
    class CashRegister
    {
        public double TotalAmount { get; set; }
        public string PaymentType { get; set; }
        public Currency Currency { get; set; }
        public static int TotalSalesCount = 0;

        public CashRegister(double totalamount, Currency currency)
        {
            Currency = currency;
            TotalAmount = totalamount;
        }
        
        public void AddNewSales(double amount, Currency currency)
        {
            if (currency==Currency)
            {
                TotalAmount += amount;
            }
            else
            {
                switch (currency)
                {
                    case Currency.Azn:
                        TotalAmount += amount /= 2;
                        break;
                    case Currency.Euro:
                        TotalAmount += amount *= 2;
                        break;
                }
            }
            
            TotalSalesCount++;
        }
        public void RemoveSales(double amount1, Currency currency1)
        {
            if (currency1 == Currency)
            {
                TotalAmount -= amount1;
            }
            else
            {
                switch (currency1)
                {
                    case Currency.Azn:
                        TotalAmount -= amount1 / 1.7;
                        break;
                    case Currency.Euro:
                        TotalAmount -= amount1 * 1.70;
                        break;
                }
            }
            
            TotalSalesCount--;
        }
        public override string ToString()
        {
            return $"Kassadaki Mebleg: {TotalAmount}\nValyuta: {Currency}\nOdenis Novu: {PaymentType}\nUmumi Satis Sayi: {TotalSalesCount}";
        }
    }
}
