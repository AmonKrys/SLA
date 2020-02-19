/*****************************************************************************
* Nome           : LocacaoBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade LocacaoDB
* Data  Criação  : 12/11/2019
* Data Alteração : -
* Escrito por    :  Amon e Guilherme
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

namespace SLA
{
    class LocacaoBD
    {
        //05/11/2019 - Amon e Guilherme - : criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Locacao
        * Parametros     : Objeto da Classe Locacao
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Amon e Guilherme
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Locacao aobj_Locacao)
        {
            //Amonrá e guilherme - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //Amonrá e guilherme - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_LOCACAO " +
                            "(" +
                            " S_INICIO_LOCACAO ," +
                            " S_FIM_LOCACAO,    " +
                            " S_OBS_LOCACAO      " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @S_INICIO_LOCACAO,  " +
                            " @S_FIM_LOCACAO, " +
                            " @S_OBS_LOCACAO   " +
                            "); " +
                            "SELECT ident_current('TB_LOCACAO') as 'id'";

            //Amonrá e guilherme - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            
            objCmd.Parameters.AddWithValue("@S_INICIO_LOCACAO ", aobj_Locacao.INICIO_LOCACAO);
            objCmd.Parameters.AddWithValue("@S_FIM_LOCACAO", aobj_Locacao.FIM_LOCACAO);
            objCmd.Parameters.AddWithValue("@S_OBS_LOCACAO  ", aobj_Locacao.OBS_LOCACAO);
            try
            {
                //Amonrá e guilherme - Abrir a conexão com o banco de dados
                objCon.Open();

                //Amonrá e guilherme - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(Amonrá e guilherme) fechar a conexão
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
        * Escrito por    : Amon e Guilherme
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Locacao aobj_Locacao)
        {


            if (aobj_Locacao.COD_LOCACAO != -1)
            {
                //(Amonrá e guilherme) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(Amonrá e guilherme) Criar a variável que contém a instrução SQL
                string varSql = "UPDATE TB_LOCACAO SET " +
                                "S_INICIO_LOCACAO   =  @S_INICIO_LOCACAO , " +
                                "S_FIM_LOCACAO      =  @S_FIM_LOCACAO,    " +
                                "S_OBS_LOCACAO      =  @S_OBS_LOCACAO      " +
                                "WHERE I_COD_LOCACAO = @I_COD_LOCACAO";

                //(Amonrá e guilherme) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_LOCACAO  ", aobj_Locacao.COD_LOCACAO);
                objCmd.Parameters.AddWithValue("@S_INICIO_LOCACAO ", aobj_Locacao.INICIO_LOCACAO);
                objCmd.Parameters.AddWithValue("@S_FIM_LOCACAO", aobj_Locacao.FIM_LOCACAO);
                objCmd.Parameters.AddWithValue("@S_OBS_LOCACAO  ", aobj_Locacao.OBS_LOCACAO);
                try
                {
                    //(Amonrá e guilherme) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(Amonrá e guilherme) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(Amonrá e guilherme) fechar a conexão
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
        * Data  Criação  : 13/02/2020
        * Data Alteração : -
        * Escrito por    : Amon e Guilherme
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Locacao aobj_Locacao)
        {
            //(Amonrá e guilherme) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(Amonrá e guilherme) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_LOCACAO " +
                            " WHERE I_COD_LOCACAO = @I_COD_LOCACAO";

            //(Amonrá e guilherme) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_LOCACAO", aobj_Locacao.COD_LOCACAO);

            try
            {
                //(Amonrá e guilherme) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(Amonrá e guilherme) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(Amonrá e guilherme) Fechar a conexão com o banco de dados
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
        * Nome           : FindByCodLocacao
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_LOCACAO
        * Parametros     : Objeto da Classe Cliente
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Amon e Guilherme
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Locacao FindByCodLocacao(Locacao aobj_Locacao)
        {
            //(Amonrá e guilherme) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(Amonrá e guilherme) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_LOCACAO " +
                            " WHERE I_COD_LOCACAO = @I_COD_LOCACAO ";

            //(Amonrá e guilherme) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_LOCACAO", aobj_Locacao.COD_LOCACAO);

            try
            {
                //(Amonrá e guilherme) Abrir a conexão com o banco de dados
                objCon.Open();

                //(Amonrá e guilherme) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(Amonrá e guilherme) Recupero os valores (Tipo um Popula Objeto)

                    aobj_Locacao.COD_LOCACAO = Convert.ToInt16(objDtr["I_COD_LOCACAO"]);
                    aobj_Locacao.INICIO_LOCACAO = Convert.ToString(objDtr["S_INICIO_LOCACAO"]);
                    aobj_Locacao.FIM_LOCACAO = Convert.ToString(objDtr["S_FIM_LOCACAO"]);
                    aobj_Locacao.OBS_LOCACAO = objDtr["S_OBS_LOCACAO"].ToString();
                    
                    
                    
                    


                }

                objCon.Close();
                objDtr.Close();
                return aobj_Locacao;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Locacao;
            }
        }


        /****************************************************************************
        * Nome           : FindAllLocacao
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Locacao
        * Data Criação   : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Amon e Guilherme
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Locacao> FindAllLocacao()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_LOCACAO ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Locacao> aLista = new List<Locacao>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Locacao aobj_Locacao = new Locacao();

                        objCmd.Parameters.AddWithValue("@I_COD_LOCACAO  ", aobj_Locacao.COD_LOCACAO);
                        objCmd.Parameters.AddWithValue("@S_INICIO_LOCACAO ", aobj_Locacao.INICIO_LOCACAO);
                        objCmd.Parameters.AddWithValue("@S_FIM_LOCACAO", aobj_Locacao.FIM_LOCACAO);
                        objCmd.Parameters.AddWithValue("@S_OBS_LOCACAO  ", aobj_Locacao.OBS_LOCACAO);









                        aLista.Add(aobj_Locacao);

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
