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
    public partial class frm_Sabor : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        public frm_Sabor Sabor_Principal = new frm_Sabor();

        public frm_Sabor()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Sabor
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            // Instância do objeto SaborBD
            SaborBD obj_SaborBD = new SaborBD();

            // Instância do objeto Lista
            List<frm_Sabor> Lista = new List<frm_Sabor>();

            // Limpando o ListBox
            lbox_Sabores.Items.Clear();

            Lista = obj_SaborBD.FindAllSabor();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Sabores.Items.Add(Lista[i].COD_SABOR.ToString() + "-" + Lista[i].TIT_SABOR);
                }
            }
        }

        private void lbox_Sabors_Click(object sender, EventArgs e)
        {
            if (lbox_Sabores.SelectedIndex != -1)
            {
                SaborBD obj_SaborBD = new SaborBD();

                string sLinha = lbox_Sabores.Items[lbox_Sabores.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Sabor_Principal.COD_SABOR = Convert.ToInt16(sLinha.Substring(0, ipos));

                Sabor_Principal = obj_SaborBD.FindByCodSabor(Sabor_Principal);

                PopulaTela(Sabor_Principal);

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
        private void PopulaTela(frm_Sabor aobj_Sabor)
        {
            if (aobj_Sabor.COD_SABOR != -1)
            {
                tbox_Cod_Sabor.Text = aobj_Sabor.COD_SABOR.ToString();
                tbox_Tit_Sabor.Text = aobj_Sabor.TIT_SABOR;
                tbox_Desc_Sabor.Text = aobj_Sabor.DESC_SABOR;
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
        private frm_Sabor PopulaObjeto()
        {
            frm_Sabor aobj_Sabor = new frm_Sabor();

            if (tbox_Cod_Sabor.Text != "")
            {
                aobj_Sabor.COD_SABOR = Convert.ToInt16(tbox_Cod_Sabor.Text);
            }
            aobj_Sabor.TIT_SABOR = tbox_Tit_Sabor.Text;
            aobj_Sabor.DESC_SABOR = tbox_Desc_Sabor.Text;

            return aobj_Sabor;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            SaborBD obj_SaborBD = new SaborBD();

            Sabor_Principal = PopulaObjeto();

            if (Sabor_Principal.COD_SABOR != -1)
            {
                obj_SaborBD.Alterar(Sabor_Principal);
                MessageBox.Show("Sabor alterada com sucesso. ", "Alteração da Sabor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Sabor_Principal.COD_SABOR = obj_SaborBD.Incluir(Sabor_Principal);
                MessageBox.Show("Sabor Incluida com sucesso. ", "Inclusão da Sabor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Sabor_Principal);
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
            tbox_Tit_Sabor.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Sabor_Principal.COD_SABOR != -1)
            {
                PopulaTela(Sabor_Principal);
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
            tbox_Tit_Sabor.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            SaborBD obj_SaborBD = new SaborBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Sabor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_SaborBD.Excluir(Sabor_Principal))
                {
                    MessageBox.Show("Sabor excluida com sucesso. ", "Exclusão da Sabor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();


            }

        }
    }
}
