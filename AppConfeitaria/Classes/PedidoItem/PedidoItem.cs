/**********************************************************************************
 * NOME:            PedidoItem
 * CLASSE:          Representação da entidade PedidoItem 
 * DT CRIAÇÃO:      14/02/2020
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
    class PedidoItem
    {
        //(Grupo (Tanto Faz) - 14/02/2020) Metodo de Destruição da Classe
        ~PedidoItem()
        {
        }

        //(Grupo (Tanto Faz) - 14/02/2020) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_PEDIDOITEM = -1;
        int VCOD_PEDIDO = -1;
        int VCOD_BOLO= -1;
        int VQUANT_PEDIDOITEM = 0;
        double VVTOTAL_PEDIDOITEM = 0;
        

        //(Grupo (Tanto Faz) - 14/02/2020) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_PEDIDOITEM     
        * METODO:          Representação do atributo Código PedidoItem com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      14/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_PEDIDOITEM
        {
            get { return VCOD_PEDIDOITEM; }
            set { VCOD_PEDIDOITEM = value; }
        }

        /***********************************************************************
        * NOME:            COD_PEDIDO     
        * METODO:          Representação do atributo código do tatuador com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      14/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_PEDIDO
        {
            get { return VCOD_PEDIDO; }
            set { VCOD_PEDIDO = value; }
        }


        /***********************************************************************
        * NOME:            COD_BOLO  
        * METODO:          Representação do atributo Código Pedido com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      14/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_BOLO
        {
            get { return VCOD_BOLO; }
            set { VCOD_BOLO= value; }
        }

        /***********************************************************************
       * NOME:            QUANT_PEDIDOITEM
       * METODO:          Representação do atributo Código Pedido com os métodos 
       *                  Get e Set          
       * DT CRIAÇÃO:      21/02/2020    
       * DT ALTERAÇÃO:    -
       * ESCRITA POR:    Jhonatan de Oliveira
       **********************************************************************/
        public int QUANT_PEDIDOITEM
        {
            get { return VQUANT_PEDIDOITEM; }
            set { VQUANT_PEDIDOITEM = value; }
        }

        /***********************************************************************
        * NOME:            VTOTAL_PEDIDOITEM
        * METODO:          Representação do atributo Código Pedido com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      21/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public double VTOTAL_PEDIDOITEM
        {
            get { return VVTOTAL_PEDIDOITEM; }
            set { VVTOTAL_PEDIDOITEM = value; }
        }

    }
}
