using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvPo4bim
{
    public class validacoesfun
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Rg { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Datanasc { get; set; }

        public string Endereco { get; set; }

        public double Salario { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Funcao { get; set; }

        public string Cep { get; set; }

        public validacoesfun()
        {

        }

        public validacoesfun(string id, string nome, string cpf, string rg, string email, string datanasc, string endereco, double salario,
            string cidade, string estado, string funcao, string cep)
        {
            id = id;
            nome = nome;
            cpf = cpf;
            rg = rg;
            email = email;
            datanasc = datanasc;
            endereco = endereco;
            salario = salario;
            cidade = cidade;
            estado = estado;
            funcao = funcao;
            cep = cep;
        }

    }

}
