namespace ProductoWilliam
{
    partial class FCalcularPro
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCalcularPro));
            this.lCodigo = new System.Windows.Forms.Label();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.tNombrePro = new System.Windows.Forms.TextBox();
            this.lNomPro = new System.Windows.Forms.Label();
            this.tValorU = new System.Windows.Forms.TextBox();
            this.tCantidad = new System.Windows.Forms.TextBox();
            this.lCantidad = new System.Windows.Forms.Label();
            this.lValorU = new System.Windows.Forms.Label();
            this.lIva = new System.Windows.Forms.Label();
            this.tTotalIva = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.tTotal = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lCodigo
            // 
            resources.ApplyResources(this.lCodigo, "lCodigo");
            this.lCodigo.Name = "lCodigo";
            // 
            // tCodigo
            // 
            this.tCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.tCodigo, "tCodigo");
            this.tCodigo.Name = "tCodigo";
            // 
            // tNombrePro
            // 
            resources.ApplyResources(this.tNombrePro, "tNombrePro");
            this.tNombrePro.Name = "tNombrePro";
            // 
            // lNomPro
            // 
            resources.ApplyResources(this.lNomPro, "lNomPro");
            this.lNomPro.Name = "lNomPro";
            // 
            // tValorU
            // 
            resources.ApplyResources(this.tValorU, "tValorU");
            this.tValorU.Name = "tValorU";
            this.tValorU.TextChanged += new System.EventHandler(this.tValorU_TextChanged);
            // 
            // tCantidad
            // 
            resources.ApplyResources(this.tCantidad, "tCantidad");
            this.tCantidad.Name = "tCantidad";
            this.tCantidad.TextChanged += new System.EventHandler(this.tCantidad_TextChanged);
            // 
            // lCantidad
            // 
            resources.ApplyResources(this.lCantidad, "lCantidad");
            this.lCantidad.Name = "lCantidad";
            // 
            // lValorU
            // 
            resources.ApplyResources(this.lValorU, "lValorU");
            this.lValorU.Name = "lValorU";
            // 
            // lIva
            // 
            resources.ApplyResources(this.lIva, "lIva");
            this.lIva.Name = "lIva";
            // 
            // tTotalIva
            // 
            resources.ApplyResources(this.tTotalIva, "tTotalIva");
            this.tTotalIva.Name = "tTotalIva";
            this.tTotalIva.ReadOnly = true;
            // 
            // lTotal
            // 
            resources.ApplyResources(this.lTotal, "lTotal");
            this.lTotal.Name = "lTotal";
            // 
            // tTotal
            // 
            resources.ApplyResources(this.tTotal, "tTotal");
            this.tTotal.Name = "tTotal";
            this.tTotal.ReadOnly = true;
            // 
            // bCalcular
            // 
            resources.ApplyResources(this.bCalcular, "bCalcular");
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // bNuevo
            // 
            resources.ApplyResources(this.bNuevo, "bNuevo");
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bSalir
            // 
            resources.ApplyResources(this.bSalir, "bSalir");
            this.bSalir.Name = "bSalir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FCalcularPro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bNuevo);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tTotal);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.tTotalIva);
            this.Controls.Add(this.lIva);
            this.Controls.Add(this.lValorU);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.tCantidad);
            this.Controls.Add(this.tValorU);
            this.Controls.Add(this.lNomPro);
            this.Controls.Add(this.tNombrePro);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.lCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FCalcularPro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.TextBox tNombrePro;
        private System.Windows.Forms.Label lNomPro;
        private System.Windows.Forms.TextBox tValorU;
        private System.Windows.Forms.TextBox tCantidad;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.Label lValorU;
        private System.Windows.Forms.Label lIva;
        private System.Windows.Forms.TextBox tTotalIva;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.TextBox tTotal;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

