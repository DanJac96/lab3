using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;

namespace Laboratorio3
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
           
            if (!IsPostBack)
            {
                dDList.Items.Insert(0, new ListItem(String.Empty, String.Empty));
                dDList.SelectedIndex = 0;
                dDLTip.Items.Insert(0, new ListItem(String.Empty, String.Empty));
                dDLTip.SelectedIndex = 0;
            }
            

        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            Herram ObjH = new Herram();
            CapaDatos.Catalogos.Herramientas catalogos = new CapaDatos.Catalogos.Herramientas();
            CapaDatos.GestionBD gestionBD = new GestionBD();
            catalogos.Producto = dDList.SelectedValue;
            catalogos.TProducto = dDLTip.SelectedValue;
            catalogos.Ubicacion = chBox.SelectedValue;
            catalogos.cant = Convert.ToInt32(cantidad.Text);
            gestionBD.inserts(catalogos);
        }

        protected void btModificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Alter.aspx");
        }
    }
}