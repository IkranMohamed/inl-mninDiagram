
    //HUVUDKLASSEN
public class Elever
{
    //ATTRIBUTER AV KLASSEN ELEVER
    public string Namn;

    public int Kurser;

    public int Betyg;

    //METODER AV KLASSEN ELEVER
 
    public void VisaBetyg()
    {
        Console.WriteLine("Dessa Elever visar betyg");
    }


    public void SkickarLäxor()
    {
        Console.WriteLine("Dessa Elever SkickarLäxor");
    }



    public void VäljaKurs()
    {
        Console.WriteLine("Dessa Elever VäljerKurs");
    }

 
    public void AnmälaSig()
    {
        Console.WriteLine("Dessa Elever AnmälerSig");
    }

}

//Subklasser som ärver från Elever


public class Person : Elever
{
    // NEW ATTRIBUTES + ALL ATTRIBUTES FROM ELEVER
    public string Namn;
    public string EfterNamn;

    // NEW METHODS + ALL METHODS FROM ELEVER 
    public new void VisaBetyg()
    {
        Console.WriteLine("Elever Visar sina Betyg");
    }
}



