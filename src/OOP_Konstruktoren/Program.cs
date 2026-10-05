// ------------------------------
// OOP_Konstruktoren
// ------------------------------


/* Schreibe einen Konstruktor zum Setzen der Felder der Klasse Schule.

Ergänze dann einen parameterlosen Konstruktor, der die Felder auf fixe Werte setzt.*/



 using System.Runtime.Intrinsics.Arm;
 using System.Security.Cryptography.X509Certificates;



namespace OOP_Konstruktoren;


class Schule
{
    public string name;
    public string Ort;
    public int anzschüler;

    public Schule() : this("HTL" , "Braunau" , 670)
    {
        
    }



    public Schule(string name , string Ort , int anzschüler){  // -> Konstrukt 
        
        this.name = name;
        this.Ort = Ort;
        this.anzschüler = anzschüler;


    }

    

   

}


class Program
{
    static void Main(string[] args)
    {
       Schule s1 = new Schule();

       Console.WriteLine($"Daten der Schule: Name : {s1.name} , Ort: {s1.Ort} , Anzahl Schüler: {s1.anzschüler}");
    
    }
}



/* Ändere die Implementierung der Konstruktoren in der Klasse Schule auf Konstruktorverkettung. Im
parameterlosen Konstruktor soll nicht direkt auf die Felder zugegriffen werden, sondern der andere
Konstruktor aufgerufen werden. */



