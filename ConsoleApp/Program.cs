﻿using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FIO fio = new FIO();
            fio.init("A", "Б", "В");
            Owner Alisher = new Owner();
            Alisher.init(fio, 0, 0);
            Alisher.enter();
            Alisher.print();

            //dd
        }
    }
}