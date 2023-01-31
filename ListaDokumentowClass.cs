using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeFinanse
{
    //ta klasa świetnie się nadaje, żeby zrobić z niej .dll
    //posprzątać w niej, bo chaos
    class ListaDokumentowClass
    {
        public List<Dokument> listaDokumentow { get; set; }
        public List<Towar> listaTowarow { get; set; }
        public List<Dokument> getListaDokumentow()
        {
            var conn = new ConnectionHelper();
            string connectionString = conn.connectionString;
            string queryString = "dbo.WyswietlDokumenty";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                var lista = new List<Dokument>();
                while (reader.Read())
                {
                    lista.Add(new Dokument(int.Parse(reader[0].ToString()), reader[1].ToString(), float.Parse(reader[2].ToString()),
                         int.Parse(reader[3].ToString()), int.Parse(reader[4].ToString()), reader[5].ToString(), reader[6].ToString()));
                }
                connection.Close();
                listaDokumentow = lista;
                return lista;
            }
        }
        public List<Towar> getListaTowarow()
        {
            var conn = new ConnectionHelper();
            string connectionString = conn.connectionString;
            string queryString = "dbo.WyswietlTowary";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                var lista = new List<Towar>();
                while (reader.Read())
                {
                    lista.Add(new Towar(int.Parse(reader[0].ToString()), reader[1].ToString(), float.Parse(reader[2].ToString()),
                         float.Parse(reader[3].ToString()), reader[4].ToString(), reader[5].ToString()));
                }
                connection.Close();
                listaTowarow = lista;
                return lista;
            }
        }
        public List<Towar> getListaTowarowNaDokumencie(int id)
        {
            var conn = new ConnectionHelper();
            string connectionString = conn.connectionString;
            string queryString = "dbo.WyswietlTowaryNaDokumecie";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter[] parameter = { new SqlParameter("@dokID", id) };
                command.Parameters.AddRange(parameter);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                var lista = new List<Towar>();
                while (reader.Read())
                {
                    lista.Add(new Towar(int.Parse(reader[0].ToString()),int.Parse(reader[1].ToString()), reader[2].ToString(), float.Parse(reader[3].ToString()),
                         float.Parse(reader[4].ToString()), reader[5].ToString(), float.Parse(reader[6].ToString()), reader[7].ToString()));
                }
                connection.Close();
                listaTowarow = lista;
                return lista;
            }
        }

        public float Suma()
        {
            var suma = 0f;
            foreach(var Dok in listaDokumentow)
            {
                suma += Dok.Cena;
            }
            return suma;
        }
        
    }
}

