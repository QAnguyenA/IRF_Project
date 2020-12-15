using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadando_bmt3q9
{
    
    public partial class Form1 : Form
    {
        Rendeles_DBEntities1 context = new Rendeles_DBEntities1();
        public Form1()
        {
            InitializeComponent();
            context.Rendeleseks.Load();
            rendelesekBindingSource.DataSource = context.Rendeleseks.Local;
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
