
namespace MojeFinanse
{
    partial class ListaDokumentow
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
            this.buttonDokumenty = new System.Windows.Forms.Button();
            this.buttonTowary = new System.Windows.Forms.Button();
            this.listDokumentow = new System.Windows.Forms.ListBox();
            this.labelMiesiac = new System.Windows.Forms.Label();
            this.comboBoxMiesiac = new System.Windows.Forms.ComboBox();
            this.labelRok = new System.Windows.Forms.Label();
            this.labelSuma = new System.Windows.Forms.Label();
            this.textBoxSuma = new System.Windows.Forms.TextBox();
            this.buttonDodajNowyDokument = new System.Windows.Forms.Button();
            this.buttonUsunDokument = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonDokumenty
            // 
            this.buttonDokumenty.Location = new System.Drawing.Point(13, 13);
            this.buttonDokumenty.Name = "buttonDokumenty";
            this.buttonDokumenty.Size = new System.Drawing.Size(358, 23);
            this.buttonDokumenty.TabIndex = 0;
            this.buttonDokumenty.Text = "Dokumenty";
            this.buttonDokumenty.UseVisualStyleBackColor = true;
            this.buttonDokumenty.Click += new System.EventHandler(this.buttonDokumenty_Click);
            // 
            // buttonTowary
            // 
            this.buttonTowary.Location = new System.Drawing.Point(430, 13);
            this.buttonTowary.Name = "buttonTowary";
            this.buttonTowary.Size = new System.Drawing.Size(358, 23);
            this.buttonTowary.TabIndex = 1;
            this.buttonTowary.Text = "Towary";
            this.buttonTowary.UseVisualStyleBackColor = true;
            this.buttonTowary.Click += new System.EventHandler(this.buttonTowary_Click);
            // 
            // listDokumentow
            // 
            this.listDokumentow.FormattingEnabled = true;
            this.listDokumentow.Location = new System.Drawing.Point(20, 60);
            this.listDokumentow.Name = "listDokumentow";
            this.listDokumentow.Size = new System.Drawing.Size(774, 264);
            this.listDokumentow.TabIndex = 2;
            this.listDokumentow.DoubleClick += new System.EventHandler(this.listDokumentow_DoubleClick);
            // 
            // labelMiesiac
            // 
            this.labelMiesiac.AutoSize = true;
            this.labelMiesiac.Location = new System.Drawing.Point(17, 346);
            this.labelMiesiac.Name = "labelMiesiac";
            this.labelMiesiac.Size = new System.Drawing.Size(43, 13);
            this.labelMiesiac.TabIndex = 3;
            this.labelMiesiac.Text = "Miesiąc";
            // 
            // comboBoxMiesiac
            // 
            this.comboBoxMiesiac.FormattingEnabled = true;
            this.comboBoxMiesiac.Items.AddRange(new object[] {
            "wszystkie",
            "styczeń",
            "luty",
            "marzec",
            "kwiecień",
            "maj",
            "czerwiec",
            "lipiec",
            "sierpień",
            "wrzesień",
            "październik",
            "listopad",
            "grudzień"});
            this.comboBoxMiesiac.Location = new System.Drawing.Point(66, 343);
            this.comboBoxMiesiac.Name = "comboBoxMiesiac";
            this.comboBoxMiesiac.Size = new System.Drawing.Size(135, 21);
            this.comboBoxMiesiac.TabIndex = 5;
            this.comboBoxMiesiac.Text = "wszystkie";
            this.comboBoxMiesiac.SelectedIndexChanged += new System.EventHandler(this.comboBoxMiesiac_SelectedIndexChanged);
            // 
            // labelRok
            // 
            this.labelRok.AutoSize = true;
            this.labelRok.Location = new System.Drawing.Point(209, 346);
            this.labelRok.Name = "labelRok";
            this.labelRok.Size = new System.Drawing.Size(27, 13);
            this.labelRok.TabIndex = 6;
            this.labelRok.Text = "Rok";
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Location = new System.Drawing.Point(218, 383);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(34, 13);
            this.labelSuma.TabIndex = 8;
            this.labelSuma.Text = "Suma";
            // 
            // textBoxSuma
            // 
            this.textBoxSuma.Location = new System.Drawing.Point(258, 378);
            this.textBoxSuma.Name = "textBoxSuma";
            this.textBoxSuma.Size = new System.Drawing.Size(134, 20);
            this.textBoxSuma.TabIndex = 9;
            // 
            // buttonDodajNowyDokument
            // 
            this.buttonDodajNowyDokument.Location = new System.Drawing.Point(589, 346);
            this.buttonDodajNowyDokument.Name = "buttonDodajNowyDokument";
            this.buttonDodajNowyDokument.Size = new System.Drawing.Size(169, 47);
            this.buttonDodajNowyDokument.TabIndex = 11;
            this.buttonDodajNowyDokument.Text = "Dodaj nowy dokument";
            this.buttonDodajNowyDokument.UseVisualStyleBackColor = true;
            this.buttonDodajNowyDokument.Click += new System.EventHandler(this.buttonDodajNowyDokument_Click);
            // 
            // buttonUsunDokument
            // 
            this.buttonUsunDokument.Location = new System.Drawing.Point(494, 347);
            this.buttonUsunDokument.Name = "buttonUsunDokument";
            this.buttonUsunDokument.Size = new System.Drawing.Size(78, 47);
            this.buttonUsunDokument.TabIndex = 12;
            this.buttonUsunDokument.Text = "Usuń";
            this.buttonUsunDokument.UseVisualStyleBackColor = true;
            this.buttonUsunDokument.Click += new System.EventHandler(this.buttonUsunDokument_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(258, 343);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2022, 10, 20, 18, 47, 31, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ListaDokumentow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonUsunDokument);
            this.Controls.Add(this.buttonDodajNowyDokument);
            this.Controls.Add(this.textBoxSuma);
            this.Controls.Add(this.labelSuma);
            this.Controls.Add(this.labelRok);
            this.Controls.Add(this.comboBoxMiesiac);
            this.Controls.Add(this.labelMiesiac);
            this.Controls.Add(this.listDokumentow);
            this.Controls.Add(this.buttonTowary);
            this.Controls.Add(this.buttonDokumenty);
            this.Name = "ListaDokumentow";
            this.Text = "Lista Dokumentów";
            this.Activated += new System.EventHandler(this.ListaDokumentow_Activated);
            this.Load += new System.EventHandler(this.ListaDokumentow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDokumenty;
        private System.Windows.Forms.Button buttonTowary;
        private System.Windows.Forms.ListBox listDokumentow;
        private System.Windows.Forms.Label labelMiesiac;
        private System.Windows.Forms.ComboBox comboBoxMiesiac;
        private System.Windows.Forms.Label labelRok;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.TextBox textBoxSuma;
        private System.Windows.Forms.Button buttonDodajNowyDokument;
        private System.Windows.Forms.Button buttonUsunDokument;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

