/*****************************************************************************
* Nome           : PedidoBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Pedido
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
    class PedidoBD
    {
        //12/11/2019 - Mfacine - ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Pedido
        * Parametros     : Objeto da Classe Pedido
        * Data  Criação  : 05/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Pedido aobj_Pedido)
        {
            //12/11/2019 - Mfacine - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //12/11/2019 - Mfacine - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_PEDIDO " +
                            "(" +
                            " I_COD_PEDIDO, " +
                            " I_COD_CLIENTE,  " +
                            " I_COD_ENTREGA,  " +
                            " DH_PEDIDO,   " +
                            " T_OBS_PEDIDO   " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @I_COD_PEDIDO," +
                            " @I_COD_CLIENTE, " +
                             " @I_COD_ENTREGA, " +
                            " @DH_PEDIDO,  " +
                            " @T_OBS_PEDIDO   " +
                            "); " +
                            "SELECT ident_current('TB_PEDIDO') as 'id'";

            //12/11/2019 - mfacine - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_PEDIDO", aobj_Pedido.COD_PEDIDO);
            objCmd.Parameters.AddWithValue("@I_COD_CLIENTE", aobj_Cliente.COD_CLIENTE);
            objCmd.Parameters.AddWithValue("@I_COD_ENTREGA", aobj_Entrega.COD_ENTREGA);
            objCmd.Parameters.AddWithValue("@DH_PEDIDO", aobj_Pedido.DH_PEDIDO);
            objCmd.Parameters.AddWithValue("@T_OBS_PEDIDO", aobj_Pedido.OBS_PEDIDO);
            try
            {
                //12/11/2019 - mfacine - Abrir a conexão com o banco de dados
                objCon.Open();

                //12/11/2019 - mfacine - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(12/11/2019-mfacine) fechar a conexão
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
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Pedido aobj_Pedido)
        {


            if (aobj_Pedido.COD_PEDIDO != -1)
            {
                //(08/11/2018-mfacine) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(15/06/2018-mfacine) Criar a variável que contém a instrução SQL
                string varSql = "UPDATE TB_PEDIDO SET " +
                                "I_COD_CLIENTE = @I_COD_CLIENTE," +
                                "I_COD_ENTREGA = @I_COD_ENTREGA, " +
                                "DH_PEDIDO = @DH_PEDIDO,  " +
                                "T_OBS_PEDIDO = @T_OBS_PEDIDO " +
                                "WHERE S_OBS_PEDIDO = @S_OBS_AGENDA";

                //(08/11/2019-mfacine) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_PEDIDO", aobj_Pedido.COD_PEDIDO);
                objCmd.Parameters.AddWithValue("@I_COD_CLIENTE", aobj_Cliente.COD_CLIENTE);
                objCmd.Parameters.AddWithValue("@I_COD_ENTREGA", aobj_Entrega.COD_ENTREGA);
                objCmd.Parameters.AddWithValue("@DH_PEDIDO", aobj_Pedido.DH_PEDIDO);
                objCmd.Parameters.AddWithValue("@T_OBS_PEDIDO", aobj_Pedido.OBS_PEDIDO);
                try
                {
                    //(12/11/2019-mfacine) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(12/11/2019-mfacine) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(12/11/2019-mfacine) fechar a conexão
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
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Pedido aobj_Pedido)
        {
            //(12/11/2019-mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2019-mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_PEDIDO " +
                            " WHERE I_COD_PEDIDO = @I_COD_PEDIDO";

            //(12/11/2019-mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_PEDIDO", aobj_Pedido.COD_PEDIDO);

            try
            {
                //(12/11/2019-mfacine) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(12/11/2019-mfacine) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(12/11/2019-mfacine) Fechar a conexão com o banco de dados
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
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Pedido FindByCodPedido(Pedido aobj_Pedido)
        {
            //(12/11/2019-Mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2019-Mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_PEDIDO " +
                            " WHERE I_COD_AGENDA = @I_COD_PEDIDO ";

            //(12/11/2019-Mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_PEDIDO", aobj_Pedido.COD_PEDIDO);

            try
            {
                //(12/11/2019-Mfacine) Abrir a conexão com o banco de dados
                objCon.Open();

                //(12/11/2019-Mfacine) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(12/11/2019-mfacine) Recupero os valores (Tipo um Popula Objeto)
                    aobj_Pedido.COD_PEDIDO = Convert.ToInt16(objDtr["I_COD_PEDIDO"]);
                    aobj_Pedido.COD_TATUADOR = Convert.ToInt16(objDtr["I_COD_TATUADOR"]);
                    aobj_Pedido.COD_CLIENTE = Convert.ToInt16(objDtr["I_COD_CLIENTE"]);
                    aobj_Pedido.DH_PEDIDO = Convert.ToDateTime(objDtr["DH_PEDIDO"]);
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
        * Data Criação   : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Pedido> FindAllPedido()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_AGENDA ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Pedido> aLista = new List<Pedido>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Pedido aobj_Pedido = new Pedido();

                        aobj_Pedido.COD_AGENDA = Convert.ToInt16(objDtr["I_COD_AGENDA"]);
                        aobj_Pedido.COD_TATUADOR = Convert.ToInt16(objDtr["I_COD_TATUADOR"]);
                        aobj_Pedido.COD_CLIENTE = Convert.ToInt16(objDtr["I_COD_CLIENTE"]);
                        aobj_Pedido.DH_AGENDA = Convert.ToDateTime(objDtr["DH_AGENDA"]);
                        aobj_Pedido.OBS_AGENDA = objDtr["T_OBS_AGENDA"].ToString();

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
