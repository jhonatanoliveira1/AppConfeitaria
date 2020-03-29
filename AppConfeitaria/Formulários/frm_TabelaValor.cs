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
    public partial class frm_TabelaValor : Form
    {

        public ListViewItem item = new ListViewItem();
        public frm_TabelaValor()
        {
            InitializeComponent();
        }

        //public void Col(string colForma, string colMedidas, string colPedaço, string colPeso, string colPreçoKg)
        //{
        //   
        //    item.SubItems.Add(colForma);
        //    item.SubItems.Add(colMedidas);
        //    item.SubItems.Add(colPedaço);
        //    item.SubItems.Add(colPeso);
        //    item.SubItems.Add(colPreçoKg);
        //    
        //}

        //    private void ltvTabelaValor_Click(object sender, EventArgs e)
        //  {
        //      for (int i = 0; i < ltvTabelaValor.Items.Count; i++)
        //      {
        //          if (ltvTabelaValor.Items[i].Selected)
        //          {
        //              PopulaTabelaLinha(ltvTabelaValor.Items[i].SubItems[0].Text, ltvTabelaValor.Items[i].SubItems[1].Text, ltvTabelaValor.Items[i].SubItems[2].Text, ltvTabelaValor.Items[i].SubItems[3].Text, ltvTabelaValor.Items[i].SubItems[4].Text);
        //              break;
        //          }
        //
        //      }
        //  }

        private void ltvTabelaValor_SelectedIndexChanged(Object sender, EventArgs e)
        {
                if (ltvTabelaValor.SelectedItems.Count > 0)
                {
                    ListViewItem itm = ltvTabelaValor.SelectedItems[0];
                    lb_Tam_Bolo.Text = itm.SubItems[0].Text + itm.SubItems[1].Text + itm.SubItems[2].Text + itm.SubItems[3].Text;
                    lb_Valor_Bolo.Text = itm.SubItems[4].Text;
                }
        }
    }
}
