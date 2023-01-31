using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeFinanse
{
    public class Towar : IDokument
    {
        private ConnectionHelper connection;
        public int IDzListyNaDokumencie { get; private set; }
        public int ID { get; private set; }
        public string Nazwa { get; set; }
        public float CenaDomyslna { get; set; }
        public float DomyslnyVat { get; set; }
        public string Opis { get; set; }
        public float Ilosc { get; set; }
        public string Jednostka { get; set; }
        public string NotFullInfo
        {
            get
            {
                return $"{ID} | {Nazwa} | {CenaDomyslna} | {DomyslnyVat} | {Jednostka} | {Opis}";
            }
        }
        public string FullInfo {
            get {
                return $"{ID} | {Nazwa} | {CenaDomyslna} | {DomyslnyVat} | {Ilosc} | {Jednostka} | {Opis}"; } 
        }

        public Towar()
        {
        }
        public Towar(string nazwa, float cenaDomyslna, float domyslnyVat, string opis, string jednostka)
        {
            connection = new ConnectionHelper();
            this.Nazwa = nazwa;
            this.CenaDomyslna = cenaDomyslna;
            this.DomyslnyVat = domyslnyVat;
            this.Opis = opis;
            this.Jednostka = jednostka;
        }
        public Towar(int ID, string nazwa, float cenaDomyslna, float domyslnyVat, string opis, string jednostka) 
            :this(nazwa,cenaDomyslna,domyslnyVat,opis,jednostka)
        {
            this.ID = ID;
        }
        public Towar(int IDnaDokumencie,int ID, string nazwa, float cenaDomyslna, float domyslnyVat, string opis, float ilosc, string jednostka) 
            :this(ID, nazwa, cenaDomyslna, domyslnyVat, opis, jednostka)
        {
            this.IDzListyNaDokumencie = IDnaDokumencie;
            this.Ilosc = ilosc;          
        }
        public void DodajDokument() {
            SqlParameter[] parameterList = {
                                            new SqlParameter("@Nazwa", this.Nazwa),
                                            new SqlParameter("@Cena", this.CenaDomyslna),
                                            new SqlParameter("@Vat", this.DomyslnyVat),
                                            new SqlParameter("@Opis", this.Opis),
                                            new SqlParameter("@Jednostka", this.Jednostka)};

            connection.OpenConnection("dbo.DodajTowar", parameterList);
        }
        public void EdytujDokument()
        {
            SqlParameter[] parameterList = {new SqlParameter("@ID", this.ID),
                                            new SqlParameter("@Nazwa", this.Nazwa),
                                            new SqlParameter("@Cena", this.CenaDomyslna),
                                            new SqlParameter("@Vat", this.DomyslnyVat),
                                            new SqlParameter("@Opis", this.Opis)};

            connection.OpenConnection("dbo.EdytujTowar", parameterList);
        }


        public void UsunDokument()
        {
            SqlParameter[] parameterList = { new SqlParameter("@ID", this.ID) };
            connection.OpenConnection("dbo.UsunTowar", parameterList);
        }

        public void UsunTowar()
        {
            SqlParameter[] parameterList = { new SqlParameter("@ID", this.IDzListyNaDokumencie) };
            connection.OpenConnection("dbo.UsunTowarND", parameterList);
        }
        
        public void DodajTowar(int IdDok)
        {
            SqlParameter[] parameterList = {
                                            new SqlParameter("@IDdok", IdDok),
                                            new SqlParameter("@TowarID", this.ID),
                                            new SqlParameter("@Cena", this.CenaDomyslna),
                                            new SqlParameter("@Vat", this.DomyslnyVat),
                                            new SqlParameter("@OpisTowaru", this.Opis),
                                            new SqlParameter("@Ilosc", this.Ilosc)};
            
            connection.OpenConnection("dbo.AddItemOnExistDoc", parameterList);
        }

        public void EdytujTowarND()
        {
            SqlParameter[] parameterList = {new SqlParameter("@ID", this.IDzListyNaDokumencie),
                                            new SqlParameter("@Nazwa", this.Nazwa),
                                            new SqlParameter("@Cena", this.CenaDomyslna),
                                            new SqlParameter("@Vat", this.DomyslnyVat),
                                            new SqlParameter("@Opis", this.Opis),
                                            new SqlParameter("@Ilosc", this.Ilosc) };                                            

            connection.OpenConnection("dbo.EdytujTowarND", parameterList);
        }
    }
}
