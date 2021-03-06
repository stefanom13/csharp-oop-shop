//Esercizio di oggi: C# Shop nome repo: csharp-oop-shop
//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
//Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva Usate
//opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso,
//ottenuto concatenando codice + nome Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)

using Csharp_Shop;

Console.WriteLine("Inserisci nome prodotto");
string nome = Console.ReadLine();
Console.WriteLine("Inserisci descrizione prodotto");
string descrizione = Console.ReadLine();
Console.WriteLine("Inserisci prezzo prodotto");
double prezzo = double.Parse(Console.ReadLine());

//creazione istanza prodotto

Prodotto prodotto = new Prodotto(nome, descrizione, prezzo);

//stampare
prodotto.Print();

//metodo per avere il nome esteso
Console.WriteLine("Nome esteso: " + prodotto.GetNomeEsteso());
//metodo prezzo comprensivo di iva
Console.WriteLine("Prezzo con iva: " + prodotto.GetTassaPrezzoStringa());

//metodo codice 8 caratteri
Console.WriteLine("Codice di otto caratteri: " + prodotto.GetPadLeftCodice());

