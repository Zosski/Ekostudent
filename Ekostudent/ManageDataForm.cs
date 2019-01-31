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
    public partial class ManageDataForm : Form
    {     
        Files files;
        public ManageDataForm(Files filesys)
        {
            files = filesys;
            InitializeComponent();
            produktradio.Checked = true;
        }

        private void produktradio_CheckedChanged(object sender, EventArgs e)
        {
            RefreshItemBox();
        }
        
        private void RefreshItemBox()
        {
            ToAddBox.Items.Clear();
            if (produktradio.Checked)
            {
                string[] JednostkiTxt = { "sztuki", "kg", "litry" };
                for (int i = 0; i < files.GProdukty(); i++)
                {
                    this.ToAddBox.Items.AddRange(new object[] { files.GProduktNazwa(i) + " " + files.GProduktCena(i) + "zl (" + JednostkiTxt[files.GProduktJednostka(i)] + ")" });
                }
            }
            else
            {
                for (int i = 0; i < files.GDania(); i++)
                {
                    this.ToAddBox.Items.AddRange(new object[] { files.GMealNazwa(i) });
                }
            }
        }

        private void ModBtn_Click(object sender, EventArgs e)
        {
            if (produktradio.Checked == true)
            {
                AddProductForm form = new AddProductForm(files, ToAddBox.SelectedIndex);
                var dialogResult = form.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    RefreshItemBox();
                }
            }
            else
            {
                AddMealForm form = new AddMealForm(files, ToAddBox.SelectedIndex);
                var dialogResult = form.ShowDialog(this);
                if(dialogResult == DialogResult.OK)
                {
                    RefreshItemBox();
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if(produktradio.Checked == true)
            {
                int[] ToDelete = new int[files.GDania()];
                int y = 0;
                for (int i = files.GDania(); i >= 0; i--)//od końca bo zmieniają się indeksy dań jak kasujemy
                {
                    for (int x = 0; x < 30; x++)
                    {
                        if (files.GMealIntQt(i, x) == 0) break;
                        if (files.GMealInt(i, x) == ToAddBox.SelectedIndex)
                        {
                            ToDelete[y] = i;
                            y++;
                            break;
                        }
                    }
                }

                DialogResult dialogResult = MessageBox.Show("Jeżeli usuniesz ten produkt "+y+" powiązanych z nim przepisów także zostanie usuniętych.\nCzy chcesz kontynuować?", "Usunąć produkt?", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    files.RemoveProduct(ToAddBox.SelectedIndex);
                    for (int i = files.GDania(); i >= 0; i--)
                    {
                        for (int x = 0; x < 30; x++)
                        {
                            if (files.GMealIntQt(i, x) == 0) break;
                            if (files.GMealInt(i, x) > ToAddBox.SelectedIndex)
                            {
                                files.GMealSetInt(i, x, files.GMealInt(i, x) - 1);//przesuwamy indeks każdego produktu ponieważ zmieni się po usunięciu
                            }
                        }
                    }
                    for (int i = 0; i < y; i++)
                    {
                        files.RemoveMeal(ToDelete[i]);
                    }
                }
                
            }
            else
            {
                files.RemoveMeal(ToAddBox.SelectedIndex);
            }
            RefreshItemBox();
        }
    }
}
