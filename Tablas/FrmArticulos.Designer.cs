namespace AplicaciónCSBD.Tablas
{
  partial class FrmArticulos
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
      this.iDARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.áREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.t4ARTÍCULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsArticulos = new AplicaciónCSBD.DsArticulos();
      this.t4ARTÍCULOTableAdapter = new AplicaciónCSBD.DsArticulosTableAdapters.T4ARTÍCULOTableAdapter();
      this.btnActualizar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.t4ARTÍCULOBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsArticulos)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDARTDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.áREADataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.t4ARTÍCULOBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(45, 13);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ShowCellErrors = false;
      this.dataGridView1.Size = new System.Drawing.Size(950, 327);
      this.dataGridView1.TabIndex = 0;
      // 
      // iDARTDataGridViewTextBoxColumn
      // 
      this.iDARTDataGridViewTextBoxColumn.DataPropertyName = "IDART";
      this.iDARTDataGridViewTextBoxColumn.HeaderText = "IDART";
      this.iDARTDataGridViewTextBoxColumn.Name = "iDARTDataGridViewTextBoxColumn";
      // 
      // nOMBREDataGridViewTextBoxColumn
      // 
      this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
      this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
      this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
      // 
      // áREADataGridViewTextBoxColumn
      // 
      this.áREADataGridViewTextBoxColumn.DataPropertyName = "ÁREA";
      this.áREADataGridViewTextBoxColumn.HeaderText = "ÁREA";
      this.áREADataGridViewTextBoxColumn.Name = "áREADataGridViewTextBoxColumn";
      // 
      // t4ARTÍCULOBindingSource
      // 
      this.t4ARTÍCULOBindingSource.DataMember = "T4ARTÍCULO";
      this.t4ARTÍCULOBindingSource.DataSource = this.dsArticulos;
      // 
      // dsArticulos
      // 
      this.dsArticulos.DataSetName = "DsArticulos";
      this.dsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // t4ARTÍCULOTableAdapter
      // 
      this.t4ARTÍCULOTableAdapter.ClearBeforeFill = true;
      // 
      // btnActualizar
      // 
      this.btnActualizar.Location = new System.Drawing.Point(829, 436);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(75, 23);
      this.btnActualizar.TabIndex = 1;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // FrmArticulos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.ClientSize = new System.Drawing.Size(1059, 561);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.dataGridView1);
      this.Name = "FrmArticulos";
      this.Text = "FrmArticulos";
      this.Load += new System.EventHandler(this.FrmArticulos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.t4ARTÍCULOBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsArticulos)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private DsArticulos dsArticulos;
    private System.Windows.Forms.BindingSource t4ARTÍCULOBindingSource;
    private DsArticulosTableAdapters.T4ARTÍCULOTableAdapter t4ARTÍCULOTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDARTDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn áREADataGridViewTextBoxColumn;
    private System.Windows.Forms.Button btnActualizar;
  }
}