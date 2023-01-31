
namespace MojeFinanse
{
    partial class DodajTowar
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
            this.labelOpis = new System.Windows.Forms.Label();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.buttonDodajDokument = new System.Windows.Forms.Button();
            this.textBoxVAT = new System.Windows.Forms.TextBox();
            this.textBoxCenaDomyslna = new System.Windows.Forms.TextBox();
            this.textBoxNazwaTowaru = new System.Windows.Forms.TextBox();
            this.labelDomyslnyVat = new System.Windows.Forms.Label();
            this.labelCenaDomyslna = new System.Windows.Forms.Label();
            this.labelNazwaTowaru = new System.Windows.Forms.Label();
            this.labelJednostka = new System.Windows.Forms.Label();
            this.comboBoxJednostka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(18, 142);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(28, 13);
            this.labelOpis.TabIndex = 55;
            this.labelOpis.Text = "Opis";
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(140, 139);
            this.textBoxOpis.MaxLength = 256;
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(559, 50);
            this.textBoxOpis.TabIndex = 54;
            this.textBoxOpis.TextChanged += new System.EventHandler(this.textBoxOpis_TextChanged);
            // 
            // buttonDodajDokument
            // 
            this.buttonDodajDokument.Location = new System.Drawing.Point(713, 12);
            this.buttonDodajDokument.Name = "buttonDodajDokument";
            this.buttonDodajDokument.Size = new System.Drawing.Size(75, 204);
            this.buttonDodajDokument.TabIndex = 49;
            this.buttonDodajDokument.Text = "Dodaj dokument";
            this.buttonDodajDokument.UseVisualStyleBackColor = true;
            this.buttonDodajDokument.Click += new System.EventHandler(this.buttonDodajDokument_Click);
            // 
            // textBoxVAT
            // 
            this.textBoxVAT.Location = new System.Drawing.Point(139, 108);
            this.textBoxVAT.Name = "textBoxVAT";
            this.textBoxVAT.Size = new System.Drawing.Size(559, 20);
            this.textBoxVAT.TabIndex = 48;
            // 
            // textBoxCenaDomyslna
            // 
            this.textBoxCenaDomyslna.Location = new System.Drawing.Point(140, 64);
            this.textBoxCenaDomyslna.Name = "textBoxCenaDomyslna";
            this.textBoxCenaDomyslna.Size = new System.Drawing.Size(559, 20);
            this.textBoxCenaDomyslna.TabIndex = 47;
            this.textBoxCenaDomyslna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCena_KeyPress);
            // 
            // textBoxNazwaTowaru
            // 
            this.textBoxNazwaTowaru.Location = new System.Drawing.Point(140, 22);
            this.textBoxNazwaTowaru.MaxLength = 50;
            this.textBoxNazwaTowaru.Name = "textBoxNazwaTowaru";
            this.textBoxNazwaTowaru.Size = new System.Drawing.Size(559, 20);
            this.textBoxNazwaTowaru.TabIndex = 46;
            // 
            // labelDomyslnyVat
            // 
            this.labelDomyslnyVat.AutoSize = true;
            this.labelDomyslnyVat.Location = new System.Drawing.Point(18, 115);
            this.labelDomyslnyVat.Name = "labelDomyslnyVat";
            this.labelDomyslnyVat.Size = new System.Drawing.Size(76, 13);
            this.labelDomyslnyVat.TabIndex = 45;
            this.labelDomyslnyVat.Text = "Domyślny VAT";
            // 
            // labelCenaDomyslna
            // 
            this.labelCenaDomyslna.AutoSize = true;
            this.labelCenaDomyslna.Location = new System.Drawing.Point(18, 71);
            this.labelCenaDomyslna.Name = "labelCenaDomyslna";
            this.labelCenaDomyslna.Size = new System.Drawing.Size(32, 13);
            this.labelCenaDomyslna.TabIndex = 42;
            this.labelCenaDomyslna.Text = "Cena";
            this.labelCenaDomyslna.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNazwaTowaru
            // 
            this.labelNazwaTowaru.AutoSize = true;
            this.labelNazwaTowaru.Location = new System.Drawing.Point(18, 27);
            this.labelNazwaTowaru.Name = "labelNazwaTowaru";
            this.labelNazwaTowaru.Size = new System.Drawing.Size(79, 13);
            this.labelNazwaTowaru.TabIndex = 41;
            this.labelNazwaTowaru.Text = "Nazwa Towaru";
            // 
            // labelJednostka
            // 
            this.labelJednostka.AutoSize = true;
            this.labelJednostka.Location = new System.Drawing.Point(18, 203);
            this.labelJednostka.Name = "labelJednostka";
            this.labelJednostka.Size = new System.Drawing.Size(56, 13);
            this.labelJednostka.TabIndex = 56;
            this.labelJednostka.Text = "Jednostka";
            // 
            // comboBoxJednostka
            // 
            this.comboBoxJednostka.FormattingEnabled = true;
            this.comboBoxJednostka.Items.AddRange(new object[] {
            "SZT",
            "KG",
            "L"});
            this.comboBoxJednostka.Location = new System.Drawing.Point(139, 195);
            this.comboBoxJednostka.Name = "comboBoxJednostka";
            this.comboBoxJednostka.Size = new System.Drawing.Size(102, 21);
            this.comboBoxJednostka.TabIndex = 57;
            this.comboBoxJednostka.Text = "SZT";
            this.comboBoxJednostka.UseWaitCursor = true;
            // 
            // DodajTowar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 240);
            this.Controls.Add(this.comboBoxJednostka);
            this.Controls.Add(this.labelJednostka);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.buttonDodajDokument);
            this.Controls.Add(this.textBoxVAT);
            this.Controls.Add(this.textBoxCenaDomyslna);
            this.Controls.Add(this.textBoxNazwaTowaru);
            this.Controls.Add(this.labelDomyslnyVat);
            this.Controls.Add(this.labelCenaDomyslna);
            this.Controls.Add(this.labelNazwaTowaru);
            this.Name = "DodajTowar";
            this.Text = "Dodaj Towar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Button buttonDodajDokument;
        private System.Windows.Forms.TextBox textBoxVAT;
        private System.Windows.Forms.TextBox textBoxCenaDomyslna;
        private System.Windows.Forms.TextBox textBoxNazwaTowaru;
        private System.Windows.Forms.Label labelDomyslnyVat;
        private System.Windows.Forms.Label labelCenaDomyslna;
        private System.Windows.Forms.Label labelNazwaTowaru;
        private System.Windows.Forms.Label labelJednostka;
        private System.Windows.Forms.ComboBox comboBoxJednostka;
    }
}