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
using System.Windows.Forms.DataVisualization.Charting;

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
            Pizzalista();
            Diagram();
           

            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Nev";


        }

        private void Pizzalista()
        {
            var lista = from x in context.Pizza_nev
                        select x;

            listBox1.DataSource = lista.ToList();
        }

        private void Diagram()
        {
            chart1.DataSource = pizzaadatokBindingSource.DataSource;

      
        }

   

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
