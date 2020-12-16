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
using IRF_Beadando_bmt3q9.Kontroller;

namespace IRF_Beadando_bmt3q9
{

    public partial class Form1 : Form
    {
        private RendelesKontroller _controller = new RendelesKontroller();
        Rendeles_DBEntities1 context = new Rendeles_DBEntities1();
        public Form1()
        {
            InitializeComponent();
            context.Rendeleseks.Load();
            rendelesekBindingSource.DataSource = context.Rendeleseks.Local;
            dataGridView2.DataSource = _controller.RendManager.Sajats;
           
            Diagram();
           

           


        }

   

        private void Diagram()
        {
            
      
        }

   

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Register(
                        int.Parse(textBox1.Text),
                        int.Parse(textBox2.Text),
                        int.Parse(textBox3.Text),
                        textBox4.Text,
                        textBox5.Text
                    );
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

     
    }
}
