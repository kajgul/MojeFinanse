using DatowanieLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojeFinanse
{
    public partial class DodajDokument : Form
    {
        static List<Towar> towary = new List<Towar>();
        BindingSource towaryBindingSource = new BindingSource();
        private static DodajTowarDoDokumentu EdytujTowar;
        public DodajDokument()
        {
            InitializeComponent();
        }

        private void buttonDodajDokument_Click(object sender, EventArgs e)
        {
            var DateOperation = new DatowanieClass();
            var dataDodania = DateOperation.DataWInt(dateTimePickerDataDodania.Text);
            var dataZakupu = DateOperation.DataWInt(dateTimePickerDataZakupu.Text);
            //uniemożliwić wpisywanie danych nienumerycznych - uniemożliwiono, wpisane niżej

            if(towary.Count == 0)
            {
                var dokument = new Dokument(textBoxMiejsceZakupu.Text, float.Parse(textBoxCena.Text), dataDodania,
                    dataZakupu, textBoxUnikalnyKod.Text, textBoxOpis.Text);
                dokument.DodajDokument();
                MessageBox.Show("Dodano dokument bez listy towarów");
            }
            else
            {
                var dokument = new Dokument(textBoxMiejsceZakupu.Text, float.Parse(textBoxCena.Text), dataDodania,
                    dataZakupu, textBoxUnikalnyKod.Text, textBoxOpis.Text, towary);
                dokument.DodajDokumentZTowarami();
                MessageBox.Show("Dodano dokument z listą towarów");
            }
            Close();
        }

        internal void ReceiveData(Towar aaTowar)
        {
            towary.Add(aaTowar);
        }

        private void buttonDodajTowar_Click(object sender, EventArgs e)
        {
            var frm = new DodajTowarDoDokumentu();
            frm.ShowDialog();
        }

        private void buttonUsunTowar_Click(object sender, EventArgs e)
        {
            if (listBoxListaTowarow.SelectedItem != null)
            {
                var towar = towary[listBoxListaTowarow.SelectedIndex];                
                towary.Remove(towar);
            }
            towaryBindingSource.ResetBindings(false);
        }

        private void textBoxOpis_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodajDokument_Load(object sender, EventArgs e)
        {
            towaryBindingSource.DataSource = towary;
            listBoxListaTowarow.DataSource = towaryBindingSource;
            listBoxListaTowarow.DisplayMember = "FullInfo";
        }

        private void DodajDokument_Activated(object sender, EventArgs e)
        {
            towaryBindingSource.ResetBindings(false);
        }

        private void listBoxListaTowarow_DoubleClick(object sender, EventArgs e)
        {
            if (towary.Count > 0) {
                var Towar = towary[listBoxListaTowarow.SelectedIndex];                
                EdytujTowar = new DodajTowarDoDokumentu(true);
                EdytujTowar.EditData(Towar);
                EdytujTowar.ShowDialog();
            } 
        }

        private void textBoxCena_keyPress(object sender, KeyPressEventArgs e)
        {
            MenuWForms.NumericValuesOnly(sender, e);
        }
    }
}
