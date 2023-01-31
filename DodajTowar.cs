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
    public partial class DodajTowar : Form
    {
        public DodajTowar()
        {
            InitializeComponent();
        }

        private void textBoxOpis_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodajDokument_Click(object sender, EventArgs e)
        {
            var towar = new Towar(textBoxNazwaTowaru.Text, float.Parse(textBoxCenaDomyslna.Text), float.Parse(textBoxVAT.Text), textBoxOpis.Text, comboBoxJednostka.Text);
            towar.DodajDokument();
            MessageBox.Show("Dodano towar");
            Close();
        }

        private void textBoxCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            MenuWForms.NumericValuesOnly(sender, e);
        }
    }
}
