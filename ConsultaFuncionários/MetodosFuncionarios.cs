using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsultaFuncionários
{
    class MetodosFuncionarios
    {
        private int id;
        private string nome;
        private string dataNascimento;
        private double salario;
        private string sexo;
        private string cargo;
        private string setor;
        private string cpf;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public bool GravarFuncionario()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string insert = "INSERT INTO funcionarios (Nome, dataNascimento, Salario, Sexo, Setor, CPF, Cargo) VALUES (@Nome, @dataNascimento, @Salario, @Sexo, @Setor, @CPF, @Cargo)";

                    MySqlCommand comandoSql = new MySqlCommand(insert, conexaoBanco);

                    comandoSql.Parameters.AddWithValue("@Nome", Nome);
                    comandoSql.Parameters.AddWithValue("@dataNascimento", DataNascimento);
                    comandoSql.Parameters.AddWithValue("@Salario", Salario);
                    comandoSql.Parameters.AddWithValue("@Sexo", Sexo);
                    comandoSql.Parameters.AddWithValue("@Setor", Setor);
                    comandoSql.Parameters.AddWithValue("@CPF", Cpf);
                    comandoSql.Parameters.AddWithValue("@Cargo", Cargo);
                    comandoSql.Parameters.AddWithValue("@Nome", Nome);

                    int resultado = comandoSql.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao gravar funcionário -> {ex.Message}");
                return false;

            }

        }

        public bool editarFuncionario()
        {
            try
            {
                using(MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string update = "UPDATE funcionarios SET (Nome, dataNascimento, Salario, Sexo, Setor, CPF, Cargo)";

                    MySqlCommand comandoSql = new MySqlCommand(update, conexaoBanco);

                    comandoSql.Parameters.AddWithValue("@Nome", Nome);
                    comandoSql.Parameters.AddWithValue("@dataNascimento", DataNascimento);
                    comandoSql.Parameters.AddWithValue("@Salario", Salario);
                    comandoSql.Parameters.AddWithValue("@Sexo", Sexo);
                    comandoSql.Parameters.AddWithValue("@Setor", Setor);
                    comandoSql.Parameters.AddWithValue("@CPF", Cpf);
                    comandoSql.Parameters.AddWithValue("@Cargo", Cargo);
                    comandoSql.Parameters.AddWithValue("@Nome", Nome);
                }
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
