namespace Ekostudent
{
    partial class RandomForm
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
            this.titlelabel = new System.Windows.Forms.Label();
            this.intBox = new System.Windows.Forms.ListBox();
            this.howtolabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NextRnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Arimo", 21.75F, System.Drawing.FontStyle.Bold);
            this.titlelabel.Location = new System.Drawing.Point(255, 9);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(0, 34);
            this.titlelabel.TabIndex = 0;
            // 
            // intBox
            // 
            this.intBox.FormattingEnabled = true;
            this.intBox.Location = new System.Drawing.Point(13, 70);
            this.intBox.Name = "intBox";
            this.intBox.Size = new System.Drawing.Size(178, 186);
            this.intBox.TabIndex = 1;
            // 
            // howtolabel
            // 
            this.howtolabel.AutoSize = true;
            this.howtolabel.Location = new System.Drawing.Point(214, 70);
            this.howtolabel.Name = "howtolabel";
            this.howtolabel.Size = new System.Drawing.Size(0, 13);
            this.howtolabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Potrzebne składniki";
            // 
            // NextRnd
            // 
            this.NextRnd.Location = new System.Drawing.Point(530, 258);
            this.NextRnd.Name = "NextRnd";
            this.NextRnd.Size = new System.Drawing.Size(126, 23);
            this.NextRnd.TabIndex = 4;
            this.NextRnd.Text = "Losuj Ponownie";
            this.NextRnd.UseVisualStyleBackColor = true;
            this.NextRnd.Click += new System.EventHandler(this.NextRnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cena: 0,00zl";
            // 
            // RandomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextRnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.howtolabel);
            this.Controls.Add(this.intBox);
            this.Controls.Add(this.titlelabel);
            this.Name = "RandomForm";
            this.Text = "RandomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.ListBox intBox;
        private System.Windows.Forms.Label howtolabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NextRnd;
        private System.Windows.Forms.Label label1;
    }
}