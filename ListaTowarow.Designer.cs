
namespace MojeFinanse
{
    partial class ListaTowarow
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
            this.buttonTowary = new System.Windows.Forms.Button();
            this.buttonDokumenty = new System.Windows.Forms.Button();
            this.listTowarow = new System.Windows.Forms.ListBox();
            this.buttonDodajTowar = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTowary
            // 
            this.buttonTowary.Location = new System.Drawing.Point(430, 12);
            this.buttonTowary.Name = "buttonTowary";
            this.buttonTowary.Size = new System.Drawing.Size(358, 23);
            this.buttonTowary.TabIndex = 3;
            this.buttonTowary.Text = "Towary";
            this.buttonTowary.UseVisualStyleBackColor = true;
            // 
            // buttonDokumenty
            // 
            this.buttonDokumenty.Location = new System.Drawing.Point(13, 12);
            this.buttonDokumenty.Name = "buttonDokumenty";
            this.buttonDokumenty.Size = new System.Drawing.Size(358, 23);
            this.buttonDokumenty.TabIndex = 2;
            this.buttonDokumenty.Text = "Dokumenty";
            this.buttonDokumenty.UseVisualStyleBackColor = true;
            this.buttonDokumenty.Click += new System.EventHandler(this.buttonDokumenty_Click);
            // 
            // listTowarow
            // 
            this.listTowarow.FormattingEnabled = true;
            this.listTowarow.Location = new System.Drawing.Point(13, 56);
            this.listTowarow.Name = "listTowarow";
            this.listTowarow.Size = new System.Drawing.Size(774, 264);
            this.listTowarow.TabIndex = 4;
            this.listTowarow.DoubleClick += new System.EventHandler(this.listTowarow_DoubleClick);
            // 
            // buttonDodajTowar
            // 
            this.buttonDodajTowar.Location = new System.Drawing.Point(618, 347);
            this.buttonDodajTowar.Name = "buttonDodajTowar";
            this.buttonDodajTowar.Size = new System.Drawing.Size(169, 47);
            this.buttonDodajTowar.TabIndex = 12;
            this.buttonDodajTowar.Text = "Dodaj Towar";
            this.buttonDodajTowar.UseVisualStyleBackColor = true;
            this.buttonDodajTowar.Click += new System.EventHandler(this.buttonDodajTowar_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(539, 349);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(73, 43);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ListaTowarow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonDodajTowar);
            this.Controls.Add(this.listTowarow);
            this.Controls.Add(this.buttonTowary);
            this.Controls.Add(this.buttonDokumenty);
            this.Name = "ListaTowarow";
            this.Text = "Lista Towarów";
            this.Activated += new System.EventHandler(this.ListaTowarow_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTowary;
        private System.Windows.Forms.Button buttonDokumenty;
        private System.Windows.Forms.ListBox listTowarow;
        private System.Windows.Forms.Button buttonDodajTowar;
        private System.Windows.Forms.Button buttonDelete;
    }
}