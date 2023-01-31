
namespace MojeFinanse
{
    partial class DodajTowarDoDokumentu
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
            this.buttonWybierzTowar = new System.Windows.Forms.Button();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.labelCenaBrutto = new System.Windows.Forms.Label();
            this.textBoxCenaBrutto = new System.Windows.Forms.TextBox();
            this.labelVAT = new System.Windows.Forms.Label();
            this.textBoxVAT = new System.Windows.Forms.TextBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.labelOpis = new System.Windows.Forms.Label();
            this.buttonDodajTowar = new System.Windows.Forms.Button();
            this.textBoxIlosc = new System.Windows.Forms.TextBox();
            this.labelIlosc = new System.Windows.Forms.Label();
            this.labelJednostka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAll = new System.Windows.Forms.TextBox();
            this.textBoxJednostka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonWybierzTowar
            // 
            this.buttonWybierzTowar.Location = new System.Drawing.Point(17, 14);
            this.buttonWybierzTowar.Name = "buttonWybierzTowar";
            this.buttonWybierzTowar.Size = new System.Drawing.Size(86, 25);
            this.buttonWybierzTowar.TabIndex = 0;
            this.buttonWybierzTowar.Text = "Wybierz towar";
            this.buttonWybierzTowar.UseVisualStyleBackColor = true;
            this.buttonWybierzTowar.Click += new System.EventHandler(this.buttonWybierzTowar_Click);
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(123, 16);
            this.textBoxNazwa.MaxLength = 50;
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(365, 20);
            this.textBoxNazwa.TabIndex = 1;
            // 
            // labelCenaBrutto
            // 
            this.labelCenaBrutto.AutoSize = true;
            this.labelCenaBrutto.Location = new System.Drawing.Point(20, 64);
            this.labelCenaBrutto.Name = "labelCenaBrutto";
            this.labelCenaBrutto.Size = new System.Drawing.Size(86, 13);
            this.labelCenaBrutto.TabIndex = 2;
            this.labelCenaBrutto.Text = "Cena Brutto za 1";
            // 
            // textBoxCenaBrutto
            // 
            this.textBoxCenaBrutto.Location = new System.Drawing.Point(124, 61);
            this.textBoxCenaBrutto.MaxLength = 12;
            this.textBoxCenaBrutto.Name = "textBoxCenaBrutto";
            this.textBoxCenaBrutto.Size = new System.Drawing.Size(140, 20);
            this.textBoxCenaBrutto.TabIndex = 3;
            this.textBoxCenaBrutto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCenaZa1_KeyPress);
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Location = new System.Drawing.Point(370, 64);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(28, 13);
            this.labelVAT.TabIndex = 4;
            this.labelVAT.Text = "VAT";
            // 
            // textBoxVAT
            // 
            this.textBoxVAT.Location = new System.Drawing.Point(404, 61);
            this.textBoxVAT.Name = "textBoxVAT";
            this.textBoxVAT.Size = new System.Drawing.Size(83, 20);
            this.textBoxVAT.TabIndex = 5;
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(123, 174);
            this.textBoxOpis.MaxLength = 256;
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(363, 91);
            this.textBoxOpis.TabIndex = 6;
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(20, 177);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(28, 13);
            this.labelOpis.TabIndex = 7;
            this.labelOpis.Text = "Opis";
            // 
            // buttonDodajTowar
            // 
            this.buttonDodajTowar.Location = new System.Drawing.Point(16, 280);
            this.buttonDodajTowar.Name = "buttonDodajTowar";
            this.buttonDodajTowar.Size = new System.Drawing.Size(470, 34);
            this.buttonDodajTowar.TabIndex = 8;
            this.buttonDodajTowar.Text = "Dodaj towar";
            this.buttonDodajTowar.UseVisualStyleBackColor = true;
            this.buttonDodajTowar.Click += new System.EventHandler(this.buttonDodajTowar_Click);
            // 
            // textBoxIlosc
            // 
            this.textBoxIlosc.Location = new System.Drawing.Point(124, 99);
            this.textBoxIlosc.Name = "textBoxIlosc";
            this.textBoxIlosc.Size = new System.Drawing.Size(140, 20);
            this.textBoxIlosc.TabIndex = 10;
            this.textBoxIlosc.Text = "1";
            this.textBoxIlosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIlosc_KeyPress);
            // 
            // labelIlosc
            // 
            this.labelIlosc.AutoSize = true;
            this.labelIlosc.Location = new System.Drawing.Point(77, 102);
            this.labelIlosc.Name = "labelIlosc";
            this.labelIlosc.Size = new System.Drawing.Size(29, 13);
            this.labelIlosc.TabIndex = 9;
            this.labelIlosc.Text = "Ilość";
            this.labelIlosc.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelJednostka
            // 
            this.labelJednostka.AutoSize = true;
            this.labelJednostka.Location = new System.Drawing.Point(342, 102);
            this.labelJednostka.Name = "labelJednostka";
            this.labelJednostka.Size = new System.Drawing.Size(56, 13);
            this.labelJednostka.TabIndex = 11;
            this.labelJednostka.Text = "Jednostka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cena Brutto za całość";
            // 
            // textBoxAll
            // 
            this.textBoxAll.Location = new System.Drawing.Point(124, 135);
            this.textBoxAll.MaxLength = 12;
            this.textBoxAll.Name = "textBoxAll";
            this.textBoxAll.Size = new System.Drawing.Size(362, 20);
            this.textBoxAll.TabIndex = 14;
            this.textBoxAll.TextChanged += new System.EventHandler(this.textBoxAll_TextChanged);
            this.textBoxAll.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceAll_KeyPress);
            // 
            // textBoxJednostka
            // 
            this.textBoxJednostka.Location = new System.Drawing.Point(405, 99);
            this.textBoxJednostka.Name = "textBoxJednostka";
            this.textBoxJednostka.Size = new System.Drawing.Size(83, 20);
            this.textBoxJednostka.TabIndex = 15;
            // 
            // DodajTowarDoDokumentu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 328);
            this.Controls.Add(this.textBoxJednostka);
            this.Controls.Add(this.textBoxAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelJednostka);
            this.Controls.Add(this.textBoxIlosc);
            this.Controls.Add(this.labelIlosc);
            this.Controls.Add(this.buttonDodajTowar);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.textBoxVAT);
            this.Controls.Add(this.labelVAT);
            this.Controls.Add(this.textBoxCenaBrutto);
            this.Controls.Add(this.labelCenaBrutto);
            this.Controls.Add(this.textBoxNazwa);
            this.Controls.Add(this.buttonWybierzTowar);
            this.Name = "DodajTowarDoDokumentu";
            this.Text = "Dodaj towar";
            this.Activated += new System.EventHandler(this.DodajTowarDoDokumentu_Activated);
            this.Load += new System.EventHandler(this.DodajTowarDoDokumentu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWybierzTowar;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Label labelCenaBrutto;
        private System.Windows.Forms.TextBox textBoxCenaBrutto;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.TextBox textBoxVAT;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Button buttonDodajTowar;
        private System.Windows.Forms.TextBox textBoxIlosc;
        private System.Windows.Forms.Label labelIlosc;
        private System.Windows.Forms.Label labelJednostka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAll;
        private System.Windows.Forms.TextBox textBoxJednostka;
    }
}