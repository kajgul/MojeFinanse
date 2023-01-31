using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeFinanse
{
    class SortingDocuments
    {
        private float aSuma;
        public SortingDocuments()
        {
            aSuma = 0;
        }
        internal List<Dokument> ModifyedListByMonth(List<Dokument> listaDokumentow, string month)
        {
            var listaZwrotna = new List<Dokument>();
            foreach (var Dok in listaDokumentow)
            {
                var dokData = Dok.DataZakupu.ToString();
                var aDokData = dokData[4].ToString() + dokData[5].ToString();
                if(aDokData == month)
                {
                    listaZwrotna.Add(Dok);
                    aSuma += Dok.Cena;
                }
            }
            return listaZwrotna;
        }
        internal List<Dokument> ModifyedListByYear(List<Dokument> listaDokumentow, string year)
        {
            var listaZwrotna = new List<Dokument>();
            foreach (var Dok in listaDokumentow)
            {
                var dokData = Dok.DataZakupu.ToString();
                var aDokData = dokData[0].ToString() + dokData[1].ToString() + dokData[2].ToString() + dokData[3].ToString();
                if (aDokData == year)
                {
                    listaZwrotna.Add(Dok);
                    aSuma += Dok.Cena;
                }
            }
           return listaZwrotna;
        }

        internal float aListaSuma()
        {
            return aSuma;
        }
    }
}
