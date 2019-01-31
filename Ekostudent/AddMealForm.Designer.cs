namespace Ekostudent
{
    partial class AddMealForm
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
            this.ToAddBox = new System.Windows.Forms.ListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.QtBox = new System.Windows.Forms.TextBox();
            this.AddedBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.mealnamebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ToAddBox
            // 
            this.ToAddBox.FormattingEnabled = true;
            this.ToAddBox.Location = new System.Drawing.Point(12, 43);
            this.ToAddBox.Name = "ToAddBox";
            this.ToAddBox.Size = new System.Drawing.Size(206, 199);
            this.ToAddBox.TabIndex = 0;
            this.ToAddBox.SelectedIndexChanged += new System.EventHandler(this.ToAddBox_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(261, 128);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = ">>>";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(261, 176);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "<<<";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // QtBox
            // 
            this.QtBox.Location = new System.Drawing.Point(261, 86);
            this.QtBox.Name = "QtBox";
            this.QtBox.Size = new System.Drawing.Size(75, 20);
            this.QtBox.TabIndex = 3;
            this.QtBox.TextChanged += new System.EventHandler(this.QtBox_TextChanged);
            // 
            // AddedBox
            // 
            this.AddedBox.FormattingEnabled = true;
            this.AddedBox.Location = new System.Drawing.Point(377, 43);
            this.AddedBox.Name = "AddedBox";
            this.AddedBox.Size = new System.Drawing.Size(206, 199);
            this.AddedBox.TabIndex = 4;
            this.AddedBox.SelectedIndexChanged += new System.EventHandler(this.AddedBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Przyrządzanie";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(12, 291);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(571, 147);
            this.desc.TabIndex = 6;
            this.desc.Text = "";
            // 
            // FinishBtn
            // 
            this.FinishBtn.Location = new System.Drawing.Point(508, 444);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(75, 23);
            this.FinishBtn.TabIndex = 7;
            this.FinishBtn.Text = "Dodaj";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ilość";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(505, 245);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(72, 13);
            this.pricelabel.TabIndex = 10;
            this.pricelabel.Text = "Koszt: 0,00 zł";
            // 
            // mealnamebox
            // 
            this.mealnamebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mealnamebox.Location = new System.Drawing.Point(12, 13);
            this.mealnamebox.Name = "mealnamebox";
            this.mealnamebox.Size = new System.Drawing.Size(571, 20);
            this.mealnamebox.TabIndex = 11;
            this.mealnamebox.Text = "Nazwa potrawy";
            this.mealnamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 479);
            this.Controls.Add(this.mealnamebox);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddedBox);
            this.Controls.Add(this.QtBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ToAddBox);
            this.Name = "AddMealForm";
            this.Text = "Dodaj danie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ToAddBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox QtBox;
        private System.Windows.Forms.ListBox AddedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox desc;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.TextBox mealnamebox;
    }
}