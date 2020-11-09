using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador.Ruta;

namespace Vista
{
    public partial class gestRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id_ruta = Int32.Parse(txtId.Text);
            string estacion = txtestacion.Text;
            int id_vehiculo = Int32.Parse(txtId_Vehiculo.Text);

            logicaControladorRuta negocioAddRuta = new logicaControladorRuta();

            int resultadoAddRuta = negocioAddRuta.NegociarInsertRuta(id_ruta, estacion, id_vehiculo);


            if (resultadoAddRuta > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se puedo registrar";
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorRuta.NegociarSelectRuta();

            GridView.DataBind();

            txtId.Text = txtestacion.Text = txtId_Vehiculo.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            string typeid_estacion = (txtestacion.Text);
            int typeid_vehiculo = Int32.Parse(txtId_Vehiculo.Text);

            logicaControladorRuta negocioUpdateRuta = new logicaControladorRuta();

            int resultadoUpdateRuta = negocioUpdateRuta.NegociarUpdateRuta(cartypeid, typeid_estacion, typeid_vehiculo);

            if (resultadoUpdateRuta > 0)
                lblMensaje.Text = "Actualizacion ok";
            else
                lblMensaje.Text = "No se pudo actualizar";


            negocioUpdateRuta = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);


            logicaControladorRuta negocioDeleteRuta = new logicaControladorRuta();

            int resultadoDeleteRuta = negocioDeleteRuta.NegociarDeleteRuta(cartypeid);

            if (resultadoDeleteRuta > 0)
                lblMensaje.Text = " Eliminar ok";
            else
                lblMensaje.Text = "No se pudo eliminar";


            negocioDeleteRuta = null;
        }
    }
}