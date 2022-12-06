using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpShop3.CustomException;

namespace CSharpShop3
{
    public class Acqua : Prodotto
    {
        // CARATTERISTICHE

        private double litri;
        private double pH;
        private string sorgente;
        private double maxCapienza;

        // COSTRUTTORE

        public Acqua(string nome, string descrizione, float prezzo, int iva, double litri, double pH, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.pH = Math.Round(pH, 2);
            this.sorgente = sorgente;
            this.maxCapienza = 1.5;
        }

        // GETTERS

        public double GetLitri()
        {
            return this.litri;
        }
        public double GetPH()
        {
            return this.pH;
        }
        public string GetSorgente()
        {
            return this.sorgente;
        }

        // SETTERS
        public void SetLitri(double litri)
        {
            this.litri = litri;
        }
        public void SetPH(double pH)
        {
            this.pH = pH;
        }
        public void SetSorgente(string sorgente)
        {
            this.sorgente = sorgente;
        }

        // METODO

        public double BeviAcqua(double litriDaBere)
        {
            if (litriDaBere <= this.litri)
            {
                this.litri = this.litri - litriDaBere;
                if (this.litri == 0)
                {
                    Console.WriteLine("Hai finito l'acqua.");
                }

            }
            else
            {
                throw new ResultCannotBeNegativeException("Non puoi bere acqua che non c'è.");
            }

            return this.litri;
        }

        public void RiempiBottiglia(float litriDaRiempire)
        {
            if (litriDaRiempire < 0)
            {
                throw new ResultCannotBeNegativeException("Non puoi riempire negativamente la bottiglia.");
            }

            if (this.maxCapienza - this.litri >= litriDaRiempire) // litriDaRiempiere <= this.maxCapienza - this.litri 
            {
                this.litri += Math.Round(litriDaRiempire, 2);
            }
            else
            {
                // Exception "Hai superato la capienza massima della bottiglia

                Console.WriteLine("La bottiglia è stata riempita al massimo.");
                this.litri = this.maxCapienza;
            }
             
        }

        public void SvuotaBottiglia()
        {
            this.litri = 0;
        }

        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine();
            Console.WriteLine("Dati acqua:");
            Console.WriteLine();
            Console.WriteLine("Litri: " + GetLitri());
            Console.WriteLine("pH: " + GetPH());
            Console.WriteLine("Sorgente: " + GetSorgente());
            Console.WriteLine();

        }


    }
}
