namespace PrintAgentRF
{
    partial class PrintAgenPrincipal
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.pmProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.pmiConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.pmiDSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pmiCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pmProcesos});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(282, 28);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "msPrincipal";
            // 
            // pmProcesos
            // 
            this.pmProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pmiConfiguracion,
            this.pmiDSistema,
            this.toolStripSeparator1,
            this.pmiCerrar});
            this.pmProcesos.Name = "pmProcesos";
            this.pmProcesos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.pmProcesos.Size = new System.Drawing.Size(79, 24);
            this.pmProcesos.Text = "Procesos";
            // 
            // pmiConfiguracion
            // 
            this.pmiConfiguracion.Name = "pmiConfiguracion";
            this.pmiConfiguracion.Size = new System.Drawing.Size(204, 26);
            this.pmiConfiguracion.Text = "Configuracion";
            this.pmiConfiguracion.Click += new System.EventHandler(this.pmiConfiguracion_Click);
            // 
            // pmiDSistema
            // 
            this.pmiDSistema.Name = "pmiDSistema";
            this.pmiDSistema.Size = new System.Drawing.Size(204, 26);
            this.pmiDSistema.Text = "Datos del Sistema";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // pmiCerrar
            // 
            this.pmiCerrar.Name = "pmiCerrar";
            this.pmiCerrar.Size = new System.Drawing.Size(204, 26);
            this.pmiCerrar.Text = "Cerrar";
            this.pmiCerrar.Click += new System.EventHandler(this.pmiCerrar_Click);
            // 
            // PrintAgenPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.msPrincipal);
            this.Name = "PrintAgenPrincipal";
            this.Text = "Principal";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem pmProcesos;
        private System.Windows.Forms.ToolStripMenuItem pmiConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem pmiDSistema;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pmiCerrar;
    }
}

