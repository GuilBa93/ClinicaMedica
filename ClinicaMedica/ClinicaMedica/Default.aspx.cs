using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string senha = txtsenha.Text;

            ClinicaMedicaEntities4 conexao = new ClinicaMedicaEntities4();
            Usuario user = conexao.Usuario.FirstOrDefault(linha=>linha.Login.Equals(usuario) && linha.Senha.Equals(senha));

            if(user!= null)
            {
                Response.Redirect("Principal.aspx");
            }
        }
    }    
}

