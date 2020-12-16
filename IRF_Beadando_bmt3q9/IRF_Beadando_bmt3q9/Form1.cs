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
using IRF_Beadando_bmt3q9.UI_kocka;

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
            PizzaKep();
           
          

        }

        private void PizzaKep()
        {
            
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    PizzaKocka sf = new PizzaKocka();
                    sf.Left = col * sf.Width;
                    sf.Top = row * sf.Height;
                    if((col % 2 & row % 2)==0)
                    {
                        sf.BackColor = Color.Yellow;
                    }
                    panel1.Controls.Add(sf);
                }
            }
        }

   

        private void Diagram()
        {
           
            chart1.Series["Series1"].Points.AddXY(label3.Text, textBox1.Text);
            chart1.Series["Series1"].Points.AddXY(label4.Text, textBox2.Text);
            chart1.Series["Series1"].Points.AddXY(label5.Text, textBox3.Text);

            chart1.Series[0]["PieLabelStyle"] = "Disabled";

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
                Diagram();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            PizzaKep();
            
            
        }

      
    }
}
