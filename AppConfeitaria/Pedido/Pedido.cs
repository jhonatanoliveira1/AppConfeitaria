/**********************************************************************************
 * NOME:            Agenda
 * CLASSE:          Representação da entidade Agenda 
 * DT CRIAÇÃO:      04/11/2019
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:     Mfacine (Monstro)
 * OBSERVAÇÕES:     Atributos privados com métodos Get e Set públicos
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBolaria
{
    class Pedido
    {
        //(Mfacine - 01/11/2019) Metodo de Destruição da Classe
        ~Pedido()
        {
        }

        //(Mfacine - 01/11/2019) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_PEDIDO = -1;
        int VCOD_CLIENTE = -1;
        int VCOD_ENTREGA = -1;
        DateTime VDH_PEDIDO = DateTime.MinValue;
        string VOBS_PEDIDO = null;

        //(Mfacine - 01/11/2019) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_AGENDA     
        * METODO:          Representação do atributo Código Agenda com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COD_PEDIDO
        {
            get { return VCOD_PEDIDO; }
            set { VCOD_PEDIDO = value; }
        }

        /***********************************************************************
        * NOME:            COD_TATUADOR     
        * METODO:          Representação do atributo código do tatuador com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COD_TATUADOR
        {
            get { return VCOD_CLIENTE; }
            set { VCOD_CLIENTE = value; }
        }


        /***********************************************************************
        * NOME:            COD_CLIENTE     
        * METODO:          Representação do atributo Código Cliente com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COD_CLIENTE
        {
            get { return VCOD_ENTREGA; }
            set { VCOD_ENTREGA = value; }
        }


        /***********************************************************************
        * NOME:            DH_AGENDA     
        * METODO:          Representação do atributo Código Agenda com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public DateTime DH_AGENDA
        {
            get { return VDH_PEDIDO; }
            set { VDH_PEDIDO = value; }
        }


        /***********************************************************************
        * NOME:            OBS_AGENDA     
        * METODO:          Representação do atributo Observação Agenda com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public string OBS_PEDIDO
        {
            get { return VOBS_PEDIDO; }
            set { VOBS_PEDIDO = value; }
        }
    }
}
