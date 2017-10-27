using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónCSBD.Tablas
{
  public partial class FrmAutores : Form
  {
    public FrmAutores()
    {
      InitializeComponent();
    }

    private void FrmAutores_Load(object sender, EventArgs e)
    {
      // TODO: esta línea de código carga datos en la tabla 'dsAutores.T4AUTOR' Puede moverla o quitarla según sea necesario.
      this.t4AUTORTableAdapter.Fill(this.dsAutores.T4AUTOR);

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    //Actualiza la tabla de autores.
    private void btnActualizar_Click(object sender, EventArgs e)
    {
      this.t4AUTORTableAdapter.Update(this.dsAutores.T4AUTOR);
    }
  }
}
