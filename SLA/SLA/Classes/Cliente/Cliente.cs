using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLA
{
    class Cliente
    {
       ~Cliente()
        {
        }

        //ATRIBUTOS/PROPRIEDADES PRIVADAS ENCAPSULADAS
        int    VCOD_CLIENTE   = -1;
        string VNOME_CLIENTE  = null;
        string VEMAIL_CLIENTE = null;
        string VTEL_CLIENTE   = null;
        string VEND_CLIENTE   = null;
        string VBAI_CLIENTE = null;
        string VCID_CLIENTE   = null;
        string VUF_CLIENTE    = null;
        string VCEP_CLIENTE   = null;


        //(Amonrá e guilherme) Métodos Públicos
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
        * NOME:            NOME_CLIENTE    
        * METODO:          Representação do atributo NOME Cliente com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public string NOME_CLIENTE
        {
            get { return VNOME_CLIENTE;}
            set { VNOME_CLIENTE = value; }
        }
        /***********************************************************************
        * NOME:            EMAIL_CLIENTE    
        * METODO:          Representação do atributo EMAIL Cliente com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public string EMAIL_CLIENTE
        {
            get { return VEMAIL_CLIENTE; }
            set { VEMAIL_CLIENTE = value; }
        }
        /***********************************************************************
        * NOME:            TEL_CLIENTE    
        * METODO:          Representação do atributo TEL Cliente com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public string TEL_CLIENTE
        {
            get { return VTEL_CLIENTE; }
            set { VTEL_CLIENTE = value; }
        }
        /***********************************************************************
        * NOME:            END_CLIENTE    
        * METODO:          Representação do atributo END Cliente com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public string END_CLIENTE
        {
            get { return VEND_CLIENTE; }
            set { VEND_CLIENTE = value; }

        }
        /***********************************************************************
        * NOME:            CID_CLIENTE    
        * METODO:          Representação do atributo CID Cliente com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public string CID_CLIENTE
        {
            get { return VCID_CLIENTE; }
            set { VCID_CLIENTE = value; }
        }
        /***********************************************************************
        * NOME:            UF_CLIENTE    
        * METODO:          Representação do atributo UF Cliente com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public string UF_CLIENTE
        {
            get { return VUF_CLIENTE; }
            set { VUF_CLIENTE = value; }
               
        }
        /***********************************************************************
        * NOME:            CEP_CLIENTE    
        * METODO:          Representação do atributo CEP Cliente com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public string CEP_CLIENTE
        {
            get { return VCEP_CLIENTE; }
            set { VCEP_CLIENTE = value; }

        }
        /***********************************************************************
        * NOME:            BAI_CLIENTE     
        * METODO:          Representação do atributo BAI Cliente com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amonrá e guilherme
        **********************************************************************/
        public string BAI_CLIENTE
        {
            get { return VBAI_CLIENTE; }
            set { VBAI_CLIENTE = value; }
               
        }
    }

}
