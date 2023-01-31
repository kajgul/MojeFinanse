using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatowanieLibrary;

namespace MojeFinanse
{
    //poprawić
    public partial class ListaDokumentow : Form
    {       
        private ListaDokumentowClass klasaLista;
        private List<Dokument> aDokumenty;
        private float Suma;
        string docDetails = "{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}";

        public ListaDokumentow()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
            klasaLista = new ListaDokumentowClass();
            listBoxRefreshing();
        }

        private void buttonDodajNowyDokument_Click(object sender, EventArgs e)
        {
            Form frm = new DodajDokument();
            frm.Show();
        }

        private void buttonDokumenty_Click(object sender, EventArgs e)
        {
            listBoxRefreshing();
        }

        private void buttonTowary_Click(object sender, EventArgs e)
        {
            Form frm = new ListaTowarow();
            frm.Show();
        }

        private void listDokumentow_DoubleClick(object sender, EventArgs e)
        {
            if (listDokumentow.SelectedItem != null)
            {
                var Dokument = klasaLista.listaDokumentow[listDokumentow.SelectedIndex];
                Form frm = new EdytujDokument(Dokument);
                frm.Show();
            }
            
        }
        private void listBoxRefreshing()
        {
            var aSortingDocuments = new SortingDocuments();
            aDokumenty = aSortingDocuments.ModifyedListByYear(klasaLista.getListaDokumentow(), dateTimePicker1.Text);
            listDokumentow.DataSource = aDokumenty;
            listDokumentow.DisplayMember = "FullInfo";
            Suma = aSortingDocuments.aListaSuma();
            textBoxSuma.Text = Suma.ToString();
            comboBoxMiesiac.Text = "wszystkie";
        }
        
        
        private void buttonOdswiez_Click(object sender, EventArgs e)
        {
        }
        private void buttonUsunDokument_Click(object sender, EventArgs e)
        {
            if (listDokumentow.SelectedItem != null)
            {
                var Dokument = klasaLista.listaDokumentow[listDokumentow.SelectedIndex];
                Dokument.UsunDokument();
                MessageBox.Show("Usunięto dokument");
                listBoxRefreshing();
            }
        }

        private void ListaDokumentow_Activated(object sender, EventArgs e)
        {
            listBoxRefreshing();
            //textBoxSuma.Text = Suma.ToString();
        }

        private void comboBoxMiesiac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var month = comboBoxMiesiac.Text;
            if (month != "wszystkie")
            {
                var aLista = aDokumenty;
                var aSortingDocuments = new SortingDocuments();
                listDokumentow.DataSource = aSortingDocuments.ModifyedListByMonth(aLista, Months.MonthNumber(month));
                Suma = aSortingDocuments.aListaSuma();
                textBoxSuma.Text = Suma.ToString();
            }
            else
            {
                listBoxRefreshing();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBoxMiesiac.Text = "wszystkie";
            var year = dateTimePicker1.Text;
            var aLista = klasaLista.listaDokumentow;
            var aSortingDocuments = new SortingDocuments();
            aDokumenty = aSortingDocuments.ModifyedListByYear(aLista, year);
            listDokumentow.DataSource = aDokumenty; 
            Suma = aSortingDocuments.aListaSuma();
            textBoxSuma.Text = Suma.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListaDokumentow_Load(object sender, EventArgs e)
        {
            listDokumentow.Items.Add(String.Format(docDetails, "ID", "Miejsce Zakupu", "Data Zakupu", "Unikalny Kod", "Opis"));
        }
    }
}
