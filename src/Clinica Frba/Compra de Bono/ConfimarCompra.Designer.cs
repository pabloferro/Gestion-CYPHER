namespace Clinica_Frba.Compra_de_Bono
{
    partial class ConfimarCompra
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
            this.label_Texto_PrecioTotal = new System.Windows.Forms.Label();
            this.button_Si = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.label_Texto = new System.Windows.Forms.Label();
            this.label_Precio = new System.Windows.Forms.Label();
            this.label_Text_Afiliado = new System.Windows.Forms.Label();
            this.label_Afiliado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Texto_PrecioTotal
            // 
            this.label_Texto_PrecioTotal.AutoSize = true;
            this.label_Texto_PrecioTotal.Location = new System.Drawing.Point(36, 55);
            this.label_Texto_PrecioTotal.Name = "label_Texto_PrecioTotal";
            this.label_Texto_PrecioTotal.Size = new System.Drawing.Size(70, 13);
            this.label_Texto_PrecioTotal.TabIndex = 0;
            this.label_Texto_PrecioTotal.Text = "Precio Total :";
            // 
            // button_Si
            // 
            this.button_Si.Location = new System.Drawing.Point(174, 78);
            this.button_Si.Name = "button_Si";
            this.button_Si.Size = new System.Drawing.Size(75, 23);
            this.button_Si.TabIndex = 1;
            this.button_Si.Text = "Si";
            this.button_Si.UseVisualStyleBackColor = true;
            this.button_Si.Click += new System.EventHandler(this.button_Si_Click);
            // 
            // button_No
            // 
            this.button_No.Location = new System.Drawing.Point(274, 77);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(75, 23);
            this.button_No.TabIndex = 2;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // label_Texto
            // 
            this.label_Texto.AutoSize = true;
            this.label_Texto.Location = new System.Drawing.Point(67, 4);
            this.label_Texto.Name = "label_Texto";
            this.label_Texto.Size = new System.Drawing.Size(146, 13);
            this.label_Texto.TabIndex = 3;
            this.label_Texto.Text = "Desea Confirmar Su Compra?";
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Location = new System.Drawing.Point(123, 55);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(0, 13);
            this.label_Precio.TabIndex = 4;
            // 
            // label_Text_Afiliado
            // 
            this.label_Text_Afiliado.AutoSize = true;
            this.label_Text_Afiliado.Location = new System.Drawing.Point(39, 25);
            this.label_Text_Afiliado.Name = "label_Text_Afiliado";
            this.label_Text_Afiliado.Size = new System.Drawing.Size(47, 13);
            this.label_Text_Afiliado.TabIndex = 5;
            this.label_Text_Afiliado.Text = "Afiliado :";
            // 
            // label_Afiliado
            // 
            this.label_Afiliado.AutoSize = true;
            this.label_Afiliado.Location = new System.Drawing.Point(126, 25);
            this.label_Afiliado.Name = "label_Afiliado";
            this.label_Afiliado.Size = new System.Drawing.Size(0, 13);
            this.label_Afiliado.TabIndex = 6;
            // 
            // ConfimarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 113);
            this.Controls.Add(this.label_Afiliado);
            this.Controls.Add(this.label_Text_Afiliado);
            this.Controls.Add(this.label_Precio);
            this.Controls.Add(this.label_Texto);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Si);
            this.Controls.Add(this.label_Texto_PrecioTotal);
            this.Name = "ConfimarCompra";
            this.Text = "ConfimarCompra";
            this.Load += new System.EventHandler(this.ConfimarCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Texto_PrecioTotal;
        private System.Windows.Forms.Button button_Si;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Label label_Texto;
        private System.Windows.Forms.Label label_Precio;
        private System.Windows.Forms.Label label_Text_Afiliado;
        private System.Windows.Forms.Label label_Afiliado;
    }
}