namespace AplicaciónCSBD.Tablas
{
  partial class FrmAutores
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
      this.dsAutores = new AplicaciónCSBD.DsAutores();
      this.t4AUTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.t4AUTORTableAdapter = new AplicaciónCSBD.DsAutoresTableAdapters.T4AUTORTableAdapter();
      this.iDAUTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cANTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.iDORGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnActualizar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsAutores)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.t4AUTORBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAUTORDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.cANTARTDataGridViewTextBoxColumn,
            this.iDORGDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.t4AUTORBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(44, 31);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(731, 258);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // dsAutores
      // 
      this.dsAutores.DataSetName = "DsAutores";
      this.dsAutores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // t4AUTORBindingSource
      // 
      this.t4AUTORBindingSource.DataMember = "T4AUTOR";
      this.t4AUTORBindingSource.DataSource = this.dsAutores;
      // 
      // t4AUTORTableAdapter
      // 
      this.t4AUTORTableAdapter.ClearBeforeFill = true;
      // 
      // iDAUTORDataGridViewTextBoxColumn
      // 
      this.iDAUTORDataGridViewTextBoxColumn.DataPropertyName = "IDAUTOR";
      this.iDAUTORDataGridViewTextBoxColumn.HeaderText = "IDAUTOR";
      this.iDAUTORDataGridViewTextBoxColumn.Name = "iDAUTORDataGridViewTextBoxColumn";
      // 
      // nOMBREDataGridViewTextBoxColumn
      // 
      this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
      this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
      this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
      // 
      // cANTARTDataGridViewTextBoxColumn
      // 
      this.cANTARTDataGridViewTextBoxColumn.DataPropertyName = "CANTART";
      this.cANTARTDataGridViewTextBoxColumn.HeaderText = "CANTART";
      this.cANTARTDataGridViewTextBoxColumn.Name = "cANTARTDataGridViewTextBoxColumn";
      // 
      // iDORGDataGridViewTextBoxColumn
      // 
      this.iDORGDataGridViewTextBoxColumn.DataPropertyName = "IDORG";
      this.iDORGDataGridViewTextBoxColumn.HeaderText = "IDORG";
      this.iDORGDataGridViewTextBoxColumn.Name = "iDORGDataGridViewTextBoxColumn";
      // 
      // btnActualizar
      // 
      this.btnActualizar.Location = new System.Drawing.Point(577, 384);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(75, 23);
      this.btnActualizar.TabIndex = 1;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // FrmAutores
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.ClientSize = new System.Drawing.Size(825, 526);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.dataGridView1);
      this.Name = "FrmAutores";
      this.Text = "FrmAutores";
      this.Load += new System.EventHandler(this.FrmAutores_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsAutores)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.t4AUTORBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private DsAutores dsAutores;
    private System.Windows.Forms.BindingSource t4AUTORBindingSource;
    private DsAutoresTableAdapters.T4AUTORTableAdapter t4AUTORTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDAUTORDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cANTARTDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDORGDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button btnActualizar;
  }
}