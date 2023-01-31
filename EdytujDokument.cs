using DatowanieLibrary;
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
    public partial class EdytujDokument : Form
    {
        private Dokument dokument;
        private ListaDokumentowClass listaTowarow; 
        private List<Towar> towary;
        private static DodajTowarDoDokumentu EdytujTowar;

        public EdytujDokument(Dokument aDokument)
        {
            listaTowarow = new ListaDokumentowClass();
            this.dokument = aDokument;
            InitializeComponent();
            textBoxMiejsceZakupu.Text = dokument.MiejsceZakupu;
            textBoxCena.Text = dokument.Cena.ToString();
            //to niżej wjebać później do dll
            var i = dokument.DataDodania.ToString();
            var j = dokument.DataZakupu.ToString();
            string aDataDodania = ""+i[6] + i[7] + "." + i[4] + i[5] + "." + i[0] + i[1] + i[2] + i[3];
            var aDataZakupu = ""+j[6] + j[7] + "." + j[4] + j[5] + "." + j[0] + j[1] + j[2] + j[3];
            dateTimePickerDataDodania.Text = aDataDodania;
            dateTimePickerDataZakupu.Text = aDataZakupu;            
            textBoxUnikalnyKod.Text = dokument.UnikalnyKod;
            textBoxOpis.Text = dokument.Opis;
            listBoxRefreshing();
        }

        private void EdytujDokument_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonEdytujDokument_Click(object sender, EventArgs e)
        {
            dokument.MiejsceZakupu = textBoxMiejsceZakupu.Text;
            try
            {
                dokument.Cena = float.Parse(textBoxCena.Text);
            }
            //conception version
            catch(FormatException)
            {
                MessageBox.Show("Cena musi być w formacie numerycznym - cena nie zostanie zmieniona");
            }
            var DateOperation = new DatowanieClass(); 
            var dataDodania = DateOperation.DataWInt(dateTimePickerDataDodania.Text);
            var dataZakupu = DateOperation.DataWInt(dateTimePickerDataZakupu.Text);
            dokument.DataDodania = dataDodania;
            dokument.DataZakupu = dataZakupu;
            dokument.UnikalnyKod = textBoxUnikalnyKod.Text;
            dokument.Opis = textBoxOpis.Text;
            dokument.EdytujDokument();
            MessageBox.Show("Wyedytowano dokument");
            Close();
        }

        private void labelListaTowarow_Click(object sender, EventArgs e)
        {
        }

        private void buttonUsunTowar_Click(object sender, EventArgs e)
        {
            if (listBoxListaTowarow.SelectedItem != null)
            {
                var towar = towary[listBoxListaTowarow.SelectedIndex];
                towar.UsunTowar();
            }
            listBoxRefreshing();
        }

        private void EdytujDokument_Activated(object sender, EventArgs e)
        {
            listBoxRefreshing();
        }

        private void listBoxRefreshing()
        {
            towary = listaTowarow.getListaTowarowNaDokumencie(dokument.ID);
            listBoxListaTowarow.DataSource = towary;
            listBoxListaTowarow.DisplayMember = "FullInfo";
        }

        private void buttonDodajTowar_Click(object sender, EventArgs e)
        {
            var frm = new DodajTowarDoDokumentu(dokument);
            frm.ShowDialog();
        }

        private void buttonDodajTowar_DoubleClick(object sender, EventArgs e)
        {
            if (towary.Count > 0)
            {
                var Towar = towary[listBoxListaTowarow.SelectedIndex];
                EdytujTowar = new DodajTowarDoDokumentu(dokument, true);
                EdytujTowar.EditData(Towar);
                EdytujTowar.ShowDialog();
            }
        }
        
        private void textBoxCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            MenuWForms.NumericValuesOnly(sender, e);
        }
    }
}
