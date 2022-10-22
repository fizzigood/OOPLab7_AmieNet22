using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab7AmieNet22
{
    //Basklass Geometri:
   abstract class Geometri //Abstract basklass för att den inte innehåller egna värden, utan dessa sätts via derived/ärvda klasser vid exekvering.
   {
        protected double Area { get; set; } //protected property/egenskap pga endast access från basklass och derived klasser, eftersom värdet sätts där.
        public abstract double GetArea(); //Abstact metod som overridas med variabler i derivded klasser.
   }


    // Rektangelklass derived/ärvd från basklass:
   class Rektangel : Geometri  
   {
        // Rektangelns area = width * length, därför behövs två properties/egenskaper - Witdh och Lenght, utöver den ärvda - Area:
        double RWidth { get; set; }
        double RLength { get; set; }

        //Constructor för rektangel:
        public Rektangel(double width = 13, double rlength = 42) //Värdet av Egenskaperna/Properties sätts i constructorn:
        {
            this.RWidth = width;
            this.RLength = rlength;
        }
        public override double GetArea()       //Override av basklassens abstracta metod med värden från Rektangelnsn egenskaper/properties.
        {
            Area = RWidth*RLength;
            return Area;
        }
   }

    //Klassen Fyrkant derived/ärvd från basklass Geometri:
   class Fyrkant : Geometri
   {
        // Fyrkantens area = length * length, därför behövs bara en property/egenskap - Length, utöver den ärvda - Area:
        double FLength { get; set; }

        //Constructor för fyrkant:
        public Fyrkant(double flength = 42) //Värdet av Egenskapen/Property sätts i constructorn:
        {
            this.FLength = flength;
        }
        public override double GetArea()    //Override av basklassens abstracta metod med värden från Fyrkantens egenskaper/properties.
        {
            Area = FLength * FLength;
            return Area;
        }
   }
    //Klassen Cirkel derived/ ärvd från från basklass:
   class Cirkel : Geometri  
   {
        //Cirkelns area = pi * radius * radius, därför behövs två Properties/Egenskaper - Pi och Radius, utöver den ärvda - Area:
        double Pi { get; set; }
        double CRadius { get; set; }

        //Constructor för Cirkel:
        public Cirkel(double pi = Math.PI, double cradius = 42) //Värdet av Cirkelns Egenskaper/Properties sätts i constructorn:
        {
            this.Pi = pi;
            this.CRadius = cradius;
        }
        public override double GetArea() //Override av basklassens abstracta metod med värden från Cirkelns egenskaper/properties.
        {
            Area = Pi * CRadius * CRadius;
            return Area;
        }
   }

    //Klassen Parallellogram derived/ärvd från basklass:
   class Parallellogram : Geometri 
   {
        //Parallellogrammets area = base * height, därför behövs två egna properties/egenskaper, Base och Height utöver den ärvda:
        double PBase { get; set; }
        double PHeight { get; set; }

        //Constructor för Parallellogram:
        public Parallellogram(double pbase = 1701, double pheight = 1337) //Värdet av Egenskaperna/Properties sätts i constructorn:
        {
            this.PBase = pbase;
            this.PHeight = pheight;
        }
        public override double GetArea() //Override av basklassens asbtracta metod med värden från Parallellogrammets egenskaper/properties:
        {
            Area = PBase * PHeight;
            return Area;
        }
   }
    //Klassen Ellips derived/ärver från basklass:
   class Ellips : Geometri 
   {
        //Ellipsens area = pi * halva minor axeln * halva major axeln, därför behöver klassen tre properties/egenskaper - Pi, Minor och Major utöver den ärvda, Area:
        double Pi { get; set; }
        double Minor { get; set; }
        double Major { get; set; }

        //Constructor för Ellips:
        public Ellips(double pi = Math.PI, double minor = 13, double major = 42) //Värdet av Egenskaperna/Properties sätts i constructorn:
        {
            this.Pi = pi;
            this.Minor = minor/2;
            this.Major = major/2;
        }
        public override double GetArea() //Override av basklassens abstracta metod med värden från Ellipsens egenskaper/properties:
        {
            Area = Pi * Minor * Major;
            return Area;
        }
   }
}
