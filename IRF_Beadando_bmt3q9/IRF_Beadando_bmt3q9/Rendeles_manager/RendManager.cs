using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRF_Beadando_bmt3q9.Absztrakt_osztaly;
using IRF_Beadando_bmt3q9.Sajat_rendeles;

namespace IRF_Beadando_bmt3q9.Rendeles_manager
{
    public class RendManager : IRendManager
    {
        public BindingList<Sajat> Sajats { get; } = new BindingList<Sajat>();

        public Sajat CreateSajat(Sajat sajat)
        {
      
            Sajats.Add(sajat);

            return sajat;
        }
    }
}
