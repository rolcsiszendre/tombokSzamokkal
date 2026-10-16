namespace tombokSzamokkal
{
    internal class Program
    {
        static int[] tomb = new int[15];
        static Random r = new Random();
        static void Feltolt()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 21);
            }
            foreach(int item in tomb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void OsszegzesTetele()
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine($"A szamok osszege: {osszeg}");
        }

        static void MegszamlalasTetele()
        {
            int db = 0;
            foreach (int item in tomb)
            {
                if (item > 0)
                {
                    db++;
                }
            }
            Console.WriteLine($"A pozitiv szamok szama: {db}");
        }

        static void EldontesTetele()
        {
            int i = 0;
            while (i < tomb.Length & tomb[i] != 0)
            {
                i++;
            }
            if (i == tomb.Length)
            {
                Console.WriteLine("Van 0 a tombben");
            }
            else
            {
                Console.WriteLine("Nincs 0 a tombben");
            }
        }
        static void KeresesTetele()
        {
            int keresett = 0;
            int i = 0;
            while (i < tomb.Length & tomb[i] != keresett)
            {
                i++;
            }
            if (i == tomb.Length)
            {
                Console.WriteLine($"A keresett szam nincs a tombben");
            }
            else
            {
                Console.WriteLine($"A {keresett} szam a tombben van");
            }
        }
            static void Main(string[] args)
        {
            Feltolt();
            MegszamlalasTetele();
            EldontesTetele();
        }
    }
}
