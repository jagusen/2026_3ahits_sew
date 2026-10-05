// ------------------------------
// Uebung_2_2
// ------------------------------

/* Eine Klasse Rechteck mit den Seiten a und b und einem Konstruktor, mit dem alle Felder
gesetzt werden können. Die Seitenlängen können Kommazahlen sein.
. Ausgabe von a und b (dafür ToString implementieren)
· Definiere einen parameterlosen Konstruktor, der a auf 10 und b auf 20 setzt. Verwende dafür
Konstruktorverkettung.
. Implementiere eine Methode Resize : Die kleinere Seite wird von der größeren abgezogen. D.h.
a oder b andert sich.
. Erstelle eine Methode Inflate - Parameter ist ein Prozentwert, um den beide Seiten vergrößert
werden sollen.
. Eine Methode AspectRatio, die das Seitenverhaltnis (simple Division a/b ) als double -Wert
ermittelt und zurückgibt ( return -Wert).
. Eine Methode SetMaxSide, der als Parameter eine neue Seitenlänge übergeben wird. Die längste
der bestehenden Seitenlängen soll auf diesen Wert gesetzt werden. Die andere Seitenlänge soll
so gesetzt werden, dass das ursprüngliche Seitenverhältnis beibehalten wird.

Anwendung: Bilder sollen in vorgegebene Quadrate eingepasst werden. Je nachdem, ob das Bild
Hoch- oder Querformat ist, wird die vertikale oder die horizontale Seitenkante auf die
Seitenlänge des Quadrats gesetzt. In der Regel mochte man weiters, dass das Seitenverhältnis
beibehalten wird und keine Verzerrung auftritt.

· Eine Methode Area soll die Fläche berechnen und zurückgeben.
. Die Methode int Tile(Rechteck r) soll die Frage beantworten, */


using System.Linq.Expressions;
using System.Security.Principal;

namespace Uebung_2_2;


class Rechteck
{
    
    public double a;
    public double b;

    public Rechteck() : this(10.0 , 30.0)
    {
        
    }

    public Rechteck(double a , double b)
    {
        this.a=a;
        this.b=b;
    }

    public void resize()
    {
        
     if (this.a>this.b)
        {
            this.a = this.a - this.b;

        }   

        else if(this.b>this.a)
        {
            this.b = this.b - this.a;
        }


    }

    public void Inflate(double p)
    {
        
        this.a = (this.a * (1+ (p/100)));
        this.b = (this.b * (1+ (p/100)));
     


    }

    public double AspectRatio()
    {
        
    double s_Verhältnis = 0;

    s_Verhältnis = this.a / this.b;
    

    return s_Verhältnis;


    }

    public void SetMaxSide(double length)
    {
        
    if(this.a > this.b)
        {
            this.a = length;
        }
    else
        {
            this.b = length;
        }



    }

    public override string ToString()
    {
        string txt = "Seite a: " + a;
        txt += " Seite b: " + b;

        return txt;
    }


}

class Program
{
    static void Main(string[] args)
    {
        Rechteck r1 = new Rechteck();

        r1.resize();
        r1.Inflate(3);
       // double f = r1.AspectRatio();
      //Console.WriteLine($"Verhältnis: {f}");
        Console.WriteLine(r1.ToString());
    }
}
