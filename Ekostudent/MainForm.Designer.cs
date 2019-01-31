namespace Ekostudent
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addproduct = new System.Windows.Forms.Button();
            this.addmeal = new System.Windows.Forms.Button();
            this.randommeal = new System.Windows.Forms.Button();
            this.datamanage = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arimo", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(66, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "EkoStudent";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dania: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produkty: 0";
            // 
            // addproduct
            // 
            this.addproduct.Location = new System.Drawing.Point(72, 129);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(172, 23);
            this.addproduct.TabIndex = 3;
            this.addproduct.Text = "Dodaj produkt";
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // addmeal
            // 
            this.addmeal.Location = new System.Drawing.Point(72, 169);
            this.addmeal.Name = "addmeal";
            this.addmeal.Size = new System.Drawing.Size(172, 23);
            this.addmeal.TabIndex = 4;
            this.addmeal.Text = "Dodaj danie";
            this.addmeal.UseVisualStyleBackColor = true;
            this.addmeal.Click += new System.EventHandler(this.addmeal_Click);
            // 
            // randommeal
            // 
            this.randommeal.Location = new System.Drawing.Point(72, 249);
            this.randommeal.Name = "randommeal";
            this.randommeal.Size = new System.Drawing.Size(172, 23);
            this.randommeal.TabIndex = 5;
            this.randommeal.Text = "Losuj danie";
            this.randommeal.UseVisualStyleBackColor = true;
            this.randommeal.Click += new System.EventHandler(this.randommeal_Click);
            // 
            // datamanage
            // 
            this.datamanage.Location = new System.Drawing.Point(72, 209);
            this.datamanage.Name = "datamanage";
            this.datamanage.Size = new System.Drawing.Size(172, 23);
            this.datamanage.TabIndex = 7;
            this.datamanage.Text = "Zarządzaj danymi";
            this.datamanage.UseVisualStyleBackColor = true;
            this.datamanage.Click += new System.EventHandler(this.datamanage_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(72, 289);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(172, 23);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Wyjdź";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 332);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.datamanage);
            this.Controls.Add(this.randommeal);
            this.Controls.Add(this.addmeal);
            this.Controls.Add(this.addproduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "EkoStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addproduct;
        private System.Windows.Forms.Button addmeal;
        private System.Windows.Forms.Button randommeal;
        private System.Windows.Forms.Button datamanage;
        private System.Windows.Forms.Button exitBtn;
    }
}

