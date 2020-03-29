/*****************************************************************************
* Nome           : TatuagemBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Bolo
* Data  Criação  : 05/11/2019
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
    class BoloBD
    {
        //05/11/2019 - Mfacine - ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Bolo
        * Parametros     : Objeto da Classe Bolo
        * Data  Criação  : 05/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Bolo aobj_Bolo)
        {
            //05/11/2019 - Mfacine - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //05/11/2018 - Mfacine - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_BOLO " +
                            "(" +
                            " I_COD_SABOR,     " +
                            " I_COD_RECHEIO,     " +
                            " I_TAM_BOLO, " +
                            " S_NM_BOLO, " +
                            " I_COB_BOLO " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @I_COD_SABOR,     " +
                            " @I_COD_RECHEIO, " +
                            " @I_TAM_BOLO, " +
                            " @S_NM_BOLO,  " +
                            " @I_COB_BOLO  " +
                            "); " +
                            "SELECT ident_current('TB_BOLO') as 'id'";

            //05/11/2019 - mfacine - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_SABOR", aobj_Sabor.COD_SABOR);
            objCmd.Parameters.AddWithValue("@I_COD_RECHEIO", aobj_Recheio.COD_RECHEIO);
            objCmd.Parameters.AddWithValue("@I_TAM_BOLO", aobj_Bolo.TAM_BOLO);
            objCmd.Parameters.AddWithValue("@S_NM_BOLO", aobj_Bolo.NM_BOLO);
            objCmd.Parameters.AddWithValue("@I_COB_BOLO", aobj_Bolo.COB_BOLO);

            try
            {
                //05/11/2019 - mfacine - Abrir a conexão com o banco de dados
                objCon.Open();

                //05/11/2019 - mfacine - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(22/06/2018-mfacine) fechar a conexão
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
        *                  Método para Alteração de um registro na tabela Bolo
        * Parametros     : Objeto da Classe Bolo
        * Data  Criação  : 08/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Bolo aobj_Bolo)
        {


            if (aobj_Bolo.COD_BOLO != -1)
            {
                //(08/11/2018-mfacine) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(15/06/2018-mfacine) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB_BOLO SET" +
                                " I_COD_BOLO = @I_COD_BOLO, " +
                                " I_COD_SABOR = @I_COD_SABOR, " +
                                " I_COD_RECHEIO = @I_COD_RECHEIO, " +
                                " I_TAM_BOLO = @I_TAM_BOLO, " +
                                " S_NM_BOLO = @S_NM_BOLO, " +
                                " I_COB_BOLO = @I_COB_BOLO " +
                                " WHERE I_COD_BOLO = @I_COD_BOLO";

                //(08/11/2019-mfacine) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_BOLO", aobj_Bolo.COD_BOLO);
                objCmd.Parameters.AddWithValue("@I_COD_SABOR", aobj_Sabor.COD_SABOR);
                objCmd.Parameters.AddWithValue("@I_COD_RECHEIO", aobj_Recheio.COD_RECHEIO);
                objCmd.Parameters.AddWithValue("@I_TAM_BOLO", aobj_Bolo.TAM_BOLO);
                objCmd.Parameters.AddWithValue("@S_NM_BOLO", aobj_Bolo.NM_BOLO);
                objCmd.Parameters.AddWithValue("@I_COB_BOLO", aobj_Bolo.COB_BOLO);
                try
                {
                    //(08/11/2019-mfacine) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(08/11/2019-mfacine) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(08/11/2018-mfacine) fechar a conexão
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
        * Parametros     : Objeto da Classe Bolo
        * Data  Criação  : 08/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Bolo aobj_Bolo)
        {
            //(08/11/2018-mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(08/11/2018-mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_BOLO " +
                            " WHERE I_COD_TATUAGEM = @I_COD_BOLO";

            //(15/06/2018-mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_BOLO", aobj_Bolo.COD_BOLO);

            try
            {
                //(15/06/2018-mfacine) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(15/06/2018-mfacine) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(15/06/2018-mfacine) Fechar a conexão com o banco de dados
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
        * Nome           : FindByCodTatuagem
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_TATUAGEM
        * Parametros     : Objeto da Classe Bolo
        * Data  Criação  : 08/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Bolo FindByCodTatuagem(Bolo aobj_Bolo)
        {
            //(08/11/2018-Mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(08/11/2018-Mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_BOLO " +
                            " WHERE I_COD_BOLO = @I_COD_BOLO ";

            //(08/11/2018-Mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_BOLO", aobj_Bolo.COD_BOLO);

            try
            {
                //(08/11/2018-Mfacine) Abrir a conexão com o banco de dados
                objCon.Open();

                //(08/11/2018-Mfacine) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(08/11/2018-mfacine) Recupero os valores (Tipo um Popula Objeto)
                    aobj_Bolo.COD_BOLO = Convert.ToInt16(objDtr["I_COD_BOLO"]);
                    aobj_Bolo.COD_SABOR = Convert.ToInt16(objDtr["I_COD_SABOR"]);
                    aobj_Bolo.COD_RECHEIO = Convert.ToInt16(objDtr["I_COD_RECHEIO"]);
                    aobj_Bolo.TAM_BOLO = Convert.ToInt16(objDtr["I_TAM_BOLO"]);
                    aobj_Bolo.NM_BOLO = objDtr["S_NM_BOLO"].ToString();
                    aobj_Bolo.COB_BOLO = Convert.ToInt16(objDtr["I_COB_BOLO"]);

                }

                objCon.Close();
                objDtr.Close();
                return aobj_Bolo;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Bolo;
            }
        }


        /****************************************************************************
        * Nome           : FindAllTatuagem
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Bolo
        * Data Criação   : 11/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Bolo> FindAllBolo()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_TATUAGEM ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Bolo> aLista = new List<Bolo>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Bolo aobj_Tatuagem = new Bolo();

                        aobj_Tatuagem.COD_BOLO = Convert.ToInt16(objDtr["I_COD_BOLO"]);
                        aobj_Tatuagem.COD_SABOR = Convert.ToInt16(objDtr["I_COD_SABOR"]);
                        aobj_Tatuagem.COD_RECHEIO = Convert.ToInt16(objDtr["I_COD_RECHEIO"]);
                        aobj_Tatuagem.TAM_BOLO = Convert.ToInt16(objDtr["I_TAM_BOLO"]);
                        aobj_Tatuagem.NM_BOLO = objDtr["S_NM_TATUAGEM"].ToString();
                        aobj_Tatuagem.COB_BOLO = Convert.ToInt16(objDtr["I_COB_BOLO"]);

                        aLista.Add(aobj_Tatuagem);

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
