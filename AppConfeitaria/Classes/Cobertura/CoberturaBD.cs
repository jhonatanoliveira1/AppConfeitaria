/*****************************************************************************
* Nome           : CoberturaBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Cobertura
* Data  Criação  : 21/02/2020
* Data Alteração : -
* Escrito por    :Jhonatan de Oliveira
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

namespace AppConfeitaria
{
    class CoberturaBD
    {
        //05/11/2019 -Jhonatan de Oliveira- ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Cobertura
        * Parametros     : Objeto da Classe Cobertura
        * Data  Criação  : 21/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(frm_Cobertura aobj_Cobertura)
        {
            //21/02/2020 -Jhonatan de Oliveira- Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //21/02/2020 -Jhonatan de Oliveira- Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_COBERTURA " +
                            "(" +
                            " S_TIT_COBERTURA,   " +
                            " T_DESC_COBERTURA  " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @S_TIT_COBERTURA,   " +
                            " @T_DESC_COBERTURA  " +
                            "); " +
                            "SELECT ident_current('TB_COBERTURA') as 'id'";

            //21/02/2020 -Jhonatan de Oliveira - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@S_TIT_COBERTURA", aobj_Cobertura.TIT_COBERTURA);
            objCmd.Parameters.AddWithValue("@T_DESC_COBERTURA", aobj_Cobertura.DESC_COBERTURA);

            try
            {
                //21/02/2020 -Jhonatan de Oliveira - Abrir a conexão com o banco de dados
                objCon.Open();

                //21/02/2020 -Jhonatan de Oliveira - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(21/02/2020-Grupo (Tanto Faz)) fechar a conexão
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
        *                  Método para Alteração de um registro na tabela Cobertura
        * Parametros     : Objeto da Classe Cobertura
        * Data  Criação  : 21/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(frm_Cobertura aobj_Cobertura)
        {


            if (aobj_Cobertura.COD_COBERTURA != -1)
            {
                //(21/02/2020-Grupo (Tanto Faz)) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(21/02/2020-Grupo (Tanto Faz)) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB_COBERTURA SET" +
                                " S_TIT_COBERTURA    = @S_TIT_COBERTURA,    " +
                                " T_DESC_COBERTURA   = @T_DESC_COBERTURA   " +
                                " WHERE I_COD_COBERTURA = @I_COD_COBERTURA";

                //(21/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_COBERTURA", aobj_Cobertura.COD_COBERTURA);
                objCmd.Parameters.AddWithValue("@S_TIT_COBERTURA", aobj_Cobertura.TIT_COBERTURA);
                objCmd.Parameters.AddWithValue("@T_DESC_COBERTURA", aobj_Cobertura.DESC_COBERTURA);

                try
                {
                    //(21/02/2020-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(21/02/2020-Grupo (Tanto Faz)) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(21/02/2020-Grupo (Tanto Faz)) fechar a conexão
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
        * Parametros     : Objeto da Classe Cobertura
        * Data  Criação  : 21/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(frm_Cobertura aobj_Cobertura)
        {
            //(21/02/2020-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(21/02/2020-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_COBERTURA " +
                            " WHERE I_COD_COBERTURA = @I_COD_COBERTURA";

            //(21/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_COBERTURA", aobj_Cobertura.COD_COBERTURA);

            try
            {
                //(21/02/2020-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(21/02/2020-Grupo (Tanto Faz)) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(21/02/2020-Grupo (Tanto Faz)) Fechar a conexão com o banco de dados
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
        * Nome           : FindByCodCobertura
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_COBERTURA
        * Parametros     : Objeto da Classe Cobertura
        * Data  Criação  : 21/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public frm_Cobertura FindByCodCobertura(frm_Cobertura aobj_Cobertura)
        {
            //(21/02/2020-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(21/02/2020-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_COBERTURA " +
                            " WHERE I_COD_COBERTURA = @I_COD_COBERTURA ";

            //(21/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_COBERTURA", aobj_Cobertura.COD_COBERTURA);

            try
            {
                //(21/02/2020-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                objCon.Open();

                //(21/02/2020-Grupo (Tanto Faz)) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(21/02/2020-Grupo (Tanto Faz)) Recupero os valores (Tipo um Popula Objeto)

                    aobj_Cobertura.COD_COBERTURA = Convert.ToInt16(objDtr["I_COD_COBERTURA"]);
                    aobj_Cobertura.TIT_COBERTURA = objDtr["S_TIT_COBERTURA"].ToString();
                    aobj_Cobertura.DESC_COBERTURA = objDtr["T_DESC_COBERTURA"].ToString();

                }

                objCon.Close();
                objDtr.Close();
                return aobj_Cobertura;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Cobertura;
            }
        }


        /****************************************************************************
        * Nome           : FindAllCobertura
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Cobertura
        * Data Criação   : 21/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<frm_Cobertura> FindAllCobertura()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_COBERTURA ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<frm_Cobertura> aLista = new List<frm_Cobertura>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        frm_Cobertura aobj_Cobertura = new frm_Cobertura();

                        aobj_Cobertura.COD_COBERTURA = Convert.ToInt16(objDtr["I_COD_COBERTURA"]);
                        aobj_Cobertura.TIT_COBERTURA = objDtr["S_TIT_COBERTURA"].ToString();
                        aobj_Cobertura.DESC_COBERTURA = objDtr["T_DESC_COBERTURA"].ToString();

                        aLista.Add(aobj_Cobertura);

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
