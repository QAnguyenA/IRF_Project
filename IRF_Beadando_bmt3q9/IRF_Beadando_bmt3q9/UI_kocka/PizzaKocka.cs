using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadando_bmt3q9.UI_kocka
{
    class PizzaKocka:Button
    {
        public PizzaKocka()
        {
            Height = 20;
            Width = Height;
            BackColor = Color.Red;
            MouseDown += PizzaKocka_MouseDown;
        }

        private void PizzaKocka_MouseDown(object sender, MouseEventArgs e)
        {
            Visible = false;
        }
    }
}
