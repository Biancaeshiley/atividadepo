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
    public partial class TelaListaFun : Form
    {
        public List<validacoesfun> funlist = new List<validacoesfun>();

        public TelaListaFun()
        {
            InitializeComponent();
            Consultar();

            botcdfun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botcdfun.FlatAppearance.BorderSize = 0;
            botcdfun.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botcdfun.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botcdfun.BackColor = Color.Transparent; 

            Botvoltarf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Botvoltarf.FlatAppearance.BorderSize = 0;
            Botvoltarf.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Botvoltarf.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Botvoltarf.BackColor = Color.Transparent;
        }

        private void botcdfun_Click(object sender, EventArgs e)
        {
            Telacdfun TCDF = new Telacdfun();
            TCDF.ShowDialog();

            
        }

        private void Botvoltarf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtlistafuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TelaListaFun_Load(object sender, EventArgs e)
        {

        }

        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM Funcionario");

                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    validacoesfun funcionario = new validacoesfun();

                    funcionario.Id = leitor.GetString("id_Fun");

                    funcionario.Nome = DAOHelper.GetString(leitor, "nome_Fun");
                    funcionario.Cpf = DAOHelper.GetString(leitor, "cpf_Fun");
                    funcionario.Rg = DAOHelper.GetString(leitor, "rg_Fun");
                    funcionario.Telefone = DAOHelper.GetString(leitor, "telefone_Fun");
                    funcionario.Email = DAOHelper.GetString(leitor, "email_Fun");
                    funcionario.Datanasc = DAOHelper.GetString(leitor, "data_nascimento_Fun");            
                    funcionario.Endereco = DAOHelper.GetString(leitor, "endereco_Fun");
                    funcionario.Salario = DAOHelper.GetDouble(leitor, "salario_Fun");
                    funcionario.Cidade = DAOHelper.GetString(leitor, "cidade_Fun");
                    funcionario.Estado = DAOHelper.GetString(leitor, "estado_Fun");
                    funcionario.Funcao = DAOHelper.GetString(leitor, "funcao_Fun");
                    funcionario.Cep = DAOHelper.GetString(leitor, "cep_Fun");


                    funlist.Add(funcionario);
                }

                dtlistafuncionario.DataSource = null;
                dtlistafuncionario.Refresh();
                dtlistafuncionario.DataSource = funlist;
            }

            catch
            {
                throw;
            }
        }
    }
}
