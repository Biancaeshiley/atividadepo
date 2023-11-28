create database Cadastro;
use Cadastro;

create table Funcionario (
id_Fun integer primary key auto_increment, 
nome_Fun varchar(200),
cpf_Fun varchar(200),
rg_Fun varchar(200),
telefone_Fun varchar(20),
email_Fun varchar(200),
data_nascimento_Fun date,
endereco_Fun varchar(200),
salario_Fun double,
cidade_Fun varchar(200),
estado_Fun varchar (200),
funcao_Fun varchar(200),
cep_Fun varchar (20)
);

create table Empresa(
id_Emp integer primary key auto_increment,
cnpj_Emp varchar(50),
Situacao_Cadastral_Emp varchar(200),
capital_social_Emp varchar(200),
razao_social_Emp varchar(200),
nome_fantasia_Emp varchar(200),
tipo_Emp varchar(200),
data_inicio_atividade_Emp date,
telefone_Emp varchar(20),
regime_tributario_Emp varchar (200),
endereco_Emp varchar(300),
cidade_Emp varchar(200),
natureza_jur_Emp varchar(150),
estado_Emp varchar(100),
porte_Empresa_Emp varchar(100),
nome_proprietario_Emp varchar(300),
cpf_proprietario_Emp varchar(11)
);

