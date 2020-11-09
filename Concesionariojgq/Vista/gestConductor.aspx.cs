using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Conductor;

namespace Vista
{
    public partial class gestConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            int idtipoconductor     = Int32.Parse(txtId.Text);
            string nombreConductor  = txtName.Text;
            string tipo_licencia    = txtTipo_Licencia.Text;
            int id_vehiculo         = Int32.Parse(txId_Vehiculo.Text);
            int id_tipoConductor    = Int32.Parse(txtId_Tipo_Conductor.Text);

            logicaControladorConductor negocioAddConductor = new logicaControladorConductor();

            int resultadoAddConductor = negocioAddConductor.NegociarInsertConductor(idtipoconductor, nombreConductor, tipo_licencia, id_vehiculo, id_tipoConductor);


            if (resultadoAddConductor > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se puedo registrar";

        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorConductor.NegociarSelectConductor();

            GridView.DataBind();

            txtId.Text = txtName.Text = txtTipo_Licencia.Text= txId_Vehiculo.Text = txtId_Tipo_Conductor.Text= "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            string typenombre = txtName.Text;
            string typetipo_licencia = txtTipo_Licencia.Text;
            int typeid_vehiculo = Int32.Parse(txId_Vehiculo.Text);
            int typeId_Tipo_Conductor = Int32.Parse(txtId_Tipo_Conductor.Text);

            logicaControladorConductor negocioUpdateConductor = new logicaControladorConductor();

            int resultadoUpdateConductor = negocioUpdateConductor.NegociarUpdateConductor(cartypeid, typenombre, typetipo_licencia, typeid_vehiculo, typeId_Tipo_Conductor);

            if (resultadoUpdateConductor > 0)
                lblMensaje.Text = "Actualizacion ok";
            else
                lblMensaje.Text = "No se pudo actualizar";


            negocioUpdateConductor = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);


            logicaControladorConductor negocioDeleteConductor = new logicaControladorConductor();

            int resultadoDeleteConductor = negocioDeleteConductor.NegociarDeleteConductor(cartypeid);

            if (resultadoDeleteConductor > 0)
                lblMensaje.Text = " Eliminar ok";
            else
                lblMensaje.Text = "No se pudo eliminar";


            negocioDeleteConductor = null;
        }
    }
}