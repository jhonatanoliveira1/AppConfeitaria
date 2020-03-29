/*****************************************************************************
* Nome           : PedidoBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Pedido
* Data  Criação  : 14/02/2020
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
    class PedidoBD
    {
        //14/02/2020 -Jhonatan de Oliveira- ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Pedido
        * Parametros     : Objeto da Classe Pedido
        * Data  Criação  : 05/11/2019
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(frm_Pedido aobj_Pedido)
        {
            //14/02/2020 -Jhonatan de Oliveira- Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //14/02/2020 -Jhonatan de Oliveira- Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_PEDIDO " +
                            "(" +
                            " I_COD_PEDIDO, " +
                            " I_COD_CLIENTE,  " +
                            " I_COD_ENTREGA,  " +
                            " DT_DH_PEDIDO,   " +
                            " T_OBS_PEDIDO   " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @I_COD_PEDIDO," +
                            " @I_COD_CLIENTE, " +
                            " @I_COD_ENTREGA, " +
                            " @DT_DH_PEDIDO,  " +
                            " @T_OBS_PEDIDO   " +
                            "); " +
                            "SELECT ident_current('TB_PEDIDO') as 'id'";

            //14/02/2020 -Jhonatan de Oliveira - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_PEDIDO", aobj_Pedido.COD_PEDIDO);
            objCmd.Parameters.AddWithValue("@I_COD_CLIENTE", aobj_Pedido.COD_CLIENTE);
            objCmd.Parameters.AddWithValue("@I_COD_ENTREGA", aobj_Pedido.COD_ENTREGA);
            objCmd.Parameters.AddWithValue("@DT_DH_PEDIDO", aobj_Pedido.DH_PEDIDO);
            objCmd.Parameters.AddWithValue("@T_OBS_PEDIDO", aobj_Pedido.OBS_PEDIDO);
            try
            {
                //14/02/2020 -Jhonatan de Oliveira - Abrir a conexão com o banco de dados
                objCon.Open();

                //14/02/2020 -Jhonatan de Oliveira - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(14/02/2020-Grupo (Tanto Faz)) fechar a conexão
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
        *                  Método para Alteração de um registro na tabela Pedido
        * Parametros     : Objeto da Classe Pedido
        * Data  Criação  : 14/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(frm_Pedido aobj_Pedido)
        {


            if (aobj_Pedido.COD_PEDIDO != -1)
            {
                //(14/02/2020-Grupo (Tanto Faz)) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(14/02/2020-Grupo (Tanto Faz)) Criar a variável que contém a instrução SQL
                string varSql = "UPDATE TB_PEDIDO SET " +
                                "I_COD_CLIENTE = @I_COD_CLIENTE," +
                                "I_COD_ENTREGA = @I_COD_ENTREGA, " +
                                "DT_DH_PEDIDO = @DT_DH_PEDIDO,  " +
                                "T_OBS_PEDIDO = @T_OBS_PEDIDO " +
                                "WHERE I_COD_PEDIDO = @I_COD_PEDIDO";

                //(08/11/2019-Grupo (Tanto Faz)) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_PEDIDO", aobj_Pedido.COD_PEDIDO);
                objCmd.Parameters.AddWithValue("@I_COD_CLIENTE", aobj_Pedido.COD_CLIENTE);
                objCmd.Parameters.AddWithValue("@I_COD_ENTREGA", aobj_Pedido.COD_ENTREGA);
                objCmd.Parameters.AddWithValue("@DT_DH_PEDIDO", aobj_Pedido.DH_PEDIDO);
                objCmd.Parameters.AddWithValue("@T_OBS_PEDIDO", aobj_Pedido.OBS_PEDIDO);
                try
                {
                    //(14/02/2020-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(14/02/2020-Grupo (Tanto Faz)) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(14/02/2020-Grupo (Tanto Faz)) fechar a conexão
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
        * Parametros     : Objeto da Classe Pedido
        * Data  Criação  : 14/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(frm_Pedido aobj_Pedido)
        {
            //(14/02/2020-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(14/02/2020-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_PEDIDO " +
                            " WHERE I_COD_PEDIDO = @I_COD_PEDIDO";

            //(14/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_PEDIDO", aobj_Pedido.COD_PEDIDO);

            try
            {
                //(14/02/2020-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(14/02/2020-Grupo (Tanto Faz)) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(14/02/2020-Grupo (Tanto Faz)) Fechar a conexão com o banco de dados
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
        * Nome           : FindByCodPedido
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_AGENDA
        * Parametros     : Objeto da Classe Pedido
        * Data  Criação  : 14/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public frm_Pedido FindByCodPedido(frm_Pedido aobj_Pedido)
        {
            //(14/02/2020-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(14/02/2020-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_PEDIDO " +
                            " WHERE I_COD_PEDIDO = @I_COD_PEDIDO ";

            //(14/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_PEDIDO", aobj_Pedido.COD_PEDIDO);

            try
            {
                //(14/02/2020-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                objCon.Open();

                //(14/02/2020-Grupo (Tanto Faz)) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(14/02/2020-Grupo (Tanto Faz)) Recupero os valores (Tipo um Popula Objeto)
                    aobj_Pedido.COD_PEDIDO = Convert.ToInt16(objDtr["I_COD_PEDIDO"]);
                    aobj_Pedido.COD_CLIENTE = Convert.ToInt16(objDtr["I_COD_CLIENTE"]);
                    aobj_Pedido.COD_ENTREGA = Convert.ToInt16(objDtr["I_COD_ENTREGA"]);
                    aobj_Pedido.DH_PEDIDO = Convert.ToDateTime(objDtr["DT_DH_PEDIDO"]);
                    aobj_Pedido.OBS_PEDIDO = objDtr["T_OBS_PEDIDO"].ToString();
                }

                objCon.Close();
                objDtr.Close();
                return aobj_Pedido;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Pedido;
            }
        }


        /****************************************************************************
        * Nome           : FindAllPedido
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Pedido
        * Data Criação   : 14/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<frm_Pedido> FindAllPedido()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_PEDIDO ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<frm_Pedido> aLista = new List<frm_Pedido>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        frm_Pedido aobj_Pedido = new frm_Pedido();

                        aobj_Pedido.COD_PEDIDO = Convert.ToInt16(objDtr["I_COD_PEDIDO"]);
                        aobj_Pedido.COD_CLIENTE = Convert.ToInt16(objDtr["I_COD_CLIENTE"]);
                        aobj_Pedido.COD_ENTREGA = Convert.ToInt16(objDtr["I_COD_ENTREGA"]);
                        aobj_Pedido.DH_PEDIDO = Convert.ToDateTime(objDtr["DT_DH_PEDIDO"]);
                        aobj_Pedido.OBS_PEDIDO = objDtr["T_OBS_PEDIDO"].ToString();

                        aLista.Add(aobj_Pedido);

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
