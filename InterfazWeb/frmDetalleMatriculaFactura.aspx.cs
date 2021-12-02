using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocio;
using Entidades;
using System.Data;

namespace InterfazWeb
{
    public partial class frmDetalleMatriculaFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["_numFactura"] != null)
            {
                DataSet DS;
                LogicaMatricula matricula = new LogicaMatricula(Configuracion.getConnectionString);
                LogicaValoresReferencia logicaValores = new LogicaValoresReferencia(Configuracion.getConnectionString); //se obtiene el periodo y el anio correspondiente
                ValoresReferencia valoresR = new ValoresReferencia();
                Matricula matriculaEstudiante;
                try
                {
                    if (!Page.IsPostBack)
                    {
                        Session["_mensaje"] = null;

                        DS = matricula.ListarMateriasMatriculadas(Convert.ToInt32(Session["_numFactura"]));//obtiene las materias matriculadas del estudiante que pago la matricula
                        matriculaEstudiante = matricula.ObtenerMatricula(Convert.ToInt32(Session["_numFactura"]));
                        ltlNumFactura.Text = matriculaEstudiante.NumeroFactura.ToString();
                        ltlFechaMatricula.Text = matriculaEstudiante.FechaMatricula.ToString("yyyy-MM-dd");
                        ltlCarnetEstudiante.Text = matriculaEstudiante.CarnetEstudiante.CarnetEstudiante;
                        ltlNombreEstudiante.Text = matriculaEstudiante.CarnetEstudiante.Nombre;
                        ltlTipoPago.Text = matriculaEstudiante.TipoPago;
                        ltlMontoMatricula.Text = string.Format("₡{0} con impuestos incluidos.", matriculaEstudiante.MontoMatricula);

                        valoresR = logicaValores.RecuperarPeriodoAnio();
                        ltlValorMatricula.Text = string.Format("₡{0}", valoresR.ValorMatricula);


                        if (DS.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                        {
                            GrdVerMaterias.DataSource = DS;
                            GrdVerMaterias.DataMember = DS.Tables[0].TableName; //se carga el dataset
                            GrdVerMaterias.DataBind();
                        }
                    }
                }
                catch (Exception)
                {

                    Session["_mensaje"] = "Error al Cargar la Factura de la matrícula";
                    Response.Redirect("FrmMatricular.aspx");
                }
            }
            else
            {
                Session["_mensaje"] = "No fue posible obtener la informacion de la matrícula";
                Response.Redirect("FrmMatricular.aspx");
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Session["_numFactura"] = null;
            Session["_CarnetEstudiante"] = null;
            Session["_codCurso"] = null;
            Response.Redirect("FrmMatricular.aspx");
        }
    }
}