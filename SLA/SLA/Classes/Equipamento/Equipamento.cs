using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLA
{

    class Equipamento
    { 
        //(Amon e Guilherme) METODO DE DESTRUIÇÃO DA CLASSE
        ~Equipamento()
        {
        }

        // (Amon e Guilherme) Atributos/Propriedades Privadas Encapsuladas
        int    VCOD_EQUIPAMENTO = -1;
        string VTIPO_EQUIPAMENTO = null;
        string VMARCA_EQUIPAMENTO = null;
        string VMODEL_EQUIPAMENTO = null;
        string VPROC_EQUIPAMENTO = null;
        string VMRAM_EQUIPAMENTO = null;
        string VHDD_EQUIPAMENTO = null;
        string VSN_EQUIPAMENTO = null;
        string VSO_EQUIPAMENTO = null;
        string VOBS_EQUIPAMENTO = null;

        //(Amon e Guilherme) Metodos Públicos
        /***********************************************************************
        * NOME:            COD_EQUIPAMENTO     
        * METODO:          Representação do atributo Código EQUIPAMENTO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon e Guilherme
        **********************************************************************/
        public int COD_EQUIPAMENTO
        {
            get { return VCOD_EQUIPAMENTO; }
            set { VCOD_EQUIPAMENTO = value; }
        }
        /***********************************************************************
        * NOME:            TIPO_EQUIPAMENTO     
        * METODO:          Representação do atributo Código EQUIPAMENTO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon e Guilherme
        **********************************************************************/
        public string TIPO_EQUIPAMENTO
        {
            get { return VTIPO_EQUIPAMENTO; }
            set { VTIPO_EQUIPAMENTO = value; }
        }
        /***********************************************************************
        * NOME:            MARCA_EQUIPAMENTO     
        * METODO:          Representação do atributo MARCA EQUIPAMENTO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon e Guilherme
        **********************************************************************/
        public string MARCA_EQUIPAMENTO
        {
            get { return VMARCA_EQUIPAMENTO; }
            set { VMARCA_EQUIPAMENTO = value; }
        }
        /***********************************************************************
        * NOME:            MODEL_EQUIPAMENTO     
        * METODO:          Representação do atributo MODELO EQUIPAMENTO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon e Guilherme
        **********************************************************************/
        public string MODEL_EQUIPAMENTO
        {
            get { return VMODEL_EQUIPAMENTO; }
            set { VMODEL_EQUIPAMENTO = value; }
        }
        /***********************************************************************
        * NOME:           PROC_EQUIPAMENTO     
        * METODO:          Representação do atributo PROC EQUIPAMENTO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon e Guilherme
        **********************************************************************/
        public string PROC_EQUIPAMENTO
        {
            get { return VPROC_EQUIPAMENTO; }
            set { VPROC_EQUIPAMENTO = value; }
        }
        /***********************************************************************
        * NOME:           MRAM_EQUIPAMENTO     
        * METODO:          Representação do atributo MRAM EQUIPAMENTO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon e Guilherme
        **********************************************************************/
        public string MRAM_EQUIPAMENTO
        {
            get { return VMRAM_EQUIPAMENTO; }
            set { VMRAM_EQUIPAMENTO = value; }
        }
        /***********************************************************************
        * NOME:           HDD_EQUIPAMENTO     
        * METODO:          Representação do atributo HDD EQUIPAMENTO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon e Guilherme
        **********************************************************************/
        public string HDD_EQUIPAMENTO
        {
            get { return VHDD_EQUIPAMENTO; }
            set { VHDD_EQUIPAMENTO = value; }
        }
        /***********************************************************************
        * NOME:           SN_EQUIPAMENTO     
        * METODO:          Representação do atributo SN EQUIPAMENTO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon e Guilherme
        **********************************************************************/
        public string SN_EQUIPAMENTO
        {
            get { return VSN_EQUIPAMENTO; }
            set { VSN_EQUIPAMENTO = value; }
        }
        /***********************************************************************
        * NOME:           SO_EQUIPAMENTO     
        * METODO:          Representação do atributo SO EQUIPAMENTO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon e Guilherme
        **********************************************************************/
        public string SO_EQUIPAMENTO
        {
            get { return VSO_EQUIPAMENTO; }
            set { VSO_EQUIPAMENTO = value; }
        }
        /***********************************************************************
        * NOME:           OBS_EQUIPAMENTO     
        * METODO:          Representação do atributo OBS EQUIPAMENTO com os métodos
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon e Guilherme
        **********************************************************************/
        public string OBS_EQUIPAMENTO
        {
            get { return VOBS_EQUIPAMENTO; }
            set { VOBS_EQUIPAMENTO = value; }
        }
    }
}
