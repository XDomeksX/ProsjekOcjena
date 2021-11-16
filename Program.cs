using System;
class HelloWorld
{
    static void Main()
    {
        int ocjena, brojPredmeta = 0, br = 0, brojPredmeta2 = 0;
        double prosjek, zbrojOcjena = 0.0;

        Console.WriteLine("#  Izračunavanje prosjeka  #");
        jump: Console.WriteLine("Unesi ocjene (0 za kraj): ");
        do
        {
            ocjena = Convert.ToInt32(Console.ReadLine());
            if (ocjena < 6)
            {

                zbrojOcjena += ocjena;

                brojPredmeta++;
                br++;
            }
            if(ocjena > 5){
                Console.WriteLine("Molim upišite ispravnu ocjenu.");
            }
        } while (ocjena != 0);
        brojPredmeta2 = brojPredmeta - 1;
        Console.WriteLine("Broj ocjena: " + br);
        Console.WriteLine("Zbroj ocjena: " + zbrojOcjena);
        Console.WriteLine("Broj predmeta: " + brojPredmeta2);
        prosjek = zbrojOcjena / brojPredmeta2;
        Console.WriteLine("Prosjek: " + prosjek);
    }
}