﻿namespace AplicaciónCSBD.Tablas
{
  partial class FrmFuncProg
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(366, 79);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(394, 72);
      this.button1.TabIndex = 0;
      this.button1.Text = "Ejecuta procedimiento";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(378, 277);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(382, 74);
      this.button2.TabIndex = 1;
      this.button2.Text = "Ejecuta función";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // FrmFuncProg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.ClientSize = new System.Drawing.Size(1124, 535);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "FrmFuncProg";
      this.Text = "FrmFuncProg";
      this.Load += new System.EventHandler(this.FrmFuncProg_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}