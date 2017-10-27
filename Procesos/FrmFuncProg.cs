using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AplicaciónCSBD.Tablas
{
  public partial class FrmFuncProg : Form
  {
    public FrmFuncProg()
    {
      InitializeComponent();
    }

    //Variable para conectarse a Oracle.
    OleDbConnection cnOracle;

    private void FrmFuncProg_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      String nomEmpresa1; String nomEmpresa2; String res;
      OleDbCommand procAlm;
      OleDbParameter par;

      //1- Abrir la conexión a la BD.
      cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle.itam.mx;" +
        "User ID=bd01;Password=esqose");
      cnOracle.Open();
      procAlm = new OleDbCommand();
      procAlm.Connection = cnOracle;

      //2- Especificar el llamado al procedimiento  (en general: al subprograma).
      procAlm.CommandText = " masPatrocinios";
      procAlm.CommandType = CommandType.StoredProcedure;

      //3- Especificar los parámetros:
      //a) primero todos los de entrada:
      nomEmpresa1 = "Telmex";
      par = new OleDbParameter("nombre1", nomEmpresa1);
      procAlm.Parameters.Add(par);

      nomEmpresa2 = "Google";
      par = new OleDbParameter("nombre2", nomEmpresa2);
      procAlm.Parameters.Add(par);

      //b) luego todos los de salida (uno en este caso):
      par = new OleDbParameter("res", OleDbType.Char, 10, ParameterDirection.Output, false, 10, 0, "Nombre", DataRowVersion.Current, 0);
      procAlm.Parameters.Add(par);

      //4- Ejecutar el procedimiento (en general: el subprograma).
      try
      {
        procAlm.ExecuteNonQuery();

        //5- Recuperar el (los) valor(es) regresado(s) por medio del (de los)
        //   parámetro(s) de salida.
        res = procAlm.Parameters["res"].Value.ToString();
        MessageBox.Show("Empresa con más concursos: " + res);
      }
      catch (OleDbException err)
      {
        MessageBox.Show(err.Message);
      }

      //6- Cerrar la conexión a la BD.
      cnOracle.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      String nomOrg; int cant;
      OleDbCommand procAlm;
      OleDbParameter par;

      //1- Abrir la conexión a la BD.
      cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle.itam.mx;" +
        "User ID=bd01;Password=esqose");
      cnOracle.Open();
      procAlm = new OleDbCommand();
      procAlm.Connection = cnOracle;

      //2- Especificar el llamado a la función.
      procAlm.CommandText = "cantCongPat";
      procAlm.CommandType = CommandType.StoredProcedure;

      //3- Especificar los parámetros:
      // a) Nota: primero hay que definir el tipo de valor que regresará la función.
      par = new OleDbParameter("RETURN_VALUE", OleDbType.Integer,
        4, ParameterDirection.ReturnValue, false, 4, 0, "None", DataRowVersion.Current, 0);
      procAlm.Parameters.Add(par);

      // b) luego hay que definir los parámetros de entrada (uno en este caso).
      nomOrg = "Telmex";
      par = new OleDbParameter("nombreOrg", nomOrg);
      procAlm.Parameters.Add(par);

      //4- Ejecutar el procedimiento (en general: el subprograma).
      try
      {
        procAlm.ExecuteNonQuery();

        //5- Recuperar el valor regresado por la función.
        cant = Convert.ToInt16(procAlm.Parameters["RETURN_VALUE"].Value);
        MessageBox.Show("Cantidad de congresos patrocinados por  " + nomOrg + ": " + cant);
      }
      catch (OleDbException err)
      {
        MessageBox.Show(err.Message);
      }

      //6- Cerrar la conexión a la BD.
      cnOracle.Close();
    }
  }
}
