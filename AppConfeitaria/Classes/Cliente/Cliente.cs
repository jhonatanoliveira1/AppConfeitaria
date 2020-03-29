/**********************************************************************************
 * NOME:            Cliente
 * CLASSE:          Representação da entidade Cliente 
 * DT CRIAÇÃO:      13/02/2020
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:    Jhonatan de Oliveira
 * OBSERVAÇÕES:     Atributos privados com métodos Get e Set públicos
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfeitaria
{
    class Cliente
    {
        //(Grupo (Tanto Faz)- 13/02/2020) Metodo de Destruição da Classe
        ~Cliente()
        {
        }

        //(Grupo (Tanto Faz)- 13/02/2020) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_CLIENTE = -1;
        string VNM_CLIENTE = null;
        string VEND_CLIENTE = null;
        string VBAI_CLIENTE = null;
        string VCID_CLIENTE = null;
        string VUF_CLIENTE = null;
        string VCEP_CLIENTE = null;
        string VCEL_CLIENTE = null;
        string VEMAIL_CLIENTE = null;
        string VCPF_CLIENTE = null;
        int VGENERO_CLIENTE = 0;
        DateTime VNASC_CLIENTE = DateTime.MinValue;


        //(Grupo (Tanto Faz)- 13/02/2020) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_CLIENTE     
        * METODO:          Representação do atributo Código Cliente com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_CLIENTE
        {
            get { return VCOD_CLIENTE; }
            set { VCOD_CLIENTE = value; }
        }




        /***********************************************************************
        * NOME:                 
        * METODO:          Representação do atributo Nome com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string NM_CLIENTE
        {
            get { return VNM_CLIENTE; }
            set { VNM_CLIENTE = value; }
        }

        /***********************************************************************
        * NOME:            END_CLIENTE     
        * METODO:          Representação do atributo endereço com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string END_CLIENTE
        {
            get { return VEND_CLIENTE; }
            set { VEND_CLIENTE = value; }
        }

        /***********************************************************************
        * NOME:            BAI_CLIENTE     
        * METODO:          Representação do atributo bairro  com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string BAI_CLIENTE
        {
            get { return VBAI_CLIENTE; }
            set { VBAI_CLIENTE = value; }
        }

        /***********************************************************************
        * NOME:            CID_CLIENTE     
        * METODO:          Representação do atributo Cidade com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string CID_CLIENTE
        {
            get { return VCID_CLIENTE; }
            set { VCID_CLIENTE = value; }
        }

        /***********************************************************************
        * NOME:            UF_CLIENTE     
        * METODO:          Representação do atributo Observação Cliente com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string UF_CLIENTE
        {
            get { return VUF_CLIENTE; }
            set { VUF_CLIENTE = value; }
        }

        /***********************************************************************
        * NOME:            CEP_CLIENTE     
        * METODO:          Representação do atributo CEP com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string CEP_CLIENTE
        {
            get { return VCEP_CLIENTE; }
            set { VCEP_CLIENTE = value; }
        }

        /***********************************************************************
        * NOME:                 
        * METODO:          Representação do atributo celular com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string CEL_CLIENTE
        {
            get { return VCEL_CLIENTE; }
            set { VCEL_CLIENTE = value; }
        }

        /***********************************************************************
        * NOME:            EMAIL_CLIENTE     
        * METODO:          Representação do atributo email com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string EMAIL_CLIENTE
        {
            get { return VEMAIL_CLIENTE; }
            set { VEMAIL_CLIENTE = value; }
        }

        /***********************************************************************
        * NOME:            CPF_CLIENTE   
        * METODO:          Representação do atributo tatoo com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string CPF_CLIENTE
        {
            get { return VCPF_CLIENTE; }
            set { VCPF_CLIENTE = value; }
        }

        /***********************************************************************
        * NOME:            GENERO_CLIENTE   
        * METODO:          Representação do atributo tatoo com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      21/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int GENERO_CLIENTE
        {
        get { return VGENERO_CLIENTE; }
        set { VGENERO_CLIENTE = value; }
        }

        /***********************************************************************
        * NOME:            NASC_CLIENTE   
        * METODO:          Representação do atributo Código Pedido com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      21/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public DateTime NASC_CLIENTE
        {
            get { return VNASC_CLIENTE; }
            set { VNASC_CLIENTE = value; }
        }

    }
}