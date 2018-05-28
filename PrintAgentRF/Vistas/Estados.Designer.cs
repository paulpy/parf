namespace PrintAgentRF.Vistas
{
    partial class Estados
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
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parestfDataSet = new PrintAgentRF.parestfDataSet();
            this.estadosTableAdapter = new PrintAgentRF.parestfDataSetTableAdapters.estadosTableAdapter();
            this.txbState = new System.Windows.Forms.TextBox();
            this.btnAddState = new System.Windows.Forms.Button();
            this.estadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvStates = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parestfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "estados";
            this.estadosBindingSource.DataSource = this.parestfDataSet;
            // 
            // parestfDataSet
            // 
            this.parestfDataSet.DataSetName = "parestfDataSet";
            this.parestfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // txbState
            // 
            this.txbState.Location = new System.Drawing.Point(407, 63);
            this.txbState.Name = "txbState";
            this.txbState.Size = new System.Drawing.Size(166, 22);
            this.txbState.TabIndex = 1;
            // 
            // btnAddState
            // 
            this.btnAddState.Location = new System.Drawing.Point(407, 112);
            this.btnAddState.Name = "btnAddState";
            this.btnAddState.Size = new System.Drawing.Size(166, 31);
            this.btnAddState.TabIndex = 2;
            this.btnAddState.Text = "Agregar Estado";
            this.btnAddState.UseVisualStyleBackColor = true;
            this.btnAddState.Click += new System.EventHandler(this.btnAddState_Click);
            // 
            // estadosBindingSource1
            // 
            this.estadosBindingSource1.DataSource = typeof(PrintAgentRF.Modelos.estados);
            // 
            // dgvStates
            // 
            this.dgvStates.AllowUserToAddRows = false;
            this.dgvStates.AllowUserToDeleteRows = false;
            this.dgvStates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStates.AutoGenerateColumns = false;
            this.dgvStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvStates.DataSource = this.estadosBindingSource;
            this.dgvStates.Location = new System.Drawing.Point(28, 22);
            this.dgvStates.Name = "dgvStates";
            this.dgvStates.ReadOnly = true;
            this.dgvStates.RowTemplate.Height = 24;
            this.dgvStates.Size = new System.Drawing.Size(360, 215);
            this.dgvStates.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadosBindingSource2
            // 
            this.estadosBindingSource2.DataSource = typeof(PrintAgentRF.Modelos.estados);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(407, 202);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 283);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvStates);
            this.Controls.Add(this.btnAddState);
            this.Controls.Add(this.txbState);
            this.Name = "Estados";
            this.Text = "Estados Posibles";
            this.Load += new System.EventHandler(this.Estados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parestfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private parestfDataSet parestfDataSet;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private parestfDataSetTableAdapters.estadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.BindingSource estadosBindingSource1;
        private System.Windows.Forms.TextBox txbState;
        private System.Windows.Forms.Button btnAddState;
        private System.Windows.Forms.DataGridView dgvStates;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource estadosBindingSource2;
        private System.Windows.Forms.Button btnBack;
    }
}