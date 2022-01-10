namespace TojasManufaktura
{
    partial class FrmMain
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
            this.btnTermeles = new System.Windows.Forms.Button();
            this.btnStatisztika = new System.Windows.Forms.Button();
            this.btnKimutatas = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.pbNyuszi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNyuszi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTermeles
            // 
            this.btnTermeles.Location = new System.Drawing.Point(17, 16);
            this.btnTermeles.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnTermeles.Name = "btnTermeles";
            this.btnTermeles.Size = new System.Drawing.Size(379, 75);
            this.btnTermeles.TabIndex = 0;
            this.btnTermeles.Text = "Termelés";
            this.btnTermeles.UseVisualStyleBackColor = true;
            this.btnTermeles.Click += new System.EventHandler(this.BtnTermeles_Click);
            // 
            // btnStatisztika
            // 
            this.btnStatisztika.Location = new System.Drawing.Point(17, 105);
            this.btnStatisztika.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnStatisztika.Name = "btnStatisztika";
            this.btnStatisztika.Size = new System.Drawing.Size(379, 75);
            this.btnStatisztika.TabIndex = 1;
            this.btnStatisztika.Text = "Statisztika";
            this.btnStatisztika.UseVisualStyleBackColor = true;
            this.btnStatisztika.Click += new System.EventHandler(this.BtnStatisztika_Click);
            // 
            // btnKimutatas
            // 
            this.btnKimutatas.Location = new System.Drawing.Point(17, 194);
            this.btnKimutatas.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnKimutatas.Name = "btnKimutatas";
            this.btnKimutatas.Size = new System.Drawing.Size(379, 75);
            this.btnKimutatas.TabIndex = 2;
            this.btnKimutatas.Text = "Kimutatás";
            this.btnKimutatas.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(17, 283);
            this.btnKilepes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(379, 75);
            this.btnKilepes.TabIndex = 3;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.BtnKilepes_Click);
            // 
            // pbNyuszi
            // 
            this.pbNyuszi.Image = global::TojasManufaktura.Properties.Resources.nyul;
            this.pbNyuszi.ImageLocation = "";
            this.pbNyuszi.Location = new System.Drawing.Point(409, 16);
            this.pbNyuszi.Name = "pbNyuszi";
            this.pbNyuszi.Size = new System.Drawing.Size(398, 342);
            this.pbNyuszi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNyuszi.TabIndex = 4;
            this.pbNyuszi.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(819, 376);
            this.Controls.Add(this.pbNyuszi);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnKimutatas);
            this.Controls.Add(this.btnStatisztika);
            this.Controls.Add(this.btnTermeles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmMain";
            this.Text = "Tojás gyár";
            ((System.ComponentModel.ISupportInitialize)(this.pbNyuszi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTermeles;
        private System.Windows.Forms.Button btnStatisztika;
        private System.Windows.Forms.Button btnKimutatas;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.PictureBox pbNyuszi;
    }
}

