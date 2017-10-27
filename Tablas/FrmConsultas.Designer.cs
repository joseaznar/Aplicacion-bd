namespace AplicaciónCSBD.Tablas
{
  partial class FrmConsultas
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
      this.components = new System.ComponentModel.Container();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.bECAINSTITUCIONARTICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsBecaInstitucionArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsBecaInstitucionArticulo = new AplicaciónCSBD.DsBecaInstitucionArticulo();
      this.dsArticuloOrganizacionAño = new AplicaciónCSBD.DsArticuloOrganizacionAño();
      this.dsArticuloOrganizacionAñoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsAutoresMasArticulos = new AplicaciónCSBD.DsAutoresMasArticulos();
      this.dsAutoresMasArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsEmpresaCongresoMonto = new AplicaciónCSBD.DsEmpresaCongresoMonto();
      this.dsEmpresaCongresoMontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.consulta1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.consulta2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.consulta3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.consulta4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.eMPRESACONGRESOMONTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.eMPRESACONGRESOMONTOTableAdapter = new AplicaciónCSBD.DsEmpresaCongresoMontoTableAdapters.EMPRESACONGRESOMONTOTableAdapter();
      this.eMPRESACONGRESOMONTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.aRTICULOSORGANIZACIONAÑOBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.aRTICULOSORGANIZACIONAÑOTableAdapter = new AplicaciónCSBD.DsArticuloOrganizacionAñoTableAdapters.ARTICULOSORGANIZACIONAÑOTableAdapter();
      this.aUTORESMASARTICULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.aUTORESMASARTICULOSTableAdapter = new AplicaciónCSBD.DsAutoresMasArticulosTableAdapters.AUTORESMASARTICULOSTableAdapter();
      this.bECAINSTITUCIONARTICULOTableAdapter = new AplicaciónCSBD.DsBecaInstitucionArticuloTableAdapters.BECAINSTITUCIONARTICULOTableAdapter();
      this.aRTICULOSORGANIZACIONAÑOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bECAINSTITUCIONARTICULOBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsBecaInstitucionArticuloBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsBecaInstitucionArticulo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsArticuloOrganizacionAño)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsArticuloOrganizacionAñoBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsAutoresMasArticulos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsAutoresMasArticulosBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsEmpresaCongresoMonto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsEmpresaCongresoMontoBindingSource)).BeginInit();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESACONGRESOMONTOBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESACONGRESOMONTOBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSORGANIZACIONAÑOBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.aUTORESMASARTICULOSBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSORGANIZACIONAÑOBindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(3, 26);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(1262, 366);
      this.dataGridView1.TabIndex = 0;
      // 
      // bECAINSTITUCIONARTICULOBindingSource
      // 
      this.bECAINSTITUCIONARTICULOBindingSource.DataMember = "BECAINSTITUCIONARTICULO";
      this.bECAINSTITUCIONARTICULOBindingSource.DataSource = this.dsBecaInstitucionArticuloBindingSource;
      // 
      // dsBecaInstitucionArticuloBindingSource
      // 
      this.dsBecaInstitucionArticuloBindingSource.DataSource = this.dsBecaInstitucionArticulo;
      this.dsBecaInstitucionArticuloBindingSource.Position = 0;
      // 
      // dsBecaInstitucionArticulo
      // 
      this.dsBecaInstitucionArticulo.DataSetName = "DsBecaInstitucionArticulo";
      this.dsBecaInstitucionArticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dsArticuloOrganizacionAño
      // 
      this.dsArticuloOrganizacionAño.DataSetName = "DsArticuloOrganizacionAño";
      this.dsArticuloOrganizacionAño.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dsArticuloOrganizacionAñoBindingSource
      // 
      this.dsArticuloOrganizacionAñoBindingSource.DataSource = this.dsArticuloOrganizacionAño;
      this.dsArticuloOrganizacionAñoBindingSource.Position = 0;
      // 
      // dsAutoresMasArticulos
      // 
      this.dsAutoresMasArticulos.DataSetName = "DsAutoresMasArticulos";
      this.dsAutoresMasArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dsAutoresMasArticulosBindingSource
      // 
      this.dsAutoresMasArticulosBindingSource.DataSource = this.dsAutoresMasArticulos;
      this.dsAutoresMasArticulosBindingSource.Position = 0;
      // 
      // dsEmpresaCongresoMonto
      // 
      this.dsEmpresaCongresoMonto.DataSetName = "DsEmpresaCongresoMonto";
      this.dsEmpresaCongresoMonto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dsEmpresaCongresoMontoBindingSource
      // 
      this.dsEmpresaCongresoMontoBindingSource.DataSource = this.dsEmpresaCongresoMonto;
      this.dsEmpresaCongresoMontoBindingSource.Position = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulta1ToolStripMenuItem,
            this.consulta2ToolStripMenuItem,
            this.consulta3ToolStripMenuItem,
            this.consulta4ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1287, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // consulta1ToolStripMenuItem
      // 
      this.consulta1ToolStripMenuItem.Name = "consulta1ToolStripMenuItem";
      this.consulta1ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
      this.consulta1ToolStripMenuItem.Text = "Consulta 1";
      this.consulta1ToolStripMenuItem.Click += new System.EventHandler(this.consulta1ToolStripMenuItem_Click);
      // 
      // consulta2ToolStripMenuItem
      // 
      this.consulta2ToolStripMenuItem.Name = "consulta2ToolStripMenuItem";
      this.consulta2ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
      this.consulta2ToolStripMenuItem.Text = "Consulta 2";
      this.consulta2ToolStripMenuItem.Click += new System.EventHandler(this.consulta2ToolStripMenuItem_Click);
      // 
      // consulta3ToolStripMenuItem
      // 
      this.consulta3ToolStripMenuItem.Name = "consulta3ToolStripMenuItem";
      this.consulta3ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
      this.consulta3ToolStripMenuItem.Text = "Consulta 3";
      this.consulta3ToolStripMenuItem.Click += new System.EventHandler(this.consulta3ToolStripMenuItem_Click);
      // 
      // consulta4ToolStripMenuItem
      // 
      this.consulta4ToolStripMenuItem.Name = "consulta4ToolStripMenuItem";
      this.consulta4ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
      this.consulta4ToolStripMenuItem.Text = "Consulta 4";
      this.consulta4ToolStripMenuItem.Click += new System.EventHandler(this.consulta4ToolStripMenuItem_Click);
      // 
      // eMPRESACONGRESOMONTOBindingSource
      // 
      this.eMPRESACONGRESOMONTOBindingSource.DataMember = "EMPRESACONGRESOMONTO";
      this.eMPRESACONGRESOMONTOBindingSource.DataSource = this.dsEmpresaCongresoMontoBindingSource;
      // 
      // eMPRESACONGRESOMONTOTableAdapter
      // 
      this.eMPRESACONGRESOMONTOTableAdapter.ClearBeforeFill = true;
      // 
      // eMPRESACONGRESOMONTOBindingSource1
      // 
      this.eMPRESACONGRESOMONTOBindingSource1.DataMember = "EMPRESACONGRESOMONTO";
      this.eMPRESACONGRESOMONTOBindingSource1.DataSource = this.dsEmpresaCongresoMontoBindingSource;
      // 
      // aRTICULOSORGANIZACIONAÑOBindingSource
      // 
      this.aRTICULOSORGANIZACIONAÑOBindingSource.DataMember = "ARTICULOSORGANIZACIONAÑO";
      this.aRTICULOSORGANIZACIONAÑOBindingSource.DataSource = this.dsArticuloOrganizacionAñoBindingSource;
      // 
      // aRTICULOSORGANIZACIONAÑOTableAdapter
      // 
      this.aRTICULOSORGANIZACIONAÑOTableAdapter.ClearBeforeFill = true;
      // 
      // aUTORESMASARTICULOSBindingSource
      // 
      this.aUTORESMASARTICULOSBindingSource.DataMember = "AUTORESMASARTICULOS";
      this.aUTORESMASARTICULOSBindingSource.DataSource = this.dsAutoresMasArticulosBindingSource;
      // 
      // aUTORESMASARTICULOSTableAdapter
      // 
      this.aUTORESMASARTICULOSTableAdapter.ClearBeforeFill = true;
      // 
      // bECAINSTITUCIONARTICULOTableAdapter
      // 
      this.bECAINSTITUCIONARTICULOTableAdapter.ClearBeforeFill = true;
      // 
      // aRTICULOSORGANIZACIONAÑOBindingSource1
      // 
      this.aRTICULOSORGANIZACIONAÑOBindingSource1.DataMember = "ARTICULOSORGANIZACIONAÑO";
      this.aRTICULOSORGANIZACIONAÑOBindingSource1.DataSource = this.dsArticuloOrganizacionAñoBindingSource;
      // 
      // FrmConsultas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.ClientSize = new System.Drawing.Size(1287, 544);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FrmConsultas";
      this.Text = "Selecciona una consulta para desplegar sus resultados.";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bECAINSTITUCIONARTICULOBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsBecaInstitucionArticuloBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsBecaInstitucionArticulo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsArticuloOrganizacionAño)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsArticuloOrganizacionAñoBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsAutoresMasArticulos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsAutoresMasArticulosBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsEmpresaCongresoMonto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsEmpresaCongresoMontoBindingSource)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESACONGRESOMONTOBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESACONGRESOMONTOBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSORGANIZACIONAÑOBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.aUTORESMASARTICULOSBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSORGANIZACIONAÑOBindingSource1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private DsArticuloOrganizacionAño dsArticuloOrganizacionAño;
    private System.Windows.Forms.BindingSource dsArticuloOrganizacionAñoBindingSource;
    private DsAutoresMasArticulos dsAutoresMasArticulos;
    private System.Windows.Forms.BindingSource dsAutoresMasArticulosBindingSource;
    private DsEmpresaCongresoMonto dsEmpresaCongresoMonto;
    private System.Windows.Forms.BindingSource dsEmpresaCongresoMontoBindingSource;
    private DsBecaInstitucionArticulo dsBecaInstitucionArticulo;
    private System.Windows.Forms.BindingSource dsBecaInstitucionArticuloBindingSource;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem consulta1ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem consulta2ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem consulta3ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem consulta4ToolStripMenuItem;
    private System.Windows.Forms.BindingSource eMPRESACONGRESOMONTOBindingSource;
    private DsEmpresaCongresoMontoTableAdapters.EMPRESACONGRESOMONTOTableAdapter eMPRESACONGRESOMONTOTableAdapter;
    private System.Windows.Forms.BindingSource eMPRESACONGRESOMONTOBindingSource1;
    private System.Windows.Forms.BindingSource aRTICULOSORGANIZACIONAÑOBindingSource;
    private DsArticuloOrganizacionAñoTableAdapters.ARTICULOSORGANIZACIONAÑOTableAdapter aRTICULOSORGANIZACIONAÑOTableAdapter;
    private System.Windows.Forms.BindingSource aUTORESMASARTICULOSBindingSource;
    private DsAutoresMasArticulosTableAdapters.AUTORESMASARTICULOSTableAdapter aUTORESMASARTICULOSTableAdapter;
    private System.Windows.Forms.BindingSource bECAINSTITUCIONARTICULOBindingSource;
    private DsBecaInstitucionArticuloTableAdapters.BECAINSTITUCIONARTICULOTableAdapter bECAINSTITUCIONARTICULOTableAdapter;
    private System.Windows.Forms.BindingSource aRTICULOSORGANIZACIONAÑOBindingSource1;
  }
}