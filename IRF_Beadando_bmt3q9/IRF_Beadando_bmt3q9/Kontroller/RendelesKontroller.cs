using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRF_Beadando_bmt3q9.Absztrakt_osztaly;
using IRF_Beadando_bmt3q9.Rendeles_manager;
using IRF_Beadando_bmt3q9.Sajat_rendeles;

namespace IRF_Beadando_bmt3q9.Kontroller
{
    public class RendelesKontroller
    {
        public IRendManager RendManager { get; set; }

        public RendelesKontroller()
        {
            RendManager = new RendManager();
        }

        public Sajat Register(int h_szama, int p_szama, int t_szama, string nev, string telefonszam)
        {
            if (!Validatenev(nev))
                throw new ValidationException(
                    "A megadott név nem megfelelő!");
            if (!ValidateTelefon(telefonszam))
                throw new ValidationException(
                    "A megadott telefonszám nem megfelelő!");
            var sajat = new Sajat()
            {
                hawaii_szama=h_szama,
                pepperonis_szama=p_szama,
                tgyumolcs_szama=t_szama,
                nev=nev,
                telefonszam=telefonszam

            };

            var ujrendeles = RendManager.CreateSajat(sajat);
            return ujrendeles;
        }

        public bool Validatenev(string nev)
        {
            return true;
        }

        public bool ValidateTelefon(string telefonszam)
        {
            return true;
        }
        
    }
}
