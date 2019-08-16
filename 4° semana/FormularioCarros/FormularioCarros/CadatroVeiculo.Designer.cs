namespace FormularioCarros
{
    partial class frmCadatroVeiculo
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
            this.label3 = new System.Windows.Forms.Label();
            this.maskedPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa:";
            // 
            // maskedPlaca
            // 
            this.maskedPlaca.Location = new System.Drawing.Point(313, 97);
            this.maskedPlaca.Mask = "aaa-9999";
            this.maskedPlaca.Name = "maskedPlaca";
            this.maskedPlaca.Size = new System.Drawing.Size(108, 22);
            this.maskedPlaca.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(95, 54);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(327, 22);
            this.txtModelo.TabIndex = 4;
            // 
            // cbAno
            // 
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(95, 90);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(121, 24);
            this.cbAno.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmCadatroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 199);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.maskedPlaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadatroVeiculo";
            this.Text = "Cadastro HBSIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Button button1;
    }
}