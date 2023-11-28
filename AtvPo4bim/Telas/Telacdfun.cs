using AtvPo4bim;
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

    public partial class Telacdfun : Form
    {
        
        public validacoesfun fun = new validacoesfun();
        public Telacdfun()
        {
            InitializeComponent();

            voltarcdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            voltarcdf.FlatAppearance.BorderSize = 0;
            voltarcdf.FlatAppearance.MouseDownBackColor = Color.Transparent;
            voltarcdf.FlatAppearance.MouseOverBackColor = Color.Transparent;
            voltarcdf.BackColor = Color.Transparent;

            deletarf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deletarf.FlatAppearance.BorderSize = 0;
            deletarf.FlatAppearance.MouseDownBackColor = Color.Transparent;
            deletarf.FlatAppearance.MouseOverBackColor = Color.Transparent;
            deletarf.BackColor = Color.Transparent;

            cadastrarf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cadastrarf.FlatAppearance.BorderSize = 0;
            cadastrarf.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cadastrarf.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cadastrarf.BackColor = Color.Transparent;
        }

        private void voltarcdf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Telacdfun_Load(object sender, EventArgs e)
        {

        }

        private void cepfun_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarf_Click(object sender, EventArgs e)
        {
            

            fun.Id = IDfun.Text;
            fun.Nome = nomefun.Text;
            fun.Cpf = cpffun.Text;
            fun.Rg = rgfun.Text;
            fun.Telefone = telefonefun.Text;
            fun.Email = emailfun.Text;
            fun.Datanasc = datanasfun.Text;
            fun.Endereco = enderecofun.Text;
            fun.Salario = Convert.ToDouble(salariofun.Text); 
            fun.Cidade = cidadefun.Text;
            fun.Estado = estadofun.Text;
            fun.Funcao = funcaofun.Text;
            fun.Cep = cepfun.Text;

            Inserir(fun);
        }
        private void Inserir(validacoesfun funcionario)
        {
            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Funcionario (nome_Fun, cpf_Fun, rg_Fun, telefone_Fun, email_Fun, data_nascimento_Fun, endereco_Fun, salario_Fun, cidade_Fun, estado_Fun , funcao_Fun, cep_Fun) VALUES (@nome, @cpf, @rg, @telefone, @email,  @data_Nascimento, @endereco,  @salario, @cidade, @estado, @funcao, @cep)");

                comando.Parameters.AddWithValue("@nome", fun.Nome);
                comando.Parameters.AddWithValue("@cpf", fun.Cpf);
                comando.Parameters.AddWithValue("@rg", fun.Rg);
                comando.Parameters.AddWithValue("@telefone", fun.Telefone);
                comando.Parameters.AddWithValue("@email", fun.Email);
                comando.Parameters.AddWithValue("@data_Nascimento", fun.Datanasc);
                comando.Parameters.AddWithValue("@endereco", fun.Endereco);
                comando.Parameters.AddWithValue("@salario", fun.Salario);
                comando.Parameters.AddWithValue("@cidade", fun.Cidade);
                comando.Parameters.AddWithValue("@estado", fun.Estado);
                comando.Parameters.AddWithValue("@funcao", fun.Funcao);
                comando.Parameters.AddWithValue("@cep", fun.Cep);


                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0) { MessageBox.Show("Funcionario Cadastrado com Sucesso", "OK", MessageBoxButtons.OK); }

            }
            catch (Exception ex) {  throw ex; }
        }

        private void deletarf_Click(object sender, EventArgs e)
        {
            IDfun.Clear();
            nomefun.Clear();
            cpffun.Clear();
            rgfun.Clear();
            telefonefun.Clear();
            emailfun.Clear();
            datanasfun.Clear();
            enderecofun.Clear();
            salariofun.Clear();
            cidadefun.Clear();
            estadofun.Text = "";
            funcaofun.Clear();
            cepfun.Clear();
            
        }
    }
}
