using AtvPo4bim;
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
    public partial class TelaCDEMP : Form
    {

        public TelaCDEMP()
        {
            InitializeComponent();

            botcdemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botcdemp.FlatAppearance.BorderSize = 0;
            botcdemp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botcdemp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botcdemp.BackColor = Color.Transparent;

            botdelearemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botdelearemp.FlatAppearance.BorderSize = 0;
            botdelearemp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botdelearemp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botdelearemp.BackColor = Color.Transparent;

            fecharcdemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            fecharcdemp.FlatAppearance.BorderSize = 0;
            fecharcdemp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            fecharcdemp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            fecharcdemp.BackColor = Color.Transparent;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnpjemp.Clear();
            cnpjemp.Clear();
            capitalS.Clear();
            razaoS.Clear();
            NomeF.Clear();
            telefoneemp.Clear();
            enderecoemp.Clear();
            Nomepropri.Clear();
            cpfpro.Clear();
            situacaoCD.Text = "";
            Naturezaju.Text = "";
            estadoemp.Text = "";
           
          
        }

        private void fecharcdemp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botcdemp_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();

            emp.Cnpj = cnpjemp.Text;
            emp.SitucaoC = situacaoCD.Text;
            emp.CapitalS = capitalS.Text;
            emp.RazaoS = razaoS.Text;
            emp.NomeFan = NomeF.Text;
            emp.Tipo = PanelRadioTipo();
            emp.DataATV = dataIni.Text;
            emp.Telefone = telefoneemp.Text;
            emp.RegimeT = PanelRadioRegime();
            emp.Endereco = enderecoemp.Text;
            emp.Cidade = cidadeemp.Text;
            emp.NaturezaJ = Naturezaju.Text;
            emp.Estado = estadoemp.Text;
            emp.PorteE = PanelRadioPanelPorteEmpresa();
            emp.NomeP = Nomepropri.Text;
            emp.CpfPr = cpfpro.Text;

            Inserir(emp);
        }

        public string PanelRadioRegime()
        {
            string radio = "";

            foreach (Control ctrl in panelRegime.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }

            return radio;
        }
        public string PanelRadioTipo()
        {
            string radio = "";

            foreach (Control ctrl in panelTipo.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }

            return radio;
        }
        public string PanelRadioPanelPorteEmpresa()
        {
            string radio = "";

            foreach (Control ctrl in panelPorteEmpresa.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }

            return radio;
        }

        private void Inserir(Empresa empresa)
        {
            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Empresa (cnpj_Emp, situacao_cadastral_Emp, capital_social_Emp, razao_social_Emp, nome_fantasia_Emp, tipo_Emp, data_inicio_atividade_Emp, telefone_Emp, regime_tributario_Emp, endereco_Emp , cidade_Emp, natureza_jur_Emp, estado_Emp, porte_Empresa_Emp, nome_proprietario_Emp, cpf_proprietario_Emp)" +
                    " VALUES (@cnpj, @Situacao_Cadastral, @capital_social, @razao_social, @nome_fantasia,  @tipo, @data_inicio_atividade, @telefone, @regime_tributario, @endereco, @cidade, @natureza_jur, @estado, @porte_Empresa, @nome_proprietario, @cpf_proprietario)");

                comando.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comando.Parameters.AddWithValue("@Situacao_Cadastral", empresa.SitucaoC);
                comando.Parameters.AddWithValue("@capital_social", empresa.CapitalS);
                comando.Parameters.AddWithValue("@razao_social", empresa.RazaoS);
                comando.Parameters.AddWithValue("@nome_fantasia", empresa.NomeFan);
                comando.Parameters.AddWithValue("@tipo", empresa.Tipo);
                comando.Parameters.AddWithValue("@data_inicio_atividade", empresa.DataATV);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@regime_tributario", empresa.RegimeT);
                comando.Parameters.AddWithValue("@endereco", empresa.Endereco);
                comando.Parameters.AddWithValue("@cidade", empresa.Cidade);
                comando.Parameters.AddWithValue("@natureza_jur", empresa.NaturezaJ);
                comando.Parameters.AddWithValue("@estado", empresa.Estado);
                comando.Parameters.AddWithValue("@porte_Empresa", empresa.PorteE);
                comando.Parameters.AddWithValue("@nome_proprietario", empresa.NomeP);
                comando.Parameters.AddWithValue("@cpf_proprietario", empresa.CpfPr);
                
               


                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0) { MessageBox.Show("Empresa Cadastrada com Sucesso", "OK", MessageBoxButtons.OK); }

            }
            catch (Exception ex) { throw ex; }
        }


    }
}

