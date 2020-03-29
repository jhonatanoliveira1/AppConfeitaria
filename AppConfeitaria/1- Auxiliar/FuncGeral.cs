/**********************************************************************************
 * NOME:            FuncGeral
 * CLASSE:          Representação do objeto de funções gerais
 * DT CRIAÇÃO:      11/02/2020
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:    Jhonatan de Oliveira
 * OBSERVAÇÕES:     Metodos públicos que serão utilizados por formulários e classes
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace AppConfeitaria
{
    class FuncGeral
    {
        /// <summary>     
        /// Vetor de bytes utilizados para a criptografia (Chave Externa)     
        /// </summary>     
        private static byte[] bIV =
        { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18,
        0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };

        /// <summary>     
        /// Representação de valor em base 64 (Chave Interna)    
        /// O Valor representa a transformação para base64 de     
        /// um conjunto de 32 caracteres (8 * 32 = 256bits)    
        /// A chave é: "Criptografias com Rijndael / AES"     
        /// </summary>     
        private const string cryptoKey =
        "Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=";



        /****************************************************************************
        * Nome           : LimpaTela
        * Procedimento   : Limpa cada componente editável ou modificado no pnl_Detalhe 
        * Parametros     : Nome do Formulário
        * Data Criação   : 11/02/2020
        * Data Alteração : 07/02/2020
        * Escrito por    :Jhonatan de Oliveira
        * Observação     : Se tag igual 1, então Data e Hora (__/__/____ __:__)
        *                  Se Tag igual 2, então Decimal (___,__)
        *                  Se Tag igual 3, então Celular (__) _____-____ 
        * ***************************************************************************/
        public void LimpaTela(Form aobj_Form)
        {
            foreach (Control pnl in aobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detalhe")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ctrl.Text = "";
                        }

                        if (ctrl is CheckBox)
                        {
                            CheckBox ChBox = new CheckBox();
                            ChBox = (CheckBox)ctrl;
                            ChBox.Checked = false;
                        }

                        if (ctrl is ComboBox)
                        {
                            ctrl.Text = "";
                        }

                        if (ctrl is MaskedTextBox)
                        {
                            switch (Convert.ToInt16(ctrl.Tag))
                            {
                                case 1:
                                    {
                                        ctrl.Text = "__/__/____ __:__";
                                        break;
                                    }

                            }
                        }
                    }
                }
            }
        }


        /****************************************************************************
        * Nome           : HabilitaTela
        * Procedimento   : Habilita cada componente editável no pnl_Detalhe 
        * Parametros     : Nome do Formulário e Bool
        * Data Criação   : 11/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * ***************************************************************************/
        public void HabilitaTela(Form aobj_Form, bool bHab)
        {
            foreach (Control pnl in aobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detalhe")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {

                        if (ctrl is TextBox && Convert.ToInt16(ctrl.Tag) != 1)
                        {
                            ctrl.Enabled = bHab;
                        }

                        if (ctrl is CheckBox)
                        {
                            ctrl.Enabled = bHab;
                        }

                        if (ctrl is Button)
                        {
                            ctrl.Enabled = bHab;
                        }

                        if (ctrl is ComboBox)
                        {
                            ctrl.Enabled = bHab;
                        }

                        if (ctrl is MaskedTextBox)
                        {
                            ctrl.Enabled = bHab;
                        }

                        if (ctrl is ListView)
                        {
                            ctrl.Enabled = bHab;
                        }

                        if (ctrl is DateTimePicker)
                        {
                            ctrl.Enabled = bHab;
                        }
                        if (ctrl is RadioButton)
                        {
                            ctrl.Enabled = bHab;
                        }
                    }
                }
            }
        }

        /****************************************************************************
        * Nome           : StatusBtn
        * Procedimento   : Define o status dos botões no pnl_Botoes  
        * Parametros     : Nome do Formulário e int
        * Data Criação   : 11/02/2020
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * ***************************************************************************/
        public void StatusBtn(Form aobj_Form, int iStatus)
        {
            foreach (Control pnl in aobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Botoes")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        switch (iStatus)
                        {
                            case 1:
                                {
                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ctrl.Enabled = false;
                                    }
                                    break;
                                }

                            case 2:
                                {
                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ctrl.Enabled = false;
                                    }
                                    break;
                                }

                            case 3:
                                {
                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ctrl.Enabled = true;
                                    }
                                    break;
                                }
                        }
                    }
                }
            }
        }
     

        /*****************************************************************************
        * Nome           : Criptografa
        * Procedimento   : Criptografa o password do usuário e retorna o 
        *                  pass criptografado
        * Parametros     : string sPassWord
        * Data  Criação  : 27/06/2018
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Percorre todos os componentes do painel Detalhe.
        * ***************************************************************************/
        public string Criptografa(string sPassWord)
        {

            try
            {
                // Se a string não está vazia, executa a criptografia
                if (!string.IsNullOrEmpty(sPassWord))
                {
                    // Cria instancias de vetores de bytes com as chaves                
                    byte[] bKey = Convert.FromBase64String(cryptoKey);
                    byte[] bText = new UTF8Encoding().GetBytes(sPassWord);

                    // Instancia a classe de criptografia Rijndael
                    Rijndael rijndael = new RijndaelManaged();

                    // Define o tamanho da chave "256 = 8 * 32"                
                    // Lembre-se: chaves possíves:                
                    // 128 (16 caracteres), 192 (24 caracteres) e 256 (32 caracteres)                
                    rijndael.KeySize = 256;

                    // Cria o espaço de memória para guardar o valor criptografado:                
                    MemoryStream mStream = new MemoryStream();
                    // Instancia o encriptador                 
                    CryptoStream encryptor = new CryptoStream(
                        mStream,
                        rijndael.CreateEncryptor(bKey, bIV),
                        CryptoStreamMode.Write);

                    // Faz a escrita dos dados criptografados no espaço de memória
                    encryptor.Write(bText, 0, bText.Length);
                    // Despeja toda a memória.                
                    encryptor.FlushFinalBlock();
                    // Pega o vetor de bytes da memória e gera a string criptografada                
                    return Convert.ToBase64String(mStream.ToArray());
                }
                else
                {
                    // Se a string for vazia retorna nulo                
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Se algum erro ocorrer, dispara a exceção            
                throw new ApplicationException("Erro ao criptografar", ex);
            }
        }



        /*****************************************************************************
        * Nome           : DesCriptografa
        * Procedimento   : Descriptografa o password do usuário e retorna o 
        *                  pass descriptografado
        * Parametros     : sCriptoPassWord
        * Data  Criação  : 22/05/2018
        * Data Alteração : -
        * Escrito por    :Jhonatan de Oliveira
        * Observações    : Percorre todos os componentes do painel Detalhe.
        * ***************************************************************************/
        public string DesCriptografa(string sCriptoPassWord)
        {
            try
            {
                // Se a string não está vazia, executa a criptografia           
                if (!string.IsNullOrEmpty(sCriptoPassWord))
                {
                    // Cria instancias de vetores de bytes com as chaves                
                    byte[] bKey = Convert.FromBase64String(cryptoKey);
                    byte[] bText = Convert.FromBase64String(sCriptoPassWord);

                    // Instancia a classe de criptografia Rijndael                
                    Rijndael rijndael = new RijndaelManaged();

                    // Define o tamanho da chave "256 = 8 * 32"                
                    // Lembre-se: chaves possíves:                
                    // 128 (16 caracteres), 192 (24 caracteres) e 256 (32 caracteres)                
                    rijndael.KeySize = 256;

                    // Cria o espaço de memória para guardar o valor DEScriptografado:               
                    MemoryStream mStream = new MemoryStream();

                    // Instancia o Decriptador                 
                    CryptoStream decryptor = new CryptoStream(
                        mStream,
                        rijndael.CreateDecryptor(bKey, bIV),
                        CryptoStreamMode.Write);

                    // Faz a escrita dos dados criptografados no espaço de memória   
                    decryptor.Write(bText, 0, bText.Length);
                    // Despeja toda a memória.                
                    decryptor.FlushFinalBlock();
                    // Instancia a classe de codificação para que a string venha de forma correta         
                    UTF8Encoding utf8 = new UTF8Encoding();
                    // Com o vetor de bytes da memória, gera a string descritografada em UTF8       
                    return utf8.GetString(mStream.ToArray());
                }
                else
                {
                    // Se a string for vazia retorna nulo                
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Se algum erro ocorrer, dispara a exceção            
                throw new ApplicationException("Erro ao descriptografar", ex);
            }
        }

       
    }
}
