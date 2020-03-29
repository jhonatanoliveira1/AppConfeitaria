/**********************************************************************************
 * NOME:            Recheio
 * CLASSE:          Representação da entidade Recheio 
 * DT CRIAÇÃO:      04/11/2019
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
    public class frm_Recheio
    {
        //(Grupo (Tanto Faz)- 01/11/2019) Metodo de Destruição da Classe
        ~frm_Recheio()
        {
        }

        //(Grupo (Tanto Faz)- 01/11/2019) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_RECHEIO = -1;
        string VTIT_RECHEIO = null;
        string VDESC_RECHEIO = null;

        //(Grupo (Tanto Faz)- 01/11/2019) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_RECHEIO     
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_RECHEIO
        {
            get { return VCOD_RECHEIO; }
            set { VCOD_RECHEIO = value; }
        }

        /***********************************************************************
        * NOME:            TIT_RECHEIO     
        * METODO:          Representação do atributo Titulo com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string TIT_RECHEIO
        {
            get { return VTIT_RECHEIO; }
            set { VTIT_RECHEIO = value; }
        }


        /***********************************************************************
        * NOME:            DESC_RECHEIO     
        * METODO:          Representação do atributo descrição com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string DESC_RECHEIO
        {
            get { return VDESC_RECHEIO; }
            set { VDESC_RECHEIO = value; }
        }

    }
}
