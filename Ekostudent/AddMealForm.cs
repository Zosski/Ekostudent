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
    public partial class AddMealForm : Form
    {
        private Files files;
        private int select1 = -1;
        private int select2 = -1;

        
        private int[] MealInt = new int[30];
        private int[] MealIntQt = new int[30];
        private int x = 0;
        private float qt=0;

        //private int produkty[]
        string[] JednostkiTxt = { "sztuki", "kg", "litry" };
        int edited = 0;
        public AddMealForm(Files filesys, int edit = -1)
        {
            edited = edit;
            files = filesys;
            InitializeComponent();
            for(int i =0;i < files.GProdukty(); i++)
            {
                this.ToAddBox.Items.AddRange(new object[] { files.GProduktNazwa(i) + " " + files.GProduktCena(i) + "zl (" + JednostkiTxt[files.GProduktJednostka(i)] + ")" });
            }
            if (edit != -1)
            {
                mealnamebox.Text = files.GMealNazwa(edit);
                desc.Text = files.GMealHowTo(edit).Replace("<newline>", Environment.NewLine);
                for (int i = 0; i < 30; i++)
                {
                    if(files.GMealIntQt(edit, i) != 0)
                    {
                        MealInt[x] = files.GMealInt(edit, i);
                        MealIntQt[x] = files.GMealIntQt(edit, i);
                        qt = files.GMealIntQt(edit, i);
                        if (files.GProduktJednostka(files.GMealInt(edit, i)) != 0) qt = files.GMealIntQt(edit, i) / 1000;
                        this.AddedBox.Items.AddRange(new object[] { files.GProduktNazwa(files.GMealInt(edit, i)) + " " + Math.Round((decimal)(files.GProduktCena(files.GMealInt(edit, i)) * qt), 2) + "zl (" + qt + " " + JednostkiTxt[files.GProduktJednostka(files.GMealInt(edit, i))] + ")" });
                        x++;
                    }
                }
                this.Text = "Edytuj przepis";
                FinishBtn.Text = "Zapisz";
            }
        }


        //dodaj do potrawy
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (qt == 0) return;
            if (select1 == -1) return;
            if (files.GProduktJednostka(select1) == 0 && qt % 1 != 0) { MessageBox.Show("Jeżeli ilość produktu jest w sztukach w ilości należy wpisać liczbę naturalną"); return; }
            this.AddedBox.Items.AddRange(new object[] { files.GProduktNazwa(select1) + " " + Math.Round((decimal)(files.GProduktCena(select1)*qt), 2) + "zl ("+qt+" " + JednostkiTxt[files.GProduktJednostka(select1)] + ")" });
            MealInt[x] = select1;
            if(files.GProduktJednostka(select1) != 0) qt = qt * 1000;
            MealIntQt[x] = (int)qt;
            if (files.GProduktJednostka(select1) != 0) qt = qt / 1000;
            x++;
            PriceRefresh();
        }

        //usun z potrawy
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (select2 == -1) return;
            RemoveInteger(select2);
            this.AddedBox.Items.RemoveAt(select2);
            PriceRefresh();
        }

        //usuń sładnik
        private void RemoveInteger(int index)
        {
            for (int i = index; i < x; i++)
            {
                MealInt[i] = MealInt[i + 1];
                MealIntQt[i] = MealIntQt[i + 1];
            }
            x--;
        }

        //ilość
        private void QtBox_TextChanged(object sender, EventArgs e)
        {
            QtBox.Text = QtBox.Text.Replace('.', ',');
            if (QtBox.Text.Length <= 0) return;
            if (!float.TryParse(QtBox.Text, out qt)) { return; }
            if (qt <= 0) { qt = 0; return; }
        }

        private void PriceRefresh()
        {
            float suma = 0;
            for (int i = 0; i < x; i++)
            {
                float cena = 0;
                cena = (float)files.GProduktCena(MealInt[i]) * MealIntQt[i];
                if (files.GProduktJednostka(MealInt[i]) != 0)
                    cena = (float)files.GProduktCena(MealInt[i]) * MealIntQt[i] / 1000;

                suma += cena;
            }
            suma = (float)Math.Round(suma, 2);
            pricelabel.Text = "Koszt: " + suma + " zł";
        }

        private void ToAddBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            select1 = ToAddBox.SelectedIndex;
        }

        private void AddedBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            select2 = AddedBox.SelectedIndex;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (edited != -1)
            {
                dialogResult = MessageBox.Show("Zapisać zmiany?", "", MessageBoxButtons.YesNo);
            }
            else
            {
                dialogResult = MessageBox.Show("Jesteś pewny że chcesz dodać ten przepis?", "", MessageBoxButtons.YesNo);
            }
          
            if (dialogResult == DialogResult.Yes)
            {
                string opis = desc.Text;
                opis = opis.Replace("\n", "<newline>");
                if(edited != -1)
                {
                    files.EditMeal(edited, mealnamebox.Text, opis, MealInt, MealIntQt);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    files.AddMeal(mealnamebox.Text, opis, MealInt, MealIntQt);
                }
            }
        }

    }
}
