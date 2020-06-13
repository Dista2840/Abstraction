﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class PersegiPanjang : BangunDatar
    {
        public int p,l;

        public override void Luas()
        {
            Console.Write("Masukkan nilai panjang    = ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai lebar      = ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas Persegi Panjang      = " + (p * l));
        }

        public override void Keliling()
        {
            Console.WriteLine("Keliling Persegi Panjang  = " + (2 * (p + l)));
        }
    }
}
