namespace SistemaDeAlunosForm
{
    partial class frmCadastroDeAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbIdade = new System.Windows.Forms.ComboBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(317, 22);
            this.txtNome.TabIndex = 2;
            // 
            // cbIdade
            // 
            this.cbIdade.FormattingEnabled = true;
            this.cbIdade.Location = new System.Drawing.Point(103, 79);
            this.cbIdade.Name = "cbIdade";
            this.cbIdade.Size = new System.Drawing.Size(317, 24);
            this.cbIdade.TabIndex = 3;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(103, 123);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(121, 32);
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.BtCadastrar_Click);
            // 
            // frmCadastroDeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 197);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.cbIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroDeAluno";
            this.Text = "Cadastro de Alunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbIdade;
        private System.Windows.Forms.Button btCadastrar;
    }
}