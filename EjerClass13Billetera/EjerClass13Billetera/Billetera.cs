using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClass13Billetera
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            var suma = BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50 + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500 + BilletesDe1000 * 1000;
            return suma;
        }
        public string Detalle()
        {
            return $"Billete de 10: {BilletesDe10}\n" +
                $"Billetes de 20: {BilletesDe20}\n" +
                $"Billetes de 50: {BilletesDe50}\n" +
                $"Billetes de 100: {BilletesDe100}\n" +
                $"Billetes de 200: {BilletesDe200}\n" +
                $"Billetes de 500: {BilletesDe500}\n" +
                $"Billetes de 1000: {BilletesDe1000}\n";
        }
        public Billetera Combinar(Billetera billeteraNumber2)
        {
            int SumaDe10 = BilletesDe10 + billeteraNumber2.BilletesDe10;
            int SumaDe20 = BilletesDe20 + billeteraNumber2.BilletesDe20;
            int SumaDe50 = BilletesDe50 + billeteraNumber2.BilletesDe50;
            int SumaDe100 = BilletesDe100 + billeteraNumber2.BilletesDe100;
            int SumaDe200 = BilletesDe200 + billeteraNumber2.BilletesDe200;
            int SumaDe500 = BilletesDe500 + billeteraNumber2.BilletesDe500;
            int SumaDe1000 = BilletesDe1000 + billeteraNumber2.BilletesDe1000;

            Billetera nuevaBilletera = new Billetera();
            nuevaBilletera.BilletesDe10 = SumaDe10;
            nuevaBilletera.BilletesDe20 = SumaDe20;
            nuevaBilletera.BilletesDe50 = SumaDe50;
            nuevaBilletera.BilletesDe100 = SumaDe100;
            nuevaBilletera.BilletesDe200 = SumaDe200;
            nuevaBilletera.BilletesDe500 = SumaDe500;
            nuevaBilletera.BilletesDe1000 = SumaDe1000;

            return nuevaBilletera;
        }
    }
}
