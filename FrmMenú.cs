using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónCSBD
{
  public partial class FrmMenú : Form
  {
    public FrmMenú()
    {
      InitializeComponent();
    }

    //Termina la aplicación.
    private void MnuSalir_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    //Abre la forma de la consulta.
    private void MnuConsulta_Click(object sender, EventArgs e) {
      Procesos.FrmConsulta fc = new Procesos.FrmConsulta();
      fc.ShowDialog();
    }

    //Forma para ejecutar subprogs. almacenados.
    private void MnuSubprogsAlm_Click(object sender, EventArgs e) {
      Procesos.FrmSubprogsAlm fsa = new Procesos.FrmSubprogsAlm();
      fsa.Show();
    }

    //Forma que usa al GestorBD.
    private void MnuGestorBD_Click(object sender, EventArgs e) {
      Procesos.FrmGestorBD fg = new Procesos.FrmGestorBD();
      fg.Show();
    }

    //Abre la forma de congresos
    private void congresosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Tablas.FrmCongresos fc = new Tablas.FrmCongresos();
      fc.Show();
    }

    //Abre la forma de autores
    private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Tablas.FrmAutores fa = new Tablas.FrmAutores();
      fa.Show();
    }

    //Abre la forma de artículos
    private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Tablas.FrmArticulos fa = new Tablas.FrmArticulos();
      fa.Show();
    }

    //Abre la forma de organizaciones
    private void organizacionesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Tablas.FrmOrganizaciones fo = new Tablas.FrmOrganizaciones();
      fo.Show();
    }

    private void generalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Tablas.FrmGeneral fg = new Tablas.FrmGeneral();
      fg.Show();
    }

    //Abre la forma de las consultas
    private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Tablas.FrmConsultas fc = new Tablas.FrmConsultas();
      fc.Show();
    }

    //Abre la forma que ejecuta la función y el procedimiento almacenados
    private void funcionYProgramaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Tablas.FrmFuncProg ff = new Tablas.FrmFuncProg();
      ff.Show();
    }
  }
}
