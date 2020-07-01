using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio3
{
    public partial class Alter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GestionBD bD = new GestionBD();
            bD.jalar();
        }
    }
}