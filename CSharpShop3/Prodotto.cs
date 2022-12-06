using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpShop3.CustomException;

namespace CSharpShop3
{
    public class Prodotto
    {
        // CARATTERISTICHE

        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private int iva;

        // COSTRUTTORI

        public Prodotto(string nome, string descrizione, float prezzo, int iva)
        {
            this.codice = CodiceRandom();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        // GETTERS

        public int GetCodice()
        {
            return this.codice;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public string GetDescrizione()
        {
            return this.descrizione;
        }
        public double GetPrezzo()
        {
            return this.prezzo;
        }
        public int GetIVA()
        {
            return this.iva;
        }

        // SETTERS

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }
        public void SetPrezo(double prezo)
        {
            this.prezzo = prezo;
        }
        public void SetIVA(int iva)
        {
            this.iva = iva;
        }

        //METODO

        private int CodiceRandom()
        {
            Random random = new Random();
            int codiceRandom = random.Next(99999999 + 1);
            return codiceRandom;
        }

        public virtual void Stampa()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Codice: \t" + GetCodice());
            Console.WriteLine("Nome: \t\t" + GetNome());
            Console.WriteLine("Descrizione: \t" + GetDescrizione());
            Console.WriteLine("Prezzo: \t" + PrezzoIVA());
            Console.WriteLine("di cui IVA: \t" + GetIVA() + "%");
            Console.WriteLine("Nome Esteso: \t" + CodiceNome());
            Console.WriteLine("----------------------------------------------------");
        }

        public string PrezzoBase()
        {
            string prezzoBase;
            prezzoBase = (this.prezzo).ToString();
            prezzoBase += " Euro";
            return prezzoBase;
        }

        public string PrezzoIVA()
        {
            string prezzoIVA;
            double prezzo = Math.Round((this.prezzo + (this.prezzo * this.iva / 100)), 2);
            prezzoIVA = prezzo.ToString();
            prezzoIVA += " Euro";
            return prezzoIVA;
        }

        public string CodiceNome()
        {
            string codiceNome;
            codiceNome = this.codice.ToString();
            codiceNome += this.nome;
            return codiceNome;
        }
    }
}
