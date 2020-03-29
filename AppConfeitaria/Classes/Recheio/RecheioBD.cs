/*****************************************************************************
* Nome           : RecheioBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Recheio
* Data  Criação  : 12/11/2019
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
    class RecheioBD
    {
        //05/11/2019 -Jhonatan de Oliveira- ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Recheio
        * Parametros     : Objeto da Classe Recheio
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(frm_Recheio aobj_Recheio)
        {
            //12/11/2019 -Jhonatan de Oliveira- Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //12/11/2018 -Jhonatan de Oliveira- Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_RECHEIO " +
                            "(" +
                            " S_TIT_RECHEIO,   " +
                            " T_DESC_RECHEIO  " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @S_TIT_RECHEIO,   " +
                            " @T_DESC_RECHEIO  " +
                            "); " +
                            "SELECT ident_current('TB_RECHEIO') as 'id'";

            //12/11/2019 -Jhonatan de Oliveira - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@S_TIT_RECHEIO", aobj_Recheio.TIT_RECHEIO);
            objCmd.Parameters.AddWithValue("@T_DESC_RECHEIO", aobj_Recheio.DESC_RECHEIO);

            try
            {
                //12/11/2019 -Jhonatan de Oliveira - Abrir a conexão com o banco de dados
                objCon.Open();

                //12/11/2019 -Jhonatan de Oliveira - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(12/11/2018-Grupo (Tanto Faz)) fechar a conexão
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
        *                  Método para Alteração de um registro na tabela Recheio
        * Parametros     : Objeto da Classe Recheio
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(frm_Recheio aobj_Recheio)
        {


            if (aobj_Recheio.COD_RECHEIO != -1)
            {
                //(12/11/2018-Grupo (Tanto Faz)) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(12/11/2018-Grupo (Tanto Faz)) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB_RECHEIO SET " +
                                " S_TIT_RECHEIO    = @S_TIT_RECHEIO,    " +
                                " T_DESC_RECHEIO   = @T_DESC_RECHEIO   " +
                                " WHERE I_COD_RECHEIO = @I_COD_RECHEIO";

                //(12/11/2019-Grupo (Tanto Faz)) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_RECHEIO", aobj_Recheio.COD_RECHEIO);
                objCmd.Parameters.AddWithValue("@S_TIT_RECHEIO", aobj_Recheio.TIT_RECHEIO);
                objCmd.Parameters.AddWithValue("@T_DESC_RECHEIO", aobj_Recheio.DESC_RECHEIO);

                try
                {
                    //(12/11/2019-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(12/11/2019-Grupo (Tanto Faz)) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(12/11/2018-Grupo (Tanto Faz)) fechar a conexão
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
        * Parametros     : Objeto da Classe Recheio
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(frm_Recheio aobj_Recheio)
        {
            //(12/11/2018-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_RECHEIO " +
                            " WHERE I_COD_RECHEIO = @I_COD_RECHEIO";

            //(12/11/2018-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_RECHEIO", aobj_Recheio.COD_RECHEIO);

            try
            {
                //(12/11/2018-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(12/11/2018-Grupo (Tanto Faz)) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(12/11/2018-Grupo (Tanto Faz)) Fechar a conexão com o banco de dados
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
        * Nome           : FindByCodRecheio
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_RECHEIO
        * Parametros     : Objeto da Classe Recheio
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public frm_Recheio FindByCodRecheio(frm_Recheio aobj_Recheio)
        {
            //(12/11/2018-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_RECHEIO " +
                            " WHERE I_COD_RECHEIO = @I_COD_RECHEIO ";

            //(12/11/2018-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_RECHEIO", aobj_Recheio.COD_RECHEIO);

            try
            {
                //(12/11/2018-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                objCon.Open();

                //(12/11/2018-Grupo (Tanto Faz)) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(12/11/2018-Grupo (Tanto Faz)) Recupero os valores (Tipo um Popula Objeto)

                    aobj_Recheio.COD_RECHEIO = Convert.ToInt16(objDtr["I_COD_RECHEIO"]);
                    aobj_Recheio.TIT_RECHEIO = objDtr["S_TIT_RECHEIO"].ToString();
                    aobj_Recheio.DESC_RECHEIO = objDtr["T_DESC_RECHEIO"].ToString();

                }

                objCon.Close();
                objDtr.Close();
                return aobj_Recheio;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Recheio;
            }
        }


        /****************************************************************************
        * Nome           : FindAllRecheio
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Recheio
        * Data Criação   : 12/11/2019
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<frm_Recheio> FindAllRecheio()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_RECHEIO ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<frm_Recheio> aLista = new List<frm_Recheio>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        frm_Recheio aobj_Recheio = new frm_Recheio();

                        aobj_Recheio.COD_RECHEIO = Convert.ToInt16(objDtr["I_COD_RECHEIO"]);
                        aobj_Recheio.TIT_RECHEIO = objDtr["S_TIT_RECHEIO"].ToString();
                        aobj_Recheio.DESC_RECHEIO = objDtr["T_DESC_RECHEIO"].ToString();

                        aLista.Add(aobj_Recheio);

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
