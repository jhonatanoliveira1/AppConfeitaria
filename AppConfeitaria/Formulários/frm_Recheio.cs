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
    public partial class frm_Recheio : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        public frm_Recheio Recheio_Principal = new frm_Recheio();

        public frm_Recheio()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Recheio
        * DT CRIAÇÃO:      19/02/2020
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            // Instância do objeto RecheioBD
            RecheioBD obj_RecheioBD = new RecheioBD();

            // Instância do objeto Lista
            List<frm_Recheio> Lista = new List<frm_Recheio>();

            // Limpando o ListBox
            lbox_Recheios.Items.Clear();

            Lista = obj_RecheioBD.FindAllRecheio();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Recheios.Items.Add(Lista[i].COD_RECHEIO.ToString() + "-" + Lista[i].TIT_RECHEIO);
                }
            }
        }

        private void lbox_Recheios_Click(object sender, EventArgs e)
        {
            if (lbox_Recheios.SelectedIndex != -1)
            {
                RecheioBD obj_RecheioBD = new RecheioBD();

                string sLinha = lbox_Recheios.Items[lbox_Recheios.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Recheio_Principal.COD_RECHEIO = Convert.ToInt16(sLinha.Substring(0, ipos));

                Recheio_Principal = obj_RecheioBD.FindByCodRecheio(Recheio_Principal);

                PopulaTela(Recheio_Principal);

                obj_FuncGeral.StatusBtn(this, 2);

            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * PROCEDIMENTO:    Preenche a tela com os dados do Objeto Principal
        * DT CRIAÇÃO:      19/02/2020
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaTela(frm_Recheio aobj_Recheio)
        {
            if (aobj_Recheio.COD_RECHEIO != -1)
            {
                tbox_Cod_Recheio.Text = aobj_Recheio.COD_RECHEIO.ToString();
                tbox_Tit_Recheio.Text = aobj_Recheio.TIT_RECHEIO;
                tbox_Desc_Recheio.Text = aobj_Recheio.DESC_RECHEIO;
            }
        }


        /**********************************************************************************
        * NOME:            PopulaObjeto
        * PROCEDIMENTO:    Preenche o objeto com os dados da  tela 
        * DT CRIAÇÃO:      19/02/2020
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private frm_Recheio PopulaObjeto()
        {
            frm_Recheio aobj_Recheio = new frm_Recheio();

            if (tbox_Cod_Recheio.Text != "")
            {
                aobj_Recheio.COD_RECHEIO = Convert.ToInt16(tbox_Cod_Recheio.Text);
            }
            aobj_Recheio.TIT_RECHEIO = tbox_Tit_Recheio.Text;
            aobj_Recheio.DESC_RECHEIO = tbox_Desc_Recheio.Text;

            return aobj_Recheio;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            RecheioBD obj_RecheioBD = new RecheioBD();

            Recheio_Principal = PopulaObjeto();

            if (Recheio_Principal.COD_RECHEIO != -1)
            {
                obj_RecheioBD.Alterar(Recheio_Principal);
                MessageBox.Show("Recheio alterada com sucesso. ", "Alteração da Recheio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Recheio_Principal.COD_RECHEIO = obj_RecheioBD.Incluir(Recheio_Principal);
                MessageBox.Show("Recheio Incluida com sucesso. ", "Inclusão da Recheio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Recheio_Principal);
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
            tbox_Tit_Recheio.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Recheio_Principal.COD_RECHEIO != -1)
            {
                PopulaTela(Recheio_Principal);
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
            tbox_Tit_Recheio.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            RecheioBD obj_RecheioBD = new RecheioBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Recheio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_RecheioBD.Excluir(Recheio_Principal))
                {
                    MessageBox.Show("Recheio excluida com sucesso. ", "Exclusão da Recheio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();


            }

        }
    }
}

