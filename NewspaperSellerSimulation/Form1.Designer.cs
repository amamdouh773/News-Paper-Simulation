namespace NewspaperSellerSimulation
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
            this.simulationSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simulationTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomNewsDayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newsDayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomDemandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lostProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrapProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyNetProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayNoDataGridViewTextBoxColumn,
            this.randomNewsDayTypeDataGridViewTextBoxColumn,
            this.newsDayTypeDataGridViewTextBoxColumn,
            this.randomDemandDataGridViewTextBoxColumn,
            this.demandDataGridViewTextBoxColumn,
            this.dailyCostDataGridViewTextBoxColumn,
            this.salesProfitDataGridViewTextBoxColumn,
            this.lostProfitDataGridViewTextBoxColumn,
            this.scrapProfitDataGridViewTextBoxColumn,
            this.dailyNetProfitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.simulationTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1071, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // simulationSystemBindingSource
            // 
            this.simulationSystemBindingSource.DataSource = typeof(NewspaperSellerModels.SimulationSystem);
            // 
            // simulationTableBindingSource
            // 
            this.simulationTableBindingSource.DataMember = "SimulationTable";
            this.simulationTableBindingSource.DataSource = this.simulationSystemBindingSource;
            // 
            // dayNoDataGridViewTextBoxColumn
            // 
            this.dayNoDataGridViewTextBoxColumn.DataPropertyName = "DayNo";
            this.dayNoDataGridViewTextBoxColumn.HeaderText = "DayNo";
            this.dayNoDataGridViewTextBoxColumn.Name = "dayNoDataGridViewTextBoxColumn";
            // 
            // randomNewsDayTypeDataGridViewTextBoxColumn
            // 
            this.randomNewsDayTypeDataGridViewTextBoxColumn.DataPropertyName = "RandomNewsDayType";
            this.randomNewsDayTypeDataGridViewTextBoxColumn.HeaderText = "RandomNewsDayType";
            this.randomNewsDayTypeDataGridViewTextBoxColumn.Name = "randomNewsDayTypeDataGridViewTextBoxColumn";
            // 
            // newsDayTypeDataGridViewTextBoxColumn
            // 
            this.newsDayTypeDataGridViewTextBoxColumn.DataPropertyName = "NewsDayType";
            this.newsDayTypeDataGridViewTextBoxColumn.HeaderText = "NewsDayType";
            this.newsDayTypeDataGridViewTextBoxColumn.Name = "newsDayTypeDataGridViewTextBoxColumn";
            // 
            // randomDemandDataGridViewTextBoxColumn
            // 
            this.randomDemandDataGridViewTextBoxColumn.DataPropertyName = "RandomDemand";
            this.randomDemandDataGridViewTextBoxColumn.HeaderText = "RandomDemand";
            this.randomDemandDataGridViewTextBoxColumn.Name = "randomDemandDataGridViewTextBoxColumn";
            // 
            // demandDataGridViewTextBoxColumn
            // 
            this.demandDataGridViewTextBoxColumn.DataPropertyName = "Demand";
            this.demandDataGridViewTextBoxColumn.HeaderText = "Demand";
            this.demandDataGridViewTextBoxColumn.Name = "demandDataGridViewTextBoxColumn";
            // 
            // dailyCostDataGridViewTextBoxColumn
            // 
            this.dailyCostDataGridViewTextBoxColumn.DataPropertyName = "DailyCost";
            this.dailyCostDataGridViewTextBoxColumn.HeaderText = "DailyCost";
            this.dailyCostDataGridViewTextBoxColumn.Name = "dailyCostDataGridViewTextBoxColumn";
            // 
            // salesProfitDataGridViewTextBoxColumn
            // 
            this.salesProfitDataGridViewTextBoxColumn.DataPropertyName = "SalesProfit";
            this.salesProfitDataGridViewTextBoxColumn.HeaderText = "SalesProfit";
            this.salesProfitDataGridViewTextBoxColumn.Name = "salesProfitDataGridViewTextBoxColumn";
            // 
            // lostProfitDataGridViewTextBoxColumn
            // 
            this.lostProfitDataGridViewTextBoxColumn.DataPropertyName = "LostProfit";
            this.lostProfitDataGridViewTextBoxColumn.HeaderText = "LostProfit";
            this.lostProfitDataGridViewTextBoxColumn.Name = "lostProfitDataGridViewTextBoxColumn";
            // 
            // scrapProfitDataGridViewTextBoxColumn
            // 
            this.scrapProfitDataGridViewTextBoxColumn.DataPropertyName = "ScrapProfit";
            this.scrapProfitDataGridViewTextBoxColumn.HeaderText = "ScrapProfit";
            this.scrapProfitDataGridViewTextBoxColumn.Name = "scrapProfitDataGridViewTextBoxColumn";
            // 
            // dailyNetProfitDataGridViewTextBoxColumn
            // 
            this.dailyNetProfitDataGridViewTextBoxColumn.DataPropertyName = "DailyNetProfit";
            this.dailyNetProfitDataGridViewTextBoxColumn.HeaderText = "DailyNetProfit";
            this.dailyNetProfitDataGridViewTextBoxColumn.Name = "dailyNetProfitDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 451);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationSystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomNewsDayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newsDayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomDemandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lostProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyNetProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource simulationTableBindingSource;
        private System.Windows.Forms.BindingSource simulationSystemBindingSource;
    }
}