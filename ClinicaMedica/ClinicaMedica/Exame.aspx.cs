using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class Exame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClinicaMedicaEntities4 conexao = new ClinicaMedicaEntities4();
            carregarGrid(conexao);
        }

        protected void btncadastrar_Click(object sender, EventArgs e)
        {
            ClinicaMedicaEntities4 conexao = new ClinicaMedicaEntities4();

            Exame exame = new Exame();
            exame.Tipo = txttipo.Text;
            exame.Valor = Convert.ToInt32(txtvalor.Text);

            conexao.Exame.Add(exame);
            conexao.SaveChanges();

            Limpar();

            carregarGrid(conexao);
        }

        private void Limpar()
        {
            txttipo.Text = string.Empty;
            txtvalor.Text = string.Empty;
        }

        private void carregarGrid(ClinicaMedicaEntities4 conexao)
        {
            var lista = conexao.Medicos.ToList();
            gridexame.DataSource = lista;
            gridexame.DataBind();
        }
    }
}