namespace Clinica_Frba.Compra_De_Bono
{
    partial class CompraBonosWindow
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
            this.textBoxAfiliado = new System.Windows.Forms.TextBox();
            this.textBoxCantBonoC = new System.Windows.Forms.TextBox();
            this.textBoxCantBonoF = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.label_Text_Afiliado = new System.Windows.Forms.Label();
            this.label_Text_Consulta = new System.Windows.Forms.Label();
            this.label_Text_Farmacia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAfiliado
            // 
            this.textBoxAfiliado.Location = new System.Drawing.Point(139, 25);
            this.textBoxAfiliado.Name = "textBoxAfiliado";
            this.textBoxAfiliado.Size = new System.Drawing.Size(100, 20);
            this.textBoxAfiliado.TabIndex = 0;
            // 
            // textBoxCantBonoC
            // 
            this.textBoxCantBonoC.Location = new System.Drawing.Point(213, 83);
            this.textBoxCantBonoC.Name = "textBoxCantBonoC";
            this.textBoxCantBonoC.Size = new System.Drawing.Size(26, 20);
            this.textBoxCantBonoC.TabIndex = 1;
            // 
            // textBoxCantBonoF
            // 
            this.textBoxCantBonoF.Location = new System.Drawing.Point(213, 134);
            this.textBoxCantBonoF.Name = "textBoxCantBonoF";
            this.textBoxCantBonoF.Size = new System.Drawing.Size(26, 20);
            this.textBoxCantBonoF.TabIndex = 2;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(54, 179);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(142, 22);
            this.buttonConfirmar.TabIndex = 3;
            this.buttonConfirmar.Text = "Confirmar Transaccion";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(94, 9);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 4;
            // 
            // label_Text_Afiliado
            // 
            this.label_Text_Afiliado.AutoSize = true;
            this.label_Text_Afiliado.Location = new System.Drawing.Point(33, 25);
            this.label_Text_Afiliado.Name = "label_Text_Afiliado";
            this.label_Text_Afiliado.Size = new System.Drawing.Size(47, 13);
            this.label_Text_Afiliado.TabIndex = 5;
            this.label_Text_Afiliado.Text = "Afiliado: ";
            // 
            // label_Text_Consulta
            // 
            this.label_Text_Consulta.AutoSize = true;
            this.label_Text_Consulta.Location = new System.Drawing.Point(33, 86);
            this.label_Text_Consulta.Name = "label_Text_Consulta";
            this.label_Text_Consulta.Size = new System.Drawing.Size(126, 13);
            this.label_Text_Consulta.TabIndex = 6;
            this.label_Text_Consulta.Text = "Cantidad Bonos Consulta";
            // 
            // label_Text_Farmacia
            // 
            this.label_Text_Farmacia.AutoSize = true;
            this.label_Text_Farmacia.Location = new System.Drawing.Point(33, 141);
            this.label_Text_Farmacia.Name = "label_Text_Farmacia";
            this.label_Text_Farmacia.Size = new System.Drawing.Size(128, 13);
            this.label_Text_Farmacia.TabIndex = 7;
            this.label_Text_Farmacia.Text = "Cantidad Bonos Farmacia";
            // 
            // CompraBonosWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 222);
            this.Controls.Add(this.label_Text_Farmacia);
            this.Controls.Add(this.label_Text_Consulta);
            this.Controls.Add(this.label_Text_Afiliado);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxCantBonoF);
            this.Controls.Add(this.textBoxCantBonoC);
            this.Controls.Add(this.textBoxAfiliado);
            this.Name = "CompraBonosWindow";
            this.Text = "Compra Bonos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAfiliado;
        private System.Windows.Forms.TextBox textBoxCantBonoC;
        private System.Windows.Forms.TextBox textBoxCantBonoF;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label_Text_Afiliado;
        private System.Windows.Forms.Label label_Text_Consulta;
        private System.Windows.Forms.Label label_Text_Farmacia;
    }
}