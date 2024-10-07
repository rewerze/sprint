using Sprint_Verseny;
using System.Text;


List<Versenyzo> versenyzo = [];

StreamReader sr = new StreamReader("forras.txt", Encoding.UTF8);
while (!sr.EndOfStream) versenyzo.Add(new(sr.ReadLine()));
sr.Close();



// írd ki a konzolra, hogy hány versenyző fejezte be a versenyt
Console.WriteLine("Darab feladat:");
Console.WriteLine($"{versenyzo.Count()} db versenyző fejezte be a versenyt");

// versenyzők száma 'elit' kategóriában
var elitSzam = versenyzo
    .FindAll(v => v.Kategoria == "elit junior")
    .Count();
Console.WriteLine($"Elitek száma: {elitSzam}");

// női versenyzők átlagéletkora
var nokAtlagEletkora = versenyzo
    .FindAll(v => v.Nem == "n")
    .Average(v => DateTime.Now.Year - v.SzulEv);

Console.WriteLine($"Nők átlag életkora: {nokAtlagEletkora}");


// a versenyzők kerékpározással töltött összideje órában. 2tj-ig kerekítve


// átlagos úszási idő elit junior kategóriában
var atlagUszIdo = versenyzo
    .FindAll(v => v.Kategoria == "elit junior")
    .Average(v => v.Uszas.Minute);

Console.WriteLine($"Az elit junior versenyzők átlag úszási ideje: {atlagUszIdo} perc");


// férfi győztes (legrövidebb összidő)



// korkategóriánként a versenyt befejezők száma
var kategoriankent = versenyzo
    .GroupBy(v => v.Kategoria);
foreach (var group in kategoriankent
    .OrderBy(g => g.Key))
{
    Console.WriteLine($"{group.Key}");
    foreach (var befejezo in group)
    {
        Console.WriteLine($"\t[{versenyzo.IndexOf(befejezo):00}] {befejezo}");
    }
}


// korkategóriánként az átlag depóban töltött idő