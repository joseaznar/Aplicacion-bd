namespace AplicaciónCSBD
{
  partial class FrmMenú
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Mnu_Congresos = new System.Windows.Forms.ToolStripMenuItem();
      this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.organizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.funcionYProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.tablasToolStripMenuItem,
            this.procesosToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(484, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // salirToolStripMenuItem
      // 
      this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSalir});
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
      this.salirToolStripMenuItem.Text = "Salir";
      // 
      // MnuSalir
      // 
      this.MnuSalir.Name = "MnuSalir";
      this.MnuSalir.Size = new System.Drawing.Size(96, 22);
      this.MnuSalir.Text = "Salir";
      this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
      // 
      // tablasToolStripMenuItem
      // 
      this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Congresos,
            this.autoresToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.organizacionesToolStripMenuItem,
            this.generalToolStripMenuItem});
      this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
      this.tablasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
      this.tablasToolStripMenuItem.Text = "Tablas";
      // 
      // Mnu_Congresos
      // 
      this.Mnu_Congresos.Name = "Mnu_Congresos";
      this.Mnu_Congresos.Size = new System.Drawing.Size(155, 22);
      this.Mnu_Congresos.Text = "Congresos";
      this.Mnu_Congresos.Click += new System.EventHandler(this.congresosToolStripMenuItem_Click);
      // 
      // autoresToolStripMenuItem
      // 
      this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
      this.autoresToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.autoresToolStripMenuItem.Text = "Autores";
      this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
      // 
      // articulosToolStripMenuItem
      // 
      this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
      this.articulosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.articulosToolStripMenuItem.Text = "Articulos";
      this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
      // 
      // organizacionesToolStripMenuItem
      // 
      this.organizacionesToolStripMenuItem.Name = "organizacionesToolStripMenuItem";
      this.organizacionesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.organizacionesToolStripMenuItem.Text = "Organizaciones";
      this.organizacionesToolStripMenuItem.Click += new System.EventHandler(this.organizacionesToolStripMenuItem_Click);
      // 
      // procesosToolStripMenuItem
      // 
      this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.funcionYProgramaToolStripMenuItem});
      this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
      this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.procesosToolStripMenuItem.Text = "Procesos";
      // 
      // generalToolStripMenuItem
      // 
      this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
      this.generalToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.generalToolStripMenuItem.Text = "General";
      this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
      // 
      // consultasToolStripMenuItem
      // 
      this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
      this.consultasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.consultasToolStripMenuItem.Text = "Consultas";
      this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
      // 
      // funcionYProgramaToolStripMenuItem
      // 
      this.funcionYProgramaToolStripMenuItem.Name = "funcionYProgramaToolStripMenuItem";
      this.funcionYProgramaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
      this.funcionYProgramaToolStripMenuItem.Text = "Funcion y programa";
      this.funcionYProgramaToolStripMenuItem.Click += new System.EventHandler(this.funcionYProgramaToolStripMenuItem_Click);
      // 
      // FrmMenú
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      this.ClientSize = new System.Drawing.Size(484, 344);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "FrmMenú";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Menú principal";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuSalir;
    private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Congresos;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizacionesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem funcionYProgramaToolStripMenuItem;
  }
}

