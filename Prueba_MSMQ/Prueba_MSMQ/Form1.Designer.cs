namespace Prueba_MSMQ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMsjeAEnviar = new System.Windows.Forms.Label();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.txtRecibir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMsjeAEnviar
            // 
            this.lblMsjeAEnviar.AutoSize = true;
            this.lblMsjeAEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjeAEnviar.Location = new System.Drawing.Point(23, 31);
            this.lblMsjeAEnviar.Name = "lblMsjeAEnviar";
            this.lblMsjeAEnviar.Size = new System.Drawing.Size(136, 19);
            this.lblMsjeAEnviar.TabIndex = 0;
            this.lblMsjeAEnviar.Text = "Mensaje a enviar";
            // 
            // txtEnviar
            // 
            this.txtEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnviar.Location = new System.Drawing.Point(171, 28);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(458, 26);
            this.txtEnviar.TabIndex = 1;
            this.txtEnviar.Text = "Texto de prueba";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(635, 25);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(113, 29);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnRecibir
            // 
            this.btnRecibir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibir.Location = new System.Drawing.Point(635, 80);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(113, 29);
            this.btnRecibir.TabIndex = 5;
            this.btnRecibir.Text = "Recibir";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // txtRecibir
            // 
            this.txtRecibir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibir.Location = new System.Drawing.Point(171, 83);
            this.txtRecibir.Name = "txtRecibir";
            this.txtRecibir.Size = new System.Drawing.Size(458, 26);
            this.txtRecibir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mensaje recibido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 176);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.txtRecibir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.lblMsjeAEnviar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsjeAEnviar;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.TextBox txtRecibir;
        private System.Windows.Forms.Label label1;
    }
}

