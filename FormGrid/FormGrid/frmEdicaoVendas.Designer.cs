namespace FormGrid
{
    partial class frmEdicaoVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdicaoVendas));
            this.cbCarro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.bancoDeDadosinnerJoinDataSet1 = new FormGrid.BancoDeDadosinnerJoinDataSet1();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrosTableAdapter = new FormGrid.BancoDeDadosinnerJoinDataSet1TableAdapters.CarrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosinnerJoinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCarro
            // 
            this.cbCarro.DataSource = this.carrosBindingSource;
            this.cbCarro.DisplayMember = "Modelo";
            this.cbCarro.FormattingEnabled = true;
            this.cbCarro.Location = new System.Drawing.Point(101, 27);
            this.cbCarro.Name = "cbCarro";
            this.cbCarro.Size = new System.Drawing.Size(310, 24);
            this.cbCarro.TabIndex = 0;
            this.cbCarro.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(101, 63);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(310, 22);
            this.txtQuantidade.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(101, 97);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(310, 22);
            this.txtValor.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(341, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 55);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalvar.BackgroundImage")));
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSalvar.Location = new System.Drawing.Point(265, 136);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(70, 55);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // bancoDeDadosinnerJoinDataSet1
            // 
            this.bancoDeDadosinnerJoinDataSet1.DataSetName = "BancoDeDadosinnerJoinDataSet1";
            this.bancoDeDadosinnerJoinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.bancoDeDadosinnerJoinDataSet1;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // frmEdicaoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCarro);
            this.Name = "frmEdicaoVendas";
            this.Text = "Edição de vendas";
            this.Load += new System.EventHandler(this.FrmEdicaoVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosinnerJoinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSalvar;
        private BancoDeDadosinnerJoinDataSet1 bancoDeDadosinnerJoinDataSet1;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private BancoDeDadosinnerJoinDataSet1TableAdapters.CarrosTableAdapter carrosTableAdapter;
    }
}