
    //HUVUDKLASSEN
public class PERSON
{
    //ATTRIBUTER AV KLASSEN PERSON
    public string Namn;

    public string Efternamn;

    
    //METODER AV KLASSEN PERSON
    public void VisaNamn()
    {
        Console.WriteLine("Person har ett namn");
    }

    public void VisaEfternamn()
    {
        Console.WriteLine("Person har ett efternam");
    }

}
//Subklasser som ärver från PERSON
public class Staff : Person
{
    // NEW ATTRIBUTES + ALL ATTRIBUTES FROM PERSON
    public string Namn;
    public string EfterNamn;

    // NEW METHODS + ALL METHODS FROM PERSON
    public new void VisaNamn()
    {
        Console.WriteLine("Elever Visar sina Betyg");
    }
}


