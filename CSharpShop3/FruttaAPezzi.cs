using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpShop3.CustomException;

namespace CSharpShop3
{
    public class FruttaAPezzi : Prodotto
    {
        // CARATTERISTICHE
        private string tipoFrutto;
        private uint quantita;

        // STATO
        private bool secca;

        // COSTRUTTORE
        public FruttaAPezzi(string nome, string tipoFrutto, string descrizione, float prezzo, int iva, bool secca = false) : base(nome, descrizione, prezzo, iva)
        {
            this.tipoFrutto = tipoFrutto;
            this.quantita = 5;
            this.secca = secca;
        }

        // GETTERS

        public string GetTipoFrutto()
        {
            return this.tipoFrutto;
        }
        public uint GetQuantita()
        {
            return this.quantita;
        }
        public bool GetSecca()
        {
            return this.secca;
        }

        // SETTERS

        public void SetTipoFrutto(string tipoFrutto)
        {
            this.tipoFrutto = tipoFrutto;
        }
        public void SetQuantita(uint quantita)
        {
            this.quantita = quantita;
        }
        public void SetSecca(bool secca)
        {
            this.secca = secca;
        }

        // METODO

        public uint MangiaFrutta(uint pezziDaMangiare)
        {
            if (pezziDaMangiare <= this.quantita)
            {
                if (this.quantita > pezziDaMangiare)
                {
                    this.quantita = this.quantita - pezziDaMangiare;
                }
                else
                {
                    this.quantita = 0;
                    Console.WriteLine("Hai finito la frutta.");
                }
            }
            else
            {
                Console.WriteLine("Non puoi mangiare frutta che non c'è.");
            }

            return this.quantita;
        }

        public void RiempiSacchetto(uint fruttaDaInserire)
        {
            this.quantita += fruttaDaInserire;
        }

        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine();
            Console.WriteLine("Dati frutta:");
            Console.WriteLine();
            Console.WriteLine("Tipo Frutta: " + GetTipoFrutto());
            Console.WriteLine("Quantità: " + GetQuantita());
            Console.WriteLine("Secca? " + GetSecca());
            Console.WriteLine();

        }
    }
}
