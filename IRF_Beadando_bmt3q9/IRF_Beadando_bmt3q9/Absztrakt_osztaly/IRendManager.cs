using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRF_Beadando_bmt3q9.Sajat_rendeles;

namespace IRF_Beadando_bmt3q9.Absztrakt_osztaly
{
    public interface IRendManager
    {
        BindingList<Sajat> Sajats { get; }

        Sajat CreateSajat(Sajat sajat);
    }
}
