
namespace MojeFinanse
{
    partial class EdytujDokument
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
            this.buttonUsunTowar = new System.Windows.Forms.Button();
            this.buttonDodajTowar = new System.Windows.Forms.Button();
            this.labelListaTowarow = new System.Windows.Forms.Label();
            this.listBoxListaTowarow = new System.Windows.Forms.ListBox();
            this.buttonEdytujDokument = new System.Windows.Forms.Button();
            this.textBoxUnikalnyKod = new System.Windows.Forms.TextBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.textBoxMiejsceZakupu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMiejsceZakupu = new System.Windows.Forms.Label();
            this.dateTimePickerDataDodania = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataZakupu = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(22, 210);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(28, 13);
            this.labelOpis.TabIndex = 37;
            this.labelOpis.Text = "Opis";
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(139, 203);
            this.textBoxOpis.MaxLength = 256;
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(559, 60);
            this.textBoxOpis.TabIndex = 36;
            // 
            // buttonUsunTowar
            // 
            this.buttonUsunTowar.Location = new System.Drawing.Point(704, 351);
            this.buttonUsunTowar.Name = "buttonUsunTowar";
            this.buttonUsunTowar.Size = new System.Drawing.Size(74, 44);
            this.buttonUsunTowar.TabIndex = 35;
            this.buttonUsunTowar.Text = "Usuń Towar";
            this.buttonUsunTowar.UseVisualStyleBackColor = true;
            this.buttonUsunTowar.Click += new System.EventHandler(this.buttonUsunTowar_Click);
            // 
            // buttonDodajTowar
            // 
            this.buttonDodajTowar.Location = new System.Drawing.Point(704, 301);
            this.buttonDodajTowar.Name = "buttonDodajTowar";
            this.buttonDodajTowar.Size = new System.Drawing.Size(74, 44);
            this.buttonDodajTowar.TabIndex = 34;
            this.buttonDodajTowar.Text = "Dodaj Towar";
            this.buttonDodajTowar.UseVisualStyleBackColor = true;
            this.buttonDodajTowar.Click += new System.EventHandler(this.buttonDodajTowar_Click);
            // 
            // labelListaTowarow
            // 
            this.labelListaTowarow.AutoSize = true;
            this.labelListaTowarow.Location = new System.Drawing.Point(18, 285);
            this.labelListaTowarow.Name = "labelListaTowarow";
            this.labelListaTowarow.Size = new System.Drawing.Size(76, 13);
            this.labelListaTowarow.TabIndex = 33;
            this.labelListaTowarow.Text = "Lista Towarów";
            this.labelListaTowarow.Click += new System.EventHandler(this.labelListaTowarow_Click);
            // 
            // listBoxListaTowarow
            // 
            this.listBoxListaTowarow.FormattingEnabled = true;
            this.listBoxListaTowarow.Location = new System.Drawing.Point(21, 301);
            this.listBoxListaTowarow.Name = "listBoxListaTowarow";
            this.listBoxListaTowarow.Size = new System.Drawing.Size(677, 134);
            this.listBoxListaTowarow.TabIndex = 32;
            this.listBoxListaTowarow.DoubleClick += new System.EventHandler(this.buttonDodajTowar_DoubleClick);
            // 
            // buttonEdytujDokument
            // 
            this.buttonEdytujDokument.Location = new System.Drawing.Point(707, 19);
            this.buttonEdytujDokument.Name = "buttonEdytujDokument";
            this.buttonEdytujDokument.Size = new System.Drawing.Size(75, 244);
            this.buttonEdytujDokument.TabIndex = 31;
            this.buttonEdytujDokument.Text = "Edytuj dokument";
            this.buttonEdytujDokument.UseVisualStyleBackColor = true;
            this.buttonEdytujDokument.Click += new System.EventHandler(this.buttonEdytujDokument_Click);
            // 
            // textBoxUnikalnyKod
            // 
            this.textBoxUnikalnyKod.Location = new System.Drawing.Point(139, 167);
            this.textBoxUnikalnyKod.MaxLength = 20;
            this.textBoxUnikalnyKod.Name = "textBoxUnikalnyKod";
            this.textBoxUnikalnyKod.Size = new System.Drawing.Size(559, 20);
            this.textBoxUnikalnyKod.TabIndex = 29;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(140, 64);
            this.textBoxCena.MaxLength = 12;
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(559, 20);
            this.textBoxCena.TabIndex = 26;
            this.textBoxCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCena_KeyPress);
            // 
            // textBoxMiejsceZakupu
            // 
            this.textBoxMiejsceZakupu.Location = new System.Drawing.Point(140, 22);
            this.textBoxMiejsceZakupu.MaxLength = 50;
            this.textBoxMiejsceZakupu.Name = "textBoxMiejsceZakupu";
            this.textBoxMiejsceZakupu.Size = new System.Drawing.Size(559, 20);
            this.textBoxMiejsceZakupu.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Unikalny Kod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data Zakupu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data Dodania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cena";
            // 
            // labelMiejsceZakupu
            // 
            this.labelMiejsceZakupu.AutoSize = true;
            this.labelMiejsceZakupu.Location = new System.Drawing.Point(18, 27);
            this.labelMiejsceZakupu.Name = "labelMiejsceZakupu";
            this.labelMiejsceZakupu.Size = new System.Drawing.Size(83, 13);
            this.labelMiejsceZakupu.TabIndex = 19;
            this.labelMiejsceZakupu.Text = "Miejsce Zakupu";
            // 
            // dateTimePickerDataDodania
            // 
            this.dateTimePickerDataDodania.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDataDodania.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataDodania.Location = new System.Drawing.Point(140, 104);
            this.dateTimePickerDataDodania.Name = "dateTimePickerDataDodania";
            this.dateTimePickerDataDodania.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerDataDodania.TabIndex = 39;
            // 
            // dateTimePickerDataZakupu
            // 
            this.dateTimePickerDataZakupu.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDataZakupu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataZakupu.Location = new System.Drawing.Point(139, 141);
            this.dateTimePickerDataZakupu.Name = "dateTimePickerDataZakupu";
            this.dateTimePickerDataZakupu.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerDataZakupu.TabIndex = 40;
            // 
            // EdytujDokument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.dateTimePickerDataZakupu);
            this.Controls.Add(this.dateTimePickerDataDodania);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.buttonUsunTowar);
            this.Controls.Add(this.buttonDodajTowar);
            this.Controls.Add(this.labelListaTowarow);
            this.Controls.Add(this.listBoxListaTowarow);
            this.Controls.Add(this.buttonEdytujDokument);
            this.Controls.Add(this.textBoxUnikalnyKod);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.textBoxMiejsceZakupu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMiejsceZakupu);
            this.Name = "EdytujDokument";
            this.Text = "Edytuj Dokument";
            this.Activated += new System.EventHandler(this.EdytujDokument_Activated);
            this.Load += new System.EventHandler(this.EdytujDokument_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Button buttonUsunTowar;
        private System.Windows.Forms.Button buttonDodajTowar;
        private System.Windows.Forms.Label labelListaTowarow;
        private System.Windows.Forms.ListBox listBoxListaTowarow;
        private System.Windows.Forms.Button buttonEdytujDokument;
        private System.Windows.Forms.TextBox textBoxUnikalnyKod;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.TextBox textBoxMiejsceZakupu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMiejsceZakupu;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDodania;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataZakupu;
    }
}