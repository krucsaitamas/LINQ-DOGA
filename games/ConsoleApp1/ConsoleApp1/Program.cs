#region
using ConsoleApp1;
using System.Reflection.Metadata;
List<Games> jatekok = [];

const string FilePath = "C:\\Users\\krucsai.tamas\\Desktop\\games\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\videogames.csv";
using StreamReader sr = new StreamReader(FilePath);
_ = sr.ReadLine();

while (!sr.EndOfStream)
{
    var tmp = sr.ReadLine().Split(',');
    jatekok.Add(new()
    //Cim,Mufaj,KiadasDatum,AktivJatekosok,Ertekeles
    {
        Cim = tmp[0],
        Mufaj = tmp[1],
        KiadasDatum = DateTime.Parse(tmp[2]),
        AktivJatekosok = int.Parse(tmp[3]),
        Ertekeles = float.Parse(tmp[4].Replace('.', ','))
    });
}

#endregion






//- [ ] **3.** Van-e egyáltalán olyan játék a listában, amit 2020. január 1. előtt adtak ki?
//- [ ] **7.** Melyik a 3 legjobbra értékelt játék a teljes listában?
//- [ ] **8.** Mennyi az átlagos aktív játékosszám azokban a játékokban, amelyeket 2022-ben vagy azután adtak ki?
//- [ ] **9.** Csoportosítsd a játékokat műfaj szerint, és add meg, hogy az egyes műfajokban hány darab játék található!
//- [ ] **10.** Csoportosítsd a játékokat műfaj szerint, majd minden műfajból válaszd ki azt az EGY játékot, amelyik a legmagasabb értékeléssel rendelkezik!

//1. Feladat
var ertekelesek = jatekok.Count(p => p.Ertekeles > 4.5);
Console.WriteLine($"Ennyi játéknak nagyobb az értékelése mint 4,5: {ertekelesek}");

//2. Feladat
var legtobbJatekos = jatekok.MaxBy(p => p.AktivJatekosok);
Console.WriteLine($"\nEzzel a játékkal játszanak a legtöbben: \n{legtobbJatekos}");

//3. Feladat


//4. Feladat
var ertekAtlag = jatekok.Sum(p => p.Ertekeles);
Console.WriteLine($"\nAz értékelések átlaga: {(ertekAtlag) / 15}");

//5. Feladat
var cyberCity = jatekok.Single(p => p.Cim == "Cyber City 2077");
Console.WriteLine($"\nA játék aminek a neve pontosan Cyber City 2077:\n{cyberCity}");

//6. Feladat
var rpg = jatekok.FindAll(p => p.Mufaj == "RPG");
Console.WriteLine("Ezek a játékok RPG-k:\n");
for (int i = 0; i < rpg.Count; i++)
{
    Console.WriteLine($"\n{rpg[i]}");
}

//7. Feladat

//8. Feladat

//9. Feladat

//10. Feladat