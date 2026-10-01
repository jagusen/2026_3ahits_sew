// ------------------------------
// OOP
// ------------------------------

using System.Net.WebSockets;

namespace OOP;


class Schule
{
   public string name; // member Variable oder Feld
   public int anzahlschüler; 
   public int anzahlLehrer; 

   // non static methode 
   public int AnzahlPersonen()
    {
        return anzahlLehrer+anzahlschüler;
    }

    // ToString() Methode 

    public override string ToString()
    {
        return $"schule:{name} , schüler:{anzahlschüler} , Lehrer:{anzahlLehrer}  ";
    }
}

class Program
{
    static void Main(string[] args)
    {
       Schule HTL = new Schule(); // Objekt erstellen (instanzieren)
       HTL.name = "HTL-Braunau";
       HTL.anzahlschüler=800;
       HTL.anzahlLehrer=100;
       // Aufruf der Methode AnzahlPersonen() für Objekt HTL

      Console.WriteLine($"Anzahl der Personen an HTL: {HTL.AnzahlPersonen()}"); 
      
      
      
       // HLW
       Schule HLW = new Schule();
       HLW.name ="HLW-Braunau";
       HLW.anzahlLehrer = 80;
       HLW.anzahlschüler=600;
      
      
      Console.WriteLine($"Anzahl der Personen an der HLW: {HLW.AnzahlPersonen()}");
       

       

       // -----------------------------------


       int n = 42;
       Console.WriteLine(n);
       Console.WriteLine(HTL); // automatisch 
       Console.WriteLine(HTL.ToString());


      

    }
}
