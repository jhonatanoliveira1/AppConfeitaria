using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConfeitaria
{
    public partial class frm_Cobertura : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        public frm_Cobertura Cobertura_Principal = new frm_Cobertura();

        public frm_Cobertura()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Cobertura
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            // Instância do objeto CoberturaBD
            CoberturaBD obj_CoberturaBD = new CoberturaBD();

            // Instância do objeto Lista
            List<frm_Cobertura> Lista = new List<frm_Cobertura>();

            // Limpando o ListBox
            lbox_Coberturas.Items.Clear();

            Lista = obj_CoberturaBD.FindAllCobertura();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Coberturas.Items.Add(Lista[i].COD_COBERTURA.ToString() + "-" + Lista[i].TIT_COBERTURA);
                }
            }
        }

        private void lbox_Coberturas_Click(object sender, EventArgs e)
        {
            if (lbox_Coberturas.SelectedIndex != -1)
            {
                CoberturaBD obj_CoberturaBD = new CoberturaBD();

                string sLinha = lbox_Coberturas.Items[lbox_Coberturas.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Cobertura_Principal.COD_COBERTURA = Convert.ToInt16(sLinha.Substring(0, ipos));

                Cobertura_Principal = obj_CoberturaBD.FindByCodCobertura(Cobertura_Principal);

                PopulaTela(Cobertura_Principal);

                obj_FuncGeral.StatusBtn(this, 2);

            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * PROCEDIMENTO:    Preenche a tela com os dados do Objeto Principal
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaTela(frm_Cobertura aobj_Cobertura)
        {
            if (aobj_Cobertura.COD_COBERTURA != -1)
            {
                tbox_Cod_Cobertura.Text = aobj_Cobertura.COD_COBERTURA.ToString();
                tbox_Tit_Cobertura.Text = aobj_Cobertura.TIT_COBERTURA;
                tbox_Desc_Cobertura.Text = aobj_Cobertura.DESC_COBERTURA;
            }
        }


        /**********************************************************************************
        * NOME:            PopulaObjeto
        * PROCEDIMENTO:    Preenche o objeto com os dados da  tela 
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private frm_Cobertura PopulaObjeto()
        {
            frm_Cobertura aobj_Cobertura = new frm_Cobertura();

            if (tbox_Cod_Cobertura.Text != "")
            {
                aobj_Cobertura.COD_COBERTURA = Convert.ToInt16(tbox_Cod_Cobertura.Text);
            }
            aobj_Cobertura.TIT_COBERTURA = tbox_Tit_Cobertura.Text;
            aobj_Cobertura.DESC_COBERTURA = tbox_Desc_Cobertura.Text;

            return aobj_Cobertura;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            CoberturaBD obj_CoberturaBD = new CoberturaBD();

            Cobertura_Principal = PopulaObjeto();

            if (Cobertura_Principal.COD_COBERTURA != -1)
            {
                obj_CoberturaBD.Alterar(Cobertura_Principal);
                MessageBox.Show("Cobertura alterada com sucesso. ", "Alteração da Cobertura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Cobertura_Principal.COD_COBERTURA = obj_CoberturaBD.Incluir(Cobertura_Principal);
                MessageBox.Show("Cobertura Incluida com sucesso. ", "Inclusão da Cobertura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Cobertura_Principal);
            }

            obj_FuncGeral.StatusBtn(this, 2);
            obj_FuncGeral.HabilitaTela(this, false);
            PopulaLista();

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Tit_Cobertura.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Cobertura_Principal.COD_COBERTURA != -1)
            {
                PopulaTela(Cobertura_Principal);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.StatusBtn(this, 1);
            }

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Tit_Cobertura.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            CoberturaBD obj_CoberturaBD = new CoberturaBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Cobertura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_CoberturaBD.Excluir(Cobertura_Principal))
                {
                    MessageBox.Show("Cobertura excluida com sucesso. ", "Exclusão da Cobertura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();


            }

        }
    }
}
