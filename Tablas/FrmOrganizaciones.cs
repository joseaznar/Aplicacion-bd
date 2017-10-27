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
  public partial class FrmOrganizaciones : Form
  {
    public FrmOrganizaciones()
    {
      InitializeComponent();
    }

    //Actualiza la tabla de organizaciones.
    private void btnActualizar_Click(object sender, EventArgs e)
    {
      this.t4ORGANIZACIÓNTableAdapter.Update(this.dsOrganizaciones.T4ORGANIZACIÓN);
    }

    private void FrmOrganizaciones_Load(object sender, EventArgs e)
    {
      // TODO: esta línea de código carga datos en la tabla 'dsOrganizaciones.T4ORGANIZACIÓN' Puede moverla o quitarla según sea necesario.
      this.t4ORGANIZACIÓNTableAdapter.Fill(this.dsOrganizaciones.T4ORGANIZACIÓN);

    }
  }
}
