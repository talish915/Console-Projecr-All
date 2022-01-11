using Kassa_Task.Models;
using System;

namespace Kassa_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cashRegister = new CashRegister(0,Enums.Currency.Azn);
            cashRegister.AddNewSales(10, Enums.Currency.Azn);
            cashRegister.AddNewSales(10, Enums.Currency.Euro);
            cashRegister.RemoveSales(10, Enums.Currency.Euro);
            Console.WriteLine(cashRegister);
        }
    }
}
