using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Vehiculo;

namespace Vista
{
    public partial class gestVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idvehiculo = Int32.Parse(txtId.Text);
            string marcavehiculo = txtMarca.Text;
            string modelovehiculo = txtModelo.Text;
            string matriculavehiculo = txtMatricula.Text;
            int anio = Int32.Parse(txtAnio.Text);
            int Tipo_Vehiculo = Int32.Parse(txtId_Tipo_Vehiculo.Text);

            logicaControladorVehiculos negocioAddVehiculo = new logicaControladorVehiculos();

            int resultadoAddVehiculo = negocioAddVehiculo.NegociarInsertVehiculo(idvehiculo, marcavehiculo, modelovehiculo, matriculavehiculo, anio, Tipo_Vehiculo);

            if (resultadoAddVehiculo > 0)
            {
                lblMensaje.Text = "Registro ok";
            }
            else
            {
                lblMensaje.Text = "No se puedo registrar";
            }

            negocioAddVehiculo = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource =logicaControladorVehiculos.NegociarSelectVehiculo();

            GridView.DataBind();

            txtId.Text = txtMarca.Text = txtModelo.Text = txtMatricula.Text = txtAnio.Text = txtId_Tipo_Vehiculo.Text= "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            string typemarca = txtMarca.Text;
            string typemodelo = txtModelo.Text;
            string typematricula = txtMatricula.Text;
            int typeanio = Int32.Parse(txtAnio.Text);
            int typeId_Tipo_Vehiculo = Int32.Parse(txtId_Tipo_Vehiculo.Text);

            logicaControladorVehiculos negocioUpdateVehiculo = new logicaControladorVehiculos();

            int resultadoUpdateVehiculos = negocioUpdateVehiculo.NegociarUpdateVehiculo(cartypeid, typemarca, typemodelo, typematricula, typeanio, typeId_Tipo_Vehiculo);

            if (resultadoUpdateVehiculos > 0)
                lblMensaje.Text = "Actualizacion ok";
            else
                lblMensaje.Text = "No se pudo actualizar";


            negocioUpdateVehiculo = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);


            logicaControladorVehiculos negocioDeleteVehiculo = new logicaControladorVehiculos();

            int resultadoDeleteVehiculo = negocioDeleteVehiculo.NegociarDeleteVehiculo(cartypeid);

            if (resultadoDeleteVehiculo > 0)
                lblMensaje.Text = " Eliminar ok";
            else
                lblMensaje.Text = "No se pudo eliminar";


            negocioDeleteVehiculo = null;
        }
    }
}