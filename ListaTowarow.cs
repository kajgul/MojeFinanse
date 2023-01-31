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

    public partial class ListaTowarow : Form
    {
        private ListaDokumentowClass klasaListaTowarow;
        private Boolean doDokumentowFlag;
   
        public ListaTowarow()
        {
            InitializeComponent();
            doDokumentowFlag = false;
            klasaListaTowarow = new ListaDokumentowClass();
            //to można zrobić niżej za pomocą interfejsu
            listRefreshing();
        }

        public ListaTowarow(bool flag):this()
        {
            this.doDokumentowFlag = flag;
        }

        private void buttonDodajTowar_Click(object sender, EventArgs e)
        {
            Form frm = new DodajTowar();
            frm.Show();
        }

        private void buttonDokumenty_Click(object sender, EventArgs e)
        {
            if (!doDokumentowFlag)
            {
                Form frm = new ListaDokumentow();
                frm.Show();
            }
        }
        private void listRefreshing()
        {
            listTowarow.DataSource = klasaListaTowarow.getListaTowarow();
            listTowarow.DisplayMember = "NotFullInfo";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listRefreshing();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var Towar = klasaListaTowarow.listaTowarow[listTowarow.SelectedIndex];
            Towar.UsunDokument();
            MessageBox.Show("Usunięto dokument");
        }

        private void listTowarow_DoubleClick(object sender, EventArgs e)
        {
            var aTowar = klasaListaTowarow.listaTowarow[listTowarow.SelectedIndex];
            if (!doDokumentowFlag) {
                Form frm = new EdytujTowar(aTowar);
                frm.Show();
            }
            else
            {
                DodajTowarDoDokumentu.aDodajTowarDoDokumentu.AddData(aTowar);         
                this.Close();
            }
        }

        private void ListaTowarow_Activated(object sender, EventArgs e)
        {
            listRefreshing();
        }
    }
}
