using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClinicaMedicaEntities4 conexao = new ClinicaMedicaEntities4();
                carregarGrid(conexao);
                carregapaciente(conexao);
                carregaexame(conexao);
                carregamedico(conexao);
            }

        }

        protected void btncadastrar_Click(object sender, EventArgs e)
        {
            ClinicaMedicaEntities4 conexao = new ClinicaMedicaEntities4();
            Consultas c = new Consultas();
            c.Data =Convert.ToDateTime(txtdata.Text);
            c.FK_Exame =Convert.ToInt32(ddlexame.Text);
            c.FK_Medico = Convert.ToDecimal(ddlmedico.Text);
            c.FK_Paciente = Convert.ToDecimal(ddlpaciente.Text);

            conexao.Consultas.Add(c);
            conexao.SaveChanges();

            Limpar();
            carregarGrid(conexao);
        }

        private void carregapaciente(ClinicaMedicaEntities4 conexao)
        {
            var pacientes = conexao.Paciente.ToList();
            ddlpaciente.DataSource = pacientes;
            ddlpaciente.DataTextField = "Nome";
            ddlpaciente.DataValueField = "CPF";
            ddlpaciente.DataBind();
        }
        private void carregamedico(ClinicaMedicaEntities4 conexao)
        {
            var medico = conexao.Medicos.ToList();
            ddlmedico.DataSource = medico;
            ddlmedico.DataTextField = "Nome";
            ddlmedico.DataValueField = "CRM";
            ddlmedico.DataBind();
        }
        private void carregaexame(ClinicaMedicaEntities4 conexao)
        {
            var exame = conexao.Exame.ToList();
            ddlexame.DataSource = exame;
            ddlexame.DataTextField = "Tipo";
            ddlexame.DataValueField = "ID";
            ddlexame.DataBind();
        }

        private void Limpar()
        {
            
            txtdata.Text = string.Empty;
        }
        private void carregarGrid(ClinicaMedicaEntities4 conexao)
        {
            var lista = conexao.Consultas.ToList();
            gridconsulta.DataSource = lista;
            gridconsulta.DataBind();
        }
    }
}