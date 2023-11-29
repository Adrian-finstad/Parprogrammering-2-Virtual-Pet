// See https://aka.ms/new-console-template for more information
//Lag en konsoll-applikasjon hvor man kan generere opp flere forskjellige
//virtuelle kjæledyr.
//Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn,
//age eller noen andre egenskaper utenfra klassen. Lag funksjonalitet som gjør
//at man kan gi dyret mat, kose med dyret eller sjekke om dyret må på do
//Her er et eksempel på hvordan det kan se ut:
//Hvilket dyr vil du ta vare på? 
//Pikachu
//1. Gi Pikachu mat
//2. Kos med Pikachu
//3. Sjekk om Pikachu må på do
//2
//Pikachu smiler!
//1. Gi Pikachu mat
//2. Kos med Pikachu
//3. Sjekk om Pikachu må på do
//1
//Pikachu er mett og fornøyd

using Parprogrammering_2_Virtual_Pet;

 void Main()
{
    var Pikachu = new Pets("Pokemon", "Yellow", "Pikachu", "Pokeballs", 7, false, true, true);
    var Sonic = new Pets("Pinnsvin", "Blue", "Sonic", "Gullringer", 12, true, false, false);
    var Fleksnes = new Pets("Katt", "Grå", "Marve Fleksnes", "Alt", 8, true, true, true);


    Console.WriteLine("Hei, og velkommen til ditt virtuelle kjæledyr!");
    Console.WriteLine("Klikk [1] for å generere Pikachu. Klikk [2] for å generere Sonic. Eller klikk [3] for å generere fleksnes.");
    var userInput = Console.ReadLine();

    if (userInput == "1")
    {
        Pikachu.printInfo();
        Console.WriteLine("Hva ønsker du å gjøre med Pikachu? Trykk 1 for å mate (hvis han er sulten), 2 for å kose, eller 3 for å ta han med på do.");
        var valg1 = Console.ReadLine();
        if(valg1 == "1")
        {
            Pikachu.feedPet();
        }
        else if (valg1 == "2")
        {
            Pikachu.cuddlePet();
        }
        else if (valg1 == "3")
        {
            Pikachu.needBathroom();
        }
        else
        {
            Main();
        }
    }
    else if (userInput == "2")
    {
        Sonic.printInfo();
        Console.WriteLine("Hva ønsker du å gjøre med Sonic? Trykk 1 for å mate (hvis han er sulten), 2 for å kose, eller 3 for å ta han med på do.");
        var valg1 = Console.ReadLine();
        if (valg1 == "1")
        {
            Sonic.feedPet();
        }
        else if (valg1 == "2")
        {
            Sonic.cuddlePet();
        }
        else if (valg1 == "3")
        {
            Sonic.needBathroom();
        }
        else
        {
            Main();
        }
    }
    else if (userInput == "3")
    {
        Fleksnes.printInfo();
        Console.WriteLine("Hva ønsker du å gjøre med Fleksnes? Trykk 1 for å mate (hvis han er sulten), 2 for å kose, eller 3 for å ta han med på do.");
        var valg1 = Console.ReadLine();
        if (valg1 == "1")
        {
            Fleksnes.feedPet();
        }
        else if (valg1 == "2")
        {
            Fleksnes.cuddlePet();
        }
        else if (valg1 == "3")
        {
            Fleksnes.needBathroom();
        }
        else
        {
            Main();
        }
    }
    else { Main(); }
}

Main();


 