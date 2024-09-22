
    //HUVUDKLASSEN
public class Betyg
{
    //ATTRIBUTER AV KLASSEN BETYG
    public string Värde;
    public string Kommentar;

    //METODER AV KLASSEN BETYG
    public void GeBetyg()
    {
        Console.WriteLine("Lärare ger Betyg");
    }

}
//Subklasser som ärver från Betyg
public class Lärare : Betyg
{
    // NEW ATTRIBUTES + ALL ATTRIBUTES FROM BETYG
    public string Namn;
    public string Kurser;

    // NEW METHODS + ALL METHODS FROM BETYG 
    public new void GeBetyg()
    {
        Console.WriteLine("Lärare ger betyg");
    }
}
