namespace KonsolowaApka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 1, 2, 3, 4, 5 };
            double srednia = ObliczSrednia(liczby);
            Console.WriteLine("Średnia: " + srednia);
            int maksimum = Max(liczby);
            Console.WriteLine("Max: " + maksimum);
        }
        static double ObliczSrednia(int[] liczby)
        {
           
<<<<<<< HEAD
            int sumaD = 0;
            foreach (int liczba in liczby)
            {
                sumaD += liczba;
            }

            return (double)sumaD / liczby.Length;
=======
            int omnom = 0;
            foreach (int liczba in liczby)
            {
                omnom += liczba;
            }

            return (double)omnom / liczby.Length;
>>>>>>> feature-new
        }

        static int Max(int[] liczby)
        {

            int max = liczby[0];
            foreach (int liczba in liczby)
            {
                if (liczba > max)
                    max = liczba;
            }

            return max;
        }
    }
}
