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
  public partial class FrmConsultas : Form
  {
    public FrmConsultas()
    {
      InitializeComponent();
    }

    private void consulta1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // TODO: esta línea de código carga datos en la tabla 'dsEmpresaCongresoMonto.EMPRESACONGRESOMONTO' Puede moverla o quitarla según sea necesario.
      this.dataGridView1.DataSource = eMPRESACONGRESOMONTOBindingSource;
      this.eMPRESACONGRESOMONTOTableAdapter.Fill(this.dsEmpresaCongresoMonto.EMPRESACONGRESOMONTO);
      this.Text = "Muestra el nombre y monto total de las empresas que han financiado más de un congreso.";
    }

    private void consulta2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // TODO: esta línea de código carga datos en la tabla 'dsArticuloOrganizacionAño.ARTICULOSORGANIZACIONAÑO' Puede moverla o quitarla según sea necesario.
      this.dataGridView1.DataSource = aRTICULOSORGANIZACIONAÑOBindingSource;
      this.aRTICULOSORGANIZACIONAÑOTableAdapter.Fill(this.dsArticuloOrganizacionAño.ARTICULOSORGANIZACIONAÑO);
      this.Text = "Muestra el nombre de la institución, la cantidad de artículos que han presentado sus invesitgadores y todo esto por año.";
    }

    private void consulta3ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.dataGridView1.DataSource = aUTORESMASARTICULOSBindingSource;
      // TODO: esta línea de código carga datos en la tabla 'dsAutoresMasArticulos.AUTORESMASARTICULOS' Puede moverla o quitarla según sea necesario.
      this.aUTORESMASARTICULOSTableAdapter.Fill(this.dsAutoresMasArticulos.AUTORESMASARTICULOS);
      this.Text = "Muestra los autores que tienen más artículos que han sido presentados en algún congresos y muestra en cuantos se han presentado.";
    }

    private void consulta4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.dataGridView1.DataSource = bECAINSTITUCIONARTICULOBindingSource;
      // TODO: esta línea de código carga datos en la tabla 'dsBecaInstitucionArticulo.BECAINSTITUCIONARTICULO' Puede moverla o quitarla según sea necesario.
      this.bECAINSTITUCIONARTICULOTableAdapter.Fill(this.dsBecaInstitucionArticulo.BECAINSTITUCIONARTICULO);
      this.Text = "Muestra el nombre y el país de las instituciones que otorgaron becas que generaron artículos que se presentaron en sus congresos.";
    }
  }
}
