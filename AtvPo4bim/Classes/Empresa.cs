using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvPo4bim.Telas
{
    public class Empresa
    {
        public string Id { get; set; }
        public string Cnpj { get; set; }

        public string SitucaoC { get; set; }

        public string CapitalS { get; set; }

        public string RazaoS { get; set; }

        public string NomeFan { get; set; }

        public string Tipo { get; set; }

        public string DataATV { get; set; }

        public string Telefone { get; set; }

        public string RegimeT { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string NaturezaJ { get; set; }

        public string Estado { get; set; }

        public string PorteE { get; set; }

        public string NomeP { get; set; }

        public string CpfPr { get; set; }

        public Empresa()
        {
            
        }

        public Empresa(string id,string cnpj, string situcaoC, string capitalS, string razaoS, string nomeFan, string tipo, string dataATV, string telefone, 
            string regimeT, string endereco, string cidade, string naturezaJ, string estado, string porteE, string nomeP, string cpfPr)
        {
            Id = id;
            Cnpj = cnpj;
            SitucaoC = situcaoC;
            CapitalS = capitalS;
            RazaoS = razaoS;
            NomeFan = nomeFan;
            Tipo = tipo;
            DataATV = dataATV;
            Telefone = telefone;
            RegimeT = regimeT;
            Endereco = endereco;
            Cidade = cidade;
            NaturezaJ = naturezaJ;
            Estado = estado;
            PorteE = porteE;
            NomeP = nomeP;
            CpfPr = cpfPr;
        }


    }
}
