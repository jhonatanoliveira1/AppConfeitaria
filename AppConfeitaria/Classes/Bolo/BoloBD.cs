/*****************************************************************************
* Nome           : BoloBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Bolo
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
    class BoloBD
    {
        //14/02/2020 -Jhonatan de Oliveira- ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Bolo
        * Parametros     : Objeto da Classe Bolo
        * Data  Criação  : 14/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Bolo aobj_Bolo)
        {
            //14/02/2020 -Jhonatan de Oliveira- Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //14/02/2020 -Jhonatan de Oliveira- Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_BOLO " +
                            "(" +
                            " I_COD_SABOR,     " +
                            " I_COD_RECHEIO,  " +
                            " S_TAM_BOLO, " +
                            " S_NM_BOLO, " +
                            " D_VALOR_BOLO, " +
                            " I_COD_COBERTURA " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @I_COD_SABOR,     " +
                            " @I_COD_RECHEIO, " +
                            " @S_TAM_BOLO, " +
                            " @S_NM_BOLO,  " +
                            " @D_VALOR_BOLO, " +
                            " @I_COD_COBERTURA  " +
                            "); " +
                            "SELECT ident_current('TB_BOLO') as 'id'";

            //14/02/2020 -Jhonatan de Oliveira - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_BOLO", aobj_Bolo.COD_BOLO);
            objCmd.Parameters.AddWithValue("@I_COD_SABOR", aobj_Bolo.COD_SABOR);
            objCmd.Parameters.AddWithValue("@I_COD_RECHEIO", aobj_Bolo.COD_RECHEIO);
            objCmd.Parameters.AddWithValue("@S_TAM_BOLO", aobj_Bolo.TAM_BOLO);
            objCmd.Parameters.AddWithValue("@S_NM_BOLO", aobj_Bolo.NM_BOLO);
            objCmd.Parameters.AddWithValue("@D_VALOR_BOLO", aobj_Bolo.VALOR_BOLO);
            objCmd.Parameters.AddWithValue("@I_COD_COBERTURA", aobj_Bolo.COD_BOLO);

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
        *                  Método para Alteração de um registro na tabela Bolo
        * Parametros     : Objeto da Classe Bolo
        * Data  Criação  : 14/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Bolo aobj_Bolo)
        {


            if (aobj_Bolo.COD_BOLO != -1)
            {
                //(14/02/2020-Grupo (Tanto Faz)) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //14/02/2020-Grupo (Tanto Faz)) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB_BOLO SET" +
                                " I_COD_BOLO = @I_COD_BOLO, " +
                                " I_COD_SABOR = @I_COD_SABOR, " +
                                " I_COD_RECHEIO = @I_COD_RECHEIO, " +
                                " S_TAM_BOLO = @S_TAM_BOLO, " +
                                " S_NM_BOLO = @S_NM_BOLO, " +
                                " D_VALOR_BOLO = @D_VALOR_BOLO, " +
                                " I_COD_COBERTURA = @I_COD_COBERTURA " +
                                " WHERE I_COD_BOLO = @I_COD_BOLO";

                //14/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_BOLO", aobj_Bolo.COD_BOLO);
                objCmd.Parameters.AddWithValue("@I_COD_SABOR", aobj_Bolo.COD_SABOR);
                objCmd.Parameters.AddWithValue("@I_COD_RECHEIO", aobj_Bolo.COD_RECHEIO);
                objCmd.Parameters.AddWithValue("@S_TAM_BOLO", aobj_Bolo.TAM_BOLO);
                objCmd.Parameters.AddWithValue("@S_NM_BOLO", aobj_Bolo.NM_BOLO);
                objCmd.Parameters.AddWithValue("@D_VALOR_BOLO", aobj_Bolo.VALOR_BOLO);
                objCmd.Parameters.AddWithValue("@I_COD_COBERTURA", aobj_Bolo.COD_COBERTURA);
                try
                {
                    //14/02/2020-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //14/02/2020-Grupo (Tanto Faz)) Executar o comando
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
        * Parametros     : Objeto da Classe Bolo
        * Data  Criação  : 14/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Bolo aobj_Bolo)
        {
            //(14/02/2020-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(14/02/2020-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_BOLO " +
                            " WHERE I_COD_BOLO = @I_COD_BOLO";

            //14/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_BOLO", aobj_Bolo.COD_BOLO);

            try
            {
                //14/02/2020-Grupo (Tanto Faz)) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //14/02/2020-Grupo (Tanto Faz)) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //14/02/2020-Grupo (Tanto Faz)) Fechar a conexão com o banco de dados
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
        * Nome           : FindByCodBolo
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_TATUAGEM
        * Parametros     : Objeto da Classe Bolo
        * Data  Criação  : 14/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Bolo FindByCodBolo(Bolo aobj_Bolo)
        {
            //(14/02/2020-Grupo (Tanto Faz)) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(14/02/2020-Grupo (Tanto Faz)) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_BOLO " +
                            " WHERE I_COD_BOLO = @I_COD_BOLO ";

            //(14/02/2020-Grupo (Tanto Faz)) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_BOLO", aobj_Bolo.COD_BOLO);

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
                    aobj_Bolo.COD_BOLO = Convert.ToInt16(objDtr["I_COD_BOLO"]);
                    aobj_Bolo.COD_SABOR = Convert.ToInt16(objDtr["I_COD_SABOR"]);
                    aobj_Bolo.COD_RECHEIO = Convert.ToInt16(objDtr["I_COD_RECHEIO"]);
                    aobj_Bolo.TAM_BOLO = objDtr["S_TAM_BOLO"].ToString();
                    aobj_Bolo.NM_BOLO = objDtr["S_NM_BOLO"].ToString();
                    aobj_Bolo.VALOR_BOLO = Convert.ToDouble(objDtr["D_VALOR_BOLO"]);
                    aobj_Bolo.COD_COBERTURA = Convert.ToInt16(objDtr["I_COD_COBERTURA"]);

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
        * Nome           : FindAllBolo
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Bolo
        * Data Criação   : 14/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Bolo> FindAllBolo()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_BOLO ";
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
                        Bolo aobj_Bolo = new Bolo();

                        aobj_Bolo.COD_BOLO = Convert.ToInt16(objDtr["I_COD_BOLO"]);
                        aobj_Bolo.COD_SABOR = Convert.ToInt16(objDtr["I_COD_SABOR"]);
                        aobj_Bolo.COD_RECHEIO = Convert.ToInt16(objDtr["I_COD_RECHEIO"]);
                        aobj_Bolo.TAM_BOLO = objDtr["S_TAM_BOLO"].ToString();
                        aobj_Bolo.NM_BOLO = objDtr["S_NM_BOLO"].ToString();
                        aobj_Bolo.VALOR_BOLO = Convert.ToDouble(objDtr["D_VALOR_BOLO"]);
                        aobj_Bolo.COD_COBERTURA = Convert.ToInt16(objDtr["I_COD_COBERTURA"]);

                        aLista.Add(aobj_Bolo);

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
