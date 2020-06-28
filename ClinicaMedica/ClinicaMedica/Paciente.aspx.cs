using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class Paciente1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClinicaMedicaEntities4 conexao = new ClinicaMedicaEntities4();
            carregarGrid(conexao);
        }

        protected void btncadastrar_Click(object sender, EventArgs e)
        {
            ClinicaMedicaEntities4 conexao = new ClinicaMedicaEntities4();

            Paciente p = new Paciente();
            p.Nome = txtnome.Text;
            p.CPF = Convert.ToDecimal(txtcpf.Text);
            p.Endereco = txtendereco.Text;
            p.Email = txtemail.Text;
            p.Telefone = Convert.ToDecimal(txttel.Text);
            p.RG = Convert.ToDecimal(txtrg.Text);

            conexao.Paciente.Add(p);
            conexao.SaveChanges();

            Limpar();

            carregarGrid(conexao);
        }

        protected void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtcpf.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtendereco.Text = string.Empty;
            txtnome.Text = string.Empty;
            txtrg.Text = string.Empty;
            txttel.Text = string.Empty;
        }

        private void carregarGrid(ClinicaMedicaEntities4 conexao)
        {
            var lista = conexao.Paciente.ToList();
            GridPaciente.DataSource = lista;
            GridPaciente.DataBind();
        }

        protected void btnalterar_Click1(object sender, EventArgs e)
        {
            if (GridPaciente.SelectedValue != null)
            {
                ClinicaMedicaEntities4 conexao = new ClinicaMedicaEntities4();
                int id = Convert.ToInt32(GridPaciente.SelectedValue.ToString());

                Paciente a = conexao.Paciente.FirstOrDefault(linha => linha.CPF.ToString().Equals(id.ToString()));

                txtnome.Text = a.Nome;
                txtcpf.Text = a.CPF.ToString();
                txtemail.Text = a.Email;
                txtendereco.Text = a.Endereco;
                txtrg.Text = a.RG.ToString();
                txttel.Text = a.Telefone.ToString();

            }
        }
    }
}