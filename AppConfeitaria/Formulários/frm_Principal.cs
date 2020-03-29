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
    public partial class frm_Principal : Form
    {
        
        public frm_Principal()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Maximizar()
        {
            Screen tela = Screen.FromPoint(this.Location);
            this.Size = tela.WorkingArea.Size;
            this.Location = Point.Empty;
        }

        private void tim_Principal_Tick(object sender, EventArgs e)
        {
            tsslabel_DataSys.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tsslabel_HoraSys.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void recheioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Recheio obj_frm_Recheio = new frm_Recheio();
            obj_frm_Recheio.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cliente obj_frm_Cliente = new frm_Cliente();
            obj_frm_Cliente.ShowDialog();
        }
       
        private void saborToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sabor obj_frm_Sabor = new frm_Sabor();
            obj_frm_Sabor.ShowDialog();
        }

        private void boloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Bolo obj_frm_Bolo = new frm_Bolo();
            obj_frm_Bolo.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Usuario obj_frm_Usuario = new frm_Usuario();
            obj_frm_Usuario.ShowDialog();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pedido obj_frm_Pedido = new frm_Pedido();
            obj_frm_Pedido.ShowDialog();
        }

        private void coberturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cobertura obj_frm_Sabor = new frm_Cobertura();
            obj_frm_Sabor.ShowDialog();
        }

    }
}
