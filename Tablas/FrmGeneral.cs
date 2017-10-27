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
  public partial class FrmGeneral : Form
  {
    public FrmGeneral()
    {
      InitializeComponent();
    }

    //Variables de la clase.
    GestorBD.GestorBD GestorBD;
    DataSet dsCong = new DataSet(), dsAutor = new DataSet(), dsArt = new DataSet(), dsOrg = new DataSet();
    string cadSql;

    //Pone los datos de todos los Autores en el dataGrid y pone 'Autores' de título en el form.
    private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      cadSql = "select * from T4Autor";
      GestorBD.consBD(cadSql, "Autores", dsAutor);
      dtgGeneral.DataSource = dsAutor.Tables["Autores"];
      this.Text = "Autores";
    }

    //Pone los datos de las organizaciones en el dataGrid y pone 'Organizaciones' de título en el form.
    private void organizacionesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      cadSql = "select * from T4Organización";
      GestorBD.consBD(cadSql, "Organizaciones", dsOrg);
      dtgGeneral.DataSource = dsOrg.Tables["Organizaciones"];
      this.Text = "Organizaciones";
    }

    private void FrmGeneral_Load(object sender, EventArgs e)
    {
      //Hace la conexión a la BD (sólo crea el objeto de conexión).
      GestorBD = new GestorBD.GestorBD("MSDAORA", "bd01", "esqose", "oracle.itam.mx");
    }

    //Pone los datos de todos los artículos en el dataGrid y pone 'Artículos' de título en el form.
    private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      cadSql = "select * from T4Artículo";
      GestorBD.consBD(cadSql, "Articulos", dsArt);
      dtgGeneral.DataSource = dsArt.Tables["Articulos"];
      this.Text = "Artículos";
    }

    //Pone los datos de todos los congresos en el dataGrid y pone 'Congresos' de título en el form.
    private void congresosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      cadSql = "select * from T4Congreso";
      GestorBD.consBD(cadSql, "Congresos", dsCong);
      dtgGeneral.DataSource = dsCong.Tables["Congresos"];
      this.Text = "Congresos";
    }

    
  }
}
