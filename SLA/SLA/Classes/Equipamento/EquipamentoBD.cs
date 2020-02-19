/*****************************************************************************
* Nome           : EquipamentoBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Equipamento
* Data  Criação  : 12/11/2019
* Data Alteração : -
* Escrito por    : Amon e Guilherme
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
    class EquipamentoBD
    {
        //05/11/2019 - Mfacine - ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Cliente
        * Parametros     : Objeto da Classe Cliente
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Amon e Guilherme
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Equipamento aobj_Equipamento)
        {
            //12/11/2019 - Mfacine - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //12/11/2018 - Mfacine - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_EQUIPAMENTO " +
                            "(" +
                            " I_COD_EQUIPAMENTO   ," +
                            " S_TIPO_EQUIPAMENTO  ," +
                            " S_MARCA_EQUIPAMENTO, " +
                            " S_MODEL_EQUIPAMENTO, " +
                            " S_PROC_EQUIPAMENTO , " +
                            " S_MRAM_EQUIPAMENTO , " +
                            " S_HDD_EQUIPAMENTO  , " +
                            " S_SN_EQUIPAMENTO   , " +
                            " S_SO_EQUIPAMENTO   , " +
                            " S_OBS_EQUIPAMENTO    " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @I_COD_EQUIPAMENTO,   " +
                            " @S_TIPO_EQUIPAMENTO,  " +
                            " @S_MARCA_EQUIPAMENTO, " +
                            " @S_MODEL_EQUIPAMENTO, " +
                            " @S_PROC_EQUIPAMENTO,  " +
                            " @S_MRAM_EQUIPAMENTO , " +
                            " @S_HDD_EQUIPAMENTO,   " +
                            " @S_SN_EQUIPAMENTO ,   " +
                            " @S_SO_EQUIPAMENTO,    " +
                            " @S_OBS_EQUIPAMENTO ,  " + 
                            "); " +
                            "SELECT ident_current('TB_EQUIPAMENTO') as 'id'";

            //12/11/2019 - mfacine - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@S_TIPO_EQUIPAMENTO ", aobj_Equipamento.TIPO_EQUIPAMENTO);
            objCmd.Parameters.AddWithValue("@S_MARCA_EQUIPAMENTO", aobj_Equipamento.MARCA_EQUIPAMENTO);
            objCmd.Parameters.AddWithValue("@S_MODEL_EQUIPAMENTO", aobj_Equipamento.MARCA_EQUIPAMENTO);
            objCmd.Parameters.AddWithValue("@S_PROC_EQUIPAMENTO ", aobj_Equipamento.PROC_EQUIPAMENTO);
            objCmd.Parameters.AddWithValue("@S_MRAM_EQUIPAMENTO ", aobj_Equipamento.MRAM_EQUIPAMENTO);
            objCmd.Parameters.AddWithValue("@S_HDD_EQUIPAMENTO  ", aobj_Equipamento.HDD_EQUIPAMENTO);
            objCmd.Parameters.AddWithValue("@S_SN_EQUIPAMENTO   ", aobj_Equipamento.SN_EQUIPAMENTO);
            objCmd.Parameters.AddWithValue("@S_SO_EQUIPAMENTO   ", aobj_Equipamento.SO_EQUIPAMENTO);
            objCmd.Parameters.AddWithValue("@S_OBS_EQUIPAMENTO  ", aobj_Equipamento.OBS_EQUIPAMENTO);

            try
            {
                //12/11/2019 - mfacine - Abrir a conexão com o banco de dados
                objCon.Open();

                //12/11/2019 - mfacine - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(12/11/2018-mfacine) fechar a conexão
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
        public Boolean Alterar(Equipamento aobj_Equipamento)
        {


            if (aobj_Equipamento.COD_EQUIPAMENTO != -1)
            {
                //(12/11/2018-mfacine) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(12/11/2018-mfacine) Criar a variável que contém a instrução SQL
                string varSql = "UPDATE TB_EQUIPAMENTO SET " +
                                "I_COD_EQUIPAMENTO  = @I_COD_EQUIPAMENTO    , " +
                                "S_TIPO_EQUIPAMENTO = @S_TIPO_EQUIPAMENTO   , " +
                                "S_MARCA_EQUIPAMENTO= @S_MARCA_EQUIPAMENTO  , " +
                                "S_MODEL_EQUIPAMENTO= @S_MODEL_EQUIPAMENTO  , " +
                                "S_PROC_EQUIPAMENTO = @S_PROC_EQUIPAMENTO   , " +
                                "S_MRAM_EQUIPAMENTO = @S_MRAM_EQUIPAMENTO   , " +
                                "S_HDD_EQUIPAMENTO  = @S_HDD_EQUIPAMENTO    , " +
                                "S_SN_EQUIPAMENTO   = @S_SN_EQUIPAMENTO     , " +
                                "S_SO_EQUIPAMENTO   = @S_SO_EQUIPAMENTO     , " +
                                "S_OBS_EQUIPAMENTO  = @S_OBS_EQUIPAMENTO     " +
                                "WHERE I_COD_EQUIPAMENTO = @I_COD_EQUIPAMENTO";

                //(12/11/2019-mfacine) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@S_TIPO_EQUIPAMENTO ", aobj_Equipamento.TIPO_EQUIPAMENTO);
                objCmd.Parameters.AddWithValue("@S_MARCA_EQUIPAMENTO", aobj_Equipamento.MARCA_EQUIPAMENTO);
                objCmd.Parameters.AddWithValue("@S_MODEL_EQUIPAMENTO", aobj_Equipamento.MARCA_EQUIPAMENTO);
                objCmd.Parameters.AddWithValue("@S_PROC_EQUIPAMENTO ", aobj_Equipamento.PROC_EQUIPAMENTO);
                objCmd.Parameters.AddWithValue("@S_MRAM_EQUIPAMENTO ", aobj_Equipamento.MRAM_EQUIPAMENTO);
                objCmd.Parameters.AddWithValue("@S_HDD_EQUIPAMENTO  ", aobj_Equipamento.HDD_EQUIPAMENTO);
                objCmd.Parameters.AddWithValue("@S_SN_EQUIPAMENTO   ", aobj_Equipamento.SN_EQUIPAMENTO);
                objCmd.Parameters.AddWithValue("@S_SO_EQUIPAMENTO   ", aobj_Equipamento.SO_EQUIPAMENTO);
                objCmd.Parameters.AddWithValue("@S_OBS_EQUIPAMENTO  ", aobj_Equipamento.OBS_EQUIPAMENTO);
                try
                {
                    //(12/11/2019-mfacine) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(12/11/2019-mfacine) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(12/11/2018-mfacine) fechar a conexão
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
        * Parametros     : Objeto da Classe Equipamento
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Amon e Guilherme
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Equipamento aobj_Equipamento)
        {
            //(12/11/2018-mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_CLIENTE " +
                            " WHERE I_COD_EQUIPAMENTO = @I_COD_EQUIPAMENTO";

            //(12/11/2018-mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_EQUIPAMENTO", aobj_Equipamento.COD_EQUIPAMENTO);

            try
            {
                //(12/11/2018-mfacine) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(12/11/2018-mfacine) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(12/11/2018-mfacine) Fechar a conexão com o banco de dados
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
        * Nome           : FindByCodEquipamento
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_Equipamento
        * Parametros     : Objeto da Classe Equipamento
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Amon e Guilherme
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Equipamento FindByCodEquipamento(Equipamento aobj_Equipamento)
        {
            //(12/11/2018-Mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-Mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_CLIENTE " +
                            " WHERE I_COD_EQUIPAMENTO = @I_COD_EQUIPAMENTO ";

            //(12/11/2018-Mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_EQUIPAMENTO", aobj_Equipamento.COD_EQUIPAMENTO);

            try
            {
                //(12/11/2018-Mfacine) Abrir a conexão com o banco de dados
                objCon.Open();

                //(12/11/2018-Mfacine) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(12/11/2018-mfacine) Recupero os valores (Tipo um Popula Objeto)

                    aobj_Equipamento.COD_EQUIPAMENTO = Convert.ToInt16(objDtr["I_COD_EQUIPAMENTO"]);
                    aobj_Equipamento.TIPO_EQUIPAMENTO = objDtr["S_TIPO_EQUIPAMENTO"].ToString();
                    aobj_Equipamento.MARCA_EQUIPAMENTO = objDtr["S_MARCA_EQUIPAMENTO"].ToString();
                    aobj_Equipamento.MARCA_EQUIPAMENTO = objDtr["S_MODEL_EQUIPAMENTO"].ToString();
                    aobj_Equipamento.PROC_EQUIPAMENTO = objDtr["S_PROC_EQUIPAMENTO"].ToString();
                    aobj_Equipamento.MRAM_EQUIPAMENTO = objDtr["S_MRAM_EQUIPAMENTO"].ToString();
                    aobj_Equipamento.HDD_EQUIPAMENTO = objDtr["S_HDD_EQUIPAMENTO"].ToString();
                    aobj_Equipamento.SN_EQUIPAMENTO = objDtr["S_SN_EQUIPAMENTO"].ToString();
                    aobj_Equipamento.SO_EQUIPAMENTO = objDtr["S_SO_EQUIPAMENTO"].ToString();
                    aobj_Equipamento.OBS_EQUIPAMENTO = objDtr["B_OBS_EQUIPAMENTO"].ToString();

                }

                objCon.Close();
                objDtr.Close();
                return aobj_Equipamento;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Equipamento;
            }
        }


        /****************************************************************************
        * Nome           : FindAllEquipamento
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Equipamento
        * Data Criação   : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Amon e Guilherme
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Equipamento> FindAllEquipamento()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_EQUIPAMENTO ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Equipamento> aLista = new List<Equipamento>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Equipamento aobj_Equipamento = new Equipamento();

                        aobj_Equipamento.COD_EQUIPAMENTO = Convert.ToInt16(objDtr["I_COD_EQUIPAMENTO"]);
                        aobj_Equipamento.TIPO_EQUIPAMENTO = objDtr["S_TIPO_EQUIPAMENTO"].ToString();
                        aobj_Equipamento.MARCA_EQUIPAMENTO = objDtr["S_MARCA_EQUIPAMENTO"].ToString();
                        aobj_Equipamento.MARCA_EQUIPAMENTO = objDtr["S_MODEL_EQUIPAMENTO"].ToString();
                        aobj_Equipamento.PROC_EQUIPAMENTO = objDtr["S_PROC_EQUIPAMENTO"].ToString();
                        aobj_Equipamento.MRAM_EQUIPAMENTO = objDtr["S_MRAM_EQUIPAMENTO"].ToString();
                        aobj_Equipamento.HDD_EQUIPAMENTO = objDtr["S_HDD_EQUIPAMENTO"].ToString();
                        aobj_Equipamento.SN_EQUIPAMENTO = objDtr["S_SN_EQUIPAMENTO"].ToString();
                        aobj_Equipamento.SO_EQUIPAMENTO = objDtr["S_SO_EQUIPAMENTO"].ToString();
                        aobj_Equipamento.OBS_EQUIPAMENTO = objDtr["B_OBS_EQUIPAMENTO"].ToString();



                        aLista.Add(aobj_Equipamento);

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
