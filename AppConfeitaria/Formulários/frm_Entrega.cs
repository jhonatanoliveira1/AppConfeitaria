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
    public partial class frm_Entrega : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        Entrega Entrega_Principal = new Entrega();

        public frm_Entrega()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Entrega
        * DT CRIAÇÃO:      02/12/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            string sPer = null;
            string sSem = null;

            // Instância do objeto EntregaBD
            EntregaBD obj_EntregaBD = new EntregaBD();

            // Instância do objeto Lista
            List<Entrega> Lista = new List<Entrega>();

            // Limpando o ListBox
            lbox_Entregas.Items.Clear();

            Lista = obj_EntregaBD.FindAllEntrega();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    //(02/12/2019 - Mfacine) - PERIODOS//
                    sPer = obj_FuncGeral.TrazPeriodo(Lista[i].PER_ENTREGA);

                    //(02/12/2019 - Mfacine) - DIAS SEMANA//
                    sSem = obj_FuncGeral.TrazSemana(Lista[i].SEM_ENTREGA);

                    lbox_Entregas.Items.Add(Lista[i].COD_ENTREGA.ToString() + "-" + sPer + "-" + sSem);
                }
            }
        }

        private void lbox_Entregas_Click(object sender, EventArgs e)
        {
            if (lbox_Entregas.SelectedIndex != -1)
            {
                EntregaBD obj_EntregaBD = new EntregaBD();

                string sLinha = lbox_Entregas.Items[lbox_Entregas.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Entrega_Principal.COD_ENTREGA = Convert.ToInt16(sLinha.Substring(0, ipos));

                Entrega_Principal = obj_EntregaBD.FindByCodEntrega(Entrega_Principal);

                PopulaTela(Entrega_Principal);

                obj_FuncGeral.StatusBtn(this, 2);

            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * PROCEDIMENTO:    Preenche a tela com os dados do Objeto Principal
        * DT CRIAÇÃO:      02/12/2019
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaTela(Entrega aobj_Entrega)
        {
            if (aobj_Entrega.COD_ENTREGA != -1)
            {
                tbox_Cod_Entrega.Text = aobj_Entrega.COD_ENTREGA.ToString();


                //(02/12/2019 - Mfacine) - PERIODOS//
                if (aobj_Entrega.PER_ENTREGA.ToString().Substring(0, 1) == "1")
                {
                    chbox_Man.Checked = true;
                }
                else
                {
                    chbox_Man.Checked = false;
                }

                if (aobj_Entrega.PER_ENTREGA.ToString().Substring(1, 1) == "1")
                {
                    chbox_Tar.Checked = true;
                }
                else
                {
                    chbox_Tar.Checked = false;
                }

                if (aobj_Entrega.PER_ENTREGA.ToString().Substring(2, 1) == "1")
                {
                    chbox_Noi.Checked = true;
                }
                else
                {
                    chbox_Noi.Checked = false;
                }

                //(02/12/2019 - Mfacine) - DIAS SEMANA//
                if (aobj_Entrega.SEM_ENTREGA.ToString().Substring(0, 1) == "1")
                {
                    chbox_Seg.Checked = true;
                }
                else
                {
                    chbox_Seg.Checked = false;
                }

                if (aobj_Entrega.SEM_ENTREGA.ToString().Substring(1, 1) == "1")
                {
                    chbox_Ter.Checked = true;
                }
                else
                {
                    chbox_Ter.Checked = false;
                }

                if (aobj_Entrega.SEM_ENTREGA.ToString().Substring(2, 1) == "1")
                {
                    chbox_Qua.Checked = true;
                }
                else
                {
                    chbox_Qua.Checked = false;
                }

                if (aobj_Entrega.SEM_ENTREGA.ToString().Substring(3, 1) == "1")
                {
                    chbox_Qui.Checked = true;
                }
                else
                {
                    chbox_Qui.Checked = false;
                }

                if (aobj_Entrega.SEM_ENTREGA.ToString().Substring(4, 1) == "1")
                {
                    chbox_Sex.Checked = true;
                }
                else
                {
                    chbox_Sex.Checked = false;
                }

                if (aobj_Entrega.SEM_ENTREGA.ToString().Substring(5, 1) == "1")
                {
                    chbox_Sab.Checked = true;
                }
                else
                {
                    chbox_Sab.Checked = false;
                }

            }
        }


        /**********************************************************************************
        * NOME:            PopulaObjeto
        * PROCEDIMENTO:    Preenche o objeto com os dados da  tela 
        * DT CRIAÇÃO:      02/12/2019
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private Entrega PopulaObjeto()
        {
            Entrega aobj_Entrega = new Entrega();

            if (tbox_Cod_Entrega.Text != "")
            {
                aobj_Entrega.COD_ENTREGA = Convert.ToInt16(tbox_Cod_Entrega.Text);
            }

            //(02/12/2019 - Mfacine) - PERIODOS//
            if (chbox_Man.Checked)
            {
                aobj_Entrega.PER_ENTREGA = "1";
            }
            else
            {
                aobj_Entrega.PER_ENTREGA = "0";
            }

            if (chbox_Tar.Checked)
            {
                aobj_Entrega.PER_ENTREGA = aobj_Entrega.PER_ENTREGA + "1";
            }
            else
            {
                aobj_Entrega.PER_ENTREGA = aobj_Entrega.PER_ENTREGA + "0";
            }

            if (chbox_Noi.Checked)
            {
                aobj_Entrega.PER_ENTREGA = aobj_Entrega.PER_ENTREGA + "1";
            }
            else
            {
                aobj_Entrega.PER_ENTREGA = aobj_Entrega.PER_ENTREGA + "0";
            }


            //(02/12/2019 - Mfacine) - DIAS SEMANA//
            if (chbox_Seg.Checked)
            {
                aobj_Entrega.SEM_ENTREGA = "1";
            }
            else
            {
                aobj_Entrega.SEM_ENTREGA = "0";
            }

            if (chbox_Ter.Checked)
            {
                aobj_Entrega.SEM_ENTREGA = aobj_Entrega.SEM_ENTREGA + "1";
            }
            else
            {
                aobj_Entrega.SEM_ENTREGA = aobj_Entrega.SEM_ENTREGA + "0";
            }

            if (chbox_Qua.Checked)
            {
                aobj_Entrega.SEM_ENTREGA = aobj_Entrega.SEM_ENTREGA + "1";
            }
            else
            {
                aobj_Entrega.SEM_ENTREGA = aobj_Entrega.SEM_ENTREGA + "0";
            }

            if (chbox_Qui.Checked)
            {
                aobj_Entrega.SEM_ENTREGA = aobj_Entrega.SEM_ENTREGA + "1";
            }
            else
            {
                aobj_Entrega.SEM_ENTREGA = aobj_Entrega.SEM_ENTREGA + "0";
            }

            if (chbox_Sex.Checked)
            {
                aobj_Entrega.SEM_ENTREGA = aobj_Entrega.SEM_ENTREGA + "1";
            }
            else
            {
                aobj_Entrega.SEM_ENTREGA = aobj_Entrega.SEM_ENTREGA + "0";
            }

            if (chbox_Sab.Checked)
            {
                aobj_Entrega.SEM_ENTREGA = aobj_Entrega.SEM_ENTREGA + "1";
            }
            else
            {
                aobj_Entrega.SEM_ENTREGA = aobj_Entrega.SEM_ENTREGA + "0";
            }


            return aobj_Entrega;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            EntregaBD obj_EntregaBD = new EntregaBD();

            Entrega_Principal = PopulaObjeto();

            if (Entrega_Principal.COD_ENTREGA != -1)
            {
                obj_EntregaBD.Alterar(Entrega_Principal);
                MessageBox.Show("Entrega alterada com sucesso. ", "Alteração da Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Entrega_Principal.COD_ENTREGA = obj_EntregaBD.Incluir(Entrega_Principal);
                MessageBox.Show("Entrega Incluida com sucesso. ", "Inclusão da Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Entrega_Principal);
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
            chbox_Man.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Entrega_Principal.COD_ENTREGA != -1)
            {
                PopulaTela(Entrega_Principal);
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
            chbox_Man.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            EntregaBD obj_EntregaBD = new EntregaBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_EntregaBD.Excluir(Entrega_Principal))
                {
                    MessageBox.Show("Entrega excluida com sucesso. ", "Exclusão da Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();


            }

        }
    }
}
