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
  public partial class FrmArticulos : Form
  {
    public FrmArticulos()
    {
      InitializeComponent();
    }

    private void FrmArticulos_Load(object sender, EventArgs e)
    {
      // TODO: esta línea de código carga datos en la tabla 'dsArticulos.T4ARTÍCULO' Puede moverla o quitarla según sea necesario.
      this.t4ARTÍCULOTableAdapter.Fill(this.dsArticulos.T4ARTÍCULO);

    }

    //Actualiza la tabla de articulos.
    private void btnActualizar_Click(object sender, EventArgs e)
    {
      this.t4ARTÍCULOTableAdapter.Update(this.dsArticulos.T4ARTÍCULO);
    }
  }
}
