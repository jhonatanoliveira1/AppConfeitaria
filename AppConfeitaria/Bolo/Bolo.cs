/**********************************************************************************
 * NOME:            Bolo
 * CLASSE:          Representação da entidade Bolo 
 * DT CRIAÇÃO:      01/11/2019
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
    class Bolo
    {
        //(Mfacine - 01/11/2019) Metodo de Destruição da Classe
        ~Bolo()
        {
        }

        //(Mfacine - 01/11/2019) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_BOLO = -1;
        int VCOD_SABOR = -1;
        int VCOD_RECHEIO = -1;
        int VTAM_BOLO = 0;
        string VNM_BOLO = null;
        int VCOB_BOLO= 0;

        //(Mfacine - 01/11/2019) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_BOLO     
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COD_BOLO
        {
            get { return VCOD_BOLO; }
            set { VCOD_BOLO = value; }
        }

        /***********************************************************************
        * NOME:            COD_SABOR 
        * METODO:          Representação do atributo Tema com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COD_SABOR
        {
            get { return VCOD_SABOR; }
            set { VCOD_SABOR = value; }
        }

        /***********************************************************************
       * NOME:            COD_RECHEIO 
       * METODO:          Representação do atributo Tema com os métodos 
       *                  Get e Set          
       * DT CRIAÇÃO:      01/11/2019    
       * DT ALTERAÇÃO:    -
       * ESCRITA POR:     Mfacine
       **********************************************************************/
        public int COD_RECHEIO
        {
            get { return VCOD_RECHEIO; }
            set { VCOD_RECHEIO = value; }
        }




        /***********************************************************************
        * NOME:            TAM_BOLO    
        * METODO:          Representação do atributo Tamanho com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int TAM_BOLO
        {
            get { return VTAM_BOLO; }
            set { VTAM_BOLO = value; }
        }


        /***********************************************************************
        * NOME:            NM_BOLO     
        * METODO:          Representação do atributo Nome com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public string NM_BOLO
        {
            get { return VNM_BOLO; }
            set { VNM_BOLO = value; }
        }


        /***********************************************************************
        * NOME:            COR_TATUAGEM     
        * METODO:          Representação do atributo Tamanho com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COB_BOLO
        {
            get { return VCOB_BOLO ; }
            set { VCOB_BOLO = value; }
        }

    }
}
