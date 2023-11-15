using Lift;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    
    private static void Main(string[] args)
    {
        List<Liftezgetesek> liftezgeteseklista = new List<Liftezgetesek>();
        Console.WriteLine("code");
        StreamReader sr = new StreamReader("lift.txt");
        while (!sr.EndOfStream)
        {
            string[] mezok = sr.ReadLine().Split(" ");
            liftezgeteseklista.Add(new Liftezgetesek(Convert.ToDateTime(mezok[0]), int.Parse(mezok[1]), int.Parse(mezok[2]), int.Parse(mezok[3])));
        }

        //3. feladat
        Console.WriteLine($"3. feladat: Összes lifthasználat: {liftezgeteseklista.Count()}");
        //4. feladat
        Console.WriteLine($"4. feladat időszak: {liftezgeteseklista[0].Idopont} - {liftezgeteseklista[liftezgeteseklista.Count-1].Idopont}");
        //5. feladat
        Console.WriteLine($"5. feladat: Célszint max: {liftezgeteseklista.OrderBy(x => x.Erkezo).Last().Erkezo}");
        //6-7. feladat
        int kartyaszamimput;
        int erkezoinput;
        try
        {
            kartyaszamimput = Convert.ToInt32(Console.ReadLine());

        }
        catch (FormatException)
        {
            kartyaszamimput = 5;
        }
        try
        {
            erkezoinput = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            erkezoinput = 5;
        }
        Console.WriteLine("6. feladat");
        Console.WriteLine($"\tKártyaszám: {kartyaszamimput}");
        Console.WriteLine($"\tCélszint: {erkezoinput}");
        if (liftezgeteseklista.Any(x => x.Sorszam == kartyaszamimput && x.Erkezo == erkezoinput))
        {
            Console.WriteLine($"7. feladat: A(z) {kartyaszamimput}. kártyával utaztak a {erkezoinput}. emeletre!");
        }
        else
        {
            Console.WriteLine($"7. feladat: A(z) {kartyaszamimput}. kártyával nem utaztak a {erkezoinput}. emeletre!");
        }
        //8. feladat
        Console.WriteLine("8. feladat: Statisztika");

        try
        {
            liftezgeteseklista.GroupBy(x => x.Idopont).ToList().ForEach(x => Console.WriteLine($"\t{x.Key} - {x.Count()}x"));
        }
        catch (Exception)
        {

            throw new Exception("valami nem jo :(");
        }

    }
}