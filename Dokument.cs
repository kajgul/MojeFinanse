using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeFinanse
{
    //klasa paragony   
    public class Dokument : IDokument
    {
        //konstruktor bez ID jest używany do tworzenia tworzenia dokumentu bez listy towarowej
        public Dokument(string miejsceZakupu, float cena, int dataZakupu, int dataDodania, string unikalnyKod, string opis)
        {
            MiejsceZakupu = miejsceZakupu;
            Cena = cena;
            DataZakupu = dataZakupu;
            DataDodania = dataDodania;
            UnikalnyKod = unikalnyKod;
            Opis = opis;
            connection = new ConnectionHelper();
        }

        //konstruktor z ID jest używany do wyciągania dokumentów do listy w interfejsie użytkownika
        //wywołanie poprzedniego 
        public Dokument(int iD, string miejsceZakupu, float cena, int dataZakupu, int dataDodania, string unikalnyKod, string opis)
            :this(miejsceZakupu, cena, dataZakupu, dataDodania, unikalnyKod, opis)
        {
            ID = iD;
        }

        //konstruktor bez ID jest używany do tworzenia tworzenia dokumentu z listą towarową
        public Dokument(string miejsceZakupu, float cena, int dataZakupu, int dataDodania, string unikalnyKod, string opis, List<Towar> listaTowarowNaDokumencie)
            : this(miejsceZakupu, cena, dataZakupu, dataDodania, unikalnyKod, opis)
        {
            this.towaryNaDokumencie = listaTowarowNaDokumencie;
        }

        public void DodajDokument()
        {
            SqlParameter[] parameterList = {new SqlParameter("@miejsceZakupu", this.MiejsceZakupu),
                                            new SqlParameter("@CenaDokumentu", this.Cena),
                                            new SqlParameter("@DataDodania", this.DataDodania),
                                            new SqlParameter("@DataZakupu", this.DataZakupu),
                                            new SqlParameter("@UnikalnyKod", this.UnikalnyKod),
                                            new SqlParameter("@Opis", this.Opis)};

            connection.OpenConnection("dbo.DodajDokument", parameterList);
        }
        public void DodajDokumentZTowarami()
        {         
            foreach (Towar item in towaryNaDokumencie) {
                SqlParameter[] parameterList = {new SqlParameter("@miejsceZakupu", this.MiejsceZakupu),
                                                new SqlParameter("@CenaDokumentu", this.Cena),
                                                new SqlParameter("@DataDodania", this.DataDodania),
                                                new SqlParameter("@DataZakupu", this.DataZakupu),
                                                new SqlParameter("@UnikalnyKod", this.UnikalnyKod),
                                                new SqlParameter("@Opis", this.Opis),
                                                new SqlParameter("@userID", 1),
                                                new SqlParameter("@TowarID", item.ID),
                                                new SqlParameter("@Cena", item.CenaDomyslna),
                                                new SqlParameter("@Vat", item.DomyslnyVat),
                                                new SqlParameter("@OpisTowaru", item.Opis),
                                                new SqlParameter("@Ilosc", item.Ilosc)};

                connection.OpenConnection("dbo.OperacjeNaDokumentach", parameterList);
            }
            SqlParameter[] aParameterList = { };
            connection.OpenConnection("dbo.OperacjeNaDokumentach2", aParameterList);
        }

        public void EdytujDokument()
        {
            SqlParameter[] parameterList = {new SqlParameter("@ID", this.ID),
                                            new SqlParameter("@miejsceZakupu", this.MiejsceZakupu),
                                            new SqlParameter("@CenaDokumentu", this.Cena),
                                            new SqlParameter("@DataDodania", this.DataDodania),
                                            new SqlParameter("@DataZakupu", this.DataZakupu),
                                            new SqlParameter("@UnikalnyKod", this.UnikalnyKod),
                                            new SqlParameter("@Opis", this.Opis)};

            connection.OpenConnection("dbo.EdytujDokument", parameterList);
        }

        public void UsunDokument()
        {
            SqlParameter[] parameterList = { new SqlParameter("@ID", this.ID) };
            connection.OpenConnection("dbo.UsunDokument", parameterList);
        }

        public int ID { get; private set; }
        public string MiejsceZakupu { get; set; }
        public float Cena { get; set; }
        public int DataZakupu { get; set; }
        public int DataDodania { get; set; }
        public string UnikalnyKod { get; set; }
        public string Opis { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{ID} | {MiejsceZakupu} | {Cena} | {DataZakupu} | {UnikalnyKod} | {Opis}";
            }
        }
        private ConnectionHelper connection;
        public List<Towar> towaryNaDokumencie { get; set; }
    }
}
