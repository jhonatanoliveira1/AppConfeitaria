/**********************************************************************************
 * NOME:            Pedido
 * CLASSE:          Representação da entidade Pedido 
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
    class frm_Pedido
    {
        //(Grupo (Tanto Faz)- 13/02/2020) Metodo de Destruição da Classe
        ~frm_Pedido()
        {
        }

        //(Grupo (Tanto Faz)- 13/02/2020) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_PEDIDO = -1;
        int VCOD_CLIENTE = -1;
        int VCOD_ENTREGA = -1;
        DateTime VDH_PEDIDO = DateTime.MinValue;
        string VOBS_PEDIDO = null;

        //(Grupo (Tanto Faz)- 13/02/2020) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_PEDIDO    
        * METODO:          Representação do atributo Código Pedido com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_PEDIDO
        {
            get { return VCOD_PEDIDO; }
            set { VCOD_PEDIDO = value; }
        }

        /***********************************************************************
        * NOME:            COD_CLIENTE    
        * METODO:          Representação do atributo código do tatuador com os métodos 
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
        * NOME:            COD_ENTREGA
        * METODO:          Representação do atributo Código Entrega com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_ENTREGA
        {
            get { return VCOD_ENTREGA; }
            set { VCOD_ENTREGA = value; }
        }


        /***********************************************************************
        * NOME:            DH_PEDIDO    
        * METODO:          Representação do atributo Código Pedido com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public DateTime DH_AGENDA
        {
            get { return VDH_PEDIDO; }
            set { VDH_PEDIDO = value; }
        }


        /***********************************************************************
        * NOME:            OBS_PEDIDO    
        * METODO:          Representação do atributo Observação Pedido com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      13/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string OBS_PEDIDO
        {
            get { return VOBS_PEDIDO; }
            set { VOBS_PEDIDO = value; }
        }

        public DateTime DH_PEDIDO { get; internal set; }
    }
}
