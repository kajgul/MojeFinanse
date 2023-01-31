
namespace MojeFinanse
{
    partial class EdytujTowar
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
            this.buttonEdytujDokument = new System.Windows.Forms.Button();
            this.textBoxVAT = new System.Windows.Forms.TextBox();
            this.textBoxCenaDomyslna = new System.Windows.Forms.TextBox();
            this.textBoxNazwaTowaru = new System.Windows.Forms.TextBox();
            this.labelDomyslnyVat = new System.Windows.Forms.Label();
            this.labelCenaDomyslna = new System.Windows.Forms.Label();
            this.labelNazwaTowaru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(12, 162);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(28, 13);
            this.labelOpis.TabIndex = 64;
            this.labelOpis.Text = "Opis";
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(133, 155);
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(559, 20);
            this.textBoxOpis.TabIndex = 63;
            // 
            // buttonEdytujDokument
            // 
            this.buttonEdytujDokument.Location = new System.Drawing.Point(707, 9);
            this.buttonEdytujDokument.Name = "buttonEdytujDokument";
            this.buttonEdytujDokument.Size = new System.Drawing.Size(75, 166);
            this.buttonEdytujDokument.TabIndex = 62;
            this.buttonEdytujDokument.Text = "Edytuj dokument";
            this.buttonEdytujDokument.UseVisualStyleBackColor = true;
            this.buttonEdytujDokument.Click += new System.EventHandler(this.buttonEdytujDokument_Click);
            // 
            // textBoxVAT
            // 
            this.textBoxVAT.Location = new System.Drawing.Point(133, 105);
            this.textBoxVAT.Name = "textBoxVAT";
            this.textBoxVAT.Size = new System.Drawing.Size(559, 20);
            this.textBoxVAT.TabIndex = 61;
            // 
            // textBoxCenaDomyslna
            // 
            this.textBoxCenaDomyslna.Location = new System.Drawing.Point(134, 61);
            this.textBoxCenaDomyslna.Name = "textBoxCenaDomyslna";
            this.textBoxCenaDomyslna.Size = new System.Drawing.Size(559, 20);
            this.textBoxCenaDomyslna.TabIndex = 60;
            // 
            // textBoxNazwaTowaru
            // 
            this.textBoxNazwaTowaru.Location = new System.Drawing.Point(134, 19);
            this.textBoxNazwaTowaru.Name = "textBoxNazwaTowaru";
            this.textBoxNazwaTowaru.Size = new System.Drawing.Size(559, 20);
            this.textBoxNazwaTowaru.TabIndex = 59;
            // 
            // labelDomyslnyVat
            // 
            this.labelDomyslnyVat.AutoSize = true;
            this.labelDomyslnyVat.Location = new System.Drawing.Point(12, 112);
            this.labelDomyslnyVat.Name = "labelDomyslnyVat";
            this.labelDomyslnyVat.Size = new System.Drawing.Size(76, 13);
            this.labelDomyslnyVat.TabIndex = 58;
            this.labelDomyslnyVat.Text = "Domyślny VAT";
            // 
            // labelCenaDomyslna
            // 
            this.labelCenaDomyslna.AutoSize = true;
            this.labelCenaDomyslna.Location = new System.Drawing.Point(12, 68);
            this.labelCenaDomyslna.Name = "labelCenaDomyslna";
            this.labelCenaDomyslna.Size = new System.Drawing.Size(32, 13);
            this.labelCenaDomyslna.TabIndex = 57;
            this.labelCenaDomyslna.Text = "Cena";
            // 
            // labelNazwaTowaru
            // 
            this.labelNazwaTowaru.AutoSize = true;
            this.labelNazwaTowaru.Location = new System.Drawing.Point(12, 24);
            this.labelNazwaTowaru.Name = "labelNazwaTowaru";
            this.labelNazwaTowaru.Size = new System.Drawing.Size(79, 13);
            this.labelNazwaTowaru.TabIndex = 56;
            this.labelNazwaTowaru.Text = "Nazwa Towaru";
            // 
            // EdytujTowar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 201);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.buttonEdytujDokument);
            this.Controls.Add(this.textBoxVAT);
            this.Controls.Add(this.textBoxCenaDomyslna);
            this.Controls.Add(this.textBoxNazwaTowaru);
            this.Controls.Add(this.labelDomyslnyVat);
            this.Controls.Add(this.labelCenaDomyslna);
            this.Controls.Add(this.labelNazwaTowaru);
            this.Name = "EdytujTowar";
            this.Text = "EdytujTowar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Button buttonEdytujDokument;
        private System.Windows.Forms.TextBox textBoxVAT;
        private System.Windows.Forms.TextBox textBoxCenaDomyslna;
        private System.Windows.Forms.TextBox textBoxNazwaTowaru;
        private System.Windows.Forms.Label labelDomyslnyVat;
        private System.Windows.Forms.Label labelCenaDomyslna;
        private System.Windows.Forms.Label labelNazwaTowaru;
    }
}