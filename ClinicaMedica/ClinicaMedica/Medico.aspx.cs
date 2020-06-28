using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class Medico1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClinicaMedicaEntities4 conexao = new ClinicaMedicaEntities4();
            carregarGrid(conexao);
        }

        protected void btncadastrar_Click(object sender, EventArgs e)
        {
            ClinicaMedicaEntities4 conexao = new ClinicaMedicaEntities4();

            Medicos m = new Medicos();
            m.CRM = Convert.ToDecimal(txtcrm.Text);
            m.Nome = txtnome.Text;
            m.CPF = Convert.ToDecimal(txtcpf.Text);
            m.RG = Convert.ToDecimal(txtrg.Text);
            m.Telefone = Convert.ToDecimal(txttel.Text);
            m.Email = txtemail.Text;

            conexao.Medicos.Add(m);
            conexao.SaveChanges();

            Limpar();

            carregarGrid(conexao);
        }

        private void Limpar()
        {
            txtcpf.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtnome.Text = string.Empty;
            txtrg.Text = string.Empty;
            txttel.Text = string.Empty;
        }

        private void carregarGrid(ClinicaMedicaEntities4 conexao)
        {
            var lista = conexao.Medicos.ToList();
            gridMedico.DataSource = lista;
            gridMedico.DataBind();
        }
    }
}