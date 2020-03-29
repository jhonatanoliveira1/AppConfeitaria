/*****************************************************************************
* Nome           : ClienteBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Cliente
* Data  Criação  : 12/11/2019
* Data Alteração : -
* Escrito por    : Mfacine (Monstro)
* Observações    : 
* ***************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Dynamic;

namespace AppBolaria
{
    class ClienteBD
    {
        //05/11/2019 - Mfacine - ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Cliente
        * Parametros     : Objeto da Classe Cliente
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Cliente aobj_Cliente)
        {
            //12/11/2019 - Mfacine - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //12/11/2018 - Mfacine - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_CLIENTE " +
                            "(" +
                            " S_NM_CLIENTE,   " +
                            " S_END_CLIENTE,  " +
                            " S_BAI_CLIENTE,  " +
                            " S_CID_CLIENTE,  " +
                            " S_UF_CLIENTE,   " +
                            " S_CEP_CLIENTE,  " +
                            " S_CEL_CLIENTE,  " +
                            " S_EMAIL_CLIENTE, " +
                            " S_CPF_CLIENTE,         " +
                             ")" +
                            "VALUES " +
                            "(" +
                            " @S_NM_CLIENTE,   " +
                            " @S_END_CLIENTE,  " +
                            " @S_BAI_CLIENTE,  " +
                            " @S_CID_CLIENTE,  " +
                            " @S_UF_CLIENTE,   " +
                            " @S_CEP_CLIENTE,  " +
                            " @S_CEL_CLIENTE,  " +
                            " @S_EMAIL_CLIENTE, " +
                            " @B_CPF_CLIENTE, " +
                            "); " +
                            "SELECT ident_current('TB_CLIENTE') as 'id'";

            //12/11/2019 - mfacine - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@S_NM_CLIENTE", aobj_Cliente.NM_CLIENTE);
            objCmd.Parameters.AddWithValue("@S_END_CLIENTE", aobj_Cliente.END_CLIENTE);
            objCmd.Parameters.AddWithValue("@S_BAI_CLIENTE", aobj_Cliente.BAI_CLIENTE);
            objCmd.Parameters.AddWithValue("@S_CID_CLIENTE", aobj_Cliente.CID_CLIENTE);
            objCmd.Parameters.AddWithValue("@S_UF_CLIENTE", aobj_Cliente.UF_CLIENTE);
            objCmd.Parameters.AddWithValue("@S_CEP_CLIENTE", aobj_Cliente.CEP_CLIENTE);
            objCmd.Parameters.AddWithValue("@S_CEL_CLIENTE", aobj_Cliente.CEL_CLIENTE);
            objCmd.Parameters.AddWithValue("@S_EMAIL_CLIENTE", aobj_Cliente.EMAIL_CLIENTE);
            objCmd.Parameters.AddWithValue("@B_CPF_CLIENTE", aobj_Cliente.CPF_CLIENTE);

            try
            {
                //12/11/2019 - mfacine - Abrir a conexão com o banco de dados
                objCon.Open();

                //12/11/2019 - mfacine - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(12/11/2018-mfacine) fechar a conexão
                objCon.Close();

                return _id;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }


        /*****************************************************************************
        * Nome           : Alterar
        * Procedimento   : Responsável por editar o Objeto na Base de Dados
        *                  Método para Alteração de um registro na tabela Cliente
        * Parametros     : Objeto da Classe Cliente
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Cliente aobj_Cliente)
        {


            if (aobj_Cliente.COD_CLIENTE != -1)
            {
                //(12/11/2018-mfacine) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(12/11/2018-mfacine) Criar a variável que contém a instrução SQL
                string varSql = "UPDATE TB_CLIENTE SET " +
                                "S_NM_CLIENTE = @S_NM_CLIENTE, " +
                                "S_END_CLIENTE = @S_END_CLIENTE, " +
                                "S_BAI_CLIENTE = @S_BAI_CLIENTE, " +
                                "S_CID_CLIENTE = @S_CID_CLIENTE, " +
                                "S_UF_CLIENTE = @S_UF_CLIENTE, " +
                                "S_CEP_CLIENTE = @S_CEP_CLIENTE, " +
                                "S_CEL_CLIENTE = @S_CEL_CLIENTE, " +
                                "S_EMAIL_CLIENTE = @S_EMAIL_CLIENTE, " +
                                "S_CPF_CLIENTE = @B_CPF_CLIENTE, " +
                                "WHERE I_COD_CLIENTE = @I_COD_CLIENTE";

                //(12/11/2019-mfacine) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_CLIENTE", aobj_Cliente.COD_CLIENTE);
                objCmd.Parameters.AddWithValue("@S_NM_CLIENTE", aobj_Cliente.NM_CLIENTE);
                objCmd.Parameters.AddWithValue("@S_END_CLIENTE", aobj_Cliente.END_CLIENTE);
                objCmd.Parameters.AddWithValue("@S_BAI_CLIENTE", aobj_Cliente.BAI_CLIENTE);
                objCmd.Parameters.AddWithValue("@S_CID_CLIENTE", aobj_Cliente.CID_CLIENTE);
                objCmd.Parameters.AddWithValue("@S_UF_CLIENTE", aobj_Cliente.UF_CLIENTE);
                objCmd.Parameters.AddWithValue("@S_CEP_CLIENTE", aobj_Cliente.CEP_CLIENTE);
                objCmd.Parameters.AddWithValue("@S_CEL_CLIENTE", aobj_Cliente.CEL_CLIENTE);
                objCmd.Parameters.AddWithValue("@S_EMAIL_CLIENTE", aobj_Cliente.EMAIL_CLIENTE);
                objCmd.Parameters.AddWithValue("@S_CPF_CLIENTE", aobj_Cliente.CPF_CLIENTE);

                try
                {
                    //(12/11/2019-mfacine) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(12/11/2019-mfacine) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(12/11/2018-mfacine) fechar a conexão
                    objCon.Close();

                    return true;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }

        }


        /*****************************************************************************
        * Nome           : Excluir
        * Procedimento   : Responsável por Apagar o Objeto na Base de Dados
        *                  Método para deletar um registro na tabela Receita
        * Parametros     : Objeto da Classe Cliente
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Cliente aobj_Cliente)
        {
            //(12/11/2018-mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_CLIENTE " +
                            " WHERE I_COD_CLIENTE = @I_COD_CLIENTE";

            //(12/11/2018-mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_CLIENTE", aobj_Cliente.COD_CLIENTE);

            try
            {
                //(12/11/2018-mfacine) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(12/11/2018-mfacine) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(12/11/2018-mfacine) Fechar a conexão com o banco de dados
                ObjCon.Close();

                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        /*****************************************************************************
        * Nome           : FindByCodCliente
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_CLIENTE
        * Parametros     : Objeto da Classe Cliente
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Cliente FindByCodCliente(Cliente aobj_Cliente)
        {
            //(12/11/2018-Mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-Mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_CLIENTE " +
                            " WHERE I_COD_CLIENTE = @I_COD_CLIENTE ";

            //(12/11/2018-Mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_CLIENTE", aobj_Cliente.COD_CLIENTE);

            try
            {
                //(12/11/2018-Mfacine) Abrir a conexão com o banco de dados
                objCon.Open();

                //(12/11/2018-Mfacine) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(12/11/2018-mfacine) Recupero os valores (Tipo um Popula Objeto)

                    aobj_Cliente.COD_CLIENTE = Convert.ToInt16(objDtr["I_COD_CLIENTE"]);
                    aobj_Cliente.NM_CLIENTE = objDtr["S_NM_CLIENTE"].ToString();
                    aobj_Cliente.END_CLIENTE = objDtr["S_END_CLIENTE"].ToString();
                    aobj_Cliente.BAI_CLIENTE = objDtr["S_BAI_CLIENTE"].ToString();
                    aobj_Cliente.CID_CLIENTE = objDtr["S_CID_CLIENTE"].ToString();
                    aobj_Cliente.UF_CLIENTE = objDtr["S_UF_CLIENTE"].ToString();
                    aobj_Cliente.CEP_CLIENTE = objDtr["S_CEP_CLIENTE"].ToString();
                    aobj_Cliente.CEL_CLIENTE = objDtr["S_CEL_CLIENTE"].ToString();
                    aobj_Cliente.EMAIL_CLIENTE = objDtr["S_EMAIL_CLIENTE"].ToString();
                    aobj_Cliente.CPF_CLIENTE = objDtr["S_CPF_CLIENTE"].ToString();


                }

                objCon.Close();
                objDtr.Close();
                return aobj_Cliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Cliente;
            }
        }


        /****************************************************************************
        * Nome           : FindAllCliente
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Cliente
        * Data Criação   : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Cliente> FindAllCliente()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_CLIENTE ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Cliente> aLista = new List<Cliente>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Cliente aobj_Cliente = new Cliente();

                        aobj_Cliente.COD_CLIENTE = Convert.ToInt16(objDtr["I_COD_CLIENTE"]);
                        aobj_Cliente.NM_CLIENTE = objDtr["S_NM_CLIENTE"].ToString();
                        aobj_Cliente.END_CLIENTE = objDtr["S_END_CLIENTE"].ToString();
                        aobj_Cliente.BAI_CLIENTE = objDtr["S_BAI_CLIENTE"].ToString();
                        aobj_Cliente.CID_CLIENTE = objDtr["S_CID_CLIENTE"].ToString();
                        aobj_Cliente.UF_CLIENTE = objDtr["S_UF_CLIENTE"].ToString();
                        aobj_Cliente.CEP_CLIENTE = objDtr["S_CEP_CLIENTE"].ToString();
                        aobj_Cliente.CEL_CLIENTE = objDtr["S_CEL_CLIENTE"].ToString();
                        aobj_Cliente.EMAIL_CLIENTE = objDtr["S_EMAIL_CLIENTE"].ToString();
                        aobj_Cliente.CPF_CLIENTE = objDtr["S_CPF_CLIENTE"].ToString();


                        aLista.Add(aobj_Cliente);

                    }

                    objCon.Close();
                    objDtr.Close();
                    return aLista;

                }
                else
                {
                    objCon.Close();
                    objDtr.Close();
                    return null;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
