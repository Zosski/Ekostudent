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
    public partial class AddProductForm : Form
    {
        private Files files;
        int edit = 0;
        public AddProductForm(Files filesys, int edited = -1)
        {
            edit = edited;
            files = filesys;
            InitializeComponent();
            if(edit != -1)
            {
                productValue.Text = files.GProduktCena(edit).ToString();
                productName.Text = files.GProduktNazwa(edit);
                string[] JednostkiTxt = { "sztuki", "kg", "litry" };
                productType.Text = JednostkiTxt[files.GProduktJednostka(edit)];
                this.Text = "Edytuj produkt";
                buttonAdd.Text = "Zapisz";
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (edit != -1)
            {
                dialogResult = MessageBox.Show("Zapisać zmiany?", "", MessageBoxButtons.YesNo);
            }
            else
            {
                dialogResult = MessageBox.Show("Jesteś pewny że chcesz dodać ten produkt?", "", MessageBoxButtons.YesNo);
            }

            if (dialogResult == DialogResult.Yes)
            {
                string wartosc = productValue.Text;
                wartosc = wartosc.Replace('.', ',');
                if (productName.Text.Length <= 2) return;
                if (float.Parse(wartosc) <= 0) return;

                int type = 0;
                if (productType.Text == "kg") type = 1;
                if (productType.Text == "litry") type = 2;

                if (edit != -1)
                {
                    files.EditProduct(edit, productName.Text, float.Parse(wartosc), type);

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    files.AddProduct(productName.Text, float.Parse(wartosc), type);
                    productValue.Text = String.Empty;
                    productName.Text = String.Empty;
                    productType.Text = "sztuki";
                }
            }
        }
    }
}
