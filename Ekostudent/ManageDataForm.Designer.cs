namespace Ekostudent
{
    partial class ManageDataForm
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
            this.ModBtn = new System.Windows.Forms.Button();
            this.produktradio = new System.Windows.Forms.RadioButton();
            this.danieradio = new System.Windows.Forms.RadioButton();
            this.DelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToAddBox
            // 
            this.ToAddBox.FormattingEnabled = true;
            this.ToAddBox.Location = new System.Drawing.Point(12, 43);
            this.ToAddBox.Name = "ToAddBox";
            this.ToAddBox.Size = new System.Drawing.Size(206, 199);
            this.ToAddBox.TabIndex = 0;
            // 
            // ModBtn
            // 
            this.ModBtn.Location = new System.Drawing.Point(143, 248);
            this.ModBtn.Name = "ModBtn";
            this.ModBtn.Size = new System.Drawing.Size(75, 23);
            this.ModBtn.TabIndex = 7;
            this.ModBtn.Text = "Modyfikuj";
            this.ModBtn.UseVisualStyleBackColor = true;
            this.ModBtn.Click += new System.EventHandler(this.ModBtn_Click);
            // 
            // produktradio
            // 
            this.produktradio.AutoSize = true;
            this.produktradio.Location = new System.Drawing.Point(12, 20);
            this.produktradio.Name = "produktradio";
            this.produktradio.Size = new System.Drawing.Size(67, 17);
            this.produktradio.TabIndex = 11;
            this.produktradio.TabStop = true;
            this.produktradio.Text = "Produkty";
            this.produktradio.UseVisualStyleBackColor = true;
            this.produktradio.CheckedChanged += new System.EventHandler(this.produktradio_CheckedChanged);
            // 
            // danieradio
            // 
            this.danieradio.AutoSize = true;
            this.danieradio.Location = new System.Drawing.Point(104, 20);
            this.danieradio.Name = "danieradio";
            this.danieradio.Size = new System.Drawing.Size(64, 17);
            this.danieradio.TabIndex = 12;
            this.danieradio.TabStop = true;
            this.danieradio.Text = "Przepisy";
            this.danieradio.UseVisualStyleBackColor = true;
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(62, 248);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 13;
            this.DelBtn.Text = "Usuń";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // ManageDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 285);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.danieradio);
            this.Controls.Add(this.produktradio);
            this.Controls.Add(this.ModBtn);
            this.Controls.Add(this.ToAddBox);
            this.Name = "ManageDataForm";
            this.Text = "Dodaj danie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ToAddBox;
        private System.Windows.Forms.Button ModBtn;
        private System.Windows.Forms.RadioButton produktradio;
        private System.Windows.Forms.RadioButton danieradio;
        private System.Windows.Forms.Button DelBtn;
    }
}