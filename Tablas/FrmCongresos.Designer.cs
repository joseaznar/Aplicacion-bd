namespace AplicaciónCSBD.Tablas
{
  partial class FrmCongresos
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
      this.dsCongresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsCongresos = new AplicaciónCSBD.DsCongresos();
      this.dsCongreso = new AplicaciónCSBD.DsCongreso();
      this.t4CONGRESOBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.t4CONGRESOTableAdapter = new AplicaciónCSBD.DsCongresoTableAdapters.T4CONGRESOTableAdapter();
      this.iDCONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fECHAINIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fECHAFINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.iDLUGARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsCongresosBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsCongresos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsCongreso)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.t4CONGRESOBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCONDataGridViewTextBoxColumn,
            this.fECHAINIDataGridViewTextBoxColumn,
            this.fECHAFINDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.iDLUGARDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.t4CONGRESOBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(23, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(859, 209);
      this.dataGridView1.TabIndex = 0;
      // 
      // btnActualizar
      // 
      this.btnActualizar.Location = new System.Drawing.Point(643, 344);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(75, 23);
      this.btnActualizar.TabIndex = 1;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // dsCongresosBindingSource
      // 
      this.dsCongresosBindingSource.DataSource = this.dsCongresos;
      this.dsCongresosBindingSource.Position = 0;
      // 
      // dsCongresos
      // 
      this.dsCongresos.DataSetName = "DsCongresos";
      this.dsCongresos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dsCongreso
      // 
      this.dsCongreso.DataSetName = "DsCongreso";
      this.dsCongreso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // t4CONGRESOBindingSource
      // 
      this.t4CONGRESOBindingSource.DataMember = "T4CONGRESO";
      this.t4CONGRESOBindingSource.DataSource = this.dsCongreso;
      // 
      // t4CONGRESOTableAdapter
      // 
      this.t4CONGRESOTableAdapter.ClearBeforeFill = true;
      // 
      // iDCONDataGridViewTextBoxColumn
      // 
      this.iDCONDataGridViewTextBoxColumn.DataPropertyName = "IDCON";
      this.iDCONDataGridViewTextBoxColumn.HeaderText = "IDCON";
      this.iDCONDataGridViewTextBoxColumn.Name = "iDCONDataGridViewTextBoxColumn";
      // 
      // fECHAINIDataGridViewTextBoxColumn
      // 
      this.fECHAINIDataGridViewTextBoxColumn.DataPropertyName = "FECHAINI";
      this.fECHAINIDataGridViewTextBoxColumn.HeaderText = "FECHAINI";
      this.fECHAINIDataGridViewTextBoxColumn.Name = "fECHAINIDataGridViewTextBoxColumn";
      // 
      // fECHAFINDataGridViewTextBoxColumn
      // 
      this.fECHAFINDataGridViewTextBoxColumn.DataPropertyName = "FECHAFIN";
      this.fECHAFINDataGridViewTextBoxColumn.HeaderText = "FECHAFIN";
      this.fECHAFINDataGridViewTextBoxColumn.Name = "fECHAFINDataGridViewTextBoxColumn";
      // 
      // nOMBREDataGridViewTextBoxColumn
      // 
      this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
      this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
      this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
      // 
      // iDLUGARDataGridViewTextBoxColumn
      // 
      this.iDLUGARDataGridViewTextBoxColumn.DataPropertyName = "IDLUGAR";
      this.iDLUGARDataGridViewTextBoxColumn.HeaderText = "IDLUGAR";
      this.iDLUGARDataGridViewTextBoxColumn.Name = "iDLUGARDataGridViewTextBoxColumn";
      // 
      // FrmCongresos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.ClientSize = new System.Drawing.Size(894, 490);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.dataGridView1);
      this.Name = "FrmCongresos";
      this.Text = "FrmCongresos";
      this.Load += new System.EventHandler(this.FrmCongresos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsCongresosBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsCongresos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsCongreso)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.t4CONGRESOBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.BindingSource dsCongresosBindingSource;
    private DsCongresos dsCongresos;
    private System.Windows.Forms.Button btnActualizar;
    private DsCongreso dsCongreso;
    private System.Windows.Forms.BindingSource t4CONGRESOBindingSource;
    private DsCongresoTableAdapters.T4CONGRESOTableAdapter t4CONGRESOTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDCONDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINIDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDLUGARDataGridViewTextBoxColumn;
  }
}