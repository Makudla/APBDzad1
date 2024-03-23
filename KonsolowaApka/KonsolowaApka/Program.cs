namespace KonsolowaApka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 1, 2, 3, 4, 5 };
            double srednia = ObliczSrednia(liczby);
            Console.WriteLine("Średnia: " + srednia);

        }
        static double ObliczSrednia(int[] liczby)
        {
           
            int suma = 0;
            foreach (int liczba in liczby)
            {
                suma += liczba;
            }

            return (double)suma / liczby.Length;
        }
    }
}
