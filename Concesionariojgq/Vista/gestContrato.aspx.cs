using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Contrato;

namespace Vista
{
    public partial class gestContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id_contrato = Int32.Parse(txtId.Text);
            int id_conductor = Int32.Parse(txtId_Conductor.Text);
            int id_vehiculo = Int32.Parse(txId_Vehiculo.Text);

            logicaControladorContrato negocioAddContrato = new logicaControladorContrato();

            int resultadoAddContrato = negocioAddContrato.NegociarInsertContrato(id_contrato, id_conductor, id_vehiculo);


            if (resultadoAddContrato > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se puedo registrar";


        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorContrato.NegociarSelectContrato();

            GridView.DataBind();

            txtId.Text = txtId_Conductor.Text = txId_Vehiculo.Text= "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            int typeid_conductor = Int32.Parse(txtId_Conductor.Text);
            int typeid_vehiculo = Int32.Parse(txId_Vehiculo.Text);

            logicaControladorContrato negocioUpdateContrato = new logicaControladorContrato();

            int resultadoUpdateContrato = negocioUpdateContrato.NegociarUpdateContrato(cartypeid, typeid_conductor, typeid_vehiculo);

            if (resultadoUpdateContrato > 0)
                lblMensaje.Text = "Actualizacion ok";
            else
                lblMensaje.Text = "No se pudo actualizar";


            negocioUpdateContrato = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);


            logicaControladorContrato negocioDeleteContrato = new logicaControladorContrato();

            int resultadoDeleteContrato = negocioDeleteContrato.NegociarDeleteContrato(cartypeid);

            if (resultadoDeleteContrato > 0)
                lblMensaje.Text = " Eliminar ok";
            else
                lblMensaje.Text = "No se pudo eliminar";


            negocioDeleteContrato = null;
        }
    }
}