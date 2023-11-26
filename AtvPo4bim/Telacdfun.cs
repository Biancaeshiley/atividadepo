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
            string id = IDfun.Text;
            string nome = nomefun.Text;
            string cpf = cpffun.Text;
            string rg = rgfun.Text;
            string telefone = telefonefun.Text;
            string email = emailfun.Text;
            string datanas = datanasfun.Text;
            string endereco = endereçofun.Text;
            double salario = Convert.ToDouble(salariofun.Text); 
            string cidade = cidadefun.Text;
            string estado = estadofun.Text;
            string funcao = funcaofun.Text;
            string cep = cepfun.Text;


            Validacoes.ValidaCPF(cpf);
            MessageBox.Show(Validacoes.ValidaCPF(cpf).ToString());


        }
    }
}
