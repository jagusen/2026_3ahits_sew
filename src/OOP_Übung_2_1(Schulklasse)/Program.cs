// ------------------------------
// Uebung_2_1
// ------------------------------



/* Erstelle eine Klasse Schulklasse mit Feldern fur die Anzahl der Schuler und den Namen des
Klassenvorstands. Erstelle einen Konstruktor, mit dem alle Felder gesetzt werden können.
Implementiere eine ToString -Methode zur Ausgabe aller Werte der Felder.

Teste, indem du 2 Objekte in der Main -Methode instanziierst.

Weiters:

· Erstelle einen parameterlosen Konstruktor und setze die Felder entsprechend deiner
Schulklasse. Verwende dafür Konstruktorverkettung, wenn schon bekannt.
. Implementiere eine Methode Dazu, die zur Anzahl der Schüler eins dazuzählt. Verfahre ähnlich
mit einer Methode Raus, an diese kann aber per Parameter die Anzahl der zu "entfernenden"
Schüler übergeben werden.
. Schreibe eine Methode KlassenwechselNach zum Ummelden eines Schulers von einer Schulklasse
in eine andere. Dabei wird von der Anzahl der Schüler in einem Schulklasse -Objekt eins
abgezogen und einem anderen Schulklasse -Objekt zur Anzahl der Schüler eins hinzugezählt.
Dieser Vorgang soll durch einen einzigen Methodenaufruf geschehen, damit kein Schüler
verloren geht. Hinweis: Als Parameter die Referenz auf die zweite Schulklasse übergeben (der
Schüler wechselt in diese zweite Schulklasse). */




using System.Security.Principal;

namespace Uebung_2_1;

class Schulklasse
{
    
public int anzschüler;
public string name;



 
public Schulklasse() : this(22 , "Herr Strasser")
    {
        
    }


    public Schulklasse(int anzschüler , string name){

this.anzschüler = anzschüler;
this.name = name; 

}

  public void dazu()
    {
        anzschüler = anzschüler +1;
        
    }

    public void raus(int anzahl)
    {
        
    anzschüler = anzschüler - anzahl;


    }

    public void dazurechnen(Schulklasse s2)
    {
        this.anzschüler--;
        s2.anzschüler++;

    }

    
    public override string ToString()
    {
        string txt = "Die 3AHITS hat " + anzschüler + " Schüler. ";
        txt += "Klassenvorstand ist " + name;
        return txt;
    }

   
}
 








class Program
{
    static void Main(string[] args)
    {
        Schulklasse s1 = new Schulklasse();
        Schulklasse s2 = new Schulklasse();
       
/*        s1.dazu();

        Console.WriteLine(s1.ToString());

        s1.raus(3);
        Console.WriteLine(s1.ToString());
*/
        s1.dazurechnen(s2);
        Console.WriteLine(s1.ToString());
        Console.WriteLine(s2.ToString());

   

    
   
    }
}
