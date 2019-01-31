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
    public partial class MainForm : Form
    {
        private Files files;
        public MainForm(Files filesys)
        {
            files = filesys;
            InitializeComponent();
            RefreshCount();
        }

        public void RefreshCount()
        {
            label2.Text = "Przepisy: " + files.GDania();
            label3.Text = "Produkty: " + files.GProdukty();
        }

        public void addproduct_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm(files);
            form.ShowDialog(this);
            RefreshCount();
        }


        private void addmeal_Click(object sender, EventArgs e)
        {
            AddMealForm form = new AddMealForm(files);
            form.ShowDialog(this);
            RefreshCount();
        }

        private void datamanage_Click(object sender, EventArgs e)
        {
            ManageDataForm form = new ManageDataForm(files);
            form.ShowDialog(this);
            RefreshCount();
        }

        private void randommeal_Click(object sender, EventArgs e)
        {
            RandomForm form = new RandomForm(files);
            form.ShowDialog(this);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
