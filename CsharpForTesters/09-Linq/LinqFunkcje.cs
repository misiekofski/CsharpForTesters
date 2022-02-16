﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._09_Linq
{
    public class LinqFunkcje
    {
        public static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bartosz Walaszek", OrdersQuantity=40, TotalPurchasesAmount=8345.66, Bank="MIL"},
                new Customer(){ Name="Janina Daily", OrdersQuantity=32, TotalPurchasesAmount=4756.21, Bank="MIL"},
                new Customer(){ Name="Gosia Piosenkarka", OrdersQuantity=21, TotalPurchasesAmount=7233.01, Bank="ING"},
                new Customer(){ Name="Kuba Jakubowski", OrdersQuantity=12, TotalPurchasesAmount=1449.92, Bank="ING"},
                new Customer(){ Name="Andrzej Jakmunaimie", OrdersQuantity=19, TotalPurchasesAmount=7872.12, Bank="MIL"},
                new Customer(){ Name="Paulina Paulaner", OrdersQuantity=1, TotalPurchasesAmount=8372.54, Bank="PKO"},
                new Customer(){ Name="Michał Pijanowski", OrdersQuantity=30, TotalPurchasesAmount=436.39, Bank="PKO"},
                new Customer(){ Name="Krzysiek Pijanowski", OrdersQuantity=4, TotalPurchasesAmount=56389.85, Bank="MIL"},
                new Customer(){ Name="Zosia Feyman", OrdersQuantity=17, TotalPurchasesAmount=1000.00, Bank="CITI"},
                new Customer(){ Name="Grzegorz Kowalski", OrdersQuantity=22, TotalPurchasesAmount=9582.68, Bank="CITI"}
            };

            // znajdź największą liczbę zamówień przy pomocy Linq

            // wydrukuj sumę zakupów przy pomocy linq

            // ile mamy elementów w tablicy z banku PKO (użyj linq)

        }

    }
}