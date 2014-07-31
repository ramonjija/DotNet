using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ramon.Model;

namespace Ramon.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisica PFisica = new Fisica();
            PFisica.CPF = "124.172.967-05";
            PFisica.Nome = "Ramon";
            PFisica.Sobrenome = "Silva";
            PFisica.RG = "21767544-6";
            PFisica.ID = 1;
            PFisica.Idade = 26;
            Telefone telefone = new Telefone();
            telefone.Tipo = TipoTelefone.Celular;
            telefone.Numero = "21988096500";

            Juridica PJuridica = new Juridica();
            PJuridica.ID = 1;
            PJuridica.CNPJ = "3412421321312";
            PJuridica.IE = "Inscrição Estadual";
            PJuridica.RazaoSocial = "Jija Land";
            PJuridica.Nome = "Ramon Gomes";

            UF uf = new UF();
            uf.ID = 25;
            uf.Sigla = "RJ";

            Cidade cidade = new Cidade();
            cidade.ID = 24;
            cidade.UF = uf;
            cidade.Nome = "Rio de Janeiro";

            Bairro bairro = new Bairro();
            bairro.ID = 23;
            bairro.Cidade = cidade;
            bairro.Nome = "Centro";

            Logradouro logradouro = new Logradouro();
            logradouro.ID = 22;
            logradouro.Bairro = bairro;
            logradouro.Nome = "Senador Dantas";
            logradouro.Tipo = TipoLogradouro.Avenida;
            logradouro.Numero = 29;

            Endereco endereco = new Endereco();
            endereco.ID = 1;
            endereco.Tipo = TipoEndereco.Residencial;
            endereco.Logradouro = logradouro;

            
            Console.WriteLine(
                "ID: " + PFisica.ID + "\n" +
                "CPF: " + PFisica.CPF + "\n" +
                "RG: " + PFisica.RG + "\n" +
                "Nome e Sobrenome: " + PFisica.Nome + " " + PFisica.Sobrenome + "\n" +
                "Idade: " + PFisica.Idade + "\n" + 
                 telefone.Tipo + " : " + telefone.Numero

                );
            Console.ReadKey();

        }
    }
}
