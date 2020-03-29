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
    public partial class frm_Pedido : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        frm_Pedido Pedido_Principal = new frm_Pedido();

        public frm_Pedido()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
            lv_Titulos();
        }
        
        /**********************************************************************************
        * NOME:            lv_Titulos
        * PROCEDIMENTO:    Preenche os nomes das colunas na Grid da Lv_PedidoItem
        * DT CRIAÇÃO:      19/02/2020
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void lv_Titulos()
        {
            ltv_PedidoItem.View = View.Details;
            ltv_PedidoItem.Columns.Add("Código", 50);
            ltv_PedidoItem.Columns.Add("Nome", 280);
            ltv_PedidoItem.Columns.Add("Tamanho", 300);
            ltv_PedidoItem.Columns.Add("Quantidade", 80);
            ltv_PedidoItem.Columns.Add("Valor", 60);
                      
        }
        
        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Pedido
        * DT CRIAÇÃO:      19/02/2020
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            Cliente obj_Cliente = new Cliente();
            ClienteBD obj_ClienteBD = new ClienteBD();

            BoloBD BoloBD = new BoloBD();
            Bolo Bolo = new Bolo();

            // Instância do objeto PedidoBD
            PedidoBD obj_PedidoBD = new PedidoBD();

            // Instância do objeto Lista
            List<frm_Pedido> Lista = new List<frm_Pedido>();

            // Limpando o ListBox
            lbox_Pedidos.Items.Clear();

            Lista = obj_PedidoBD.FindAllPedido();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    obj_Cliente.COD_CLIENTE = Lista[i].COD_CLIENTE;

                    lbox_Pedidos.Items.Add(Lista[i].COD_PEDIDO.ToString() + "-" + obj_ClienteBD.FindByCodCliente(obj_Cliente).NM_CLIENTE);  
                }
            }
        }

        private void lbox_Pedidos_Click(object sender, EventArgs e)
        {
            if (lbox_Pedidos.SelectedIndex != -1)
            {
                PedidoBD obj_PedidoBD = new PedidoBD();

                string sLinha = lbox_Pedidos.Items[lbox_Pedidos.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Pedido_Principal.COD_PEDIDO = Convert.ToInt16(sLinha.Substring(0, ipos));

                Pedido_Principal = obj_PedidoBD.FindByCodPedido(Pedido_Principal);

                PopulaTela(Pedido_Principal);

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
        private void PopulaTela(frm_Pedido aobj_Pedido)
        {
            if (aobj_Pedido.COD_PEDIDO != -1)
            {
                ClienteBD obj_ClienteBD = new ClienteBD();
                Cliente obj_Cliente = new Cliente();

                PedidoItemBD pedidoItemBD = new PedidoItemBD();
                PedidoItem pedidoItem = new PedidoItem();


                tbox_Cod_Pedido.Text = aobj_Pedido.COD_PEDIDO.ToString();
                mtbox_Dh_Pedido.Text = aobj_Pedido.DH_PEDIDO.ToString();

                obj_Cliente.COD_CLIENTE = Pedido_Principal.COD_CLIENTE;
                tbox_Cod_Cliente.Text = obj_Cliente.COD_CLIENTE.ToString();
                lb_Nm_Cliente.Text = obj_ClienteBD.FindByCodCliente(obj_Cliente).NM_CLIENTE;
                lb_Cid_Cliente.Text = obj_ClienteBD.FindByCodCliente(obj_Cliente).CID_CLIENTE;
                lb_End_Cliente.Text = obj_ClienteBD.FindByCodCliente(obj_Cliente).END_CLIENTE;
                lb_Bai_Cliente.Text = obj_ClienteBD.FindByCodCliente(obj_Cliente).BAI_CLIENTE;

                tbox_Obs_Pedido.Text = aobj_Pedido.OBS_PEDIDO;


                //BoloBD BoloBD = new BoloBD();
                //Bolo Bolo = new Bolo();
                //
                //obj_Bolo.COD_BOLO = Pedido_Principal.COD_BOLO;
                //tbox_Cod_Bolo.Text = obj_Bolo.COD_BOLO.ToString();
                //lb_Nm_Bolo.Text = obj_BoloBD.FindByCodBolo(obj_Cliente).NM_BOLO;
                //lb_Tam_Bolo.Text = obj_BoloBD.FindByCodBolo(obj_Cliente).TAM_BOLO;
                //lb_Valor_Bolo = obj_BoloBD.FindByCodBolo(obj_Cliente).VALOR_BOLO.ToString();


                PopulaPedidoItem();

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
        private frm_Pedido PopulaObjeto()
        {
            frm_Pedido aobj_Pedido = new frm_Pedido();

            if (tbox_Cod_Pedido.Text != "")
            {
                aobj_Pedido.COD_PEDIDO = Convert.ToInt16(tbox_Cod_Pedido.Text);
            }

            aobj_Pedido.DH_PEDIDO = Convert.ToDateTime(mtbox_Dh_Pedido.Text);
            aobj_Pedido.COD_CLIENTE = Convert.ToInt16(tbox_Cod_Cliente.Text);
            //aobj_Pedido.COD_BOLO = Convert.ToInt16(tbox_Cod_Bolo.Text);
            aobj_Pedido.OBS_PEDIDO = tbox_Obs_Pedido.Text;


            return aobj_Pedido;
        }
        
        /**********************************************************************************
        * NOME:            PopulaPedidoItem
        * PROCEDIMENTO:    Preenche a Lista de itens do pedido
        * DT CRIAÇÃO:      19/02/2020
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaPedidoItem()
        {
            PedidoItemBD obj_PedidoItemBD = new PedidoItemBD();
            Bolo obj_Bolo = new Bolo();
            BoloBD obj_BoloBD = new BoloBD();

            List<PedidoItem> ListPedidoItem = new List<PedidoItem>();

            ListPedidoItem = obj_PedidoItemBD.FindAllByPedido(Pedido_Principal);

            if (ListPedidoItem != null)
            {

                for (int t = 0; t < ListPedidoItem.Count; t++)
                {
                    obj_Bolo.COD_BOLO = ListPedidoItem[t].COD_BOLO;
                    obj_Bolo = obj_BoloBD.FindByCodBolo(obj_Bolo);


                    PopulaLinha(obj_Bolo.COD_BOLO.ToString(), obj_Bolo.NM_BOLO, obj_Bolo.TAM_BOLO, ListPedidoItem[t].QUANT_PEDIDOITEM.ToString(), obj_Bolo.VALOR_BOLO.ToString("R$ 999,99"));
                }

            }

        }
        
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            PedidoBD obj_PedidoBD = new PedidoBD();
            PedidoItemBD obj_PedidoItemBD = new PedidoItemBD();
            PedidoItem obj_PedidoItem = new PedidoItem();

            Pedido_Principal = PopulaObjeto();

            if (Pedido_Principal.COD_PEDIDO != -1)
            {
                obj_PedidoBD.Alterar(Pedido_Principal);
                MessageBox.Show("Pedido alterada com sucesso. ", "Alteração da Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Pedido_Principal.COD_PEDIDO = obj_PedidoBD.Incluir(Pedido_Principal);
                MessageBox.Show("Pedido Incluida com sucesso. ", "Inclusão da Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Pedido_Principal);
            }

            if (ltv_PedidoItem.Items.Count != 0)
            {
                obj_PedidoItem.COD_PEDIDO = Convert.ToInt16(tbox_Cod_Pedido.Text);

                obj_PedidoItemBD.Excluir(obj_PedidoItem);

                for (int i = 0; i < ltv_PedidoItem.Items.Count; i++)
                {

                    obj_PedidoItem.COD_PEDIDO = Convert.ToInt16(tbox_Cod_Pedido.Text);
                    obj_PedidoItem.COD_BOLO = Convert.ToInt16(ltv_PedidoItem.Items[i].SubItems[0].Text);
                    obj_PedidoItem.QUANT_PEDIDOITEM = Convert.ToInt16(ltv_PedidoItem.Items[i].SubItems[4].Text);
                    int cod = obj_PedidoItemBD.Incluir(obj_PedidoItem);

                }

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
            mtbox_Dh_Pedido.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Pedido_Principal.COD_PEDIDO != -1)
            {
                PopulaTela(Pedido_Principal);
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
            mtbox_Dh_Pedido.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            PedidoBD obj_PedidoBD = new PedidoBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_PedidoBD.Excluir(Pedido_Principal))
                {
                    MessageBox.Show("Pedido excluida com sucesso. ", "Exclusão da Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();
                
            }

        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            frm_Cliente obj_frm_Cliente = new frm_Cliente();
            obj_frm_Cliente.ShowDialog();
        }

        private void btn_Bolo_Click(object sender, EventArgs e)
        {
            frm_Bolo obj_frm_Bolo = new frm_Bolo();
            obj_frm_Bolo.ShowDialog();
        }

        private void tbox_Cod_Bolo_Leave(object sender, EventArgs e)
        {
            BoloBD obj_BoloBD = new BoloBD();
            Bolo obj_Bolo = new Bolo();

            if (tbox_Cod_Bolo.Text != "")
            {
                obj_Bolo.COD_BOLO = Convert.ToInt16(tbox_Cod_Bolo.Text);
                obj_Bolo = obj_BoloBD.FindByCodBolo(obj_Bolo);

                lb_Nm_Bolo.Text  = obj_Bolo.NM_BOLO;
                lb_Tam_Bolo.Text = obj_Bolo.TAM_BOLO;
                lb_Valor_Bolo.Text = obj_Bolo.VALOR_BOLO.ToString();

            }
            else
            {
                lb_Nm_Bolo.Text    = "";
                lb_Tam_Bolo.Text   = "";
                lb_Valor_Bolo.Text = "";
            }

        }
               
        private void btn_Up_Click(object sender, EventArgs e)
        {
            var confimation = MessageBox.Show("Deseja retirar este bolo da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confimation == DialogResult.Yes)
            {
                for (int i = 0; i < ltv_PedidoItem.Items.Count; i++)
                {
                    if (ltv_PedidoItem.Items[i].Selected)
                    {
                        tbox_Cod_Bolo.Text = ltv_PedidoItem.Items[i].SubItems[0].Text;
                        lb_Nm_Bolo.Text = ltv_PedidoItem.Items[i].SubItems[1].Text;
                        lb_Tam_Bolo.Text = ltv_PedidoItem.Items[i].SubItems[2].Text;
                        tbox_Quant_PedidoItem.Text = ltv_PedidoItem.Items[i].SubItems[3].Text;
                        lb_Valor_Bolo.Text = ltv_PedidoItem.Items[i].SubItems[4].Text;
                        ltv_PedidoItem.Items[i].Remove();
                    }
                }
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            PopulaLinha(tbox_Cod_Bolo.Text, lb_Nm_Bolo.Text,lb_Tam_Bolo.Text, tbox_Quant_PedidoItem.Text, lb_Valor_Bolo.Text);
        }

        /**********************************************************************************
        * NOME:            PopulaLinha
        * PROCEDIMENTO:    Preenche a Linha do List View Pedido Item
        * DT CRIAÇÃO:      26/02/2020
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLinha(string codBolo, string nmBolo,string tamBolo, string quantidadePedidoItem, string valorBolo)
        {
           
            ListViewItem item = new ListViewItem(new[] { codBolo, nmBolo, tamBolo, quantidadePedidoItem, valorBolo});
            ltv_PedidoItem.Items.Add(item);
        }
        
        /**********************************************************************************
        * NOME:            CalculaTotal
        * PROCEDIMENTO:    Preenche a Linha do List View Pedido Item
        * DT CRIAÇÃO:      25/02/2020
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void CalculaTotal (object sender, EventArgs e)
        {
            var total = 0m;
            for (int i = 0; i < ltv_PedidoItem.Items.Count; i++)
            {
                var quant = decimal.Parse(ltv_PedidoItem.Items[i].SubItems[2].Text);

                var preco = decimal.Parse(ltv_PedidoItem.Items[i].SubItems[3].Text);

                total += (quant * preco);
            }

            lb_Vtotal_PedidoItem.Text = total.ToString("R$ 999,99");
        }

    }
}
