namespace chat_winforms_1
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
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_listener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_puerto = new System.Windows.Forms.TextBox();
            this.txt_lis_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_3online1 = new chat_winforms_1.btn_3online();
            this.SuspendLayout();
            // 
            // btn_conectar
            // 
            this.btn_conectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_conectar.Location = new System.Drawing.Point(371, 37);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(94, 85);
            this.btn_conectar.TabIndex = 0;
            this.btn_conectar.Text = "Jugar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_listener
            // 
            this.btn_listener.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_listener.Location = new System.Drawing.Point(243, 94);
            this.btn_listener.Name = "btn_listener";
            this.btn_listener.Size = new System.Drawing.Size(115, 23);
            this.btn_listener.TabIndex = 1;
            this.btn_listener.Text = "listener";
            this.btn_listener.UseVisualStyleBackColor = true;
            this.btn_listener.Click += new System.EventHandler(this.btn_listener_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ip : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "puerto :";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(53, 53);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(181, 20);
            this.txt_ip.TabIndex = 4;
            // 
            // txt_puerto
            // 
            this.txt_puerto.Location = new System.Drawing.Point(282, 53);
            this.txt_puerto.Name = "txt_puerto";
            this.txt_puerto.Size = new System.Drawing.Size(75, 20);
            this.txt_puerto.TabIndex = 5;
            // 
            // txt_lis_port
            // 
            this.txt_lis_port.Location = new System.Drawing.Point(134, 96);
            this.txt_lis_port.Name = "txt_lis_port";
            this.txt_lis_port.Size = new System.Drawing.Size(100, 20);
            this.txt_lis_port.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "puerto de escucha :";
            // 
            // btn_3online1
            // 
            this.btn_3online1.Location = new System.Drawing.Point(26, 158);
            this.btn_3online1.Name = "btn_3online1";
            this.btn_3online1.posicion = null;
            this.btn_3online1.Size = new System.Drawing.Size(150, 150);
            this.btn_3online1.TabIndex = 13;
            this.btn_3online1.Load += new System.EventHandler(this.btn_3online1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(488, 639);
            this.Controls.Add(this.btn_3online1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_lis_port);
            this.Controls.Add(this.txt_puerto);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_listener);
            this.Controls.Add(this.btn_conectar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_listener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_puerto;
        private System.Windows.Forms.TextBox txt_lis_port;
        private System.Windows.Forms.Label label4;
        private btn_3online btn_3online1;
    }
}

