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

  
        public static bool ValidaCPF(string CPF)
        {
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");

            if (CPF.Length != 11)
            { return false; }

            int s = 0;
            int n1 = 10;
            for (int i = 0; i < 9; i++)
            {
                s += Convert.ToInt32(CPF[i].ToString()) * n1;
                n1--;
            }

            int res = s % 11;

            if (res < 2)
            { res = 0; }

            else
            { res = 11 - res; }

            
            int so = 0;
            int n2 = 11;
            for (int i = 0; i < 10; i++)
            {
                so += Convert.ToInt32(CPF[i].ToString()) * n2;
                n2--;
            }

            int res2 = so % 11;

            if (res2 < 2)
            { res2 = 0; }

            else
            { res2 = 11 - (so % 11); }

            if (res == Convert.ToInt32(CPF[9].ToString()) && res2 == Convert.ToInt32(CPF[10].ToString()))
            { return true; }

            else { return false; }
            
        }
    
}
    