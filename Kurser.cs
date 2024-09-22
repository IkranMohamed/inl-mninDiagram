
    //HUVUDKLASSEN
public class KURSER
{
    //ATTRIBUTER AV KLASSEN KURSER
    public string Namn;

    //METODER AV KLASSEN KURSER
    public void Undervisa()
    {
        Console.WriteLine("Kurser undervisas");
    }

}
//Subklasser som ärver från KURSER
public class Elev : KURSER
{
    // NEW ATTRIBUTES + ALL ATTRIBUTES FROM KURSER
    public string Namn;

    // NEW METHODS + ALL METHODS FROM KURSER 
    public new void Undervisa()
    {
        Console.WriteLine("Kurser hålls under undervisning");
    }
}
