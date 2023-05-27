namespace Prueba_MSMQ_Transacciones
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
            this.btnRecibir = new System.Windows.Forms.Button();
            this.txtRecibir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.lblMsjeAEnviar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRecibir
            // 
            this.btnRecibir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibir.Location = new System.Drawing.Point(714, 129);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(175, 29);
            this.btnRecibir.TabIndex = 11;
            this.btnRecibir.Text = "Recibir";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // txtRecibir
            // 
            this.txtRecibir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibir.Location = new System.Drawing.Point(181, 131);
            this.txtRecibir.Name = "txtRecibir";
            this.txtRecibir.Size = new System.Drawing.Size(527, 26);
            this.txtRecibir.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mensaje recibido";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(714, 73);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(175, 29);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar a Colas";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnviar.Location = new System.Drawing.Point(181, 75);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(527, 26);
            this.txtEnviar.TabIndex = 7;
            this.txtEnviar.Text = "Texto de prueba";
            // 
            // lblMsjeAEnviar
            // 
            this.lblMsjeAEnviar.AutoSize = true;
            this.lblMsjeAEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjeAEnviar.Location = new System.Drawing.Point(33, 79);
            this.lblMsjeAEnviar.Name = "lblMsjeAEnviar";
            this.lblMsjeAEnviar.Size = new System.Drawing.Size(136, 19);
            this.lblMsjeAEnviar.TabIndex = 6;
            this.lblMsjeAEnviar.Text = "Mensaje a enviar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(867, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ejemplo de envio transaccional (a 2 colas) y recepcion transaccional (confirmacio" +
    "n de que se procesó el msje ok)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.txtRecibir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.lblMsjeAEnviar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Prueba de transaccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.TextBox txtRecibir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Label lblMsjeAEnviar;
        private System.Windows.Forms.Label label2;
    }
}

