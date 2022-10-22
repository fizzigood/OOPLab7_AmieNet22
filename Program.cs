namespace OOPLab7AmieNet22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rektangel rektangel = new Rektangel();                                  //Nytt objekt/instans av Rektangelklassen.
            Console.WriteLine("Area Rektangel: " + rektangel.GetArea());            //Kallar på metoden GetArea från basklassen med Rektangelns implementering.
            Console.WriteLine();                                                    //Mellanrum mellan nästa utskrift.

            Fyrkant fyrkant = new Fyrkant();                                        //Nytt objekt/instans av Fyrkantklassen.
            Console.WriteLine("Area Fyrkant: " + fyrkant.GetArea());                //Kallar på metoden GetArea från basklassen med Fyrkantens implementering.
            Console.WriteLine();                                                    //Mellanrum mellan nästa utskrift.

            Cirkel cirkel = new Cirkel();                                           //Nytt objekt/instans av Cirkelklassen.
            Console.WriteLine("Area Cirkel: " + cirkel.GetArea());                  //Kallar på metoden GetArea från basklassen med Cirkelns implementering.
            Console.WriteLine();                                                    //Mellanrum mellan nästa utskrift.

            Parallellogram parallellogram = new Parallellogram();                   //Nytt objekt/instans av Parallellogramklassen
            Console.WriteLine("Area Parallellogram: " + parallellogram.GetArea());  //Kallar på metoden GetArea från basklassen med Parallellogrammets implementering.
            Console.WriteLine();                                                    //Mellanrum mellan nästa utskrift

            Ellips ellips = new Ellips();                                           //Nytt objekt/instans av Ellipslklassen
            Console.WriteLine("Area Ellips: " + ellips.GetArea());                  //Kallar på metoden GetArea från basklassen med Ellipsens implementering.
            Console.WriteLine();                                                    //Mellanrum mellan nästa utskrift.
        }
    }
}