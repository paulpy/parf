namespace PrintAgentRF.Vistas
{
    partial class Configuracion
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
            this.lblConfNomAgente = new System.Windows.Forms.Label();
            this.lblConfPassAgente = new System.Windows.Forms.Label();
            this.lblConfIpEquipo = new System.Windows.Forms.Label();
            this.lvlConfPuerto = new System.Windows.Forms.Label();
            this.lvlConfHost = new System.Windows.Forms.Label();
            this.txbConfNombreAgent = new System.Windows.Forms.TextBox();
            this.txbConfIpAgente = new System.Windows.Forms.TextBox();
            this.txbConfPuerto = new System.Windows.Forms.TextBox();
            this.txbConfHost = new System.Windows.Forms.TextBox();
            this.txbConfContrasena = new System.Windows.Forms.TextBox();
            this.btnConfActualizar = new System.Windows.Forms.Button();
            this.btnConfCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfNomAgente
            // 
            this.lblConfNomAgente.AutoSize = true;
            this.lblConfNomAgente.Location = new System.Drawing.Point(62, 46);
            this.lblConfNomAgente.Name = "lblConfNomAgente";
            this.lblConfNomAgente.Size = new System.Drawing.Size(111, 17);
            this.lblConfNomAgente.TabIndex = 0;
            this.lblConfNomAgente.Text = "Nombre Agente:";
            // 
            // lblConfPassAgente
            // 
            this.lblConfPassAgente.AutoSize = true;
            this.lblConfPassAgente.Location = new System.Drawing.Point(62, 86);
            this.lblConfPassAgente.Name = "lblConfPassAgente";
            this.lblConfPassAgente.Size = new System.Drawing.Size(156, 17);
            this.lblConfPassAgente.TabIndex = 1;
            this.lblConfPassAgente.Text = "Contraseña Agente PS:";
            // 
            // lblConfIpEquipo
            // 
            this.lblConfIpEquipo.AutoSize = true;
            this.lblConfIpEquipo.Location = new System.Drawing.Point(62, 133);
            this.lblConfIpEquipo.Name = "lblConfIpEquipo";
            this.lblConfIpEquipo.Size = new System.Drawing.Size(94, 17);
            this.lblConfIpEquipo.TabIndex = 2;
            this.lblConfIpEquipo.Text = "Ip del Equipo:";
            // 
            // lvlConfPuerto
            // 
            this.lvlConfPuerto.AutoSize = true;
            this.lvlConfPuerto.Location = new System.Drawing.Point(62, 176);
            this.lvlConfPuerto.Name = "lvlConfPuerto";
            this.lvlConfPuerto.Size = new System.Drawing.Size(54, 17);
            this.lvlConfPuerto.TabIndex = 3;
            this.lvlConfPuerto.Text = "Puerto:";
            // 
            // lvlConfHost
            // 
            this.lvlConfHost.AutoSize = true;
            this.lvlConfHost.Location = new System.Drawing.Point(62, 214);
            this.lvlConfHost.Name = "lvlConfHost";
            this.lvlConfHost.Size = new System.Drawing.Size(113, 17);
            this.lvlConfHost.TabIndex = 4;
            this.lvlConfHost.Text = "Host Acceso PS:";
            // 
            // txbConfNombreAgent
            // 
            this.txbConfNombreAgent.Location = new System.Drawing.Point(255, 46);
            this.txbConfNombreAgent.Name = "txbConfNombreAgent";
            this.txbConfNombreAgent.Size = new System.Drawing.Size(185, 22);
            this.txbConfNombreAgent.TabIndex = 5;
            // 
            // txbConfIpAgente
            // 
            this.txbConfIpAgente.Location = new System.Drawing.Point(255, 128);
            this.txbConfIpAgente.Name = "txbConfIpAgente";
            this.txbConfIpAgente.Size = new System.Drawing.Size(185, 22);
            this.txbConfIpAgente.TabIndex = 6;
            // 
            // txbConfPuerto
            // 
            this.txbConfPuerto.Location = new System.Drawing.Point(255, 170);
            this.txbConfPuerto.Name = "txbConfPuerto";
            this.txbConfPuerto.Size = new System.Drawing.Size(185, 22);
            this.txbConfPuerto.TabIndex = 7;
            // 
            // txbConfHost
            // 
            this.txbConfHost.Location = new System.Drawing.Point(255, 211);
            this.txbConfHost.Name = "txbConfHost";
            this.txbConfHost.Size = new System.Drawing.Size(185, 22);
            this.txbConfHost.TabIndex = 8;
            // 
            // txbConfContrasena
            // 
            this.txbConfContrasena.Location = new System.Drawing.Point(255, 86);
            this.txbConfContrasena.Name = "txbConfContrasena";
            this.txbConfContrasena.Size = new System.Drawing.Size(185, 22);
            this.txbConfContrasena.TabIndex = 9;
            this.txbConfContrasena.UseSystemPasswordChar = true;
            // 
            // btnConfActualizar
            // 
            this.btnConfActualizar.Location = new System.Drawing.Point(142, 263);
            this.btnConfActualizar.Name = "btnConfActualizar";
            this.btnConfActualizar.Size = new System.Drawing.Size(84, 23);
            this.btnConfActualizar.TabIndex = 10;
            this.btnConfActualizar.Text = "Actualizar";
            this.btnConfActualizar.UseVisualStyleBackColor = true;
            // 
            // btnConfCancelar
            // 
            this.btnConfCancelar.Location = new System.Drawing.Point(255, 263);
            this.btnConfCancelar.Name = "btnConfCancelar";
            this.btnConfCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnConfCancelar.TabIndex = 11;
            this.btnConfCancelar.Text = "Atras";
            this.btnConfCancelar.UseVisualStyleBackColor = true;
            this.btnConfCancelar.Click += new System.EventHandler(this.btnConfCancelar_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 298);
            this.Controls.Add(this.btnConfCancelar);
            this.Controls.Add(this.btnConfActualizar);
            this.Controls.Add(this.txbConfContrasena);
            this.Controls.Add(this.txbConfHost);
            this.Controls.Add(this.txbConfPuerto);
            this.Controls.Add(this.txbConfIpAgente);
            this.Controls.Add(this.txbConfNombreAgent);
            this.Controls.Add(this.lvlConfHost);
            this.Controls.Add(this.lvlConfPuerto);
            this.Controls.Add(this.lblConfIpEquipo);
            this.Controls.Add(this.lblConfPassAgente);
            this.Controls.Add(this.lblConfNomAgente);
            this.Name = "Configuracion";
            this.Text = "Configurarciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfNomAgente;
        private System.Windows.Forms.Label lblConfPassAgente;
        private System.Windows.Forms.Label lblConfIpEquipo;
        private System.Windows.Forms.Label lvlConfPuerto;
        private System.Windows.Forms.Label lvlConfHost;
        private System.Windows.Forms.TextBox txbConfNombreAgent;
        private System.Windows.Forms.TextBox txbConfIpAgente;
        private System.Windows.Forms.TextBox txbConfPuerto;
        private System.Windows.Forms.TextBox txbConfHost;
        private System.Windows.Forms.TextBox txbConfContrasena;
        private System.Windows.Forms.Button btnConfActualizar;
        private System.Windows.Forms.Button btnConfCancelar;
    }
}