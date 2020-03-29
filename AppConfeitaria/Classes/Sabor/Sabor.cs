/**********************************************************************************
 * NOME:            Sabor
 * CLASSE:          Representação da entidade Sabor 
 * DT CRIAÇÃO:     19/02/2020
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
    public class frm_Sabor
    {
        //(Grupo (Tanto Faz)-19/02/2020) Metodo de Destruição da Classe
        ~frm_Sabor()
        {
        }

        //(Grupo (Tanto Faz)-19/02/2020) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_SABOR = -1;
        string VTIT_SABOR = null;
        string VDESC_SABOR = null;

        //(Grupo (Tanto Faz)-19/02/2020) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_SABOR     
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:     19/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_SABOR
        {
            get { return VCOD_SABOR; }
            set { VCOD_SABOR = value; }
        }


        /***********************************************************************
        * NOME:            TIT_SABOR     
        * METODO:          Representação do atributo Título com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:     19/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string TIT_SABOR
        {
            get { return VTIT_SABOR; }
            set { VTIT_SABOR = value; }
        }


        /***********************************************************************
        * NOME:            DESC_SABOR     
        * METODO:          Representação do atributo Descrição com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:     19/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string DESC_SABOR
        {
            get { return VDESC_SABOR; }
            set { VDESC_SABOR = value; }
        }


    }
}
