/*****************************************************************************
* Nome           : PedidoItemBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade PedidoItem
* Data  Criação  :19/02/2020
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
    class PedidoItemBD
    {
        //19/02/2020 -Jhonatan de Oliveira - ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela PedidoItem
        * Parametros     : Objeto da Classe PedidoItem
        * Data  Criação  : 21/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(PedidoItem aobj_PedidoItem)
        {
            //19/02/2020 -Jhonatan de Oliveira - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //19/02/2020 -Jhonatan de Oliveira - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_PEDIDOITEM " +
                            "(" +
                            " I_COD_PEDIDO,   " +
                            " I_COD_BOLO,  " +
                            " I_QUANT_PEDIDOITEM, " +
                            " D_VTOTAL_PEDIDOITEM " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @I_COD_PEDIDO,   " +
                            " @I_COD_BOLO,  " +
                            " @I_QUANT_PEDIDOITEM, " +
                            " @D_VTOTAL_PEDIDOITEM " +
                            "); " +
                            "SELECT ident_current('TB_PEDIDOITEM') as 'id'";

            //21/02/2020 -Jhonatan de Oliveira - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_PEDIDO ", aobj_PedidoItem.COD_PEDIDO);
            objCmd.Parameters.AddWithValue("@I_COD_BOLO ", aobj_PedidoItem.COD_BOLO);
            objCmd.Parameters.AddWithValue("@I_QUANT_PEDIDOITEM ", aobj_PedidoItem.QUANT_PEDIDOITEM);
            objCmd.Parameters.AddWithValue("@D_VTOTAL_PEDIDOITEM ", aobj_PedidoItem.VTOTAL_PEDIDOITEM);

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
        * Nome           : Excluir
        * Procedimento   : Responsável por Apagar o Objeto na Base de Dados
        *                  Método para deletar um registro na tabela Receita
        * Parametros     : Objeto da Classe PedidoItem
        * Data  Criação  :19/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(PedidoItem aobj_PedidoItem)
        {
            //(19/02/2020-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(19/02/2020-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_PEDIDOITEM " +
                            " WHERE I_COD_PEDIDO = @I_COD_PEDIDO";

            //(19/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_PEDIDO", aobj_PedidoItem.COD_PEDIDO);

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



        /****************************************************************************
        * Nome           : FindAllByPedido
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe PedidoItem
        * Data Criação   : 21/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<PedidoItem> FindAllByPedido(frm_Pedido aobj_Pedido)
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_PEDIDOITEM " +
                            " WHERE I_COD_PEDIDO = @I_COD_PEDIDO";

            //(19/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_PEDIDO", aobj_Pedido.COD_PEDIDO);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<PedidoItem> aLista = new List<PedidoItem>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        PedidoItem aobj_PedidoItem = new PedidoItem();

                        aobj_PedidoItem.COD_PEDIDOITEM = Convert.ToInt16(objDtr["I_COD_PEDIDOITEM"]);
                        aobj_PedidoItem.COD_PEDIDO = Convert.ToInt16(objDtr["I_COD_PEDIDO"]);
                        aobj_PedidoItem.COD_BOLO = Convert.ToInt16(objDtr["I_COD_BOLO"]);
                        aobj_PedidoItem.QUANT_PEDIDOITEM = Convert.ToInt16(objDtr["I_QUANT_PEDIDOITEM"]);
                        aobj_PedidoItem.VTOTAL_PEDIDOITEM = Convert.ToDouble(objDtr["D_VTOTAL_PEDIDOITEM"]);

                        aLista.Add(aobj_PedidoItem);

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
