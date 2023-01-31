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
    public partial class DodajTowarDoDokumentu : Form
    {
        private static ListaTowarow ListaTowarow;
        internal static DodajTowarDoDokumentu aDodajTowarDoDokumentu;
        private Towar aTowar;
        private TextBox tbNazwa;
        private TextBox tbCena;
        private TextBox tbVat;
        private TextBox tbOpis;
        private TextBox tbIlosc;
        private TextBox tbJednostka;
        private bool edycjaTowaru;
        private bool edycjaDokumentu;
        private Dokument dokument;

        public DodajTowarDoDokumentu()
        {
            InitializeComponent();
            ListaTowarow = new ListaTowarow(true);
            aDodajTowarDoDokumentu = this;
            aTowar = new Towar();
            tbNazwa = textBoxNazwa;
            tbCena = textBoxCenaBrutto;
            tbVat = textBoxVAT;
            tbOpis = textBoxOpis;
            tbIlosc = textBoxIlosc;
            tbJednostka = textBoxJednostka;
            edycjaTowaru = false;
            edycjaDokumentu = false;
        }
        public DodajTowarDoDokumentu(bool edycjaTowaru)
        {
            this.edycjaTowaru = edycjaTowaru;
            InitializeComponent();
            Text = "Edytuj Towar";
            buttonDodajTowar.Text = "Edytuj Towar";
            tbNazwa = textBoxNazwa;
            tbCena = textBoxCenaBrutto;
            tbVat = textBoxVAT;
            tbOpis = textBoxOpis;
            tbIlosc = textBoxIlosc;
            tbJednostka = textBoxJednostka;
            edycjaDokumentu = false;
        }
        public DodajTowarDoDokumentu(Dokument dokument):this()
        {
            this.dokument = dokument;
            edycjaDokumentu = true;
        }
        public DodajTowarDoDokumentu(Dokument dokument, bool edycjaTowaru) : this(edycjaTowaru:edycjaTowaru)
        {
            this.dokument = dokument;
            edycjaDokumentu = true;
        }
   
        private void buttonWybierzTowar_Click(object sender, EventArgs e)
        {
            if(edycjaTowaru == false) ListaTowarow.ShowDialog();
        }

        private void buttonDodajTowar_Click(object sender, EventArgs e)
        {
            if (edycjaDokumentu == true)
            {
                if (!edycjaTowaru) {
                    //var aEdytujDokument = new EdytujDokument(dokument);
                    aTowar.CenaDomyslna = float.Parse(textBoxCenaBrutto.Text);
                    aTowar.DomyslnyVat = float.Parse(textBoxVAT.Text);
                    aTowar.Opis = textBoxOpis.Text;
                    aTowar.Ilosc = float.Parse(textBoxIlosc.Text);                  
                    aTowar.DodajTowar(dokument.ID);
                    this.Close();
                }
                else {
                    aTowar.CenaDomyslna = float.Parse(textBoxCenaBrutto.Text);
                    aTowar.DomyslnyVat = float.Parse(textBoxVAT.Text);
                    aTowar.Opis = textBoxOpis.Text;
                    aTowar.Ilosc = float.Parse(textBoxIlosc.Text);   
                    aTowar.EdytujTowarND();
                    this.Close();
                }
            }
            else
            {
                if (edycjaTowaru)
                {
                    aTowar.CenaDomyslna = float.Parse(textBoxCenaBrutto.Text);
                    aTowar.DomyslnyVat = float.Parse(textBoxVAT.Text);
                    aTowar.Opis = textBoxOpis.Text;
                    aTowar.Ilosc = float.Parse(textBoxIlosc.Text);
                    this.Close();
                }
                else
                {
                    var aDodajDokument = new DodajDokument();
                    aTowar.CenaDomyslna = float.Parse(textBoxCenaBrutto.Text);
                    aTowar.DomyslnyVat = float.Parse(textBoxVAT.Text);
                    aTowar.Opis = textBoxOpis.Text;
                    aTowar.Ilosc = float.Parse(textBoxIlosc.Text);
                    aDodajDokument.ReceiveData(aTowar);
                    this.Close();
                }
            }
        }

        internal void AddData(Towar aTowar)
        {
            this.aTowar = aTowar;
            tbNazwa.Text = aTowar.Nazwa;
            tbCena.Text = aTowar.CenaDomyslna.ToString();
            tbVat.Text = aTowar.DomyslnyVat.ToString();
            tbOpis.Text = aTowar.Opis;
            tbIlosc.Text = aTowar.Ilosc.ToString();
            tbJednostka.Text = aTowar.Jednostka;
        }

        internal void EditData(Towar eTowar)
        {
            this.aTowar = eTowar;
            tbNazwa.Text = eTowar.Nazwa;
            tbCena.Text = eTowar.CenaDomyslna.ToString();
            tbVat.Text = eTowar.DomyslnyVat.ToString();
            tbOpis.Text = eTowar.Opis;
            tbIlosc.Text = eTowar.Ilosc.ToString();
            tbJednostka.Text = eTowar.Jednostka;
        }

        private void buttonOdśwież_Click(object sender, EventArgs e) { }
        private void DodajTowarDoDokumentu_Load(object sender, EventArgs e) {
            textBoxAll.Text = (aTowar.Ilosc * aTowar.CenaDomyslna).ToString();
        }
        private void DodajTowarDoDokumentu_Activated(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAll_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCenaZa1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MenuWForms.NumericValuesOnly(sender, e);
        }

        private void textBoxIlosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            MenuWForms.NumericValuesOnly(sender, e);
        }

        private void textBoxPriceAll_KeyPress(object sender, KeyPressEventArgs e)
        {
            MenuWForms.NumericValuesOnly(sender, e);
        }
    }
}
