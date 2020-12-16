
namespace IRF_Beadando_bmt3q9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Hawaii_Pizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pepperonis_Pizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenger_Gyumolcsei_Pizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Házhozsszállítás = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Név = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telfonszám = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaadatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaadatokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Hawaii_Pizza,
            this.Pepperonis_Pizza,
            this.Tenger_Gyumolcsei_Pizza,
            this.Házhozsszállítás,
            this.Név,
            this.Telfonszám});
            this.dataGridView1.DataSource = this.rendelesekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(636, 239);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Hawaii_Pizza
            // 
            this.Hawaii_Pizza.DataPropertyName = "Hawaii_Pizza";
            this.Hawaii_Pizza.HeaderText = "Hawaii_Pizza";
            this.Hawaii_Pizza.Name = "Hawaii_Pizza";
            this.Hawaii_Pizza.ReadOnly = true;
            // 
            // Pepperonis_Pizza
            // 
            this.Pepperonis_Pizza.DataPropertyName = "Pepperonis_Pizza";
            this.Pepperonis_Pizza.HeaderText = "Pepperonis_Pizza";
            this.Pepperonis_Pizza.Name = "Pepperonis_Pizza";
            this.Pepperonis_Pizza.ReadOnly = true;
            // 
            // Tenger_Gyumolcsei_Pizza
            // 
            this.Tenger_Gyumolcsei_Pizza.DataPropertyName = "Tenger_Gyumolcsei_Pizza";
            this.Tenger_Gyumolcsei_Pizza.HeaderText = "Tenger_Gyumolcsei_Pizza";
            this.Tenger_Gyumolcsei_Pizza.Name = "Tenger_Gyumolcsei_Pizza";
            this.Tenger_Gyumolcsei_Pizza.ReadOnly = true;
            // 
            // Házhozsszállítás
            // 
            this.Házhozsszállítás.DataPropertyName = "Házhozsszállítás";
            this.Házhozsszállítás.HeaderText = "Házhozsszállítás";
            this.Házhozsszállítás.Name = "Házhozsszállítás";
            this.Házhozsszállítás.ReadOnly = true;
            // 
            // Név
            // 
            this.Név.DataPropertyName = "Név";
            this.Név.HeaderText = "Név";
            this.Név.Name = "Név";
            this.Név.ReadOnly = true;
            // 
            // Telfonszám
            // 
            this.Telfonszám.DataPropertyName = "Telfonszám";
            this.Telfonszám.HeaderText = "Telfonszám";
            this.Telfonszám.Name = "Telfonszám";
            this.Telfonszám.ReadOnly = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(762, 239);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(201, 199);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendelesekBindingSource
            // 
            this.rendelesekBindingSource.DataSource = typeof(IRF_Beadando_bmt3q9.Rendelesek);
            // 
            // pizzaadatokBindingSource
            // 
            this.pizzaadatokBindingSource.DataSource = typeof(IRF_Beadando_bmt3q9.Pizza_adatok);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaadatokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rendelesekBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hawaii_Pizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pepperonis_Pizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenger_Gyumolcsei_Pizza;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Házhozsszállítás;
        private System.Windows.Forms.DataGridViewTextBoxColumn Név;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telfonszám;
        private System.Windows.Forms.BindingSource pizzaadatokBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

