/*****************************************************************************
* Nome           : SaborBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Sabor
* Data  Criação  : 19/02/2020
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
    class SaborBD
    {
        //05/11/2019 -Jhonatan de Oliveira- ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Sabor
        * Parametros     : Objeto da Classe Sabor
        * Data  Criação  : 19/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(frm_Sabor aobj_Sabor)
        {
            //19/02/2020 -Jhonatan de Oliveira- Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //19/02/2020 -Jhonatan de Oliveira- Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_SABOR " +
                            "(" +
                            " S_TIT_SABOR,   " +
                            " T_DESC_SABOR  " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @S_TIT_SABOR,   " +
                            " @T_DESC_SABOR  " +
                            "); " +
                            "SELECT ident_current('TB_SABOR') as 'id'";

            //19/02/2020 -Jhonatan de Oliveira - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@S_TIT_SABOR", aobj_Sabor.TIT_SABOR);
            objCmd.Parameters.AddWithValue("@T_DESC_SABOR", aobj_Sabor.DESC_SABOR);

            try
            {
                //19/02/2020 -Jhonatan de Oliveira - Abrir a conexão com o banco de dados
                objCon.Open();

                //19/02/2020 -Jhonatan de Oliveira - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(19/02/2020-Grupo (Tanto Faz)) fechar a conexão
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
        *                  Método para Alteração de um registro na tabela Sabor
        * Parametros     : Objeto da Classe Sabor
        * Data  Criação  : 19/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(frm_Sabor aobj_Sabor)
        {


            if (aobj_Sabor.COD_SABOR != -1)
            {
                //(19/02/2020-Grupo (Tanto Faz)) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(19/02/2020-Grupo (Tanto Faz)) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB_SABOR SET" +
                                " S_TIT_SABOR    = @S_TIT_SABOR,    " +
                                " T_DESC_SABOR   = @T_DESC_SABOR   " +
                                " WHERE I_COD_SABOR = @I_COD_SABOR";

                //(19/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_SABOR", aobj_Sabor.COD_SABOR);
                objCmd.Parameters.AddWithValue("@S_TIT_SABOR", aobj_Sabor.TIT_SABOR);
                objCmd.Parameters.AddWithValue("@T_DESC_SABOR", aobj_Sabor.DESC_SABOR);

                try
                {
                    //(19/02/2020-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(19/02/2020-Grupo (Tanto Faz)) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(19/02/2020-Grupo (Tanto Faz)) fechar a conexão
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
        * Parametros     : Objeto da Classe Sabor
        * Data  Criação  : 19/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(frm_Sabor aobj_Sabor)
        {
            //(19/02/2020-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(19/02/2020-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_SABOR " +
                            " WHERE I_COD_SABOR = @I_COD_SABOR";

            //(19/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_SABOR", aobj_Sabor.COD_SABOR);

            try
            {
                //(19/02/2020-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(19/02/2020-Grupo (Tanto Faz)) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(19/02/2020-Grupo (Tanto Faz)) Fechar a conexão com o banco de dados
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
        * Nome           : FindByCodSabor
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_SABOR
        * Parametros     : Objeto da Classe Sabor
        * Data  Criação  : 19/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public frm_Sabor FindByCodSabor(frm_Sabor aobj_Sabor)
        {
            //(19/02/2020-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(19/02/2020-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_SABOR " +
                            " WHERE I_COD_SABOR = @I_COD_SABOR ";

            //(19/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_SABOR", aobj_Sabor.COD_SABOR);

            try
            {
                //(19/02/2020-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                objCon.Open();

                //(19/02/2020-Grupo (Tanto Faz)) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(19/02/2020-Grupo (Tanto Faz)) Recupero os valores (Tipo um Popula Objeto)

                    aobj_Sabor.COD_SABOR = Convert.ToInt16(objDtr["I_COD_SABOR"]);
                    aobj_Sabor.TIT_SABOR = objDtr["S_TIT_SABOR"].ToString();
                    aobj_Sabor.DESC_SABOR = objDtr["T_DESC_SABOR"].ToString();

                }

                objCon.Close();
                objDtr.Close();
                return aobj_Sabor;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Sabor;
            }
        }


        /****************************************************************************
        * Nome           : FindAllSabor
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Sabor
        * Data Criação   : 19/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<frm_Sabor> FindAllSabor()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_SABOR ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<frm_Sabor> aLista = new List<frm_Sabor>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        frm_Sabor aobj_Sabor = new frm_Sabor();

                        aobj_Sabor.COD_SABOR = Convert.ToInt16(objDtr["I_COD_SABOR"]);
                        aobj_Sabor.TIT_SABOR = objDtr["S_TIT_SABOR"].ToString();
                        aobj_Sabor.DESC_SABOR = objDtr["T_DESC_SABOR"].ToString();

                        aLista.Add(aobj_Sabor);

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
