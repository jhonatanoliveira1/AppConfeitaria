/**********************************************************************************
 * NOME:            Bolo
 * CLASSE:          Representação da entidade Bolo 
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
    class Bolo
    {
        //(Grupo (Tanto Faz)- 14/02/2020) Metodo de Destruição da Classe
        ~Bolo()
        {
        }

        //(Grupo (Tanto Faz)- 14/02/2020) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_BOLO = -1;
        int VCOD_SABOR = -1;
        int VCOD_RECHEIO = -1;
        int VCOD_COBERTURA = -1;
        string VTAM_BOLO = null;
        double VVALOR_BOLO = 0;
        string VNM_BOLO = null;
        

        //(Grupo (Tanto Faz)- 14/02/2020) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_BOLO     
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      14/02/2020   
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_BOLO
        {
            get { return VCOD_BOLO; }
            set { VCOD_BOLO = value; }
        }

        /***********************************************************************
        * NOME:            COD_SABOR 
        * METODO:          Representação do atributo Sabor com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      14/02/2020   
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_SABOR
        {
            get { return VCOD_SABOR; }
            set { VCOD_SABOR = value; }
        }

        /***********************************************************************
       * NOME:            COD_RECHEIO 
       * METODO:          Representação do atributo Sabor com os métodos 
       *                  Get e Set          
       * DT CRIAÇÃO:      14/02/2020   
       * DT ALTERAÇÃO:    -
       * ESCRITA POR:    Jhonatan de Oliveira
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
        * DT CRIAÇÃO:      14/02/2020   
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string TAM_BOLO
        {
            get { return VTAM_BOLO; }
            set { VTAM_BOLO = value; }
        }


        /***********************************************************************
        * NOME:            NM_BOLO     
        * METODO:          Representação do atributo Nome com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      14/02/2020   
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string NM_BOLO
        {
            get { return VNM_BOLO; }
            set { VNM_BOLO = value; }
        }

        /***********************************************************************
       * NOME:            VALOR_BOLO     
       * METODO:          Representação do atributo Nome com os métodos 
       *                  Get e Set          
       * DT CRIAÇÃO:      05/03/2020   
       * DT ALTERAÇÃO:    -
       * ESCRITA POR:    Jhonatan de Oliveira
       **********************************************************************/
        public double VALOR_BOLO
        {
            get { return VVALOR_BOLO; }
            set { VVALOR_BOLO = value; }
        }

        /***********************************************************************
        * NOME:            COD_COBERUTRA   
        * METODO:          Representação do atributo Tamanho com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      14/02/2020   
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_COBERTURA

        {
            get { return VCOD_COBERTURA; }
            set { VCOD_COBERTURA = value; }
        }

        public short COD_COBERUTRA { get; internal set; }

    }
}
