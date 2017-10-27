namespace AplicaciónCSBD.Tablas
{
  partial class FrmOrganizaciones
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
      this.btnActualizar = new System.Windows.Forms.Button();
      this.dsOrganizaciones = new AplicaciónCSBD.DsOrganizaciones();
      this.t4ORGANIZACIÓNBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.t4ORGANIZACIÓNTableAdapter = new AplicaciónCSBD.DsOrganizacionesTableAdapters.T4ORGANIZACIÓNTableAdapter();
      this.iDORGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.iDPAISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsOrganizaciones)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.t4ORGANIZACIÓNBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDORGDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn,
            this.iDPAISDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.t4ORGANIZACIÓNBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(51, 22);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(1123, 358);
      this.dataGridView1.TabIndex = 0;
      // 
      // btnActualizar
      // 
      this.btnActualizar.Location = new System.Drawing.Point(1045, 460);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(75, 23);
      this.btnActualizar.TabIndex = 1;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // dsOrganizaciones
      // 
      this.dsOrganizaciones.DataSetName = "DsOrganizaciones";
      this.dsOrganizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // t4ORGANIZACIÓNBindingSource
      // 
      this.t4ORGANIZACIÓNBindingSource.DataMember = "T4ORGANIZACIÓN";
      this.t4ORGANIZACIÓNBindingSource.DataSource = this.dsOrganizaciones;
      // 
      // t4ORGANIZACIÓNTableAdapter
      // 
      this.t4ORGANIZACIÓNTableAdapter.ClearBeforeFill = true;
      // 
      // iDORGDataGridViewTextBoxColumn
      // 
      this.iDORGDataGridViewTextBoxColumn.DataPropertyName = "IDORG";
      this.iDORGDataGridViewTextBoxColumn.HeaderText = "IDORG";
      this.iDORGDataGridViewTextBoxColumn.Name = "iDORGDataGridViewTextBoxColumn";
      // 
      // nOMBREDataGridViewTextBoxColumn
      // 
      this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
      this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
      this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
      // 
      // tIPODataGridViewTextBoxColumn
      // 
      this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
      this.tIPODataGridViewTextBoxColumn.HeaderText = "TIPO";
      this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
      // 
      // iDPAISDataGridViewTextBoxColumn
      // 
      this.iDPAISDataGridViewTextBoxColumn.DataPropertyName = "IDPAIS";
      this.iDPAISDataGridViewTextBoxColumn.HeaderText = "IDPAIS";
      this.iDPAISDataGridViewTextBoxColumn.Name = "iDPAISDataGridViewTextBoxColumn";
      // 
      // FrmOrganizaciones
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.ClientSize = new System.Drawing.Size(1268, 594);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.dataGridView1);
      this.Name = "FrmOrganizaciones";
      this.Text = "FrmOrganizaciones";
      this.Load += new System.EventHandler(this.FrmOrganizaciones_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsOrganizaciones)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.t4ORGANIZACIÓNBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnActualizar;
    private DsOrganizaciones dsOrganizaciones;
    private System.Windows.Forms.BindingSource t4ORGANIZACIÓNBindingSource;
    private DsOrganizacionesTableAdapters.T4ORGANIZACIÓNTableAdapter t4ORGANIZACIÓNTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDORGDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDPAISDataGridViewTextBoxColumn;
  }
}