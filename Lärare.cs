
    //HUVUDKLASSEN
public class LÄRARE
{
    //ATTRIBUTER AV KLASSEN LÄRARE
    public string Namn;

    public string Kurser;

    //METODER AV KLASSEN LÄRARE
    public void Undervisa()
    {
        Console.WriteLine("En lärare undervisar");
    }

}
//Subklasser som ärver från Lärare
public class Skola : Lärare 
{
    // NEW ATTRIBUTES + ALL ATTRIBUTES FROM ELEVER
    public string Elever;
    public string Lärare;
    public string Kurser;
    public string Adress;
    public string Namn;

    // NEW METHODS + ALL METHODS FROM ELEVER 
    public new void Undervisa()
    {
        Console.WriteLine("En lärare undervisar i en skola");
    }
}
