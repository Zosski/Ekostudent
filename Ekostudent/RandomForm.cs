using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekostudent
{
    public partial class RandomForm : Form
    {
        Files file;
        int last;
        public RandomForm(Files filesys)
        {
            file = filesys;
            InitializeComponent();
            GetRandomMeal();
        }

        private void GetRandomMeal()
        {
            Random rnd = new Random();
            int next;
            do{next = rnd.Next(0, file.GDania());} while (next == last);
            last = next;
            titlelabel.Text = file.GMealNazwa(next);
            howtolabel.Text = file.GMealHowTo(next).Replace("<newline>", Environment.NewLine);
            string[] JednostkiTxt = { "sztuki", "kg", "litry" };
            intBox.Items.Clear();
            for (int i = 0; i < 30; i++)
            {
                if (file.GMealIntQt(next, i) != 0)
                {
                    float qt = file.GMealIntQt(next, i);
                    if (file.GProduktJednostka(file.GMealInt(next, i)) != 0) qt = file.GMealIntQt(next, i) / 1000;
                    this.intBox.Items.AddRange(new object[] { file.GProduktNazwa(file.GMealInt(next, i)) + " " + Math.Round((decimal)(file.GProduktCena(file.GMealInt(next, i)) * qt), 2) + "zl (" + qt + " " + JednostkiTxt[file.GProduktJednostka(file.GMealInt(next, i))] + ")" });
                }
            }
            PriceRefresh();
        }

        private void PriceRefresh()
        {
            float suma = 0;
            for (int i = 0; i < 30; i++)
            {
                if (file.GMealIntQt(last, i) != 0)
                {
                    float cena = 0;
                    cena = (float)file.GProduktCena(file.GMealInt(last, i)) * (float)file.GMealIntQt(last, i);
                    if (file.GProduktJednostka(file.GMealInt(last, i)) != 0)
                        cena = (float)file.GProduktCena(file.GMealInt(last, i)) * file.GMealIntQt(last, i) / 1000;
                    suma += cena;
                }
            }
            suma = (float)Math.Round(suma, 2);
            label1.Text = "Koszt: " + suma + " zł";
        }

        private void NextRnd_Click(object sender, EventArgs e)
        {
            GetRandomMeal();
        }
    }
}
