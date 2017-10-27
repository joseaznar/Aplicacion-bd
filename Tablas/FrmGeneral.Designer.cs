namespace AplicaciónCSBD.Tablas
{
  partial class FrmGeneral
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
      this.dtgGeneral = new System.Windows.Forms.DataGridView();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.congresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.organizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dtgGeneral
      // 
      this.dtgGeneral.AllowUserToAddRows = false;
      this.dtgGeneral.AllowUserToDeleteRows = false;
      this.dtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgGeneral.Location = new System.Drawing.Point(0, 30);
      this.dtgGeneral.Name = "dtgGeneral";
      this.dtgGeneral.ReadOnly = true;
      this.dtgGeneral.Size = new System.Drawing.Size(1180, 322);
      this.dtgGeneral.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.congresosToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.artículosToolStripMenuItem,
            this.organizacionesToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1192, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // congresosToolStripMenuItem
      // 
      this.congresosToolStripMenuItem.Name = "congresosToolStripMenuItem";
      this.congresosToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
      this.congresosToolStripMenuItem.Text = "Congresos";
      this.congresosToolStripMenuItem.Click += new System.EventHandler(this.congresosToolStripMenuItem_Click);
      // 
      // autoresToolStripMenuItem
      // 
      this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
      this.autoresToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
      this.autoresToolStripMenuItem.Text = "Autores";
      this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
      // 
      // artículosToolStripMenuItem
      // 
      this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
      this.artículosToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
      this.artículosToolStripMenuItem.Text = "Artículos";
      this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
      // 
      // organizacionesToolStripMenuItem
      // 
      this.organizacionesToolStripMenuItem.Name = "organizacionesToolStripMenuItem";
      this.organizacionesToolStripMenuItem.Size = new System.Drawing.Size(100, 23);
      this.organizacionesToolStripMenuItem.Text = "Organizaciones";
      this.organizacionesToolStripMenuItem.Click += new System.EventHandler(this.organizacionesToolStripMenuItem_Click);
      // 
      // FrmGeneral
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.ClientSize = new System.Drawing.Size(1192, 538);
      this.Controls.Add(this.dtgGeneral);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FrmGeneral";
      this.Text = "Dar click en alguna de las opciones del menu para cargar datos.";
      this.Load += new System.EventHandler(this.FrmGeneral_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dtgGeneral;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem congresosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem organizacionesToolStripMenuItem;
  }
}