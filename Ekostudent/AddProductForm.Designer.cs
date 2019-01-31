namespace Ekostudent
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.ComboBox();
            this.productValue = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa Skladnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jednostka Miary";
            // 
            // productType
            // 
            this.productType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productType.FormattingEnabled = true;
            this.productType.Items.AddRange(new object[] {
            "sztuki",
            "kg",
            "litry"});
            this.productType.Location = new System.Drawing.Point(180, 104);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(121, 21);
            this.productType.TabIndex = 2;
            // 
            // productValue
            // 
            this.productValue.Location = new System.Drawing.Point(180, 64);
            this.productValue.Name = "productValue";
            this.productValue.Size = new System.Drawing.Size(121, 20);
            this.productValue.TabIndex = 4;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(180, 23);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(121, 20);
            this.productName.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(180, 150);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Dodaj Produkt";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 206);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productValue);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProductForm";
            this.Text = "Dodaj produkt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox productType;
        private System.Windows.Forms.TextBox productValue;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Button buttonAdd;
    }
}