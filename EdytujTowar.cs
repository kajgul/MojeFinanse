using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojeFinanse
{
    public partial class EdytujTowar : Form
    {
        private Towar towar;
        public EdytujTowar(Towar towar)
        {
            this.towar = towar;
            InitializeComponent();
            textBoxNazwaTowaru.Text = towar.Nazwa;
            textBoxCenaDomyslna.Text = towar.CenaDomyslna.ToString();
            textBoxVAT.Text = towar.DomyslnyVat.ToString();
            textBoxOpis.Text = towar.Opis;
        }

        private void buttonEdytujDokument_Click(object sender, EventArgs e)
        {
            towar.Nazwa = textBoxNazwaTowaru.Text;
            towar.CenaDomyslna = float.Parse(textBoxCenaDomyslna.Text);
            towar.DomyslnyVat = float.Parse(textBoxVAT.Text);
            towar.Opis = textBoxOpis.Text;
            towar.EdytujDokument();
            MessageBox.Show("Dokonano edycji towaru");
            Close();
        }
    }
}
