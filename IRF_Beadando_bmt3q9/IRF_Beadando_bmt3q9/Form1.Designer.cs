﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hawaiiPizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pepperonisPizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.névDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telfonszámDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.KosarbaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UjraBtn = new System.Windows.Forms.Button();
            this.RendelésBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.hawaiiPizzaDataGridViewTextBoxColumn,
            this.pepperonisPizzaDataGridViewTextBoxColumn,
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn,
            this.névDataGridViewTextBoxColumn,
            this.telfonszámDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rendelesekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(656, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hawaiiPizzaDataGridViewTextBoxColumn
            // 
            this.hawaiiPizzaDataGridViewTextBoxColumn.DataPropertyName = "Hawaii_Pizza";
            this.hawaiiPizzaDataGridViewTextBoxColumn.HeaderText = "Hawaii_Pizza";
            this.hawaiiPizzaDataGridViewTextBoxColumn.Name = "hawaiiPizzaDataGridViewTextBoxColumn";
            this.hawaiiPizzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pepperonisPizzaDataGridViewTextBoxColumn
            // 
            this.pepperonisPizzaDataGridViewTextBoxColumn.DataPropertyName = "Pepperonis_Pizza";
            this.pepperonisPizzaDataGridViewTextBoxColumn.HeaderText = "Pepperonis_Pizza";
            this.pepperonisPizzaDataGridViewTextBoxColumn.Name = "pepperonisPizzaDataGridViewTextBoxColumn";
            this.pepperonisPizzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tengerGyumolcseiPizzaDataGridViewTextBoxColumn
            // 
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn.DataPropertyName = "Tenger_Gyumolcsei_Pizza";
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn.HeaderText = "Tenger_Gyumolcsei_Pizza";
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn.Name = "tengerGyumolcseiPizzaDataGridViewTextBoxColumn";
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // névDataGridViewTextBoxColumn
            // 
            this.névDataGridViewTextBoxColumn.DataPropertyName = "Név";
            this.névDataGridViewTextBoxColumn.HeaderText = "Név";
            this.névDataGridViewTextBoxColumn.Name = "névDataGridViewTextBoxColumn";
            this.névDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telfonszámDataGridViewTextBoxColumn
            // 
            this.telfonszámDataGridViewTextBoxColumn.DataPropertyName = "Telfonszám";
            this.telfonszámDataGridViewTextBoxColumn.HeaderText = "Telfonszám";
            this.telfonszámDataGridViewTextBoxColumn.Name = "telfonszámDataGridViewTextBoxColumn";
            this.telfonszámDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendelesekBindingSource
            // 
            this.rendelesekBindingSource.DataSource = typeof(IRF_Beadando_bmt3q9.Rendelesek);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(702, 205);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(261, 217);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(656, 103);
            this.dataGridView2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 401);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 401);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(311, 401);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(473, 401);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(104, 20);
            this.textBox5.TabIndex = 9;
            // 
            // KosarbaBtn
            // 
            this.KosarbaBtn.Location = new System.Drawing.Point(598, 399);
            this.KosarbaBtn.Name = "KosarbaBtn";
            this.KosarbaBtn.Size = new System.Drawing.Size(98, 23);
            this.KosarbaBtn.TabIndex = 10;
            this.KosarbaBtn.Text = "Kosárba";
            this.KosarbaBtn.UseVisualStyleBackColor = true;
            this.KosarbaBtn.Click += new System.EventHandler(this.KosarbaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aktív rendelések";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Saját rendelés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hawaii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pepperonis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tenger Gyümölcsei";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Név";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefon";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(702, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 170);
            this.panel1.TabIndex = 18;
            // 
            // UjraBtn
            // 
            this.UjraBtn.Location = new System.Drawing.Point(888, 29);
            this.UjraBtn.Name = "UjraBtn";
            this.UjraBtn.Size = new System.Drawing.Size(75, 75);
            this.UjraBtn.TabIndex = 19;
            this.UjraBtn.Text = "Újra";
            this.UjraBtn.UseVisualStyleBackColor = true;
            this.UjraBtn.Click += new System.EventHandler(this.UjraBtn_Click);
            // 
            // RendelésBtn
            // 
            this.RendelésBtn.Location = new System.Drawing.Point(888, 124);
            this.RendelésBtn.Name = "RendelésBtn";
            this.RendelésBtn.Size = new System.Drawing.Size(75, 75);
            this.RendelésBtn.TabIndex = 20;
            this.RendelésBtn.Text = "Rendelés";
            this.RendelésBtn.UseVisualStyleBackColor = true;
            this.RendelésBtn.Click += new System.EventHandler(this.RendelesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.RendelésBtn);
            this.Controls.Add(this.UjraBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KosarbaBtn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button KosarbaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UjraBtn;
        private System.Windows.Forms.Button RendelésBtn;
        private System.Windows.Forms.BindingSource rendelesekBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hawaiiPizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pepperonisPizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengerGyumolcseiPizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn névDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telfonszámDataGridViewTextBoxColumn;
    }
}

