/**********************************************************************************
 * NOME:            Entrega
 * CLASSE:          Representação da entidade Entrega 
 * DT CRIAÇÃO:      14/02/2020
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:     Grupo (Tanto Faz)
 * OBSERVAÇÕES:     Atributos privados com métodos Get e Set públicos
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfeitaria
{
    class Entrega
    {
        //(Grupo (Tanto Faz) - 14/02/2020) Metodo de Destruição da Classe
        ~Entrega()
        {
        }

        //(Grupo (Tanto Faz) - 14/02/2020) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_ENTREGA= -1;
        string VSEM_ENTREGA= null;
        string VPER_ENTREGA= null;

        //(Grupo (Tanto Faz) - 14/02/2020) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_ENTREGA    
        * METODO:          Representação do atributo Código do turno com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      14/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Grupo (Tanto Faz)
        **********************************************************************/
        public int COD_ENTREGA
        {
            get { return VCOD_ENTREGA; }
            set { VCOD_ENTREGA= value; }
        }


        /***********************************************************************
        * NOME:            SEM_ENTREGA    
        * METODO:          Representação do atributo semana com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      14/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Grupo (Tanto Faz)
        **********************************************************************/
        public string SEM_ENTREGA
        {
            get { return VSEM_ENTREGA; }
            set { VSEM_ENTREGA= value; }
        }


        /***********************************************************************
        * NOME:            PER_ENTREGA    
        * METODO:          Representação do atributo periodo com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      14/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Grupo (Tanto Faz)
        **********************************************************************/
        public string PER_ENTREGA
        {
            get { return VPER_ENTREGA; }
            set { VPER_ENTREGA= value; }
        }

    }
}
