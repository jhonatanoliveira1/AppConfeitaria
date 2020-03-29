/**********************************************************************************
 * NOME:            Cobertura
 * CLASSE:          Representação da entidade Cobertura 
 * DT CRIAÇÃO:     21/02/2020
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
    public class frm_Cobertura
    {
        //(Grupo (Tanto Faz)-21/02/2020) Metodo de Destruição da Classe
        ~frm_Cobertura()
        {
        }

        //(Grupo (Tanto Faz)-21/02/2020) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_COBERTURA= -1;
        string VTIT_COBERTURA= null;
        string VDESC_COBERTURA= null;

        //(Grupo (Tanto Faz)-21/02/2020) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_COBERTURA    
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:     21/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public int COD_COBERTURA
        {
            get { return VCOD_COBERTURA; }
            set { VCOD_COBERTURA= value; }
        }


        /***********************************************************************
        * NOME:            TIT_COBERTURA    
        * METODO:          Representação do atributo Título com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:     21/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string TIT_COBERTURA
        {
            get { return VTIT_COBERTURA; }
            set { VTIT_COBERTURA= value; }
        }


        /***********************************************************************
        * NOME:            DESC_COBERTURA    
        * METODO:          Representação do atributo Descrição com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:     21/02/2020    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        **********************************************************************/
        public string DESC_COBERTURA
        {
            get { return VDESC_COBERTURA; }
            set { VDESC_COBERTURA= value; }
        }


    }
}
