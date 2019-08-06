namespace MVCProject.View.Adicionar
{
    partial class frmAdicionarLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarLivro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.generoTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.GeneroTableAdapter();
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editoraTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.EditoraTableAdapter();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sinopse:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Editora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gênero:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "ISBN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Observações:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(114, 30);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(317, 22);
            this.txtRegistro.TabIndex = 9;
            this.txtRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRegistro_KeyPress);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(114, 59);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(317, 22);
            this.txtTitulo.TabIndex = 10;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(114, 87);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(317, 22);
            this.txtTipo.TabIndex = 11;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(114, 115);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(317, 69);
            this.txtDescricao.TabIndex = 12;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(114, 190);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(317, 22);
            this.txtISBN.TabIndex = 13;
            // 
            // cbGenero
            // 
            this.cbGenero.DataSource = this.generoBindingSource;
            this.cbGenero.DisplayMember = "Nome";
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(114, 218);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(317, 24);
            this.cbGenero.TabIndex = 15;
            this.cbGenero.ValueMember = "Id";
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // cbEditora
            // 
            this.cbEditora.DataSource = this.editoraBindingSource;
            this.cbEditora.DisplayMember = "Nome";
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(114, 248);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(317, 24);
            this.cbEditora.TabIndex = 16;
            this.cbEditora.ValueMember = "Id";
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataMember = "Editora";
            this.editoraBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // editoraTableAdapter
            // 
            this.editoraTableAdapter.ClearBeforeFill = true;
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(114, 278);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(317, 76);
            this.txtSinopse.TabIndex = 17;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(115, 364);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(317, 76);
            this.txtObservacoes.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(351, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 61);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdicionarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(799, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.cbEditora);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdicionarLivro";
            this.Text = "Adicionar um Livro.";
            this.Load += new System.EventHandler(this.FrmAdicionarLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.ComboBox cbGenero;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.ComboBox cbEditora;
        private System.Windows.Forms.BindingSource editoraBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.EditoraTableAdapter editoraTableAdapter;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}