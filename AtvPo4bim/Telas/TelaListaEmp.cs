using AtvPo4bim.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtvPo4bim
{
    public partial class TelaListaEmp : Form
    {
        public List<Empresa> emplist = new List<Empresa>();
        public TelaListaEmp()
        {
            InitializeComponent();
            Consultar();

            voltarle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            voltarle.FlatAppearance.BorderSize = 0;
            voltarle.FlatAppearance.MouseDownBackColor = Color.Transparent;
            voltarle.FlatAppearance.MouseOverBackColor = Color.Transparent;
            voltarle.BackColor = Color.Transparent;

            botcdemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botcdemp.FlatAppearance.BorderSize = 0;
            botcdemp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botcdemp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botcdemp.BackColor = Color.Transparent;
        }

        private void voltarle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botcdemp_Click(object sender, EventArgs e)
        {
            TelaCDEMP TCE = new TelaCDEMP();
            TCE.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM Empresa");

                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    Empresa empresa = new Empresa();

                    empresa.Id = leitor.GetString("id_Emp");

                    empresa.Cnpj = DAOHelper.GetString(leitor, "cnpj_Emp");
                    empresa.SitucaoC = DAOHelper.GetString(leitor, "Situacao_Cadastral_Emp");
                    empresa.CapitalS = DAOHelper.GetString(leitor, "capital_social_Emp");
                    empresa.RazaoS = DAOHelper.GetString(leitor, "razao_social_Emp");
                    empresa.NomeFan = DAOHelper.GetString(leitor, "nome_fantasia_Emp");                 
                    empresa.Tipo = DAOHelper.GetString(leitor, "tipo_Emp");                                      
                    empresa.DataATV = DAOHelper.GetString(leitor, "data_inicio_atividade_Emp");
                    empresa.Telefone = DAOHelper.GetString(leitor, "telefone_Emp");
                    empresa.RegimeT = DAOHelper.GetString(leitor, "regime_tributario_Emp");
                    empresa.Endereco = DAOHelper.GetString(leitor, "endereco_Emp");
                    empresa.Cidade = DAOHelper.GetString(leitor, "cidade_Emp");
                    empresa.NaturezaJ = DAOHelper.GetString(leitor, "natureza_jur_Emp");
                    empresa.Estado = DAOHelper.GetString(leitor, "estado_Emp");
                    empresa.PorteE = DAOHelper.GetString(leitor, "porte_Empresa_Emp");
                    empresa.NomeP = DAOHelper.GetString(leitor, "nome_proprietario_Emp");
                    empresa.CpfPr = DAOHelper.GetString(leitor, "cpf_proprietario_Emp");


                    emplist.Add(empresa);
                }

                dgvEmpresa.DataSource = null;
                dgvEmpresa.Refresh();
                dgvEmpresa.DataSource = emplist;
            }

            catch
            {
                throw;
            }
        }
    }
}
