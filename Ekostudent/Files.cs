using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Ekostudent
{
    public class Files
    {
        private static int MAX_PRODUCTS = 100;
        private static int MAX_MEALS = 100;

        private int Produkty = 0;
        private string[] ProduktNazwa = new string[MAX_PRODUCTS];
        private float[] ProduktCena = new float[MAX_PRODUCTS];
        private int[] ProduktJednostka = new int[MAX_PRODUCTS];//0 - g, 1 - sztuki

        private int Dania = 0;
        private string[] MealNazwa = new string[MAX_MEALS];
        private string[] MealHowTo = new string[MAX_MEALS];
        private int[,] MealInt = new int[MAX_MEALS, 30];
        private int[,] MealIntQt = new int[MAX_MEALS, 30];


        public void LoadFiles()
        {
            this.LoadProducts();
            this.LoadMeals();
        }

        public void AddProduct(string pname, float pprice, int ptype)
        {
            if (Produkty >= MAX_PRODUCTS)
            {
                MessageBox.Show("Przekroczono limit produktow");
            }
            else
            {
                IEnumerable<string> m_oEnum = new List<string>() { pname + "|" + pprice + "|" + ptype };
                File.AppendAllLines("produkty.txt", m_oEnum);
                ProduktNazwa[Produkty] = pname;
                ProduktCena[Produkty] = pprice;
                ProduktJednostka[Produkty] = ptype;
                Produkty++;
            }
        }
        public void AddMeal(string mname, string mhowto, int[] mint, int[] mintqt)
        {
            if (Dania >= MAX_MEALS)
            {
                MessageBox.Show("Przekroczono limit przepisów");
            }
            else
            {
                string parser = string.Empty;
                for (int i = 0; i < 30; i++)
                {
                    if (mintqt[i] == 0) break;
                    if (i == 0)
                    {
                        parser = String.Format("{0} {1}", mint[i], mintqt[i]);
                    }
                    else
                    {
                        parser = String.Format("{0}/{1} {2}", parser, mint[i], mintqt[i]);
                    }
                }
                IEnumerable<string> m_oEnum = new List<string>() { mname + "|" + mhowto + "|" + parser };
                File.AppendAllLines("potrawy.txt", m_oEnum);
                MealNazwa[Dania] = mname;
                MealHowTo[Dania] = mhowto;
                for (int i = 0; i < 30; i++)
                {
                    if (mintqt[i] == 0) break;
                    MealInt[Dania, i] = mint[i];
                    MealIntQt[Dania, i] = mintqt[i];
                }
                Dania++;
            }

        }

        public void EditProduct(int pos, string pname, float pprice, int ptype)
        {
            File.WriteAllText("produkty.txt", String.Empty);
            for (int i = 0; i < Produkty; i++)
            {
                IEnumerable<string> m_oEnum;
                if (i == pos)
                {
                     m_oEnum = new List<string>() { pname + "|" + pprice + "|" + ptype };
                }
                else
                {
                    m_oEnum = new List<string>() { ProduktNazwa[i] + "|" + ProduktCena[i] + "|" + ProduktJednostka[i] };
                }
                File.AppendAllLines("produkty.txt", m_oEnum);
            }
            LoadProducts();
        }

        public void EditMeal(int pos, string mname, string mhowto, int[] mint, int[] mintqt)
        {
            File.WriteAllText("potrawy.txt", String.Empty);
            for (int z = 0; z < Dania; z++)
            {
                if (z == pos)
                {
                    MealNazwa[z] = mname;
                    MealHowTo[z] = mhowto;
                }
                string parser = string.Empty;
                for (int i = 0; i < 30; i++)
                {
                    if (z == pos)
                    {
                        MealInt[z, i] = mint[i];
                        MealIntQt[z, i] = mintqt[i];
                    }

                    if (MealIntQt[z, i] == 0) break;
                    if (i == 0)
                    {
                        parser = String.Format("{0} {1}", MealInt[z, i], MealIntQt[z, i]);
                    }
                    else
                    {
                        parser = String.Format("{0}/{1} {2}", parser, MealInt[z, i], MealIntQt[z, i]);
                    }
                }
                IEnumerable<string> m_oEnum = new List<string>() { MealNazwa[z] + "|" + MealHowTo[z] + "|" + parser };
                File.AppendAllLines("potrawy.txt", m_oEnum);
            }
            LoadMeals();
        }

        public void RemoveProduct(int pos)
        {
            File.WriteAllText("produkty.txt", String.Empty);
            for (int i = 0; i < Produkty; i++)
            {
                if (i == pos) continue;
                IEnumerable<string> m_oEnum = new List<string>() { ProduktNazwa[i] + "|" + ProduktCena[i] + "|" + ProduktJednostka[i] };
                File.AppendAllLines("produkty.txt", m_oEnum);
            }
            LoadProducts();
        }
        public void RemoveMeal(int pos)
        {
            File.WriteAllText("potrawy.txt", String.Empty);
            for (int z = 0; z < Dania; z++)
            {
                if (z == pos) continue;
                string parser = string.Empty;
                for (int i = 0; i < 30; i++)
                {
                    if (MealIntQt[z, i] == 0) break;
                    if (i == 0)
                    {
                        parser = String.Format("{0} {1}", MealInt[z, i], MealIntQt[z, i]);
                    }
                    else
                    {
                        parser = String.Format("{0}/{1} {2}", parser, MealInt[z, i], MealIntQt[z, i]);
                    }
                }
                IEnumerable<string> m_oEnum = new List<string>() { MealNazwa[z] + "|" + MealHowTo[z] + "|" + parser };
                File.AppendAllLines("potrawy.txt", m_oEnum);
            }
            LoadMeals();
        }

        public int GProdukty()
        {
            return Produkty;
        }
        public string GProduktNazwa(int id)
        {
            return ProduktNazwa[id];
        }
        public float GProduktCena(int id)
        {
            if (Produkty <= id) { MessageBox.Show("Hjuston we gat problem"); return 0; }
            return ProduktCena[id];
        }
        public int GProduktJednostka(int id)
        {
            return ProduktJednostka[id];
        }

        public int GDania()
        {
            return Dania;
        }
        public string GMealNazwa(int id)
        {
            return MealNazwa[id];
        }
        public string GMealHowTo(int id)
        {
            return MealHowTo[id];
        }
        public int GMealInt(int id, int id2)
        {
            return MealInt[id, id2];
        }
        public int GMealIntQt(int id, int id2)
        {
            return MealIntQt[id, id2];
        }
        public void GMealSetInt(int id, int id2, int newid)
        {
            MealInt[id, id2] = newid;
        }
        private void LoadProducts()
        {
            string[] lines = System.IO.File.ReadAllLines("produkty.txt");
            int i = 0;
            foreach (string line in lines)
            {
                if (i > MAX_PRODUCTS)
                {
                    MessageBox.Show("Nie zaladowano wszystkch produktow poniewaz przekroczona zostala ich ilosc");
                    break;
                }
                var parameters = line.Split('|');
                ProduktNazwa[i] = parameters[0];
                ProduktCena[i] = float.Parse(parameters[1]);
                ProduktJednostka[i] = int.Parse(parameters[2]);
                i++;
            }
            Produkty = i;
        }
        private void LoadMeals()
        {
            string[] lines = System.IO.File.ReadAllLines("potrawy.txt");
            int i = 0;
            foreach (string line in lines)
            {
                if (i > MAX_MEALS)
                {
                    MessageBox.Show("Nie zaladowano wszystkch posilkow poniewaz przekroczona zostala ich ilosc");
                    break;
                }
                var parameters = line.Split('|');
                MealNazwa[i] = parameters[0].Replace("<newline>", "\n");
                MealHowTo[i] = parameters[1];
                var parameters2 = parameters[2].Split('/');
                int x = 0;
                for(int y = x; y < 30; y++)
                {
                    MealInt[i, y] = 0;
                    MealIntQt[i, y] = 0;
                }
                foreach (string param in parameters2)
                {
                    parameters = param.Split(' ');
                    MealInt[i, x] = int.Parse(parameters[0]);
                    MealIntQt[i, x] = int.Parse(parameters[1]);
                    x++;
                }
                i++;
            }
            Dania = i;
        }

    }

}
