
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rendelesekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rendelesDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rendeles_DBDataSet = new IRF_Beadando_bmt3q9.Rendeles_DBDataSet();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hawaiiPizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pepperonisPizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.házhozsszállításDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.névDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telfonszámDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendeles_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.hawaiiPizzaDataGridViewTextBoxColumn,
            this.pepperonisPizzaDataGridViewTextBoxColumn,
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn,
            this.házhozsszállításDataGridViewCheckBoxColumn,
            this.névDataGridViewTextBoxColumn,
            this.telfonszámDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rendelesekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // rendelesekBindingSource
            // 
            this.rendelesekBindingSource.DataMember = "Rendelesek";
            this.rendelesekBindingSource.DataSource = this.rendelesDBDataSetBindingSource;
            // 
            // rendelesDBDataSetBindingSource
            // 
            this.rendelesDBDataSetBindingSource.DataSource = this.rendeles_DBDataSet;
            this.rendelesDBDataSetBindingSource.Position = 0;
            // 
            // rendeles_DBDataSet
            // 
            this.rendeles_DBDataSet.DataSetName = "Rendeles_DBDataSet";
            this.rendeles_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.hawaiiPizzaDataGridViewTextBoxColumn.DataPropertyName = "Hawaii Pizza";
            this.hawaiiPizzaDataGridViewTextBoxColumn.HeaderText = "Hawaii Pizza";
            this.hawaiiPizzaDataGridViewTextBoxColumn.Name = "hawaiiPizzaDataGridViewTextBoxColumn";
            this.hawaiiPizzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pepperonisPizzaDataGridViewTextBoxColumn
            // 
            this.pepperonisPizzaDataGridViewTextBoxColumn.DataPropertyName = "Pepperonis Pizza";
            this.pepperonisPizzaDataGridViewTextBoxColumn.HeaderText = "Pepperonis Pizza";
            this.pepperonisPizzaDataGridViewTextBoxColumn.Name = "pepperonisPizzaDataGridViewTextBoxColumn";
            this.pepperonisPizzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tengerGyumolcseiPizzaDataGridViewTextBoxColumn
            // 
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn.DataPropertyName = "Tenger Gyumolcsei Pizza";
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn.HeaderText = "Tenger Gyumolcsei Pizza";
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn.Name = "tengerGyumolcseiPizzaDataGridViewTextBoxColumn";
            this.tengerGyumolcseiPizzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // házhozsszállításDataGridViewCheckBoxColumn
            // 
            this.házhozsszállításDataGridViewCheckBoxColumn.DataPropertyName = "Házhozsszállítás";
            this.házhozsszállításDataGridViewCheckBoxColumn.HeaderText = "Házhozsszállítás";
            this.házhozsszállításDataGridViewCheckBoxColumn.Name = "házhozsszállításDataGridViewCheckBoxColumn";
            this.házhozsszállításDataGridViewCheckBoxColumn.ReadOnly = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendeles_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rendelesDBDataSetBindingSource;
        private Rendeles_DBDataSet rendeles_DBDataSet;
        private System.Windows.Forms.BindingSource rendelesekBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hawaiiPizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pepperonisPizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengerGyumolcseiPizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn házhozsszállításDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn névDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telfonszámDataGridViewTextBoxColumn;
    }
}

