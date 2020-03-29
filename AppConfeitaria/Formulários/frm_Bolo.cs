using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AppConfeitaria
{
    public partial class frm_Bolo : Form
    {
        public string foto = "";

        FuncGeral obj_FuncGeral = new FuncGeral();
        Bolo Bolo_Principal = new Bolo();

        public frm_Bolo()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Bolo
        * DT CRIAÇÃO:      19/02/2020
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Grupo (Tanto Faz)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            // Instância do objeto BoloBD
            BoloBD obj_BoloBD = new BoloBD();

            // Instância do objeto Lista
            List<Bolo> Lista = new List<Bolo>();

            // Limpando o ListBox
            lbox_Bolos.Items.Clear();

            Lista = obj_BoloBD.FindAllBolo();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Bolos.Items.Add(Lista[i].COD_BOLO.ToString() + "-" + Lista[i].NM_BOLO);
                }
            }
        }

        private void lbox_Bolos_Click(object sender, EventArgs e)
        {
            if (lbox_Bolos.SelectedIndex != -1)
            {
                BoloBD obj_BoloBD = new BoloBD();

                string sLinha = lbox_Bolos.Items[lbox_Bolos.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Bolo_Principal.COD_BOLO = Convert.ToInt16(sLinha.Substring(0, ipos));

                Bolo_Principal = obj_BoloBD.FindByCodBolo(Bolo_Principal);

                PopulaTela(Bolo_Principal);

                obj_FuncGeral.StatusBtn(this, 2);

            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * PROCEDIMENTO:    Preenche a tela com os dados do Objeto Principal
        * DT CRIAÇÃO:      19/02/2020
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:     Grupo (Tanto Faz)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaTela(Bolo aobj_Bolo)
        {
            if (aobj_Bolo.COD_BOLO != -1)
            {
                SaborBD obj_SaborBD = new SaborBD();
                frm_Sabor obj_Sabor = new frm_Sabor();
                RecheioBD obj_RecheioBD = new RecheioBD();
                frm_Recheio obj_Recheio = new frm_Recheio();
                CoberturaBD obj_CoberturaBD = new CoberturaBD();
                frm_Cobertura obj_Cobertura = new frm_Cobertura();

                tbox_Cod_Bolo.Text = aobj_Bolo.COD_BOLO.ToString();
                tbox_Cod_Sabor.Text = aobj_Bolo.COD_SABOR.ToString();
                tbox_Cod_Recheio.Text = aobj_Bolo.COD_RECHEIO.ToString();
                tbox_Cod_Cobertura.Text = aobj_Bolo.COD_COBERTURA.ToString();
                tbox_Nm_Bolo.Text = aobj_Bolo.NM_BOLO;
                lb_Tam_Bolo.Text = aobj_Bolo.TAM_BOLO;
                lb_Valor_Bolo.Text = aobj_Bolo.VALOR_BOLO.ToString();

                obj_Sabor .COD_SABOR = aobj_Bolo.COD_SABOR;

                lb_Tit_Sabor.Text = obj_SaborBD.FindByCodSabor(obj_Sabor).TIT_SABOR;

                obj_Recheio.COD_RECHEIO = aobj_Bolo.COD_RECHEIO;

                lb_Tit_Recheio.Text = obj_RecheioBD.FindByCodRecheio(obj_Recheio).TIT_RECHEIO;
                
                obj_Cobertura.COD_COBERTURA = aobj_Bolo.COD_COBERTURA;

                lb_Tit_Cobertura.Text = obj_CoberturaBD.FindByCodCobertura(obj_Cobertura).TIT_COBERTURA;

            }
        }

        /**********************************************************************************
        * NOME:            PopulaObjeto
        * PROCEDIMENTO:    Preenche o objeto com os dados da  tela 
        * DT CRIAÇÃO:      19/02/2020
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:     Grupo (Tanto Faz)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private Bolo PopulaObjeto()
        {
            Bolo aobj_Bolo = new Bolo();

            if (tbox_Cod_Bolo.Text != "")
            {
                aobj_Bolo.COD_BOLO = Convert.ToInt16(tbox_Cod_Bolo.Text);
            }

            aobj_Bolo.COD_SABOR = Convert.ToInt16(tbox_Cod_Sabor.Text);
            aobj_Bolo.COD_RECHEIO = Convert.ToInt16(tbox_Cod_Recheio.Text);
            aobj_Bolo.COD_COBERTURA = Convert.ToInt16(tbox_Cod_Cobertura.Text);
            aobj_Bolo.NM_BOLO = tbox_Nm_Bolo.Text;
            aobj_Bolo.TAM_BOLO = lb_Valor_Bolo.Text;
            aobj_Bolo.VALOR_BOLO = Convert.ToDouble(lb_Valor_Bolo.Text);

            return aobj_Bolo;
        }
        
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            BoloBD obj_BoloBD = new BoloBD();

            Bolo_Principal = PopulaObjeto();

            if (Bolo_Principal.COD_BOLO != -1)
            {
                obj_BoloBD.Alterar(Bolo_Principal);
                MessageBox.Show("Bolo alterada com sucesso. ", "Alteração da Bolo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Bolo_Principal.COD_BOLO = obj_BoloBD.Incluir(Bolo_Principal);
                MessageBox.Show("Bolo Incluida com sucesso. ", "Inclusão da Bolo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Bolo_Principal);
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
            tbox_Nm_Bolo.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Bolo_Principal.COD_BOLO != -1)
            {
                PopulaTela(Bolo_Principal);
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
            tbox_Nm_Bolo.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            BoloBD obj_BoloBD = new BoloBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Bolo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_BoloBD.Excluir(Bolo_Principal))
                {
                    MessageBox.Show("Bolo excluida com sucesso. ", "Exclusão da Bolo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();
                
            }

        }

        private void btn_Sabor_Click(object sender, EventArgs e)
        {
            frm_Sabor obj_frm_Sabor = new frm_Sabor();
            obj_frm_Sabor.ShowDialog();
            tbox_Cod_Sabor.Text = obj_frm_Sabor.Sabor_Principal.COD_SABOR.ToString();
            tbox_Cod_Sabor_Leave(tbox_Cod_Sabor, e);
        }

        private void tbox_Cod_Sabor_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_Sabor.Text != "")
            {
                SaborBD obj_SaborBD = new SaborBD();
                frm_Sabor obj_Sabor = new frm_Sabor();

                obj_Sabor.COD_SABOR = Convert.ToInt16(tbox_Cod_Sabor.Text);

                lb_Tit_Sabor.Text = obj_SaborBD.FindByCodSabor(obj_Sabor).TIT_SABOR;
            }
            else
            {
                lb_Tit_Sabor.Text = "";
            }
        }
        private void btn_Recheio_Click(object sender, EventArgs e)
        {
            frm_Recheio obj_frm_Recheio = new frm_Recheio();
            obj_frm_Recheio.ShowDialog();
            tbox_Cod_Recheio.Text = obj_frm_Recheio.Recheio_Principal.COD_RECHEIO.ToString();
            tbox_Cod_Recheio_Leave(tbox_Cod_Recheio, e);
        }

        private void tbox_Cod_Recheio_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_Recheio.Text != "")
            {
                RecheioBD obj_RecheioBD = new RecheioBD();
                frm_Recheio obj_Recheio = new frm_Recheio();

                obj_Recheio.COD_RECHEIO = Convert.ToInt16(tbox_Cod_Recheio.Text);

                lb_Tit_Recheio.Text = obj_RecheioBD.FindByCodRecheio(obj_Recheio).TIT_RECHEIO;
            }
            else
            {
                lb_Tit_Recheio.Text = "";
            }
        }

        private void btn_Cobertura_Click(object sender, EventArgs e)
        {
            frm_Cobertura obj_frm_Cobertura = new frm_Cobertura();
            obj_frm_Cobertura.ShowDialog();
            tbox_Cod_Cobertura.Text = obj_frm_Cobertura.Cobertura_Principal.COD_COBERTURA.ToString();
            tbox_Cod_Cobertura_Leave(tbox_Cod_Sabor, e);
        }

        private void tbox_Cod_Cobertura_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_Cobertura.Text != "")
            {
                CoberturaBD obj_CoberturaBD = new CoberturaBD();
                frm_Cobertura obj_Cobertura = new frm_Cobertura();

                obj_Cobertura.COD_COBERTURA = Convert.ToInt16(tbox_Cod_Cobertura.Text);

                lb_Tit_Cobertura.Text = obj_CoberturaBD.FindByCodCobertura(obj_Cobertura).TIT_COBERTURA;
            }
            else
            {
                lb_Tit_Cobertura.Text = "";
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.ShowDialog();
                if (!string.IsNullOrEmpty(od.FileName))
                {
                    this.foto = od.FileName;
                    pbox_Imagem_Bolo.Load(this.foto);
                }
            }
            catch
            {
                MessageBox.Show("Algum erro ocorreu! Você pode estar tentando enviar outros tipos de arquivos \n"
                    + "que não são imagens, selecione arquivos do tipo .png, .jpg, .bitmap,  por exemplo.", "Erro");
            }
        }

        private void btn_TabelaValor_Click(object sender, EventArgs e)
        {
            //ListViewItem Col = new ListViewItem();
            //frm_TabelaValor obj_frm_TabelaValor = new frm_TabelaValor();
            //obj_frm_TabelaValor.ShowDialog();

            //Col.SubItems.Add(obj_frm_TabelaValor.item.SubItems[0].Text);
            //Col.SubItems.Add(obj_frm_TabelaValor.item.SubItems[2].Text);
            //Col.SubItems.Add(obj_frm_TabelaValor.item.SubItems[3].Text);
            //Col.SubItems.Add(obj_frm_TabelaValor.item.SubItems[1].Text);
            //Col.SubItems.Add(obj_frm_TabelaValor.item.SubItems[4].Text);
        }

    }
}
