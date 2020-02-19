using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLA
{
    class Locacao
    {
        //Amon e Guilherme METODOS DE DESTRUIÇÃO DA CLASSE
       ~Locacao()
        {
        }
        //Amon e guilherme ATRIBUTOS/PROPRIEDADES PRIVADAS ENCAPSULADAS
        int VCOD_LOCACAO = -1;
        int VCOD_CLIENTE = -1;
        int VCOD_EQUIPAMENTO = -1;
        string VINICIO_LOCACAO = null;
        string VFIM_LOCACAO = null;
        string VOBS_LOCACAO = null;

        //(Amonrá e guilherme) Métodos Públicos
        /***********************************************************************
        * NOME:            COD_LOCACAO     
        * METODO:          Representação do atributo Código LOCACAO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public int COD_LOCACAO
        {
            get { return VCOD_LOCACAO; }
            set { VCOD_CLIENTE = value; }
        }
        /***********************************************************************
        * NOME:            COD_CLIENTE   
        * METODO:          Representação do atributo Código Cliente com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public int COD_CLIENTE
        {
            get { return VCOD_CLIENTE; }
            set { VCOD_CLIENTE = value; }
        }
        /***********************************************************************
        * NOME:            COD_EQUIPAMEMTO   
        * METODO:          Representação do atributo Código EQUIPAMENTO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public int COD_EQUIPAMENTO
        {
            get { return VCOD_EQUIPAMENTO; }
            set { VCOD_EQUIPAMENTO = value; }
        }
        /***********************************************************************
        * NOME:            DH_INICIO_LOCACAO   
        * METODO:          Representação do atributo DateTime INICIO_LOCACAO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public string INICIO_LOCACAO
        {
            get { return VINICIO_LOCACAO; }
            set { VFIM_LOCACAO = value; }
        }
        /***********************************************************************
        * NOME:            DH_FIM_LOCACAO   
        * METODO:          Representação do atributo DateTime FIM_LOCACAO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public string FIM_LOCACAO
        {
            get { return VFIM_LOCACAO; }
            set { VFIM_LOCACAO = value; }
        }
        /***********************************************************************
        * NOME:            VOBS_LOCACAO   
        * METODO:          Representação do atributo DateTime VOBS_LOCACAO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
         public string OBS_LOCACAO
        {
            get { return VOBS_LOCACAO; }
            set { VOBS_LOCACAO = value; }
        } 
    }

}
