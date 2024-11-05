using System.Globalization;

namespace metodusok2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = Primszamok(1,25);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            int elofordul= szovegelofordulas("asdasdasdasdasdasdasd", "asd");
			Console.WriteLine(elofordul);
        }
		static List<int> Primszamok(int kezdo,int veg)
		{
			List<int> primlista = new List<int>();
            for (int i = kezdo; i < veg; i++)
            {
                if (primE(i))
                {
                    primlista.Add(i);
                }
            }
			return primlista;
        }
		static bool primE(int szam)
		{
			if (szam < 2) return false;
            for (int i = 2; i <= Math.Sqrt(szam); i++)
            {
				if (szam % i == 0) return false;
            }
			return true;
        }
        static int szovegelofordulas(string szoveg, string alszoveg)
        {
            string temp = "";
            int count = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                temp = temp + szoveg[i];
                if (i%alszoveg.Length==2)
                {
                    if (alszoveg==temp)
                    {
                        count++;
                        temp = "";
                    }
                }
            }
            return count;
        }
        static int szamjegyosszeg(int szam)
        {

        }
	}
}
