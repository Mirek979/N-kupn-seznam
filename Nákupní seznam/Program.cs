
class Program
{



    static List<List<Tuple<string, int>>> nakupniSeznamy = new List<List<Tuple<string, int>>>();
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Zadej příkaz(exit, show, delete, add)");
            string prikaz = Console.ReadLine();

            switch (prikaz)
            {
                case "add":
                    Pridej();
                    break;
                case "delete":
                    Odstran();
                    break;
                case "show":
                    Zobraz();
                    break;
                case "exit":
                    Console.WriteLine("Děkujieme za použití programu");
                    return;
                default:
                    Console.WriteLine(prikaz + "není známý");
                    break;


            }
        }
        static void Pridej()

        {
            Console.WriteLine("Nákupní seznam: " + nakupniSeznamy.Count);
            List<Tuple<string, int>> seznam = new List<Tuple<string, int>>();
            while (true)
            {
                Console.Write("Zadej položku k přidání nebo napiš exit: ");
                string polozka = Console.ReadLine();
                if (polozka == "exit") break;
                int pocet;
                while (true)
                {
                    Console.WriteLine("Zadej počet: ");
                    string pocetS = Console.ReadLine();
                    if (int.TryParse(pocetS, out pocet))
                    {
                        break;
                    }
                    else
                        Console.WriteLine("Zadej celé číslo");

                }


                seznam.Add(new Tuple<string, int>(polozka, pocet));

                nakupniSeznamy.Add(seznam);
            }
        }

        static void Odstran()
        {
            Console.WriteLine("Zadej index nákupního seznamu pro smazání:");
            string s = Console.ReadLine();
            int index;
            if (int.TryParse(s, out index))
            {
                if (index >= nakupniSeznamy.Count)
                {
                    Console.WriteLine("Takový seznam neexistuje!");
                    return;
                }
                Console.WriteLine("Chystáte se odstranit seznam " + index + " kde je " + nakupniSeznamy[index].Count + " položek. Jste si jisti(y/n)?");
                string r = Console.ReadLine();
                if (r == "y")
                {
                    nakupniSeznamy.RemoveAt(index);
                    Console.WriteLine("Odstraněno!");
                }
            }
            else
                Console.WriteLine("Nezadali jste celé číslo!");

        }

        static void Zobraz()
        {
            Console.WriteLine("Zadej index k zobrazení: ");
            string s = Console.ReadLine();
            int index;
            if (int.TryParse(s, out index))
            {
                for (int i = 0; i < nakupniSeznamy[index].Count; i++)
                {
                    Console.WriteLine(nakupniSeznamy[index][i].Item1 + " " + nakupniSeznamy[index][i].Item2);
                }
            }
            else
                Console.WriteLine("Nezadali jste celé číslo!");

        }
    }


}