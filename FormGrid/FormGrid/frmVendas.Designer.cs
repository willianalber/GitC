namespace FormGrid
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDeDadosinnerJoinDataSet1 = new FormGrid.BancoDeDadosinnerJoinDataSet1();
            this.vendasTableAdapter = new FormGrid.BancoDeDadosinnerJoinDataSet1TableAdapters.VendasTableAdapter();
            this.DeletCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosinnerJoinDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeletCommand,
            this.Alterar,
            this.idDataGridViewTextBoxColumn,
            this.carroDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.usuIncDataGridViewTextBoxColumn,
            this.usuAltDataGridViewTextBoxColumn,
            this.datIncDataGridViewTextBoxColumn,
            this.datAltDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1379, 547);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 91);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "Vendas";
            this.vendasBindingSource.DataSource = this.bancoDeDadosinnerJoinDataSet1;
            // 
            // bancoDeDadosinnerJoinDataSet1
            // 
            this.bancoDeDadosinnerJoinDataSet1.DataSetName = "BancoDeDadosinnerJoinDataSet1";
            this.bancoDeDadosinnerJoinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // DeletCommand
            // 
            this.DeletCommand.DataPropertyName = "DeletCommand";
            this.DeletCommand.HeaderText = "Deletar";
            this.DeletCommand.MinimumWidth = 6;
            this.DeletCommand.Name = "DeletCommand";
            this.DeletCommand.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeletCommand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeletCommand.Width = 125;
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.MinimumWidth = 6;
            this.Alterar.Name = "Alterar";
            this.Alterar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Alterar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseColumnTextForButtonValue = true;
            this.Alterar.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // carroDataGridViewTextBoxColumn
            // 
            this.carroDataGridViewTextBoxColumn.DataPropertyName = "Carro";
            this.carroDataGridViewTextBoxColumn.HeaderText = "Carro";
            this.carroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carroDataGridViewTextBoxColumn.Name = "carroDataGridViewTextBoxColumn";
            this.carroDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // usuIncDataGridViewTextBoxColumn
            // 
            this.usuIncDataGridViewTextBoxColumn.DataPropertyName = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.HeaderText = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuIncDataGridViewTextBoxColumn.Name = "usuIncDataGridViewTextBoxColumn";
            this.usuIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuAltDataGridViewTextBoxColumn
            // 
            this.usuAltDataGridViewTextBoxColumn.DataPropertyName = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.HeaderText = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuAltDataGridViewTextBoxColumn.Name = "usuAltDataGridViewTextBoxColumn";
            this.usuAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // datIncDataGridViewTextBoxColumn
            // 
            this.datIncDataGridViewTextBoxColumn.DataPropertyName = "DatInc";
            this.datIncDataGridViewTextBoxColumn.HeaderText = "DatInc";
            this.datIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datIncDataGridViewTextBoxColumn.Name = "datIncDataGridViewTextBoxColumn";
            this.datIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // datAltDataGridViewTextBoxColumn
            // 
            this.datAltDataGridViewTextBoxColumn.DataPropertyName = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.HeaderText = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datAltDataGridViewTextBoxColumn.Name = "datAltDataGridViewTextBoxColumn";
            this.datAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosinnerJoinDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private BancoDeDadosinnerJoinDataSet1 bancoDeDadosinnerJoinDataSet1;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private BancoDeDadosinnerJoinDataSet1TableAdapters.VendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn DeletCommand;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn;
    }
}