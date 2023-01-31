using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeFinanse
{
    interface IDokument
    {
        int ID { get; }
        string FullInfo { get; }
        void DodajDokument();
        void EdytujDokument();
        void UsunDokument();
    }
}
