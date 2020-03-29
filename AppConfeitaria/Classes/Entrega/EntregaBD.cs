/*****************************************************************************
* Nome           : EntregaBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Entrega
* Data  Criação  : 14/02/2020
* Data Alteração : -
* Escrito por    : Grupo (Tanto Faz)
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
    class EntregaBD
    {
        //05/11/2019 - Grupo (Tanto Faz) - ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Entrega
        * Parametros     : Objeto da Classe Entrega
        * Data  Criação  : 14/02/2020
        * Data Alteração : -
        * Escrito por    : Grupo (Tanto Faz)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Entrega aobj_Entrega)
        {
            //14/02/2020 - Grupo (Tanto Faz) - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //14/02/2020 - Grupo (Tanto Faz) - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_ENTREGA " +
                            "(" +
                            " S_SEM_ENTREGA,   " +
                            " S_PER_ENTREGA  " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @S_SEM_ENTREGA,   " +
                            " @S_PER_ENTREGA  " +
                            "); " +
                            "SELECT ident_current('TB_ENTREGA') as 'id'";

            //14/02/2020 - mfacine - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@S_SEM_ENTREGA", aobj_Entrega.SEM_ENTREGA);
            objCmd.Parameters.AddWithValue("@S_PER_ENTREGA", aobj_Entrega.PER_ENTREGA);

            try
            {
                //14/02/2020 - mfacine - Abrir a conexão com o banco de dados
                objCon.Open();

                //14/02/2020 - mfacine - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(14/02/2020-mfacine) fechar a conexão
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
        *                  Método para Alteração de um registro na tabela Entrega
        * Parametros     : Objeto da Classe Entrega
        * Data  Criação  : 14/02/2020
        * Data Alteração : -
        * Escrito por    : Grupo (Tanto Faz)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Entrega aobj_Entrega)
        {


            if (aobj_Entrega.COD_ENTREGA != -1)
            {
                //(14/02/2020-mfacine) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(14/02/2020-mfacine) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB_ENTREGA SET " +
                                " S_SEM_ENTREGA    = @S_SEM_ENTREGA,    " +
                                " S_PER_ENTREGA    = @S_PER_ENTREGA   " +
                                " WHERE I_COD_ENTREGA = @I_COD_ENTREGA";

                //(14/02/2020-mfacine) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_ENTREGA", aobj_Entrega.COD_ENTREGA);
                objCmd.Parameters.AddWithValue("@S_SEM_ENTREGA", aobj_Entrega.SEM_ENTREGA);
                objCmd.Parameters.AddWithValue("@S_PER_ENTREGA", aobj_Entrega.PER_ENTREGA);

                try
                {
                    //(14/02/2020-mfacine) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(14/02/2020-mfacine) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(14/02/2020-mfacine) fechar a conexão
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
        * Parametros     : Objeto da Classe Entrega
        * Data  Criação  : 14/02/2020
        * Data Alteração : -
        * Escrito por    : Grupo (Tanto Faz)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Entrega aobj_Entrega)
        {
            //(14/02/2020-mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(14/02/2020-mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_ENTREGA " +
                            " WHERE I_COD_ENTREGA = @I_COD_ENTREGA";

            //(14/02/2020-mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_ENTREGA", aobj_Entrega.COD_ENTREGA);

            try
            {
                //(14/02/2020-mfacine) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(14/02/2020-mfacine) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(14/02/2020-mfacine) Fechar a conexão com o banco de dados
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
        * Nome           : FindByCodEntrega
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_ENTREGA
        * Parametros     : Objeto da Classe Entrega
        * Data  Criação  : 14/02/2020
        * Data Alteração : -
        * Escrito por    : Grupo (Tanto Faz)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Entrega FindByCodEntrega(Entrega aobj_Entrega)
        {
            //(14/02/2020-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(14/02/2020-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_ENTREGA " +
                            " WHERE I_COD_ENTREGA = @I_COD_ENTREGA ";

            //(14/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_ENTREGA", aobj_Entrega.COD_ENTREGA);

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

                    //(14/02/2020-mfacine) Recupero os valores (Tipo um Popula Objeto)

                    aobj_Entrega.COD_ENTREGA = Convert.ToInt16(objDtr["I_COD_ENTREGA"]);
                    aobj_Entrega.SEM_ENTREGA = objDtr["S_SEM_ENTREGA"].ToString();
                    aobj_Entrega.PER_ENTREGA = objDtr["S_PER_ENTREGA"].ToString();

                }

                objCon.Close();
                objDtr.Close();
                return aobj_Entrega;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Entrega;
            }
        }


        /****************************************************************************
        * Nome           : FindAllEntrega
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Entrega
        * Data Criação   : 14/02/2020
        * Data Alteração : -
        * Escrito por    : Grupo (Tanto Faz)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Entrega> FindAllEntrega()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_ENTREGA ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Entrega> aLista = new List<Entrega>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Entrega aobj_Entrega = new Entrega();

                        aobj_Entrega.COD_ENTREGA = Convert.ToInt16(objDtr["I_COD_ENTREGA"]);
                        aobj_Entrega.SEM_ENTREGA = objDtr["S_SEM_ENTREGA"].ToString();
                        aobj_Entrega.PER_ENTREGA = objDtr["S_PER_ENTREGA"].ToString();

                        aLista.Add(aobj_Entrega);

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
