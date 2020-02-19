/**********************************************************************************
 * NOME:            Equipamento
 * CLASSE:          Representação da entidade Equipamento 
 * DT CRIAÇÃO:      13/02/2020
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:     Guilherme & Amon ra
 * OBSERVAÇÕES:     Atributos privados com métodos Get e Set públicos
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipamento
{
    class Equipamento
    {
        //(Guilherme & Amon ra - 13/02/2020) Metodo de Destruição da Classe
        ~Equipamento()
        {
        }

        //(Guilherme & Amon ra - 13/02/2020) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_EQUIPAMENTO = -1;
        string VTIPO_EQUIPAMENTO = null;
        string VMARCA_EQUIPAMENTO = null;
        string VMODEL_EQUIPAMENTO = null;
        string VPROC_EQUIPAMENTO = null;
        string VMRAM_EQUIPAMENTO = null;
        string VHDD_EQUIPAMENTO = null;
        string VSN_EQUIPAMENTO = null;
        string VSO_EQUIPAMENTO = null;
        string VOBS_EQUIPAMENTO = null;

        //(Guilherme & Amon ra - 13/02/2020) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_EQUIPAMENTO     
        * METODO:          Representação do atributo Código Equipamento com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Guilherme & Amon ra
        **********************************************************************/
        public int COD_EQUIPAMENTO
        {
            get { return VCOD_EQUIPAMENTO; }
            set { VCOD_EQUIPAMENTO = value; }
        }

        /*************************************************************************
        * NOME:            TIPO EQUIPAMENTO     
        * METODO:          Representação do atributo código do Tipo de equipamento 
        *                  com os métodos Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Guilherme & Amon ra
        **************************************************************************/
        public string TIPO_EQUIPAMENTO
        {
            get { return VTIPO_EQUIPAMENTO; }
            set { VTIPO_EQUIPAMENTO = value; }
        }


        /***********************************************************************
        * NOME:            MARCA_EQUIPAMENTO     
        * METODO:          Representação do atributo Marca do Equipamento com 
        *                  os métodos Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Guilherme & Amon ra
        **********************************************************************/
        public string MARCA_EQUIPAMENTO
        {
            get { return VMARCA_EQUIPAMENTO; }
            set { VMARCA_EQUIPAMENTO = value; }
        }

        /***********************************************************************
        * NOME:            MODEL_EQUIPAMENTO     
        * METODO:          Representação do atributo Modelo do Equipamento com 
        *                  os métodos Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Guilherme & Amon ra
        **********************************************************************/
        public string MODEL_EQUIPAMENTO
        {
            get { return VMODEL_EQUIPAMENTO; }
            set { VMODEL_EQUIPAMENTO = value; }
        }

        /***********************************************************************
        * NOME:            PROC_EQUIPAMENTO     
        * METODO:          Representação do atributo Processador do Equipamento 
        *                  com os métodos Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Guilherme & Amon ra
        **********************************************************************/
        public string PROC_EQUIPAMENTO
        {
            get { return VPROC_EQUIPAMENTO; }
            set { VPROC_EQUIPAMENTO = value; }
        }

        /***********************************************************************
        * NOME:            MRAM_EQUIPAMENTO     
        * METODO:          Representação do atributo Memoria Ram do Equipamento 
        *                  com os métodos Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Guilherme & Amon ra
        **********************************************************************/
        public string MRAM_EQUIPAMENTO
        {
            get { return VMRAM_EQUIPAMENTO; }
            set { VMRAM_EQUIPAMENTO = value; }
        }

        /***********************************************************************
        * NOME:            HDD_EQUIPAMENTO    
        * METODO:          Representação do atributo Hard Disk com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Guilherme & Amon ra
        **********************************************************************/
        public string HDD_EQUIPAMENTO
        {
            get { return VHDD_EQUIPAMENTO; }
            set { VHDD_EQUIPAMENTO = value; }
        }

        /***********************************************************************
        * NOME:            SN_EQUIPAMENTO     
        * METODO:          Representação do atributo Serial Number com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Guilherme & Amon ra
        **********************************************************************/
        public string SN_EQUIPAMENTO
        {
            get { return VSN_EQUIPAMENTO; }
            set { VSN_EQUIPAMENTO = value; }
        }

        /***********************************************************************
        * NOME:                 
        * METODO:          Representação do atributo Sistema Operacional
        *                  com os métodos Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Guilherme & Amon ra
        **********************************************************************/
        public string SO_EQUIPAMENTO
        {
            get { return VSO_EQUIPAMENTO; }
            set { VSO_EQUIPAMENTO = value; }
        }

        /***********************************************************************
        * NOME:            OBS_EQUIPAMENTO     
        * METODO:          Representação do atributo Observação com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Guilherme & Amon ra
        **********************************************************************/
        public string OBS_EQUIPAMENTO
        {
            get { return VOBS_EQUIPAMENTO; }
            set { VOBS_EQUIPAMENTO = value; }
        }
    }
}