using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (Menu1.SelectedValue.Equals("Paciente"))
            {
                Response.Redirect("Paciente.aspx");
            }

            if (Menu1.SelectedValue.Equals("Medico"))
            {
                Response.Redirect("Medico.aspx");
            }

            if (Menu1.SelectedValue.Equals("Exame"))
            {
                Response.Redirect("Exame.aspx");
            }
            if (Menu1.SelectedValue.Equals("Consulta"))
            {
                Response.Redirect("Consulta.aspx");
            }
        }
    }
}