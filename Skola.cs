
    //HUVUDKLASSEN
public class SKOLA
{
    //ATTRIBUTER AV KLASSEN SKOLA
    public string Namn;

    public string Kurser;

    public string Betyg;

    public string Adress;

    public string Elever;

    public string Lärare;

    //METODER AV KLASSEN SKOLA
    public void Regristrera()
    {
        Console.WriteLine("Skolan registrerar alla elever");
    }

    public void GeBetyg()
    {
        Console.WriteLine("Dessa Elever GeBetyg");
    }

}
//Subklasser som ärver från SKOLA
public class Personal : SKOLA
{
    // NEW ATTRIBUTES + ALL ATTRIBUTES FROM SKOLA
    public string Namn;
    public string EfterNamn;

    // NEW METHODS + ALL METHODS FROM SKOLA
    public new void Registrera()
    {
        Console.WriteLine("Skolan registrerar eleverna");
    }
}


