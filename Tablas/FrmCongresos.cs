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
  public partial class FrmCongresos : Form
  {
    public FrmCongresos()
    {
      InitializeComponent();
    }

    private void FrmCongresos_Load(object sender, EventArgs e)
    {
      // TODO: esta línea de código carga datos en la tabla 'dsCongreso.T4CONGRESO' Puede moverla o quitarla según sea necesario.
      this.t4CONGRESOTableAdapter.Fill(this.dsCongreso.T4CONGRESO);
    }

    //Actualiza la tabla de congresos.
    private void btnActualizar_Click(object sender, EventArgs e)
    {
      this.t4CONGRESOTableAdapter.Update(this.dsCongreso.T4CONGRESO);
    }
  }
}
