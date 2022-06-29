using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop
{
    internal class Prodotto
    {
        public int Codice { get; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        private double prezzo;
        private double iva;

        // get e set di prezzo e iva
        public double Prezzo
        {
            get { return prezzo; }
            set
            {
                prezzo = value;
                iva = prezzo * 0.21;
            }
        }

        public double Iva
        {
            get { return iva; }
        }

        //costruttore
        public Prodotto(string nome, string descrizione, double prezzo)
        {
            Codice = new Random().Next(1, 99999999);
            Nome = nome;
            Descrizione = descrizione;
            Prezzo  = prezzo;
        }

        //metodo per avere nome + codice
        public string GetNomeEsteso()
        {
            return $"{Codice} -- {Nome}";
        }

        //metodo per avere prezzo compreso di iva
        public double GetPrezzoIva()
        {
            return prezzo + iva;
        }

        public string GetPrezzoStringa()
        {
            return String.Format("{0:0.00}", prezzo) + "$"; // 
        }

        public string GetTassaPrezzoStringa()
        {
            return String.Format("{0:0.00}", GetPrezzoIva());
        }

        //metodo per astampare
        public void Print()
        {
            Console.WriteLine($"{GetNomeEsteso()}");
            Console.Write("Descrizione: ");
            Console.WriteLine(Descrizione);
            Console.WriteLine(GetPrezzoStringa);
            Console.Write("IVA: ");
            Console.WriteLine(iva);
        }
    }
}
